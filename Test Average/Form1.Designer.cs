namespace Test_Average
{
    partial class testAverage
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
            this.test1PromptLabel = new System.Windows.Forms.Label();
            this.test2PromptLabel = new System.Windows.Forms.Label();
            this.test3PromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // test1PromptLabel
            // 
            this.test1PromptLabel.AutoSize = true;
            this.test1PromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test1PromptLabel.Location = new System.Drawing.Point(168, 93);
            this.test1PromptLabel.Name = "test1PromptLabel";
            this.test1PromptLabel.Size = new System.Drawing.Size(47, 16);
            this.test1PromptLabel.TabIndex = 0;
            this.test1PromptLabel.Text = "Test 1:";
            // 
            // test2PromptLabel
            // 
            this.test2PromptLabel.AutoSize = true;
            this.test2PromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test2PromptLabel.Location = new System.Drawing.Point(168, 157);
            this.test2PromptLabel.Name = "test2PromptLabel";
            this.test2PromptLabel.Size = new System.Drawing.Size(47, 16);
            this.test2PromptLabel.TabIndex = 1;
            this.test2PromptLabel.Text = "Test 2:";
            // 
            // test3PromptLabel
            // 
            this.test3PromptLabel.AutoSize = true;
            this.test3PromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test3PromptLabel.Location = new System.Drawing.Point(168, 227);
            this.test3PromptLabel.Name = "test3PromptLabel";
            this.test3PromptLabel.Size = new System.Drawing.Size(47, 16);
            this.test3PromptLabel.TabIndex = 2;
            this.test3PromptLabel.Text = "Test 3:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(115, 297);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(131, 16);
            this.outputDescriptionLabel.TabIndex = 3;
            this.outputDescriptionLabel.Text = "Average Test Score:";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(252, 290);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(185, 23);
            this.averageLabel.TabIndex = 4;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(118, 366);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 38);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Caclulate Average";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(242, 366);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(74, 38);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(362, 366);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 38);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(337, 86);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 20);
            this.test1TextBox.TabIndex = 8;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(337, 154);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 20);
            this.test2TextBox.TabIndex = 9;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(337, 220);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 20);
            this.test3TextBox.TabIndex = 10;
            // 
            // testAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 493);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.test3PromptLabel);
            this.Controls.Add(this.test2PromptLabel);
            this.Controls.Add(this.test1PromptLabel);
            this.Name = "testAverage";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1PromptLabel;
        private System.Windows.Forms.Label test2PromptLabel;
        private System.Windows.Forms.Label test3PromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
    }
}

