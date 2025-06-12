namespace BikeManagementSystemDesktop.Views
{
    partial class MaintenanceHistoryForm
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
            splitContainer1 = new SplitContainer();
            bikeImage = new PictureBox();
            labelBikeId = new Label();
            labelBikeIdText = new Label();
            labelBikeType = new Label();
            labelVendor = new Label();
            labelBikeTypeText = new Label();
            labelVendorText = new Label();
            labelBikeModel = new Label();
            labelBikeModelText = new Label();
            maintenaceTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bikeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maintenaceTable).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(bikeImage);
            splitContainer1.Panel1.Controls.Add(labelBikeId);
            splitContainer1.Panel1.Controls.Add(labelBikeIdText);
            splitContainer1.Panel1.Controls.Add(labelBikeType);
            splitContainer1.Panel1.Controls.Add(labelVendor);
            splitContainer1.Panel1.Controls.Add(labelBikeTypeText);
            splitContainer1.Panel1.Controls.Add(labelVendorText);
            splitContainer1.Panel1.Controls.Add(labelBikeModel);
            splitContainer1.Panel1.Controls.Add(labelBikeModelText);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(maintenaceTable);
            splitContainer1.Size = new Size(915, 564);
            splitContainer1.SplitterDistance = 162;
            splitContainer1.TabIndex = 0;
            // 
            // bikeImage
            // 
            bikeImage.Location = new Point(305, 3);
            bikeImage.MaximumSize = new Size(285, 156);
            bikeImage.Name = "bikeImage";
            bikeImage.Size = new Size(285, 156);
            bikeImage.SizeMode = PictureBoxSizeMode.Zoom;
            bikeImage.TabIndex = 8;
            bikeImage.TabStop = false;
            // 
            // labelBikeId
            // 
            labelBikeId.AutoSize = true;
            labelBikeId.Location = new Point(39, 9);
            labelBikeId.Name = "labelBikeId";
            labelBikeId.Size = new Size(43, 15);
            labelBikeId.TabIndex = 7;
            labelBikeId.Text = "bike ID";
            // 
            // labelBikeIdText
            // 
            labelBikeIdText.AutoSize = true;
            labelBikeIdText.Location = new Point(12, 9);
            labelBikeIdText.Name = "labelBikeIdText";
            labelBikeIdText.Size = new Size(21, 15);
            labelBikeIdText.TabIndex = 6;
            labelBikeIdText.Text = "ID:";
            // 
            // labelBikeType
            // 
            labelBikeType.AutoSize = true;
            labelBikeType.Location = new Point(76, 54);
            labelBikeType.Name = "labelBikeType";
            labelBikeType.Size = new Size(55, 15);
            labelBikeType.TabIndex = 5;
            labelBikeType.Text = "bike type";
            // 
            // labelVendor
            // 
            labelVendor.AutoSize = true;
            labelVendor.Location = new Point(65, 39);
            labelVendor.Name = "labelVendor";
            labelVendor.Size = new Size(44, 15);
            labelVendor.TabIndex = 4;
            labelVendor.Text = "vendor";
            // 
            // labelBikeTypeText
            // 
            labelBikeTypeText.AutoSize = true;
            labelBikeTypeText.Location = new Point(12, 54);
            labelBikeTypeText.Name = "labelBikeTypeText";
            labelBikeTypeText.Size = new Size(58, 15);
            labelBikeTypeText.TabIndex = 3;
            labelBikeTypeText.Text = "Bike type:";
            // 
            // labelVendorText
            // 
            labelVendorText.AutoSize = true;
            labelVendorText.Location = new Point(12, 39);
            labelVendorText.Name = "labelVendorText";
            labelVendorText.Size = new Size(47, 15);
            labelVendorText.TabIndex = 2;
            labelVendorText.Text = "Vendor:";
            // 
            // labelBikeModel
            // 
            labelBikeModel.AutoSize = true;
            labelBikeModel.Location = new Point(87, 24);
            labelBikeModel.Name = "labelBikeModel";
            labelBikeModel.Size = new Size(66, 15);
            labelBikeModel.TabIndex = 1;
            labelBikeModel.Text = "bike model";
            // 
            // labelBikeModelText
            // 
            labelBikeModelText.AutoSize = true;
            labelBikeModelText.Location = new Point(12, 24);
            labelBikeModelText.Name = "labelBikeModelText";
            labelBikeModelText.Size = new Size(69, 15);
            labelBikeModelText.TabIndex = 0;
            labelBikeModelText.Text = "Bike model:";
            // 
            // maintenaceTable
            // 
            maintenaceTable.AllowUserToAddRows = false;
            maintenaceTable.AllowUserToDeleteRows = false;
            maintenaceTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            maintenaceTable.Dock = DockStyle.Fill;
            maintenaceTable.Location = new Point(0, 0);
            maintenaceTable.Name = "maintenaceTable";
            maintenaceTable.ReadOnly = true;
            maintenaceTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            maintenaceTable.Size = new Size(915, 398);
            maintenaceTable.TabIndex = 0;
            // 
            // MaintenanceHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 564);
            Controls.Add(splitContainer1);
            Name = "MaintenanceHistoryForm";
            Text = "MaintenanceHistory";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bikeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)maintenaceTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label labelBikeType;
        private Label labelVendor;
        private Label labelBikeTypeText;
        private Label labelVendorText;
        private Label labelBikeModel;
        private Label labelBikeModelText;
        private Label labelBikeId;
        private Label labelBikeIdText;
        private DataGridView maintenaceTable;
        private PictureBox bikeImage;
    }
}