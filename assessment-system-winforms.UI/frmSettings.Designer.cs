namespace CSCP
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.chbTimerPerQuestionOff = new System.Windows.Forms.CheckBox();
            this.chbTimerOff = new System.Windows.Forms.CheckBox();
            this.rbRandomizeOrder = new System.Windows.Forms.RadioButton();
            this.rbSameOrder = new System.Windows.Forms.RadioButton();
            this.rbAnswersAfterAllQuestions = new System.Windows.Forms.RadioButton();
            this.rbAnserAfterEachQuestion = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbQuestions = new System.Windows.Forms.GroupBox();
            this.gbTimer = new System.Windows.Forms.GroupBox();
            this.gbAnswers = new System.Windows.Forms.GroupBox();
            this.gbQuestions.SuspendLayout();
            this.gbTimer.SuspendLayout();
            this.gbAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbTimerPerQuestionOff
            // 
            this.chbTimerPerQuestionOff.AutoSize = true;
            this.chbTimerPerQuestionOff.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTimerPerQuestionOff.Location = new System.Drawing.Point(7, 71);
            this.chbTimerPerQuestionOff.Margin = new System.Windows.Forms.Padding(5);
            this.chbTimerPerQuestionOff.Name = "chbTimerPerQuestionOff";
            this.chbTimerPerQuestionOff.Size = new System.Drawing.Size(245, 28);
            this.chbTimerPerQuestionOff.TabIndex = 2;
            this.chbTimerPerQuestionOff.Text = "Timer Per Quesiton Off?";
            this.chbTimerPerQuestionOff.UseVisualStyleBackColor = true;
            // 
            // chbTimerOff
            // 
            this.chbTimerOff.AutoSize = true;
            this.chbTimerOff.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTimerOff.Location = new System.Drawing.Point(8, 33);
            this.chbTimerOff.Margin = new System.Windows.Forms.Padding(5);
            this.chbTimerOff.Name = "chbTimerOff";
            this.chbTimerOff.Size = new System.Drawing.Size(125, 28);
            this.chbTimerOff.TabIndex = 1;
            this.chbTimerOff.Text = "Timer Off?";
            this.chbTimerOff.UseVisualStyleBackColor = true;
            // 
            // rbRandomizeOrder
            // 
            this.rbRandomizeOrder.AutoSize = true;
            this.rbRandomizeOrder.Checked = true;
            this.rbRandomizeOrder.Location = new System.Drawing.Point(8, 71);
            this.rbRandomizeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.rbRandomizeOrder.Name = "rbRandomizeOrder";
            this.rbRandomizeOrder.Size = new System.Drawing.Size(352, 28);
            this.rbRandomizeOrder.TabIndex = 3;
            this.rbRandomizeOrder.TabStop = true;
            this.rbRandomizeOrder.Text = "Randomize the Questions each time";
            this.rbRandomizeOrder.UseVisualStyleBackColor = true;
            // 
            // rbSameOrder
            // 
            this.rbSameOrder.AutoSize = true;
            this.rbSameOrder.Location = new System.Drawing.Point(8, 33);
            this.rbSameOrder.Margin = new System.Windows.Forms.Padding(4);
            this.rbSameOrder.Name = "rbSameOrder";
            this.rbSameOrder.Size = new System.Drawing.Size(333, 28);
            this.rbSameOrder.TabIndex = 2;
            this.rbSameOrder.Text = "Always Display in the Same Order";
            this.rbSameOrder.UseVisualStyleBackColor = true;
            // 
            // rbAnswersAfterAllQuestions
            // 
            this.rbAnswersAfterAllQuestions.AutoSize = true;
            this.rbAnswersAfterAllQuestions.Checked = true;
            this.rbAnswersAfterAllQuestions.Location = new System.Drawing.Point(7, 71);
            this.rbAnswersAfterAllQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.rbAnswersAfterAllQuestions.Name = "rbAnswersAfterAllQuestions";
            this.rbAnswersAfterAllQuestions.Size = new System.Drawing.Size(370, 28);
            this.rbAnswersAfterAllQuestions.TabIndex = 3;
            this.rbAnswersAfterAllQuestions.TabStop = true;
            this.rbAnswersAfterAllQuestions.Text = "Display all Answers At the End of Test";
            this.rbAnswersAfterAllQuestions.UseVisualStyleBackColor = true;
            // 
            // rbAnserAfterEachQuestion
            // 
            this.rbAnserAfterEachQuestion.AutoSize = true;
            this.rbAnserAfterEachQuestion.Location = new System.Drawing.Point(7, 32);
            this.rbAnserAfterEachQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.rbAnserAfterEachQuestion.Name = "rbAnserAfterEachQuestion";
            this.rbAnserAfterEachQuestion.Size = new System.Drawing.Size(349, 28);
            this.rbAnserAfterEachQuestion.TabIndex = 2;
            this.rbAnserAfterEachQuestion.Text = "Display Answer After Each Question";
            this.rbAnserAfterEachQuestion.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Green;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(308, 380);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(208, 380);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbQuestions
            // 
            this.gbQuestions.Controls.Add(this.rbSameOrder);
            this.gbQuestions.Controls.Add(this.rbRandomizeOrder);
            this.gbQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbQuestions.Location = new System.Drawing.Point(12, 137);
            this.gbQuestions.Name = "gbQuestions";
            this.gbQuestions.Size = new System.Drawing.Size(388, 110);
            this.gbQuestions.TabIndex = 5;
            this.gbQuestions.TabStop = false;
            this.gbQuestions.Text = "Questions:";
            // 
            // gbTimer
            // 
            this.gbTimer.Controls.Add(this.chbTimerOff);
            this.gbTimer.Controls.Add(this.chbTimerPerQuestionOff);
            this.gbTimer.Location = new System.Drawing.Point(12, 11);
            this.gbTimer.Name = "gbTimer";
            this.gbTimer.Size = new System.Drawing.Size(388, 110);
            this.gbTimer.TabIndex = 6;
            this.gbTimer.TabStop = false;
            this.gbTimer.Text = "Timer:";
            // 
            // gbAnswers
            // 
            this.gbAnswers.Controls.Add(this.rbAnserAfterEachQuestion);
            this.gbAnswers.Controls.Add(this.rbAnswersAfterAllQuestions);
            this.gbAnswers.Location = new System.Drawing.Point(12, 263);
            this.gbAnswers.Name = "gbAnswers";
            this.gbAnswers.Size = new System.Drawing.Size(388, 110);
            this.gbAnswers.TabIndex = 7;
            this.gbAnswers.TabStop = false;
            this.gbAnswers.Text = "Answers:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 421);
            this.Controls.Add(this.gbAnswers);
            this.Controls.Add(this.gbTimer);
            this.Controls.Add(this.gbQuestions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.gbQuestions.ResumeLayout(false);
            this.gbQuestions.PerformLayout();
            this.gbTimer.ResumeLayout(false);
            this.gbTimer.PerformLayout();
            this.gbAnswers.ResumeLayout(false);
            this.gbAnswers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chbTimerPerQuestionOff;
        private System.Windows.Forms.CheckBox chbTimerOff;
        private System.Windows.Forms.RadioButton rbRandomizeOrder;
        private System.Windows.Forms.RadioButton rbSameOrder;
        private System.Windows.Forms.RadioButton rbAnswersAfterAllQuestions;
        private System.Windows.Forms.RadioButton rbAnserAfterEachQuestion;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbQuestions;
        private System.Windows.Forms.GroupBox gbTimer;
        private System.Windows.Forms.GroupBox gbAnswers;
    }
}