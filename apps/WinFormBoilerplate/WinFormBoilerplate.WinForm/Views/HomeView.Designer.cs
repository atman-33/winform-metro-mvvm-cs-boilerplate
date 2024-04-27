namespace WinFormBoilerplate.WinForm.Views
{
    partial class HomeView
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
            Value1TextBox = new TextBox();
            label1 = new Label();
            Value2TextBox = new TextBox();
            CalculateButton = new Button();
            label2 = new Label();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // Value1TextBox
            // 
            Value1TextBox.Location = new Point(55, 105);
            Value1TextBox.Name = "Value1TextBox";
            Value1TextBox.Size = new Size(100, 25);
            Value1TextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 109);
            label1.Name = "label1";
            label1.Size = new Size(17, 17);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // Value2TextBox
            // 
            Value2TextBox.Location = new Point(246, 105);
            Value2TextBox.Name = "Value2TextBox";
            Value2TextBox.Size = new Size(100, 25);
            Value2TextBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(426, 98);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(80, 38);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 174);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 5;
            label2.Text = "Result: ";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(154, 174);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(48, 17);
            ResultLabel.TabIndex = 6;
            ResultLabel.Text = "(result)";
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultLabel);
            Controls.Add(label2);
            Controls.Add(CalculateButton);
            Controls.Add(Value2TextBox);
            Controls.Add(label1);
            Controls.Add(Value1TextBox);
            Name = "HomeView";
            Text = "HomeView";
            Controls.SetChildIndex(Value1TextBox, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(Value2TextBox, 0);
            Controls.SetChildIndex(CalculateButton, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(ResultLabel, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Value1TextBox;
        private Label label1;
        private TextBox Value2TextBox;
        private Button CalculateButton;
        private Label label2;
        private Label ResultLabel;
    }
}