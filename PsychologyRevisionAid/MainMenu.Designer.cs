namespace PsychologyRevisionAid
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblQuizName = new System.Windows.Forms.Label();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuizName
            // 
            this.lblQuizName.AutoSize = true;
            this.lblQuizName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblQuizName.Font = new System.Drawing.Font("Arial Narrow", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizName.Location = new System.Drawing.Point(171, 9);
            this.lblQuizName.Name = "lblQuizName";
            this.lblQuizName.Size = new System.Drawing.Size(415, 52);
            this.lblQuizName.TabIndex = 1;
            this.lblQuizName.Text = "Psychology Revision Aid";
            // 
            // lstBox
            // 
            this.lstBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 20;
            this.lstBox.Items.AddRange(new object[] {
            "Memory",
            "Attachment",
            "Pschopathology",
            "Social Influence",
            "Research Methods",
            "Approaches in Psychology",
            "Schizophrenia",
            "Relationships",
            "Gender",
            "Biopsychology",
            "Issues and debates in Psychology",
            "Forensic Psychology"});
            this.lstBox.Location = new System.Drawing.Point(547, 98);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(263, 244);
            this.lstBox.TabIndex = 2;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.TopicSelected);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1, 339);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(289, 61);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-131, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(941, 328);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "After selecting the topic you wish to be quizzed on,click the start button";
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable.Location = new System.Drawing.Point(1, 72);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(241, 52);
            this.btnTable.TabIndex = 7;
            this.btnTable.Text = "Show Average Scores";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblQuizName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuizName;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTable;
    }
}