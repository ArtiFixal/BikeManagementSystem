namespace BikeManagementSystemDesktop.Views
{
    partial class BikeRentalForm
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
            splitMainContainer = new SplitContainer();
            splitBikeContainer = new SplitContainer();
            buttonSearch = new Button();
            modelBox = new TextBox();
            vendorBox = new ComboBox();
            typeBox = new ComboBox();
            labelFilters = new Label();
            bikeTable = new DataGridView();
            buttonAddToRent = new Button();
            splitRentalContainer = new SplitContainer();
            buttonAddClient = new Button();
            buttonRemoveBike = new Button();
            rentTo = new DateTimePicker();
            labelTo = new Label();
            rentFrom = new DateTimePicker();
            labelFrom = new Label();
            clientBox = new ComboBox();
            labelClient = new Label();
            rentalTable = new DataGridView();
            buttonRent = new Button();
            buttonCancel = new Button();
            labelTerrain = new Label();
            terrainBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitMainContainer).BeginInit();
            splitMainContainer.Panel1.SuspendLayout();
            splitMainContainer.Panel2.SuspendLayout();
            splitMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitBikeContainer).BeginInit();
            splitBikeContainer.Panel1.SuspendLayout();
            splitBikeContainer.Panel2.SuspendLayout();
            splitBikeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bikeTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitRentalContainer).BeginInit();
            splitRentalContainer.Panel1.SuspendLayout();
            splitRentalContainer.Panel2.SuspendLayout();
            splitRentalContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rentalTable).BeginInit();
            SuspendLayout();
            // 
            // splitMainContainer
            // 
            splitMainContainer.Dock = DockStyle.Top;
            splitMainContainer.Location = new Point(0, 0);
            splitMainContainer.Name = "splitMainContainer";
            // 
            // splitMainContainer.Panel1
            // 
            splitMainContainer.Panel1.Controls.Add(splitBikeContainer);
            // 
            // splitMainContainer.Panel2
            // 
            splitMainContainer.Panel2.Controls.Add(splitRentalContainer);
            splitMainContainer.Size = new Size(800, 443);
            splitMainContainer.SplitterDistance = 393;
            splitMainContainer.TabIndex = 0;
            // 
            // splitBikeContainer
            // 
            splitBikeContainer.Dock = DockStyle.Fill;
            splitBikeContainer.Location = new Point(0, 0);
            splitBikeContainer.Name = "splitBikeContainer";
            splitBikeContainer.Orientation = Orientation.Horizontal;
            // 
            // splitBikeContainer.Panel1
            // 
            splitBikeContainer.Panel1.Controls.Add(buttonSearch);
            splitBikeContainer.Panel1.Controls.Add(modelBox);
            splitBikeContainer.Panel1.Controls.Add(vendorBox);
            splitBikeContainer.Panel1.Controls.Add(typeBox);
            splitBikeContainer.Panel1.Controls.Add(labelFilters);
            // 
            // splitBikeContainer.Panel2
            // 
            splitBikeContainer.Panel2.Controls.Add(bikeTable);
            splitBikeContainer.Panel2.Controls.Add(buttonAddToRent);
            splitBikeContainer.Size = new Size(393, 443);
            splitBikeContainer.SplitterDistance = 101;
            splitBikeContainer.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(266, 56);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // modelBox
            // 
            modelBox.Location = new Point(12, 56);
            modelBox.Name = "modelBox";
            modelBox.PlaceholderText = "Bike model...";
            modelBox.Size = new Size(248, 23);
            modelBox.TabIndex = 3;
            // 
            // vendorBox
            // 
            vendorBox.FormattingEnabled = true;
            vendorBox.Location = new Point(139, 27);
            vendorBox.Name = "vendorBox";
            vendorBox.Size = new Size(121, 23);
            vendorBox.TabIndex = 2;
            vendorBox.Text = "Vendor";
            // 
            // typeBox
            // 
            typeBox.FormattingEnabled = true;
            typeBox.Location = new Point(12, 27);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(121, 23);
            typeBox.TabIndex = 1;
            typeBox.Text = "Type";
            // 
            // labelFilters
            // 
            labelFilters.AutoSize = true;
            labelFilters.Location = new Point(3, 9);
            labelFilters.Name = "labelFilters";
            labelFilters.Size = new Size(41, 15);
            labelFilters.TabIndex = 0;
            labelFilters.Text = "Filters:";
            // 
            // bikeTable
            // 
            bikeTable.AllowUserToAddRows = false;
            bikeTable.AllowUserToDeleteRows = false;
            bikeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bikeTable.Dock = DockStyle.Top;
            bikeTable.Location = new Point(0, 0);
            bikeTable.Name = "bikeTable";
            bikeTable.ReadOnly = true;
            bikeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bikeTable.Size = new Size(393, 289);
            bikeTable.TabIndex = 2;
            // 
            // buttonAddToRent
            // 
            buttonAddToRent.Location = new Point(168, 295);
            buttonAddToRent.Name = "buttonAddToRent";
            buttonAddToRent.Size = new Size(75, 23);
            buttonAddToRent.TabIndex = 1;
            buttonAddToRent.Text = "Add to rent";
            buttonAddToRent.UseVisualStyleBackColor = true;
            buttonAddToRent.Click += buttonAddToRent_Click;
            // 
            // splitRentalContainer
            // 
            splitRentalContainer.Dock = DockStyle.Fill;
            splitRentalContainer.Location = new Point(0, 0);
            splitRentalContainer.Name = "splitRentalContainer";
            splitRentalContainer.Orientation = Orientation.Horizontal;
            // 
            // splitRentalContainer.Panel1
            // 
            splitRentalContainer.Panel1.Controls.Add(terrainBox);
            splitRentalContainer.Panel1.Controls.Add(labelTerrain);
            splitRentalContainer.Panel1.Controls.Add(buttonAddClient);
            splitRentalContainer.Panel1.Controls.Add(buttonRemoveBike);
            splitRentalContainer.Panel1.Controls.Add(rentTo);
            splitRentalContainer.Panel1.Controls.Add(labelTo);
            splitRentalContainer.Panel1.Controls.Add(rentFrom);
            splitRentalContainer.Panel1.Controls.Add(labelFrom);
            splitRentalContainer.Panel1.Controls.Add(clientBox);
            splitRentalContainer.Panel1.Controls.Add(labelClient);
            // 
            // splitRentalContainer.Panel2
            // 
            splitRentalContainer.Panel2.Controls.Add(rentalTable);
            splitRentalContainer.Size = new Size(403, 443);
            splitRentalContainer.SplitterDistance = 193;
            splitRentalContainer.TabIndex = 0;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Location = new Point(269, 27);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(75, 23);
            buttonAddClient.TabIndex = 7;
            buttonAddClient.Text = "Add client";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonRemoveBike
            // 
            buttonRemoveBike.Location = new Point(306, 158);
            buttonRemoveBike.Name = "buttonRemoveBike";
            buttonRemoveBike.Size = new Size(94, 23);
            buttonRemoveBike.TabIndex = 6;
            buttonRemoveBike.Text = "Remove bike";
            buttonRemoveBike.UseVisualStyleBackColor = true;
            buttonRemoveBike.Click += buttonRemoveBike_Click;
            // 
            // rentTo
            // 
            rentTo.Location = new Point(14, 115);
            rentTo.Name = "rentTo";
            rentTo.Size = new Size(200, 23);
            rentTo.TabIndex = 5;
            rentTo.ValueChanged += rentTo_ValueChanged;
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Location = new Point(3, 97);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(48, 15);
            labelTo.TabIndex = 4;
            labelTo.Text = "Rent to:";
            // 
            // rentFrom
            // 
            rentFrom.Location = new Point(14, 71);
            rentFrom.Name = "rentFrom";
            rentFrom.Size = new Size(200, 23);
            rentFrom.TabIndex = 3;
            rentFrom.ValueChanged += rentFrom_ValueChanged;
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(3, 53);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(63, 15);
            labelFrom.TabIndex = 2;
            labelFrom.Text = "Rent from:";
            // 
            // clientBox
            // 
            clientBox.FormattingEnabled = true;
            clientBox.Location = new Point(14, 27);
            clientBox.Name = "clientBox";
            clientBox.Size = new Size(249, 23);
            clientBox.TabIndex = 1;
            clientBox.Text = "Client";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point(3, 9);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(41, 15);
            labelClient.TabIndex = 0;
            labelClient.Text = "Client:";
            // 
            // rentalTable
            // 
            rentalTable.AllowUserToAddRows = false;
            rentalTable.AllowUserToDeleteRows = false;
            rentalTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentalTable.Dock = DockStyle.Fill;
            rentalTable.Location = new Point(0, 0);
            rentalTable.Name = "rentalTable";
            rentalTable.ReadOnly = true;
            rentalTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rentalTable.Size = new Size(403, 246);
            rentalTable.TabIndex = 0;
            // 
            // buttonRent
            // 
            buttonRent.Location = new Point(316, 449);
            buttonRent.Name = "buttonRent";
            buttonRent.Size = new Size(75, 23);
            buttonRent.TabIndex = 1;
            buttonRent.Text = "Rent";
            buttonRent.UseVisualStyleBackColor = true;
            buttonRent.Click += buttonRent_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(397, 449);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelTerrain
            // 
            labelTerrain.AutoSize = true;
            labelTerrain.Location = new Point(3, 141);
            labelTerrain.Name = "labelTerrain";
            labelTerrain.Size = new Size(142, 15);
            labelTerrain.TabIndex = 8;
            labelTerrain.Text = "Approximate terrain type:";
            // 
            // terrainBox
            // 
            terrainBox.FormattingEnabled = true;
            terrainBox.Location = new Point(14, 159);
            terrainBox.Name = "terrainBox";
            terrainBox.Size = new Size(200, 23);
            terrainBox.TabIndex = 9;
            terrainBox.Text = "Terrain";
            // 
            // BikeRentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(buttonCancel);
            Controls.Add(buttonRent);
            Controls.Add(splitMainContainer);
            Name = "BikeRentalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bike rental form";
            splitMainContainer.Panel1.ResumeLayout(false);
            splitMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMainContainer).EndInit();
            splitMainContainer.ResumeLayout(false);
            splitBikeContainer.Panel1.ResumeLayout(false);
            splitBikeContainer.Panel1.PerformLayout();
            splitBikeContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitBikeContainer).EndInit();
            splitBikeContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bikeTable).EndInit();
            splitRentalContainer.Panel1.ResumeLayout(false);
            splitRentalContainer.Panel1.PerformLayout();
            splitRentalContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitRentalContainer).EndInit();
            splitRentalContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rentalTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMainContainer;
        private SplitContainer splitBikeContainer;
        private SplitContainer splitRentalContainer;
        private ComboBox vendorBox;
        private ComboBox typeBox;
        private Label labelFilters;
        private Label labelClient;
        private Button buttonSearch;
        private TextBox modelBox;
        private DateTimePicker rentTo;
        private Label labelTo;
        private DateTimePicker rentFrom;
        private Label labelFrom;
        private ComboBox clientBox;
        private Button buttonRemoveBike;
        private Button buttonAddToRent;
        private Button buttonRent;
        private Button buttonCancel;
        private DataGridView bikeTable;
        private DataGridView rentalTable;
        private Button buttonAddClient;
        private ComboBox terrainBox;
        private Label labelTerrain;
    }
}