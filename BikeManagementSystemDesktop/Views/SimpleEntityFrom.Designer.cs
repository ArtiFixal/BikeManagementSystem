namespace BikeManagementSystemDesktop.Views
{
    partial class SimpleEntityFrom
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
            labelName = new Label();
            textBox = new TextBox();
            ActionButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(13, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // textBox
            // 
            textBox.Location = new Point(61, 7);
            textBox.Name = "textBox";
            textBox.Size = new Size(183, 23);
            textBox.TabIndex = 1;
            // 
            // ActionButton
            // 
            ActionButton.Location = new Point(46, 48);
            ActionButton.Name = "ActionButton";
            ActionButton.Size = new Size(75, 23);
            ActionButton.TabIndex = 2;
            ActionButton.Text = "Action";
            ActionButton.UseVisualStyleBackColor = true;
            ActionButton.Click += ActionButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(127, 48);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SimpleEntityFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 83);
            Controls.Add(CancelButton);
            Controls.Add(ActionButton);
            Controls.Add(textBox);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SimpleEntityFrom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Simple Entity Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBox;
        private Button ActionButton;
        private Button CancelButton;
    }
}