namespace BikeManagementSystemDesktop.Views
{
    partial class ClientForm
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
            labelFirstName = new Label();
            firstNameBox = new TextBox();
            labelLastName = new Label();
            labelPhoneNumber = new Label();
            labelIdentityNumber = new Label();
            lastNameBox = new TextBox();
            phoneNumberBox = new TextBox();
            IdentityNumberBox = new TextBox();
            buttonAction = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 9);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(65, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First name:";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(12, 27);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(263, 23);
            firstNameBox.TabIndex = 1;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 53);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(64, 15);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Last name:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(12, 96);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(89, 15);
            labelPhoneNumber.TabIndex = 3;
            labelPhoneNumber.Text = "Phone number:";
            // 
            // labelIdentityNumber
            // 
            labelIdentityNumber.AutoSize = true;
            labelIdentityNumber.Location = new Point(12, 140);
            labelIdentityNumber.Name = "labelIdentityNumber";
            labelIdentityNumber.Size = new Size(95, 15);
            labelIdentityNumber.TabIndex = 4;
            labelIdentityNumber.Text = "Identity number:";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(12, 70);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(263, 23);
            lastNameBox.TabIndex = 5;
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.Location = new Point(12, 114);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.Size = new Size(263, 23);
            phoneNumberBox.TabIndex = 6;
            // 
            // IdentityNumberBox
            // 
            IdentityNumberBox.Location = new Point(12, 158);
            IdentityNumberBox.Name = "IdentityNumberBox";
            IdentityNumberBox.Size = new Size(263, 23);
            IdentityNumberBox.TabIndex = 7;
            // 
            // buttonAction
            // 
            buttonAction.Location = new Point(66, 189);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(75, 23);
            buttonAction.TabIndex = 8;
            buttonAction.Text = "Action";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(147, 189);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 224);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAction);
            Controls.Add(IdentityNumberBox);
            Controls.Add(phoneNumberBox);
            Controls.Add(lastNameBox);
            Controls.Add(labelIdentityNumber);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelLastName);
            Controls.Add(firstNameBox);
            Controls.Add(labelFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Client Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private TextBox firstNameBox;
        private Label labelLastName;
        private Label labelPhoneNumber;
        private Label labelIdentityNumber;
        private TextBox lastNameBox;
        private TextBox phoneNumberBox;
        private TextBox IdentityNumberBox;
        private Button buttonAction;
        private Button buttonCancel;
    }
}