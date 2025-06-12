namespace BikeManagementSystemDesktop.Views
{
    partial class BikeWearTableForm
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
            splitRoot = new SplitContainer();
            labelBikeType = new Label();
            labelBikeTypeText = new Label();
            splitBikeWear = new SplitContainer();
            wearTable = new DataGridView();
            wearTablePage = new NumericUpDown();
            labelPage = new Label();
            buttonEditRatio = new Button();
            ((System.ComponentModel.ISupportInitialize)splitRoot).BeginInit();
            splitRoot.Panel1.SuspendLayout();
            splitRoot.Panel2.SuspendLayout();
            splitRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitBikeWear).BeginInit();
            splitBikeWear.Panel1.SuspendLayout();
            splitBikeWear.Panel2.SuspendLayout();
            splitBikeWear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wearTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wearTablePage).BeginInit();
            SuspendLayout();
            // 
            // splitRoot
            // 
            splitRoot.Dock = DockStyle.Fill;
            splitRoot.Location = new Point(0, 0);
            splitRoot.Name = "splitRoot";
            splitRoot.Orientation = Orientation.Horizontal;
            // 
            // splitRoot.Panel1
            // 
            splitRoot.Panel1.Controls.Add(labelBikeType);
            splitRoot.Panel1.Controls.Add(labelBikeTypeText);
            // 
            // splitRoot.Panel2
            // 
            splitRoot.Panel2.Controls.Add(splitBikeWear);
            splitRoot.Size = new Size(800, 450);
            splitRoot.SplitterDistance = 34;
            splitRoot.TabIndex = 0;
            // 
            // labelBikeType
            // 
            labelBikeType.AutoSize = true;
            labelBikeType.Location = new Point(68, 9);
            labelBikeType.Name = "labelBikeType";
            labelBikeType.Size = new Size(30, 15);
            labelBikeType.TabIndex = 1;
            labelBikeType.Text = "type";
            // 
            // labelBikeTypeText
            // 
            labelBikeTypeText.AutoSize = true;
            labelBikeTypeText.Location = new Point(3, 9);
            labelBikeTypeText.Name = "labelBikeTypeText";
            labelBikeTypeText.Size = new Size(59, 15);
            labelBikeTypeText.TabIndex = 0;
            labelBikeTypeText.Text = "Bike Type:";
            // 
            // splitBikeWear
            // 
            splitBikeWear.Dock = DockStyle.Fill;
            splitBikeWear.Location = new Point(0, 0);
            splitBikeWear.Name = "splitBikeWear";
            // 
            // splitBikeWear.Panel1
            // 
            splitBikeWear.Panel1.Controls.Add(wearTable);
            // 
            // splitBikeWear.Panel2
            // 
            splitBikeWear.Panel2.Controls.Add(wearTablePage);
            splitBikeWear.Panel2.Controls.Add(labelPage);
            splitBikeWear.Panel2.Controls.Add(buttonEditRatio);
            splitBikeWear.Size = new Size(800, 412);
            splitBikeWear.SplitterDistance = 705;
            splitBikeWear.TabIndex = 0;
            // 
            // wearTable
            // 
            wearTable.AllowUserToAddRows = false;
            wearTable.AllowUserToDeleteRows = false;
            wearTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wearTable.Dock = DockStyle.Fill;
            wearTable.Location = new Point(0, 0);
            wearTable.Name = "wearTable";
            wearTable.ReadOnly = true;
            wearTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            wearTable.Size = new Size(705, 412);
            wearTable.TabIndex = 0;
            // 
            // wearTablePage
            // 
            wearTablePage.Location = new Point(3, 386);
            wearTablePage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            wearTablePage.Name = "wearTablePage";
            wearTablePage.Size = new Size(85, 23);
            wearTablePage.TabIndex = 2;
            wearTablePage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            wearTablePage.ValueChanged += wearTablePage_ValueChanged;
            // 
            // labelPage
            // 
            labelPage.AutoSize = true;
            labelPage.Location = new Point(2, 368);
            labelPage.Name = "labelPage";
            labelPage.Size = new Size(36, 15);
            labelPage.TabIndex = 1;
            labelPage.Text = "Page:";
            // 
            // buttonEditRatio
            // 
            buttonEditRatio.Location = new Point(2, 3);
            buttonEditRatio.Name = "buttonEditRatio";
            buttonEditRatio.Size = new Size(86, 23);
            buttonEditRatio.TabIndex = 0;
            buttonEditRatio.Text = "Edit ratio";
            buttonEditRatio.UseVisualStyleBackColor = true;
            buttonEditRatio.Click += buttonEditRatio_Click;
            // 
            // BikeWearTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitRoot);
            Name = "BikeWearTableForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bike type wear ratios";
            splitRoot.Panel1.ResumeLayout(false);
            splitRoot.Panel1.PerformLayout();
            splitRoot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitRoot).EndInit();
            splitRoot.ResumeLayout(false);
            splitBikeWear.Panel1.ResumeLayout(false);
            splitBikeWear.Panel2.ResumeLayout(false);
            splitBikeWear.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitBikeWear).EndInit();
            splitBikeWear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wearTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)wearTablePage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitRoot;
        private Label labelBikeType;
        private Label labelBikeTypeText;
        private SplitContainer splitBikeWear;
        private DataGridView wearTable;
        private Button buttonEditRatio;
        private NumericUpDown wearTablePage;
        private Label labelPage;
    }
}