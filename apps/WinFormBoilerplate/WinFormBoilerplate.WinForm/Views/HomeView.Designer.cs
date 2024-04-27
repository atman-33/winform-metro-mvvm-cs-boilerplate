﻿namespace WinFormBoilerplate.WinForm.Views
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Value1TextBox
            // 
            Value1TextBox.Anchor = AnchorStyles.None;
            Value1TextBox.Location = new Point(24, 45);
            Value1TextBox.Name = "Value1TextBox";
            Value1TextBox.Size = new Size(100, 25);
            Value1TextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(170, 49);
            label1.Name = "label1";
            label1.Size = new Size(17, 17);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // Value2TextBox
            // 
            Value2TextBox.Anchor = AnchorStyles.None;
            Value2TextBox.Location = new Point(232, 45);
            Value2TextBox.Name = "Value2TextBox";
            Value2TextBox.Size = new Size(100, 25);
            Value2TextBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            CalculateButton.Anchor = AnchorStyles.None;
            CalculateButton.Location = new Point(391, 38);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(80, 38);
            CalculateButton.TabIndex = 4;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(49, 164);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 5;
            label2.Text = "Result: ";
            // 
            // ResultLabel
            // 
            ResultLabel.Anchor = AnchorStyles.None;
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(154, 164);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(48, 17);
            ResultLabel.TabIndex = 6;
            ResultLabel.Text = "(result)";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.60784F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.84313726F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6078434F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6078434F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(Value1TextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(ResultLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(Value2TextBox, 2, 0);
            tableLayoutPanel1.Controls.Add(CalculateButton, 3, 0);
            tableLayoutPanel1.Location = new Point(20, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(760, 345);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "HomeView";
            Text = "HomeView";
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}