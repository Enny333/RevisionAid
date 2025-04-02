
namespace PsychologyRevisionAid
{
    partial class QuesionsAndAnswers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuesionsAndAnswers));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOpt1 = new System.Windows.Forms.RadioButton();
            this.btnOpt2 = new System.Windows.Forms.RadioButton();
            this.btnOpt3 = new System.Windows.Forms.RadioButton();
            this.btnOpt4 = new System.Windows.Forms.RadioButton();
            this.btnNextQ = new System.Windows.Forms.Button();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblRightOutOfAmountOfQuestions = new System.Windows.Forms.Label();
            this.lblQNumber = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.OutOf20 = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDiffLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.lblQuestion.Location = new System.Drawing.Point(82, 89);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(152, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question goes here";
            // 
            // btnOpt1
            // 
            this.btnOpt1.AutoSize = true;
            this.btnOpt1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnOpt1.Location = new System.Drawing.Point(12, 158);
            this.btnOpt1.Name = "btnOpt1";
            this.btnOpt1.Size = new System.Drawing.Size(73, 24);
            this.btnOpt1.TabIndex = 1;
            this.btnOpt1.TabStop = true;
            this.btnOpt1.Text = "Option1";
            this.btnOpt1.UseVisualStyleBackColor = true;
            this.btnOpt1.Click += new System.EventHandler(this.CheckAnswerOpt1);
            // 
            // btnOpt2
            // 
            this.btnOpt2.AutoSize = true;
            this.btnOpt2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnOpt2.Location = new System.Drawing.Point(406, 158);
            this.btnOpt2.Name = "btnOpt2";
            this.btnOpt2.Size = new System.Drawing.Size(73, 24);
            this.btnOpt2.TabIndex = 2;
            this.btnOpt2.TabStop = true;
            this.btnOpt2.Text = "Option2";
            this.btnOpt2.UseVisualStyleBackColor = true;
            this.btnOpt2.Click += new System.EventHandler(this.CheckAnswerOpt2);
            // 
            // btnOpt3
            // 
            this.btnOpt3.AutoSize = true;
            this.btnOpt3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnOpt3.Location = new System.Drawing.Point(12, 279);
            this.btnOpt3.Name = "btnOpt3";
            this.btnOpt3.Size = new System.Drawing.Size(73, 24);
            this.btnOpt3.TabIndex = 3;
            this.btnOpt3.TabStop = true;
            this.btnOpt3.Text = "Option3";
            this.btnOpt3.UseVisualStyleBackColor = true;
            this.btnOpt3.Click += new System.EventHandler(this.CheckAnswerOpt3);
            // 
            // btnOpt4
            // 
            this.btnOpt4.AutoSize = true;
            this.btnOpt4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnOpt4.Location = new System.Drawing.Point(406, 279);
            this.btnOpt4.Name = "btnOpt4";
            this.btnOpt4.Size = new System.Drawing.Size(73, 24);
            this.btnOpt4.TabIndex = 4;
            this.btnOpt4.TabStop = true;
            this.btnOpt4.Text = "Option4";
            this.btnOpt4.UseVisualStyleBackColor = true;
            this.btnOpt4.Click += new System.EventHandler(this.CheckAnswerOpt4);
            // 
            // btnNextQ
            // 
            this.btnNextQ.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.btnNextQ.Location = new System.Drawing.Point(607, 400);
            this.btnNextQ.Name = "btnNextQ";
            this.btnNextQ.Size = new System.Drawing.Size(126, 38);
            this.btnNextQ.TabIndex = 5;
            this.btnNextQ.Text = "Next";
            this.btnNextQ.UseVisualStyleBackColor = true;
            this.btnNextQ.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.btnCheckAnswer.Location = new System.Drawing.Point(607, 337);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(126, 38);
            this.btnCheckAnswer.TabIndex = 6;
            this.btnCheckAnswer.Text = "CheckAnswer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // lblRightOutOfAmountOfQuestions
            // 
            this.lblRightOutOfAmountOfQuestions.AutoSize = true;
            this.lblRightOutOfAmountOfQuestions.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightOutOfAmountOfQuestions.Location = new System.Drawing.Point(683, 62);
            this.lblRightOutOfAmountOfQuestions.Name = "lblRightOutOfAmountOfQuestions";
            this.lblRightOutOfAmountOfQuestions.Size = new System.Drawing.Size(50, 20);
            this.lblRightOutOfAmountOfQuestions.TabIndex = 7;
            this.lblRightOutOfAmountOfQuestions.Text = "Correct";
            // 
            // lblQNumber
            // 
            this.lblQNumber.AutoSize = true;
            this.lblQNumber.Font = new System.Drawing.Font("Arial Narrow", 17F);
            this.lblQNumber.Location = new System.Drawing.Point(45, 91);
            this.lblQNumber.Name = "lblQNumber";
            this.lblQNumber.Size = new System.Drawing.Size(31, 27);
            this.lblQNumber.TabIndex = 8;
            this.lblQNumber.Text = "N.";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Underline);
            this.lblTopic.Location = new System.Drawing.Point(334, 18);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(68, 31);
            this.lblTopic.TabIndex = 9;
            this.lblTopic.Text = "Topic";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.btnBack.Location = new System.Drawing.Point(-2, 400);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 38);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // OutOf20
            // 
            this.OutOf20.AutoSize = true;
            this.OutOf20.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutOf20.Location = new System.Drawing.Point(726, 62);
            this.OutOf20.Name = "OutOf20";
            this.OutOf20.Size = new System.Drawing.Size(50, 20);
            this.OutOf20.TabIndex = 11;
            this.OutOf20.Text = "/        15";
            // 
            // btnResults
            // 
            this.btnResults.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.btnResults.Location = new System.Drawing.Point(475, 399);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(126, 38);
            this.btnResults.TabIndex = 12;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblDiffLevel
            // 
            this.lblDiffLevel.AutoSize = true;
            this.lblDiffLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiffLevel.Location = new System.Drawing.Point(577, 25);
            this.lblDiffLevel.Name = "lblDiffLevel";
            this.lblDiffLevel.Size = new System.Drawing.Size(99, 24);
            this.lblDiffLevel.TabIndex = 14;
            this.lblDiffLevel.Text = "lblDiffLevel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Difficulty =  ";
            // 
            // QuesionsAndAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDiffLevel);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.OutOf20);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblQNumber);
            this.Controls.Add(this.lblRightOutOfAmountOfQuestions);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.btnNextQ);
            this.Controls.Add(this.btnOpt4);
            this.Controls.Add(this.btnOpt3);
            this.Controls.Add(this.btnOpt2);
            this.Controls.Add(this.btnOpt1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "QuesionsAndAnswers";
            this.Text = "QuesionsAndAnswers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton btnOpt1;
        private System.Windows.Forms.RadioButton btnOpt2;
        private System.Windows.Forms.RadioButton btnOpt3;
        private System.Windows.Forms.RadioButton btnOpt4;
        private System.Windows.Forms.Button btnNextQ;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblRightOutOfAmountOfQuestions;
        private System.Windows.Forms.Label lblQNumber;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label OutOf20;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDiffLevel;
        private System.Windows.Forms.Label label1;
    }
}