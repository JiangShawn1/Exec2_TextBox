namespace Q4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.peopleLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.peopleTextBox1 = new System.Windows.Forms.TextBox();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(37, 47);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(29, 12);
            this.peopleLabel.TabIndex = 0;
            this.peopleLabel.Text = "人數";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(221, 47);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(41, 12);
            this.carLabel.TabIndex = 1;
            this.carLabel.Text = "車輛數";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(268, 93);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 22);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "計算";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // peopleTextBox1
            // 
            this.peopleTextBox1.Location = new System.Drawing.Point(72, 42);
            this.peopleTextBox1.Name = "peopleTextBox1";
            this.peopleTextBox1.Size = new System.Drawing.Size(100, 22);
            this.peopleTextBox1.TabIndex = 3;
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(268, 42);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(100, 22);
            this.carTextBox.TabIndex = 4;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.answerTextBox.Location = new System.Drawing.Point(72, 144);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(296, 29);
            this.answerTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 229);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(this.peopleTextBox1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.peopleLabel);
            this.Name = "Form1";
            this.Text = "計算入場費用";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox peopleTextBox1;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
    }
}

