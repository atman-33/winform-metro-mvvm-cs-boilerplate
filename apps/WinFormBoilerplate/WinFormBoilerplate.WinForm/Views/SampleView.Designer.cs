namespace WinFormBoilerplate.WinForm.Views
{
    partial class SampleView
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
            HomeViewButton = new Button();
            SuspendLayout();
            // 
            // HomeViewButton
            // 
            HomeViewButton.Location = new Point(23, 75);
            HomeViewButton.Name = "HomeViewButton";
            HomeViewButton.Size = new Size(99, 33);
            HomeViewButton.TabIndex = 1;
            HomeViewButton.Text = "ホーム画面へ";
            HomeViewButton.UseVisualStyleBackColor = true;
            HomeViewButton.Click += HomeViewButton_Click;
            // 
            // SampleView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HomeViewButton);
            Name = "SampleView";
            Text = "SampleView";
            Controls.SetChildIndex(HomeViewButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeViewButton;
    }
}