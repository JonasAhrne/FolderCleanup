namespace FolderCleanup
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMods = new System.Windows.Forms.Button();
            this.buttonNoMods = new System.Windows.Forms.Button();
            this.textBoxPathOriginal = new System.Windows.Forms.TextBox();
            this.textBoxPathBackup = new System.Windows.Forms.TextBox();
            this.checkedListBoxRpfFiles = new System.Windows.Forms.CheckedListBox();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMods
            // 
            this.buttonMods.Location = new System.Drawing.Point(58, 51);
            this.buttonMods.Name = "buttonMods";
            this.buttonMods.Size = new System.Drawing.Size(75, 23);
            this.buttonMods.TabIndex = 0;
            this.buttonMods.Text = "Mods eh?";
            this.buttonMods.UseVisualStyleBackColor = true;
            this.buttonMods.Click += new System.EventHandler(this.buttonMods_Click);
            // 
            // buttonNoMods
            // 
            this.buttonNoMods.Location = new System.Drawing.Point(184, 51);
            this.buttonNoMods.Name = "buttonNoMods";
            this.buttonNoMods.Size = new System.Drawing.Size(75, 23);
            this.buttonNoMods.TabIndex = 1;
            this.buttonNoMods.Text = "mods no?";
            this.buttonNoMods.UseVisualStyleBackColor = true;
            this.buttonNoMods.Click += new System.EventHandler(this.buttonNoMods_Click);
            // 
            // textBoxPathOriginal
            // 
            this.textBoxPathOriginal.Location = new System.Drawing.Point(58, 80);
            this.textBoxPathOriginal.Name = "textBoxPathOriginal";
            this.textBoxPathOriginal.Size = new System.Drawing.Size(482, 20);
            this.textBoxPathOriginal.TabIndex = 2;
            this.textBoxPathOriginal.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // textBoxPathBackup
            // 
            this.textBoxPathBackup.Location = new System.Drawing.Point(58, 116);
            this.textBoxPathBackup.Name = "textBoxPathBackup";
            this.textBoxPathBackup.Size = new System.Drawing.Size(482, 20);
            this.textBoxPathBackup.TabIndex = 3;
            // 
            // checkedListBoxRpfFiles
            // 
            this.checkedListBoxRpfFiles.FormattingEnabled = true;
            this.checkedListBoxRpfFiles.Location = new System.Drawing.Point(58, 157);
            this.checkedListBoxRpfFiles.Name = "checkedListBoxRpfFiles";
            this.checkedListBoxRpfFiles.Size = new System.Drawing.Size(482, 289);
            this.checkedListBoxRpfFiles.TabIndex = 4;
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(58, 464);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(201, 23);
            this.buttonBackup.TabIndex = 5;
            this.buttonBackup.Text = "Backup selected files";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 513);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.checkedListBoxRpfFiles);
            this.Controls.Add(this.textBoxPathBackup);
            this.Controls.Add(this.textBoxPathOriginal);
            this.Controls.Add(this.buttonNoMods);
            this.Controls.Add(this.buttonMods);
            this.Name = "MainWindow";
            this.Text = "Mod handler v.0.00001";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMods;
        private System.Windows.Forms.Button buttonNoMods;
        private System.Windows.Forms.TextBox textBoxPathOriginal;
        private System.Windows.Forms.TextBox textBoxPathBackup;
        private System.Windows.Forms.CheckedListBox checkedListBoxRpfFiles;
        private System.Windows.Forms.Button buttonBackup;
    }
}

