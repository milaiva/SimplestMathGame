namespace SimplestMathGame
{
    partial class Form1
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
            this.MathQuestionLbl = new System.Windows.Forms.Label();
            this.CheckAnswerBtn = new System.Windows.Forms.Button();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.CorrectLbl = new System.Windows.Forms.Label();
            this.FalseLbl = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.CorrectDashLbl = new System.Windows.Forms.Label();
            this.FalseDashLbl = new System.Windows.Forms.Label();
            this.TotalNumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MathQuestionLbl
            // 
            this.MathQuestionLbl.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MathQuestionLbl.Location = new System.Drawing.Point(13, 31);
            this.MathQuestionLbl.Name = "MathQuestionLbl";
            this.MathQuestionLbl.Size = new System.Drawing.Size(210, 30);
            this.MathQuestionLbl.TabIndex = 0;
            // 
            // CheckAnswerBtn
            // 
            this.CheckAnswerBtn.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAnswerBtn.Location = new System.Drawing.Point(16, 140);
            this.CheckAnswerBtn.Name = "CheckAnswerBtn";
            this.CheckAnswerBtn.Size = new System.Drawing.Size(210, 30);
            this.CheckAnswerBtn.TabIndex = 1;
            this.CheckAnswerBtn.Text = "Check my answer!";
            this.CheckAnswerBtn.UseVisualStyleBackColor = true;
            this.CheckAnswerBtn.Click += new System.EventHandler(this.CheckAnswerBtn_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTextBox.Location = new System.Drawing.Point(16, 76);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(210, 23);
            this.AnswerTextBox.TabIndex = 2;
            this.AnswerTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AnswerTextBox_KeyUp);
            // 
            // CorrectLbl
            // 
            this.CorrectLbl.AutoSize = true;
            this.CorrectLbl.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectLbl.Location = new System.Drawing.Point(60, 212);
            this.CorrectLbl.Name = "CorrectLbl";
            this.CorrectLbl.Size = new System.Drawing.Size(84, 17);
            this.CorrectLbl.TabIndex = 3;
            this.CorrectLbl.Text = "CORRECT";
            // 
            // FalseLbl
            // 
            this.FalseLbl.AutoSize = true;
            this.FalseLbl.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FalseLbl.Location = new System.Drawing.Point(319, 212);
            this.FalseLbl.Name = "FalseLbl";
            this.FalseLbl.Size = new System.Drawing.Size(60, 17);
            this.FalseLbl.TabIndex = 4;
            this.FalseLbl.Text = "FALSE";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Font = new System.Drawing.Font("Snap ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLbl.Location = new System.Drawing.Point(604, 212);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(59, 17);
            this.TotalLbl.TabIndex = 5;
            this.TotalLbl.Text = "TOTAL";
            // 
            // CorrectDashLbl
            // 
            this.CorrectDashLbl.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectDashLbl.Location = new System.Drawing.Point(63, 267);
            this.CorrectDashLbl.Name = "CorrectDashLbl";
            this.CorrectDashLbl.Size = new System.Drawing.Size(100, 23);
            this.CorrectDashLbl.TabIndex = 6;
            // 
            // FalseDashLbl
            // 
            this.FalseDashLbl.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FalseDashLbl.Location = new System.Drawing.Point(318, 267);
            this.FalseDashLbl.Name = "FalseDashLbl";
            this.FalseDashLbl.Size = new System.Drawing.Size(100, 23);
            this.FalseDashLbl.TabIndex = 7;
            // 
            // TotalNumLbl
            // 
            this.TotalNumLbl.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNumLbl.Location = new System.Drawing.Point(603, 267);
            this.TotalNumLbl.Name = "TotalNumLbl";
            this.TotalNumLbl.Size = new System.Drawing.Size(100, 23);
            this.TotalNumLbl.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalNumLbl);
            this.Controls.Add(this.FalseDashLbl);
            this.Controls.Add(this.CorrectDashLbl);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.FalseLbl);
            this.Controls.Add(this.CorrectLbl);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.CheckAnswerBtn);
            this.Controls.Add(this.MathQuestionLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MathQuestionLbl;
        private System.Windows.Forms.Button CheckAnswerBtn;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label CorrectLbl;
        private System.Windows.Forms.Label FalseLbl;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label CorrectDashLbl;
        private System.Windows.Forms.Label FalseDashLbl;
        private System.Windows.Forms.Label TotalNumLbl;
    }
}

