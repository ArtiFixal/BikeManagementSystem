namespace BikeManagementSystemDesktop.Views
{
    partial class BikeReturnForm
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
            labelStatus = new Label();
            bikeStatus = new TextBox();
            labelModelText = new Label();
            labelBikeID = new Label();
            labelVendorText = new Label();
            labelTypeText = new Label();
            labelIdText = new Label();
            labelModel = new Label();
            labelVendor = new Label();
            labelType = new Label();
            buttonReturn = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 84);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(204, 15);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Bike return status (leave blank if fine):";
            // 
            // bikeStatus
            // 
            bikeStatus.Location = new Point(12, 102);
            bikeStatus.Multiline = true;
            bikeStatus.Name = "bikeStatus";
            bikeStatus.Size = new Size(447, 221);
            bikeStatus.TabIndex = 1;
            // 
            // labelModelText
            // 
            labelModelText.AutoSize = true;
            labelModelText.Location = new Point(8, 24);
            labelModelText.Name = "labelModelText";
            labelModelText.Size = new Size(44, 15);
            labelModelText.TabIndex = 2;
            labelModelText.Text = "Model:";
            // 
            // labelBikeID
            // 
            labelBikeID.AutoSize = true;
            labelBikeID.Location = new Point(35, 9);
            labelBikeID.Name = "labelBikeID";
            labelBikeID.Size = new Size(17, 15);
            labelBikeID.TabIndex = 3;
            labelBikeID.Text = "id";
            // 
            // labelVendorText
            // 
            labelVendorText.AutoSize = true;
            labelVendorText.Location = new Point(8, 39);
            labelVendorText.Name = "labelVendorText";
            labelVendorText.Size = new Size(47, 15);
            labelVendorText.TabIndex = 4;
            labelVendorText.Text = "Vendor:";
            // 
            // labelTypeText
            // 
            labelTypeText.AutoSize = true;
            labelTypeText.Location = new Point(8, 54);
            labelTypeText.Name = "labelTypeText";
            labelTypeText.Size = new Size(34, 15);
            labelTypeText.TabIndex = 5;
            labelTypeText.Text = "Type:";
            // 
            // labelIdText
            // 
            labelIdText.AutoSize = true;
            labelIdText.Location = new Point(8, 9);
            labelIdText.Name = "labelIdText";
            labelIdText.Size = new Size(21, 15);
            labelIdText.TabIndex = 6;
            labelIdText.Text = "ID:";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(58, 24);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(41, 15);
            labelModel.TabIndex = 7;
            labelModel.Text = "model";
            // 
            // labelVendor
            // 
            labelVendor.AutoSize = true;
            labelVendor.Location = new Point(61, 39);
            labelVendor.Name = "labelVendor";
            labelVendor.Size = new Size(44, 15);
            labelVendor.TabIndex = 8;
            labelVendor.Text = "vendor";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(48, 54);
            labelType.Name = "labelType";
            labelType.Size = new Size(30, 15);
            labelType.TabIndex = 9;
            labelType.Text = "type";
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(151, 331);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(75, 23);
            buttonReturn.TabIndex = 10;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(232, 331);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // BikeReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 366);
            Controls.Add(buttonCancel);
            Controls.Add(buttonReturn);
            Controls.Add(labelType);
            Controls.Add(labelVendor);
            Controls.Add(labelModel);
            Controls.Add(labelIdText);
            Controls.Add(labelTypeText);
            Controls.Add(labelVendorText);
            Controls.Add(labelBikeID);
            Controls.Add(labelModelText);
            Controls.Add(bikeStatus);
            Controls.Add(labelStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BikeReturnForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bike Return Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStatus;
        private TextBox bikeStatus;
        private Label labelModelText;
        private Label labelBikeID;
        private Label labelVendorText;
        private Label labelTypeText;
        private Label labelIdText;
        private Label labelModel;
        private Label labelVendor;
        private Label labelType;
        private Button buttonReturn;
        private Button buttonCancel;
    }
}