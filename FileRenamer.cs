using System;
using System.IO;

namespace FileRenamerToCreationDate
{
    public sealed class FileRenamer : IDisposable
    {
        private readonly string _fileName;
        private readonly FileInfo _fileInfo;
        private readonly bool _setSmallerLastWriteDate;
        private readonly bool _setExifCreationDate;

        public FileRenamer(
            string fileName,
            bool setSmallerLastWriteDate,
            bool setExifCreationDate)
        {
            _fileName = fileName;
            _fileInfo = new FileInfo(fileName);
            _setSmallerLastWriteDate = setSmallerLastWriteDate;
            _setExifCreationDate = setExifCreationDate;
        }

        public void Rename()
        {
            if (string.IsNullOrEmpty(_fileName))
                return;

            var filePath = _fileInfo.FullName;
            var fileExt = _fileInfo.Extension.ToLower();
            var fileDirPath = _fileInfo.Directory?.FullName;
            if (string.IsNullOrEmpty(fileDirPath))
                return;

            var creationDate = GetCreationDate();
            var newFileName = creationDate.ToString("yyyyMMdd_HHmmss");

            var newFilePath = Path.Combine(fileDirPath, newFileName + fileExt);
            if (File.Exists(newFilePath))
            {
                var index = 0;
                do
                {
                    var tempFileName = newFileName;
                    tempFileName = $"{tempFileName}({index})";
                    newFilePath = Path.Combine(fileDirPath, tempFileName + fileExt);
                    index++;
                } while (File.Exists(newFilePath));
            }

            File.Move(filePath, newFilePath);
        }

        private DateTime GetCreationDate()
        {
            var creationDate = _fileInfo.CreationTime;

            if(_setSmallerLastWriteDate)
            {
                if (creationDate > _fileInfo.LastWriteTime)
                {
                    creationDate = _fileInfo.LastWriteTime;
                }
            }

            if (_setExifCreationDate)
            {
                if (ImageHelper.IsImage(_fileInfo.Extension))
                {
                    var takenDate = ImageHelper.GetDateTakenFromImage(_fileName);
                    if (takenDate.HasValue)
                        creationDate = takenDate.Value;
                }
            }

            return creationDate;
        }

        public void Dispose()
        {
        }
    }
}
