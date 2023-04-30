using System.Windows.Forms;

namespace FileRenamerToCreationDate
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.fbdBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRename = new System.Windows.Forms.Button();
            this.chkLastWriteTime = new System.Windows.Forms.CheckBox();
            this.chkExif = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFilePath.Location = new System.Drawing.Point(9, 47);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(393, 26);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(8, 6);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(395, 32);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRename.Location = new System.Drawing.Point(7, 109);
            this.btnRename.Margin = new System.Windows.Forms.Padding(4);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(396, 32);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "Rename to Creation Date";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // chkLastWriteTime
            // 
            this.chkLastWriteTime.AutoSize = true;
            this.chkLastWriteTime.Checked = true;
            this.chkLastWriteTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLastWriteTime.Location = new System.Drawing.Point(9, 82);
            this.chkLastWriteTime.Name = "chkLastWriteTime";
            this.chkLastWriteTime.Size = new System.Drawing.Size(192, 20);
            this.chkLastWriteTime.TabIndex = 3;
            this.chkLastWriteTime.Text = "Set Smaller Last Write Time";
            this.chkLastWriteTime.UseVisualStyleBackColor = true;
            // 
            // chkExif
            // 
            this.chkExif.AutoSize = true;
            this.chkExif.Checked = true;
            this.chkExif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExif.Location = new System.Drawing.Point(233, 82);
            this.chkExif.Name = "chkExif";
            this.chkExif.Size = new System.Drawing.Size(163, 20);
            this.chkExif.TabIndex = 4;
            this.chkExif.Text = "Set EXIF Creation Date";
            this.chkExif.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 148);
            this.Controls.Add(this.chkExif);
            this.Controls.Add(this.chkLastWriteTime);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename Files To Creation Date (yyyyMMdd_hhmmss)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtFilePath;
        private Button btnBrowse;
        private FolderBrowserDialog fbdBrowser;
        private Button btnRename;
        private CheckBox chkLastWriteTime;
        private CheckBox chkExif;
    }
}