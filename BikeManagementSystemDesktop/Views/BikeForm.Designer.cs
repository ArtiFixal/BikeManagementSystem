namespace BikeManagementSystemDesktop.Views
{
    partial class BikeForm
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
            bikeImage = new PictureBox();
            buttonImageChoose = new Button();
            labelModel = new Label();
            modelBox = new TextBox();
            labelVendor = new Label();
            vendorBox = new ComboBox();
            typeBox = new ComboBox();
            labelType = new Label();
            buttonAction = new Button();
            buttonCancel = new Button();
            buttonAddVendor = new Button();
            buttonAddType = new Button();
            ((System.ComponentModel.ISupportInitialize)bikeImage).BeginInit();
            SuspendLayout();
            // 
            // bikeImage
            // 
            bikeImage.Location = new Point(12, 12);
            bikeImage.Name = "bikeImage";
            bikeImage.Size = new Size(489, 174);
            bikeImage.SizeMode = PictureBoxSizeMode.Zoom;
            bikeImage.TabIndex = 0;
            bikeImage.TabStop = false;
            // 
            // buttonImageChoose
            // 
            buttonImageChoose.Location = new Point(203, 192);
            buttonImageChoose.Name = "buttonImageChoose";
            buttonImageChoose.Size = new Size(91, 23);
            buttonImageChoose.TabIndex = 1;
            buttonImageChoose.Text = "Choose image";
            buttonImageChoose.UseVisualStyleBackColor = true;
            buttonImageChoose.Click += buttonImageChoose_Click;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(12, 216);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(44, 15);
            labelModel.TabIndex = 2;
            labelModel.Text = "Model:";
            // 
            // modelBox
            // 
            modelBox.Location = new Point(12, 234);
            modelBox.Name = "modelBox";
            modelBox.PlaceholderText = "Model name...";
            modelBox.Size = new Size(320, 23);
            modelBox.TabIndex = 3;
            modelBox.TextChanged += modelBox_TextChanged;
            // 
            // labelVendor
            // 
            labelVendor.AutoSize = true;
            labelVendor.Location = new Point(12, 269);
            labelVendor.Name = "labelVendor";
            labelVendor.Size = new Size(47, 15);
            labelVendor.TabIndex = 5;
            labelVendor.Text = "Vendor:";
            // 
            // vendorBox
            // 
            vendorBox.FormattingEnabled = true;
            vendorBox.Location = new Point(12, 287);
            vendorBox.Name = "vendorBox";
            vendorBox.Size = new Size(200, 23);
            vendorBox.TabIndex = 6;
            vendorBox.Text = "Vendor";
            // 
            // typeBox
            // 
            typeBox.FormattingEnabled = true;
            typeBox.Location = new Point(12, 346);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(200, 23);
            typeBox.TabIndex = 7;
            typeBox.Text = "Bike type";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(12, 328);
            labelType.Name = "labelType";
            labelType.Size = new Size(58, 15);
            labelType.TabIndex = 8;
            labelType.Text = "Bike type:";
            // 
            // buttonAction
            // 
            buttonAction.Location = new Point(171, 384);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(75, 23);
            buttonAction.TabIndex = 9;
            buttonAction.Text = "Action";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(252, 384);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAddVendor
            // 
            buttonAddVendor.Location = new Point(218, 287);
            buttonAddVendor.Name = "buttonAddVendor";
            buttonAddVendor.Size = new Size(114, 23);
            buttonAddVendor.TabIndex = 11;
            buttonAddVendor.Text = "Add new vendor";
            buttonAddVendor.UseVisualStyleBackColor = true;
            buttonAddVendor.Click += buttonAddVendor_Click;
            // 
            // buttonAddType
            // 
            buttonAddType.Location = new Point(218, 346);
            buttonAddType.Name = "buttonAddType";
            buttonAddType.Size = new Size(114, 23);
            buttonAddType.TabIndex = 12;
            buttonAddType.Text = "Add new bike type";
            buttonAddType.UseVisualStyleBackColor = true;
            buttonAddType.Click += buttonAddType_Click;
            // 
            // BikeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 419);
            Controls.Add(buttonAddType);
            Controls.Add(buttonAddVendor);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAction);
            Controls.Add(labelType);
            Controls.Add(typeBox);
            Controls.Add(vendorBox);
            Controls.Add(labelVendor);
            Controls.Add(modelBox);
            Controls.Add(labelModel);
            Controls.Add(buttonImageChoose);
            Controls.Add(bikeImage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BikeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bike Form";
            ((System.ComponentModel.ISupportInitialize)bikeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bikeImage;
        private Button buttonImageChoose;
        private Label labelModel;
        private TextBox modelBox;
        private Label labelVendor;
        private ComboBox vendorBox;
        private ComboBox typeBox;
        private Label labelType;
        private Button buttonAction;
        private Button buttonCancel;
        private Button buttonAddVendor;
        private Button buttonAddType;
    }
}