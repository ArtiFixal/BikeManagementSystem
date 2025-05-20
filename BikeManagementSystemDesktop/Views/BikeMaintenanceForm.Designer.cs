namespace BikeManagementSystemDesktop.Views
{
    partial class BikeMaintenanceForm
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
            labelBikeIdText = new Label();
            labelBikeID = new Label();
            labelModelText = new Label();
            labelVendorText = new Label();
            labelTypeText = new Label();
            labelModel = new Label();
            labelVendor = new Label();
            labelType = new Label();
            labelMaintenanceDate = new Label();
            maintenanceDate = new DateTimePicker();
            maintenanceDescritpion = new TextBox();
            labelDescription = new Label();
            buttonAction = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelBikeIdText
            // 
            labelBikeIdText.AutoSize = true;
            labelBikeIdText.Location = new Point(12, 9);
            labelBikeIdText.Name = "labelBikeIdText";
            labelBikeIdText.Size = new Size(21, 15);
            labelBikeIdText.TabIndex = 0;
            labelBikeIdText.Text = "ID:";
            // 
            // labelBikeID
            // 
            labelBikeID.AutoSize = true;
            labelBikeID.Location = new Point(39, 9);
            labelBikeID.Name = "labelBikeID";
            labelBikeID.Size = new Size(40, 15);
            labelBikeID.TabIndex = 1;
            labelBikeID.Text = "bikeID";
            // 
            // labelModelText
            // 
            labelModelText.AutoSize = true;
            labelModelText.Location = new Point(12, 24);
            labelModelText.Name = "labelModelText";
            labelModelText.Size = new Size(44, 15);
            labelModelText.TabIndex = 2;
            labelModelText.Text = "Model:";
            // 
            // labelVendorText
            // 
            labelVendorText.AutoSize = true;
            labelVendorText.Location = new Point(12, 39);
            labelVendorText.Name = "labelVendorText";
            labelVendorText.Size = new Size(47, 15);
            labelVendorText.TabIndex = 3;
            labelVendorText.Text = "Vendor:";
            // 
            // labelTypeText
            // 
            labelTypeText.AutoSize = true;
            labelTypeText.Location = new Point(12, 54);
            labelTypeText.Name = "labelTypeText";
            labelTypeText.Size = new Size(34, 15);
            labelTypeText.TabIndex = 4;
            labelTypeText.Text = "Type:";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(62, 24);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(41, 15);
            labelModel.TabIndex = 5;
            labelModel.Text = "model";
            // 
            // labelVendor
            // 
            labelVendor.AutoSize = true;
            labelVendor.Location = new Point(65, 39);
            labelVendor.Name = "labelVendor";
            labelVendor.Size = new Size(44, 15);
            labelVendor.TabIndex = 6;
            labelVendor.Text = "vendor";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(52, 54);
            labelType.Name = "labelType";
            labelType.Size = new Size(30, 15);
            labelType.TabIndex = 7;
            labelType.Text = "type";
            // 
            // labelMaintenanceDate
            // 
            labelMaintenanceDate.AutoSize = true;
            labelMaintenanceDate.Location = new Point(12, 83);
            labelMaintenanceDate.Name = "labelMaintenanceDate";
            labelMaintenanceDate.Size = new Size(105, 15);
            labelMaintenanceDate.TabIndex = 8;
            labelMaintenanceDate.Text = "Maintenance date:";
            // 
            // maintenanceDate
            // 
            maintenanceDate.Location = new Point(12, 101);
            maintenanceDate.Name = "maintenanceDate";
            maintenanceDate.Size = new Size(210, 23);
            maintenanceDate.TabIndex = 9;
            // 
            // maintenanceDescritpion
            // 
            maintenanceDescritpion.Location = new Point(12, 155);
            maintenanceDescritpion.Multiline = true;
            maintenanceDescritpion.Name = "maintenanceDescritpion";
            maintenanceDescritpion.Size = new Size(471, 283);
            maintenanceDescritpion.TabIndex = 10;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(12, 137);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(141, 15);
            labelDescription.TabIndex = 11;
            labelDescription.Text = "Maintenance description:";
            // 
            // buttonAction
            // 
            buttonAction.Location = new Point(150, 446);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(86, 23);
            buttonAction.TabIndex = 12;
            buttonAction.Text = "Maintenance";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(242, 446);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // BikeMaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 481);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAction);
            Controls.Add(labelDescription);
            Controls.Add(maintenanceDescritpion);
            Controls.Add(maintenanceDate);
            Controls.Add(labelMaintenanceDate);
            Controls.Add(labelType);
            Controls.Add(labelVendor);
            Controls.Add(labelModel);
            Controls.Add(labelTypeText);
            Controls.Add(labelVendorText);
            Controls.Add(labelModelText);
            Controls.Add(labelBikeID);
            Controls.Add(labelBikeIdText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BikeMaintenanceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bike Maintenance Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBikeIdText;
        private Label labelBikeID;
        private Label labelModelText;
        private Label labelVendorText;
        private Label labelTypeText;
        private Label labelModel;
        private Label labelVendor;
        private Label labelType;
        private Label labelMaintenanceDate;
        private DateTimePicker maintenanceDate;
        private TextBox maintenanceDescritpion;
        private Label labelDescription;
        private Button buttonAction;
        private Button buttonCancel;
    }
}