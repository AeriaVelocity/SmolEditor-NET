namespace SmolEditor
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
            this.editorBox = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.visitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.darkMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // editorBox
            // 
            this.editorBox.AcceptsReturn = true;
            this.editorBox.AcceptsTab = true;
            this.editorBox.AllowDrop = true;
            this.editorBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editorBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorBox.Location = new System.Drawing.Point(0, 33);
            this.editorBox.Multiline = true;
            this.editorBox.Name = "editorBox";
            this.editorBox.Size = new System.Drawing.Size(588, 340);
            this.editorBox.TabIndex = 0;
            // 
            // writeButton
            // 
            this.writeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.writeButton.Location = new System.Drawing.Point(5, 6);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 1;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // visitButton
            // 
            this.visitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.visitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visitButton.Location = new System.Drawing.Point(86, 6);
            this.visitButton.Name = "visitButton";
            this.visitButton.Size = new System.Drawing.Size(75, 23);
            this.visitButton.TabIndex = 1;
            this.visitButton.Text = "Visit";
            this.visitButton.UseVisualStyleBackColor = true;
            this.visitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Location = new System.Drawing.Point(538, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Location = new System.Drawing.Point(264, 11);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(60, 13);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Smol Editor";
            this.MainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            this.saveFileDialog1.Title = "Write File";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Visit File";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // darkMode
            // 
            this.darkMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.darkMode.AutoSize = true;
            this.darkMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.darkMode.Location = new System.Drawing.Point(492, 6);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(40, 23);
            this.darkMode.TabIndex = 4;
            this.darkMode.Text = "Dark";
            this.darkMode.UseVisualStyleBackColor = true;
            this.darkMode.CheckedChanged += new System.EventHandler(this.darkMode_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(588, 373);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.visitButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.editorBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.Text = "Smol Editor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editorBox;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button visitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox darkMode;
    }
}

