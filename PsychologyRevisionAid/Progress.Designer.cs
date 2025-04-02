namespace PsychologyRevisionAid
{
    partial class Progress
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Progress Analysis";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(-2, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(360, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 101);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cick \'Show Graph\' to display a line graph showing your scores on the selected top" +
    "ic \r\n\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGraph.Location = new System.Drawing.Point(408, 181);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(145, 50);
            this.btnGraph.TabIndex = 7;
            this.btnGraph.Text = "Show Graph";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Progress";
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.Progress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGraph;
    }
}