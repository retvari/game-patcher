namespace David.Lister
{
    partial class lForm
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
            this.Result = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.saveButton = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.filePath = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Location = new System.Drawing.Point(12, 12);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Result.Size = new System.Drawing.Size(518, 267);
            this.Result.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(538, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(110, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Select a path";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(12, 345);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(636, 13);
            this.Progress.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(538, 51);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save generated list";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(12, 317);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(518, 20);
            this.filePath.TabIndex = 4;
            // 
            // removeButton
            // 
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(209, 290);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select a region to remove it from the list";
            // 
            // lForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.Result);
            this.MaximizeBox = false;
            this.Name = "lForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button saveButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

