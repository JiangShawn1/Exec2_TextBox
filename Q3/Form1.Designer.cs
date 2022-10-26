namespace Q3
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
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(114, 103);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(89, 22);
            this.dateTextBox.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(114, 211);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(89, 22);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "判斷";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(347, 162);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(89, 12);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.Text = "請輸入日期判斷";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 328);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.dateTextBox);
            this.Name = "Form1";
            this.Text = "輸入生日判斷是否已滿 13 歲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label answerLabel;
    }
}

