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
            tableLayoutPanel1 = new TableLayoutPanel();
            SampleViewButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SampleViewDialogButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Value1TextBox
            // 
            Value1TextBox.Anchor = AnchorStyles.None;
            Value1TextBox.Location = new Point(24, 36);
            Value1TextBox.Name = "Value1TextBox";
            Value1TextBox.Size = new Size(100, 25);
            Value1TextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(170, 40);
            label1.Name = "label1";
            label1.Size = new Size(17, 17);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // Value2TextBox
            // 
            Value2TextBox.Anchor = AnchorStyles.None;
            Value2TextBox.Location = new Point(232, 36);
            Value2TextBox.Name = "Value2TextBox";
            Value2TextBox.Size = new Size(100, 25);
            Value2TextBox.TabIndex = 3;
            // 
            // CalculateButton
            // 
            CalculateButton.Anchor = AnchorStyles.None;
            CalculateButton.Location = new Point(391, 30);
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
            label2.Location = new Point(49, 138);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 5;
            label2.Text = "Result: ";
            // 
            // ResultLabel
            // 
            ResultLabel.Anchor = AnchorStyles.None;
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(154, 138);
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
            tableLayoutPanel1.Location = new Point(20, 111);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(760, 294);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // SampleViewButton
            // 
            SampleViewButton.Location = new Point(3, 3);
            SampleViewButton.Name = "SampleViewButton";
            SampleViewButton.Size = new Size(124, 32);
            SampleViewButton.TabIndex = 8;
            SampleViewButton.Text = "サンプル画面へ";
            SampleViewButton.UseVisualStyleBackColor = true;
            SampleViewButton.Click += SampleViewButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(SampleViewButton);
            flowLayoutPanel1.Controls.Add(SampleViewDialogButton);
            flowLayoutPanel1.Location = new Point(20, 63);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(760, 42);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // SampleViewDialogButton
            // 
            SampleViewDialogButton.Location = new Point(133, 3);
            SampleViewDialogButton.Name = "SampleViewDialogButton";
            SampleViewDialogButton.Size = new Size(199, 32);
            SampleViewDialogButton.TabIndex = 9;
            SampleViewDialogButton.Text = "サンプル画面へ（別フォーム）";
            SampleViewDialogButton.UseVisualStyleBackColor = true;
            SampleViewDialogButton.Click += SampleViewDialogButton_Click;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "HomeView";
            Text = "HomeView";
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            Controls.SetChildIndex(flowLayoutPanel1, 0);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
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
        private Button SampleViewButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SampleViewDialogButton;
    }
}