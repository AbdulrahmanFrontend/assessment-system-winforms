namespace CSCP
{
    partial class frmExam
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblNumberOfQuestion = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblExamTimer = new System.Windows.Forms.Label();
            this.lblQuantityExamTimer = new System.Windows.Forms.Label();
            this.lblQuantityOfQuestionTimer = new System.Windows.Forms.Label();
            this.lblQuestionTimer = new System.Windows.Forms.Label();
            this.pnlExamTimer = new System.Windows.Forms.Panel();
            this.pbExamTimer = new System.Windows.Forms.PictureBox();
            this.pnlQuestionTimer = new System.Windows.Forms.Panel();
            this.pbQuestionTimer = new System.Windows.Forms.PictureBox();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.btnNextQ = new System.Windows.Forms.Button();
            this.btnBackQ = new System.Windows.Forms.Button();
            this.chkReviewMark = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlExamTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExamTimer)).BeginInit();
            this.pnlQuestionTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionTimer)).BeginInit();
            this.pnlQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuestion.Location = new System.Drawing.Point(57, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(125, 28);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question:";
            // 
            // lblNumberOfQuestion
            // 
            this.lblNumberOfQuestion.AutoSize = true;
            this.lblNumberOfQuestion.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestion.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfQuestion.Location = new System.Drawing.Point(188, 8);
            this.lblNumberOfQuestion.Name = "lblNumberOfQuestion";
            this.lblNumberOfQuestion.Size = new System.Drawing.Size(90, 29);
            this.lblNumberOfQuestion.TabIndex = 1;
            this.lblNumberOfQuestion.Text = "1 / 105";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(1174, 639);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 51);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "End Exam";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // lblExamTimer
            // 
            this.lblExamTimer.AutoSize = true;
            this.lblExamTimer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExamTimer.Location = new System.Drawing.Point(57, 10);
            this.lblExamTimer.Name = "lblExamTimer";
            this.lblExamTimer.Size = new System.Drawing.Size(158, 28);
            this.lblExamTimer.TabIndex = 12;
            this.lblExamTimer.Text = "Exam Timer:";
            // 
            // lblQuantityExamTimer
            // 
            this.lblQuantityExamTimer.AutoSize = true;
            this.lblQuantityExamTimer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityExamTimer.ForeColor = System.Drawing.Color.White;
            this.lblQuantityExamTimer.Location = new System.Drawing.Point(221, 8);
            this.lblQuantityExamTimer.Name = "lblQuantityExamTimer";
            this.lblQuantityExamTimer.Size = new System.Drawing.Size(94, 29);
            this.lblQuantityExamTimer.TabIndex = 13;
            this.lblQuantityExamTimer.Text = "1:34:38";
            // 
            // lblQuantityOfQuestionTimer
            // 
            this.lblQuantityOfQuestionTimer.AutoSize = true;
            this.lblQuantityOfQuestionTimer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityOfQuestionTimer.ForeColor = System.Drawing.Color.White;
            this.lblQuantityOfQuestionTimer.Location = new System.Drawing.Point(262, 8);
            this.lblQuantityOfQuestionTimer.Name = "lblQuantityOfQuestionTimer";
            this.lblQuantityOfQuestionTimer.Size = new System.Drawing.Size(60, 29);
            this.lblQuantityOfQuestionTimer.TabIndex = 15;
            this.lblQuantityOfQuestionTimer.Text = "1:01";
            // 
            // lblQuestionTimer
            // 
            this.lblQuestionTimer.AutoSize = true;
            this.lblQuestionTimer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuestionTimer.Location = new System.Drawing.Point(57, 9);
            this.lblQuestionTimer.Name = "lblQuestionTimer";
            this.lblQuestionTimer.Size = new System.Drawing.Size(199, 28);
            this.lblQuestionTimer.TabIndex = 14;
            this.lblQuestionTimer.Text = "Question Timer:";
            // 
            // pnlExamTimer
            // 
            this.pnlExamTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlExamTimer.AutoSize = true;
            this.pnlExamTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExamTimer.Controls.Add(this.pbExamTimer);
            this.pnlExamTimer.Controls.Add(this.lblExamTimer);
            this.pnlExamTimer.Controls.Add(this.lblQuantityExamTimer);
            this.pnlExamTimer.Location = new System.Drawing.Point(493, 6);
            this.pnlExamTimer.Name = "pnlExamTimer";
            this.pnlExamTimer.Size = new System.Drawing.Size(334, 50);
            this.pnlExamTimer.TabIndex = 16;
            // 
            // pbExamTimer
            // 
            this.pbExamTimer.Location = new System.Drawing.Point(3, 9);
            this.pbExamTimer.Name = "pbExamTimer";
            this.pbExamTimer.Size = new System.Drawing.Size(48, 29);
            this.pbExamTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExamTimer.TabIndex = 18;
            this.pbExamTimer.TabStop = false;
            // 
            // pnlQuestionTimer
            // 
            this.pnlQuestionTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuestionTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestionTimer.Controls.Add(this.pbQuestionTimer);
            this.pnlQuestionTimer.Controls.Add(this.lblQuestionTimer);
            this.pnlQuestionTimer.Controls.Add(this.lblQuantityOfQuestionTimer);
            this.pnlQuestionTimer.Location = new System.Drawing.Point(975, 6);
            this.pnlQuestionTimer.Name = "pnlQuestionTimer";
            this.pnlQuestionTimer.Size = new System.Drawing.Size(334, 50);
            this.pnlQuestionTimer.TabIndex = 17;
            // 
            // pbQuestionTimer
            // 
            this.pbQuestionTimer.Location = new System.Drawing.Point(3, 9);
            this.pbQuestionTimer.Name = "pbQuestionTimer";
            this.pbQuestionTimer.Size = new System.Drawing.Size(48, 29);
            this.pbQuestionTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuestionTimer.TabIndex = 19;
            this.pbQuestionTimer.TabStop = false;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestion.Controls.Add(this.pbQuestion);
            this.pnlQuestion.Controls.Add(this.lblQuestion);
            this.pnlQuestion.Controls.Add(this.lblNumberOfQuestion);
            this.pnlQuestion.Location = new System.Drawing.Point(12, 6);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(334, 50);
            this.pnlQuestion.TabIndex = 18;
            // 
            // pbQuestion
            // 
            this.pbQuestion.Location = new System.Drawing.Point(3, 9);
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.Size = new System.Drawing.Size(48, 29);
            this.pbQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuestion.TabIndex = 19;
            this.pbQuestion.TabStop = false;
            // 
            // btnNextQ
            // 
            this.btnNextQ.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNextQ.BackColor = System.Drawing.Color.Teal;
            this.btnNextQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextQ.FlatAppearance.BorderSize = 0;
            this.btnNextQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQ.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQ.ForeColor = System.Drawing.Color.White;
            this.btnNextQ.Location = new System.Drawing.Point(635, 640);
            this.btnNextQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextQ.Name = "btnNextQ";
            this.btnNextQ.Size = new System.Drawing.Size(130, 51);
            this.btnNextQ.TabIndex = 20;
            this.btnNextQ.Text = "Next →→";
            this.btnNextQ.UseVisualStyleBackColor = false;
            // 
            // btnBackQ
            // 
            this.btnBackQ.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBackQ.BackColor = System.Drawing.Color.Teal;
            this.btnBackQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackQ.FlatAppearance.BorderSize = 0;
            this.btnBackQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackQ.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackQ.ForeColor = System.Drawing.Color.White;
            this.btnBackQ.Location = new System.Drawing.Point(475, 640);
            this.btnBackQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackQ.Name = "btnBackQ";
            this.btnBackQ.Size = new System.Drawing.Size(130, 51);
            this.btnBackQ.TabIndex = 21;
            this.btnBackQ.Text = "←← Back";
            this.btnBackQ.UseVisualStyleBackColor = false;
            // 
            // chkReviewMark
            // 
            this.chkReviewMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkReviewMark.AutoSize = true;
            this.chkReviewMark.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReviewMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkReviewMark.Location = new System.Drawing.Point(12, 666);
            this.chkReviewMark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkReviewMark.Name = "chkReviewMark";
            this.chkReviewMark.Size = new System.Drawing.Size(164, 25);
            this.chkReviewMark.TabIndex = 22;
            this.chkReviewMark.Text = "Mark For Review?";
            this.chkReviewMark.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1298, 571);
            this.panel1.TabIndex = 23;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton4.Location = new System.Drawing.Point(10, 178);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.radioButton4.Size = new System.Drawing.Size(1276, 38);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Hashtable";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton1.Location = new System.Drawing.Point(10, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.radioButton1.Size = new System.Drawing.Size(1276, 38);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "List";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.Location = new System.Drawing.Point(10, 102);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.radioButton3.Size = new System.Drawing.Size(1276, 38);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ArrayList";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton2.Location = new System.Drawing.Point(10, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.radioButton2.Size = new System.Drawing.Size(1276, 38);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Stack";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.label1.Size = new System.Drawing.Size(605, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which collection allows you to specify the type of objects it stores?";
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1323, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkReviewMark);
            this.Controls.Add(this.btnBackQ);
            this.Controls.Add(this.btnNextQ);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pnlQuestionTimer);
            this.Controls.Add(this.pnlExamTimer);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1059, 372);
            this.Name = "frmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certified Supply Chain Profesional (CSCP) Exam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlExamTimer.ResumeLayout(false);
            this.pnlExamTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExamTimer)).EndInit();
            this.pnlQuestionTimer.ResumeLayout(false);
            this.pnlQuestionTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionTimer)).EndInit();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblNumberOfQuestion;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblExamTimer;
        private System.Windows.Forms.Label lblQuantityExamTimer;
        private System.Windows.Forms.Label lblQuantityOfQuestionTimer;
        private System.Windows.Forms.Label lblQuestionTimer;
        private System.Windows.Forms.Panel pnlExamTimer;
        private System.Windows.Forms.Panel pnlQuestionTimer;
        private System.Windows.Forms.PictureBox pbExamTimer;
        private System.Windows.Forms.PictureBox pbQuestionTimer;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.PictureBox pbQuestion;
        private System.Windows.Forms.Button btnNextQ;
        private System.Windows.Forms.Button btnBackQ;
        private System.Windows.Forms.CheckBox chkReviewMark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}