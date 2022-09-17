namespace MathGenerator
{
    partial class FormMain
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LBoxTotal = new System.Windows.Forms.ListBox();
            this.BtnCopyAnswer = new System.Windows.Forms.Button();
            this.CkBMultiply = new System.Windows.Forms.CheckBox();
            this.CkBDivide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(174, 12);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(468, 41);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "生成题目";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LBoxTotal
            // 
            this.LBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBoxTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBoxTotal.FormattingEnabled = true;
            this.LBoxTotal.ItemHeight = 28;
            this.LBoxTotal.Location = new System.Drawing.Point(12, 59);
            this.LBoxTotal.Name = "LBoxTotal";
            this.LBoxTotal.Size = new System.Drawing.Size(630, 868);
            this.LBoxTotal.TabIndex = 4;
            // 
            // BtnCopyAnswer
            // 
            this.BtnCopyAnswer.Location = new System.Drawing.Point(12, 933);
            this.BtnCopyAnswer.Name = "BtnCopyAnswer";
            this.BtnCopyAnswer.Size = new System.Drawing.Size(630, 41);
            this.BtnCopyAnswer.TabIndex = 6;
            this.BtnCopyAnswer.Text = "复制答案至剪贴板";
            this.BtnCopyAnswer.UseVisualStyleBackColor = true;
            this.BtnCopyAnswer.Click += new System.EventHandler(this.BtnCopyAnswer_Click);
            // 
            // CkBMultiply
            // 
            this.CkBMultiply.AutoSize = true;
            this.CkBMultiply.Location = new System.Drawing.Point(12, 23);
            this.CkBMultiply.Name = "CkBMultiply";
            this.CkBMultiply.Size = new System.Drawing.Size(75, 21);
            this.CkBMultiply.TabIndex = 7;
            this.CkBMultiply.Text = "包含乘法";
            this.CkBMultiply.UseVisualStyleBackColor = true;
            // 
            // CkBDivide
            // 
            this.CkBDivide.AutoSize = true;
            this.CkBDivide.Location = new System.Drawing.Point(93, 23);
            this.CkBDivide.Name = "CkBDivide";
            this.CkBDivide.Size = new System.Drawing.Size(75, 21);
            this.CkBDivide.TabIndex = 8;
            this.CkBDivide.Text = "包含除法";
            this.CkBDivide.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(654, 985);
            this.Controls.Add(this.CkBDivide);
            this.Controls.Add(this.CkBMultiply);
            this.Controls.Add(this.BtnCopyAnswer);
            this.Controls.Add(this.LBoxTotal);
            this.Controls.Add(this.BtnGenerate);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "100以内算术题生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnGenerate;
        private ListBox LBoxTotal;
        private Button BtnCopyAnswer;
        private CheckBox CkBMultiply;
        private CheckBox CkBDivide;
    }
}