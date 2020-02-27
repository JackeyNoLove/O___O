namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.InputBox1 = new System.Windows.Forms.TextBox();
            this.InputBox2 = new System.Windows.Forms.TextBox();
            this.OperatorList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.CalculteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox1
            // 
            this.InputBox1.Location = new System.Drawing.Point(116, 45);
            this.InputBox1.Name = "InputBox1";
            this.InputBox1.Size = new System.Drawing.Size(92, 25);
            this.InputBox1.TabIndex = 0;
            // 
            // InputBox2
            // 
            this.InputBox2.Location = new System.Drawing.Point(360, 45);
            this.InputBox2.Name = "InputBox2";
            this.InputBox2.Size = new System.Drawing.Size(92, 25);
            this.InputBox2.TabIndex = 0;
            // 
            // OperatorList
            // 
            this.OperatorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperatorList.FormattingEnabled = true;
            this.OperatorList.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.OperatorList.Location = new System.Drawing.Point(224, 47);
            this.OperatorList.Name = "OperatorList";
            this.OperatorList.Size = new System.Drawing.Size(121, 23);
            this.OperatorList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(458, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(489, 48);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 15);
            this.Answer.TabIndex = 6;
            // 
            // CalculteButton
            // 
            this.CalculteButton.Font = new System.Drawing.Font("宋体", 50F);
            this.CalculteButton.Location = new System.Drawing.Point(116, 105);
            this.CalculteButton.Name = "CalculteButton";
            this.CalculteButton.Size = new System.Drawing.Size(336, 165);
            this.CalculteButton.TabIndex = 7;
            this.CalculteButton.Text = "计算";
            this.CalculteButton.UseVisualStyleBackColor = true;
            this.CalculteButton.Click += new System.EventHandler(this.CalculteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 361);
            this.Controls.Add(this.CalculteButton);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperatorList);
            this.Controls.Add(this.InputBox2);
            this.Controls.Add(this.InputBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox1;
        private System.Windows.Forms.TextBox InputBox2;
        private System.Windows.Forms.ComboBox OperatorList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button CalculteButton;
    }
}

