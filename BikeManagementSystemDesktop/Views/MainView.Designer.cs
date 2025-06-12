using BikeManagementSystemLib;
using BikeManagementSystemLib.Models;
using BikeManagementSystemLib.Services;

namespace BikeManagementSystemDesktop
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BikeTable = new DataGridView();
            menuTab = new TabControl();
            pageDashborad = new TabPage();
            buttonRent = new Button();
            BikePage = new TabPage();
            bikeSplitContainer = new SplitContainer();
            buttonMaintenanceHistory = new Button();
            labelBikeTablePage = new Label();
            bikeTablePageNumber = new NumericUpDown();
            buttonDeleteBike = new Button();
            buttonAddBike = new Button();
            buttonEditBike = new Button();
            VendorPage = new TabPage();
            vendorSplitContainer = new SplitContainer();
            vendorTable = new DataGridView();
            labelVendorPage = new Label();
            vendorTablePageNumber = new NumericUpDown();
            buttonVendorDelete = new Button();
            buttonVendorEdit = new Button();
            buttonVendorAdd = new Button();
            TypePage = new TabPage();
            typeSplitContainer = new SplitContainer();
            typeTable = new DataGridView();
            buttonOpenWearRatios = new Button();
            labelTypePage = new Label();
            typeTablePageNumber = new NumericUpDown();
            buttonTypeDelete = new Button();
            buttonTypeEdit = new Button();
            buttonTypeAdd = new Button();
            ActiveRentalsPage = new TabPage();
            activeRentalSplitContainer = new SplitContainer();
            activeRentalTable = new DataGridView();
            activeRentalPageNumber = new NumericUpDown();
            labelActiveRentalsPage = new Label();
            buttonActiveRentalsOpen = new Button();
            WornBikesPage = new TabPage();
            wearedBikesSplitContainer = new SplitContainer();
            wornBikesTable = new DataGridView();
            wornBikesTablePage = new NumericUpDown();
            labelWornBikesPage = new Label();
            buttonMaintenanceBike = new Button();
            TerrainPage = new TabPage();
            splitContainer1 = new SplitContainer();
            terrainTable = new DataGridView();
            terrainTablePage = new NumericUpDown();
            labelTerrrainPage = new Label();
            buttonTerrainDelete = new Button();
            buttonTerrainEdit = new Button();
            buttonTerrainAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)BikeTable).BeginInit();
            menuTab.SuspendLayout();
            pageDashborad.SuspendLayout();
            BikePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bikeSplitContainer).BeginInit();
            bikeSplitContainer.Panel1.SuspendLayout();
            bikeSplitContainer.Panel2.SuspendLayout();
            bikeSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bikeTablePageNumber).BeginInit();
            VendorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vendorSplitContainer).BeginInit();
            vendorSplitContainer.Panel1.SuspendLayout();
            vendorSplitContainer.Panel2.SuspendLayout();
            vendorSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vendorTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendorTablePageNumber).BeginInit();
            TypePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)typeSplitContainer).BeginInit();
            typeSplitContainer.Panel1.SuspendLayout();
            typeSplitContainer.Panel2.SuspendLayout();
            typeSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)typeTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeTablePageNumber).BeginInit();
            ActiveRentalsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activeRentalSplitContainer).BeginInit();
            activeRentalSplitContainer.Panel1.SuspendLayout();
            activeRentalSplitContainer.Panel2.SuspendLayout();
            activeRentalSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)activeRentalTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activeRentalPageNumber).BeginInit();
            WornBikesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wearedBikesSplitContainer).BeginInit();
            wearedBikesSplitContainer.Panel1.SuspendLayout();
            wearedBikesSplitContainer.Panel2.SuspendLayout();
            wearedBikesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wornBikesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wornBikesTablePage).BeginInit();
            TerrainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)terrainTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)terrainTablePage).BeginInit();
            SuspendLayout();
            // 
            // BikeTable
            // 
            BikeTable.AllowUserToAddRows = false;
            BikeTable.AllowUserToDeleteRows = false;
            BikeTable.Dock = DockStyle.Fill;
            BikeTable.Location = new Point(0, 0);
            BikeTable.Name = "BikeTable";
            BikeTable.ReadOnly = true;
            BikeTable.RowTemplate.Resizable = DataGridViewTriState.True;
            BikeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BikeTable.Size = new Size(696, 417);
            BikeTable.TabIndex = 4;
            // 
            // menuTab
            // 
            menuTab.Controls.Add(pageDashborad);
            menuTab.Controls.Add(BikePage);
            menuTab.Controls.Add(VendorPage);
            menuTab.Controls.Add(TypePage);
            menuTab.Controls.Add(ActiveRentalsPage);
            menuTab.Controls.Add(WornBikesPage);
            menuTab.Controls.Add(TerrainPage);
            menuTab.Dock = DockStyle.Fill;
            menuTab.Location = new Point(0, 0);
            menuTab.Name = "menuTab";
            menuTab.SelectedIndex = 0;
            menuTab.Size = new Size(804, 451);
            menuTab.TabIndex = 0;
            // 
            // pageDashborad
            // 
            pageDashborad.Controls.Add(buttonRent);
            pageDashborad.Location = new Point(4, 24);
            pageDashborad.Name = "pageDashborad";
            pageDashborad.Padding = new Padding(3);
            pageDashborad.Size = new Size(796, 423);
            pageDashborad.TabIndex = 0;
            pageDashborad.Text = "Dashboard";
            pageDashborad.UseVisualStyleBackColor = true;
            // 
            // buttonRent
            // 
            buttonRent.Location = new Point(6, 6);
            buttonRent.Name = "buttonRent";
            buttonRent.Size = new Size(75, 23);
            buttonRent.TabIndex = 0;
            buttonRent.Text = "Rent bikes";
            buttonRent.UseVisualStyleBackColor = true;
            buttonRent.Click += buttonRent_Click;
            // 
            // BikePage
            // 
            BikePage.Controls.Add(bikeSplitContainer);
            BikePage.Location = new Point(4, 24);
            BikePage.Name = "BikePage";
            BikePage.Padding = new Padding(3);
            BikePage.Size = new Size(796, 423);
            BikePage.TabIndex = 1;
            BikePage.Text = "Bikes";
            BikePage.UseVisualStyleBackColor = true;
            // 
            // bikeSplitContainer
            // 
            bikeSplitContainer.Dock = DockStyle.Fill;
            bikeSplitContainer.Location = new Point(3, 3);
            bikeSplitContainer.Name = "bikeSplitContainer";
            // 
            // bikeSplitContainer.Panel1
            // 
            bikeSplitContainer.Panel1.Controls.Add(BikeTable);
            // 
            // bikeSplitContainer.Panel2
            // 
            bikeSplitContainer.Panel2.Controls.Add(buttonMaintenanceHistory);
            bikeSplitContainer.Panel2.Controls.Add(labelBikeTablePage);
            bikeSplitContainer.Panel2.Controls.Add(bikeTablePageNumber);
            bikeSplitContainer.Panel2.Controls.Add(buttonDeleteBike);
            bikeSplitContainer.Panel2.Controls.Add(buttonAddBike);
            bikeSplitContainer.Panel2.Controls.Add(buttonEditBike);
            bikeSplitContainer.Size = new Size(790, 417);
            bikeSplitContainer.SplitterDistance = 696;
            bikeSplitContainer.TabIndex = 7;
            // 
            // buttonMaintenanceHistory
            // 
            buttonMaintenanceHistory.Location = new Point(3, 90);
            buttonMaintenanceHistory.Name = "buttonMaintenanceHistory";
            buttonMaintenanceHistory.Size = new Size(87, 39);
            buttonMaintenanceHistory.TabIndex = 11;
            buttonMaintenanceHistory.Text = "Maintenance history";
            buttonMaintenanceHistory.UseVisualStyleBackColor = true;
            buttonMaintenanceHistory.Click += buttonMaintenanceHistory_Click;
            // 
            // labelBikeTablePage
            // 
            labelBikeTablePage.AutoSize = true;
            labelBikeTablePage.Location = new Point(2, 371);
            labelBikeTablePage.Name = "labelBikeTablePage";
            labelBikeTablePage.Size = new Size(36, 15);
            labelBikeTablePage.TabIndex = 10;
            labelBikeTablePage.Text = "Page:";
            // 
            // bikeTablePageNumber
            // 
            bikeTablePageNumber.Location = new Point(2, 389);
            bikeTablePageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            bikeTablePageNumber.Name = "bikeTablePageNumber";
            bikeTablePageNumber.Size = new Size(81, 23);
            bikeTablePageNumber.TabIndex = 9;
            bikeTablePageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            bikeTablePageNumber.ValueChanged += bikeTablePageNumber_ValueChanged;
            // 
            // buttonDeleteBike
            // 
            buttonDeleteBike.Location = new Point(3, 61);
            buttonDeleteBike.Name = "buttonDeleteBike";
            buttonDeleteBike.Size = new Size(87, 23);
            buttonDeleteBike.TabIndex = 8;
            buttonDeleteBike.Text = "Delete Bike";
            buttonDeleteBike.UseVisualStyleBackColor = true;
            buttonDeleteBike.Click += buttonDeleteBike_Click;
            // 
            // buttonAddBike
            // 
            buttonAddBike.Location = new Point(3, 3);
            buttonAddBike.Name = "buttonAddBike";
            buttonAddBike.Size = new Size(87, 23);
            buttonAddBike.TabIndex = 6;
            buttonAddBike.Text = "Add Bike";
            buttonAddBike.UseVisualStyleBackColor = true;
            buttonAddBike.Click += buttonAddBike_Click;
            // 
            // buttonEditBike
            // 
            buttonEditBike.Location = new Point(3, 32);
            buttonEditBike.Name = "buttonEditBike";
            buttonEditBike.Size = new Size(87, 23);
            buttonEditBike.TabIndex = 7;
            buttonEditBike.Text = "Edit Bike";
            buttonEditBike.UseVisualStyleBackColor = true;
            buttonEditBike.Click += buttonEditBike_Click;
            // 
            // VendorPage
            // 
            VendorPage.Controls.Add(vendorSplitContainer);
            VendorPage.Location = new Point(4, 24);
            VendorPage.Name = "VendorPage";
            VendorPage.Padding = new Padding(3);
            VendorPage.Size = new Size(796, 423);
            VendorPage.TabIndex = 2;
            VendorPage.Text = "Vendors";
            VendorPage.UseVisualStyleBackColor = true;
            // 
            // vendorSplitContainer
            // 
            vendorSplitContainer.Dock = DockStyle.Fill;
            vendorSplitContainer.Location = new Point(3, 3);
            vendorSplitContainer.Name = "vendorSplitContainer";
            // 
            // vendorSplitContainer.Panel1
            // 
            vendorSplitContainer.Panel1.Controls.Add(vendorTable);
            // 
            // vendorSplitContainer.Panel2
            // 
            vendorSplitContainer.Panel2.Controls.Add(labelVendorPage);
            vendorSplitContainer.Panel2.Controls.Add(vendorTablePageNumber);
            vendorSplitContainer.Panel2.Controls.Add(buttonVendorDelete);
            vendorSplitContainer.Panel2.Controls.Add(buttonVendorEdit);
            vendorSplitContainer.Panel2.Controls.Add(buttonVendorAdd);
            vendorSplitContainer.Size = new Size(790, 417);
            vendorSplitContainer.SplitterDistance = 690;
            vendorSplitContainer.TabIndex = 0;
            // 
            // vendorTable
            // 
            vendorTable.AllowUserToAddRows = false;
            vendorTable.AllowUserToDeleteRows = false;
            vendorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vendorTable.Dock = DockStyle.Fill;
            vendorTable.Location = new Point(0, 0);
            vendorTable.Name = "vendorTable";
            vendorTable.ReadOnly = true;
            vendorTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vendorTable.Size = new Size(690, 417);
            vendorTable.TabIndex = 0;
            // 
            // labelVendorPage
            // 
            labelVendorPage.AutoSize = true;
            labelVendorPage.Location = new Point(2, 373);
            labelVendorPage.Name = "labelVendorPage";
            labelVendorPage.Size = new Size(36, 15);
            labelVendorPage.TabIndex = 4;
            labelVendorPage.Text = "Page:";
            // 
            // vendorTablePageNumber
            // 
            vendorTablePageNumber.Location = new Point(2, 391);
            vendorTablePageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            vendorTablePageNumber.Name = "vendorTablePageNumber";
            vendorTablePageNumber.Size = new Size(94, 23);
            vendorTablePageNumber.TabIndex = 3;
            vendorTablePageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            vendorTablePageNumber.ValueChanged += vendorTablePageNumber_ValueChanged;
            // 
            // buttonVendorDelete
            // 
            buttonVendorDelete.Location = new Point(3, 61);
            buttonVendorDelete.Name = "buttonVendorDelete";
            buttonVendorDelete.Size = new Size(90, 23);
            buttonVendorDelete.TabIndex = 2;
            buttonVendorDelete.Text = "Delete vendor";
            buttonVendorDelete.UseVisualStyleBackColor = true;
            buttonVendorDelete.Click += buttonVendorDelete_Click;
            // 
            // buttonVendorEdit
            // 
            buttonVendorEdit.Location = new Point(3, 32);
            buttonVendorEdit.Name = "buttonVendorEdit";
            buttonVendorEdit.Size = new Size(90, 23);
            buttonVendorEdit.TabIndex = 1;
            buttonVendorEdit.Text = "Edit vendor";
            buttonVendorEdit.UseVisualStyleBackColor = true;
            buttonVendorEdit.Click += buttonVendorEdit_Click;
            // 
            // buttonVendorAdd
            // 
            buttonVendorAdd.Location = new Point(3, 3);
            buttonVendorAdd.Name = "buttonVendorAdd";
            buttonVendorAdd.Size = new Size(90, 23);
            buttonVendorAdd.TabIndex = 0;
            buttonVendorAdd.Text = "Add vendor";
            buttonVendorAdd.UseVisualStyleBackColor = true;
            buttonVendorAdd.Click += buttonAddVendor_Click;
            // 
            // TypePage
            // 
            TypePage.Controls.Add(typeSplitContainer);
            TypePage.Location = new Point(4, 24);
            TypePage.Name = "TypePage";
            TypePage.Padding = new Padding(3);
            TypePage.Size = new Size(796, 423);
            TypePage.TabIndex = 3;
            TypePage.Text = "Bike Types";
            TypePage.UseVisualStyleBackColor = true;
            // 
            // typeSplitContainer
            // 
            typeSplitContainer.Dock = DockStyle.Fill;
            typeSplitContainer.Location = new Point(3, 3);
            typeSplitContainer.Name = "typeSplitContainer";
            // 
            // typeSplitContainer.Panel1
            // 
            typeSplitContainer.Panel1.Controls.Add(typeTable);
            // 
            // typeSplitContainer.Panel2
            // 
            typeSplitContainer.Panel2.Controls.Add(buttonOpenWearRatios);
            typeSplitContainer.Panel2.Controls.Add(labelTypePage);
            typeSplitContainer.Panel2.Controls.Add(typeTablePageNumber);
            typeSplitContainer.Panel2.Controls.Add(buttonTypeDelete);
            typeSplitContainer.Panel2.Controls.Add(buttonTypeEdit);
            typeSplitContainer.Panel2.Controls.Add(buttonTypeAdd);
            typeSplitContainer.Size = new Size(790, 417);
            typeSplitContainer.SplitterDistance = 703;
            typeSplitContainer.TabIndex = 0;
            // 
            // typeTable
            // 
            typeTable.AllowUserToAddRows = false;
            typeTable.AllowUserToDeleteRows = false;
            typeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            typeTable.Dock = DockStyle.Fill;
            typeTable.Location = new Point(0, 0);
            typeTable.Name = "typeTable";
            typeTable.ReadOnly = true;
            typeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            typeTable.Size = new Size(703, 417);
            typeTable.TabIndex = 0;
            // 
            // buttonOpenWearRatios
            // 
            buttonOpenWearRatios.Location = new Point(2, 90);
            buttonOpenWearRatios.Name = "buttonOpenWearRatios";
            buttonOpenWearRatios.Size = new Size(75, 23);
            buttonOpenWearRatios.TabIndex = 5;
            buttonOpenWearRatios.Text = "Wear ratios";
            buttonOpenWearRatios.UseVisualStyleBackColor = true;
            buttonOpenWearRatios.Click += buttonOpenWearRatios_Click;
            // 
            // labelTypePage
            // 
            labelTypePage.AutoSize = true;
            labelTypePage.Location = new Point(2, 376);
            labelTypePage.Name = "labelTypePage";
            labelTypePage.Size = new Size(36, 15);
            labelTypePage.TabIndex = 4;
            labelTypePage.Text = "Page:";
            // 
            // typeTablePageNumber
            // 
            typeTablePageNumber.Location = new Point(3, 394);
            typeTablePageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            typeTablePageNumber.Name = "typeTablePageNumber";
            typeTablePageNumber.Size = new Size(83, 23);
            typeTablePageNumber.TabIndex = 3;
            typeTablePageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            typeTablePageNumber.ValueChanged += typeTablePageNumber_ValueChanged;
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.Location = new Point(2, 61);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(75, 23);
            buttonTypeDelete.TabIndex = 2;
            buttonTypeDelete.Text = "Delete type";
            buttonTypeDelete.UseVisualStyleBackColor = true;
            buttonTypeDelete.Click += buttonTypeDelete_Click;
            // 
            // buttonTypeEdit
            // 
            buttonTypeEdit.Location = new Point(2, 32);
            buttonTypeEdit.Name = "buttonTypeEdit";
            buttonTypeEdit.Size = new Size(75, 23);
            buttonTypeEdit.TabIndex = 1;
            buttonTypeEdit.Text = "Edit type";
            buttonTypeEdit.UseVisualStyleBackColor = true;
            buttonTypeEdit.Click += buttonTypeEdit_Click;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.Location = new Point(3, 3);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(75, 23);
            buttonTypeAdd.TabIndex = 0;
            buttonTypeAdd.Text = "Add type";
            buttonTypeAdd.UseVisualStyleBackColor = true;
            buttonTypeAdd.Click += buttonTypeAdd_Click;
            // 
            // ActiveRentalsPage
            // 
            ActiveRentalsPage.Controls.Add(activeRentalSplitContainer);
            ActiveRentalsPage.Location = new Point(4, 24);
            ActiveRentalsPage.Name = "ActiveRentalsPage";
            ActiveRentalsPage.Padding = new Padding(3);
            ActiveRentalsPage.Size = new Size(796, 423);
            ActiveRentalsPage.TabIndex = 4;
            ActiveRentalsPage.Text = "Active rentals";
            ActiveRentalsPage.UseVisualStyleBackColor = true;
            // 
            // activeRentalSplitContainer
            // 
            activeRentalSplitContainer.Dock = DockStyle.Fill;
            activeRentalSplitContainer.Location = new Point(3, 3);
            activeRentalSplitContainer.Name = "activeRentalSplitContainer";
            // 
            // activeRentalSplitContainer.Panel1
            // 
            activeRentalSplitContainer.Panel1.Controls.Add(activeRentalTable);
            // 
            // activeRentalSplitContainer.Panel2
            // 
            activeRentalSplitContainer.Panel2.Controls.Add(activeRentalPageNumber);
            activeRentalSplitContainer.Panel2.Controls.Add(labelActiveRentalsPage);
            activeRentalSplitContainer.Panel2.Controls.Add(buttonActiveRentalsOpen);
            activeRentalSplitContainer.Size = new Size(790, 417);
            activeRentalSplitContainer.SplitterDistance = 703;
            activeRentalSplitContainer.TabIndex = 0;
            // 
            // activeRentalTable
            // 
            activeRentalTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            activeRentalTable.Dock = DockStyle.Fill;
            activeRentalTable.Location = new Point(0, 0);
            activeRentalTable.Name = "activeRentalTable";
            activeRentalTable.ReadOnly = true;
            activeRentalTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            activeRentalTable.Size = new Size(703, 417);
            activeRentalTable.TabIndex = 0;
            // 
            // activeRentalPageNumber
            // 
            activeRentalPageNumber.Location = new Point(2, 391);
            activeRentalPageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            activeRentalPageNumber.Name = "activeRentalPageNumber";
            activeRentalPageNumber.Size = new Size(84, 23);
            activeRentalPageNumber.TabIndex = 2;
            activeRentalPageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            activeRentalPageNumber.ValueChanged += activeRentalPageNumber_ValueChanged;
            // 
            // labelActiveRentalsPage
            // 
            labelActiveRentalsPage.AutoSize = true;
            labelActiveRentalsPage.Location = new Point(2, 373);
            labelActiveRentalsPage.Name = "labelActiveRentalsPage";
            labelActiveRentalsPage.Size = new Size(36, 15);
            labelActiveRentalsPage.TabIndex = 1;
            labelActiveRentalsPage.Text = "Page:";
            // 
            // buttonActiveRentalsOpen
            // 
            buttonActiveRentalsOpen.Location = new Point(3, 3);
            buttonActiveRentalsOpen.Name = "buttonActiveRentalsOpen";
            buttonActiveRentalsOpen.Size = new Size(75, 23);
            buttonActiveRentalsOpen.TabIndex = 0;
            buttonActiveRentalsOpen.Text = "Open";
            buttonActiveRentalsOpen.UseVisualStyleBackColor = true;
            buttonActiveRentalsOpen.Click += buttonActiveRentalsOpen_Click;
            // 
            // WornBikesPage
            // 
            WornBikesPage.Controls.Add(wearedBikesSplitContainer);
            WornBikesPage.Location = new Point(4, 24);
            WornBikesPage.Name = "WornBikesPage";
            WornBikesPage.Padding = new Padding(3);
            WornBikesPage.Size = new Size(796, 423);
            WornBikesPage.TabIndex = 5;
            WornBikesPage.Text = "Worn bikes";
            WornBikesPage.UseVisualStyleBackColor = true;
            // 
            // wearedBikesSplitContainer
            // 
            wearedBikesSplitContainer.Dock = DockStyle.Fill;
            wearedBikesSplitContainer.Location = new Point(3, 3);
            wearedBikesSplitContainer.Name = "wearedBikesSplitContainer";
            // 
            // wearedBikesSplitContainer.Panel1
            // 
            wearedBikesSplitContainer.Panel1.Controls.Add(wornBikesTable);
            // 
            // wearedBikesSplitContainer.Panel2
            // 
            wearedBikesSplitContainer.Panel2.Controls.Add(wornBikesTablePage);
            wearedBikesSplitContainer.Panel2.Controls.Add(labelWornBikesPage);
            wearedBikesSplitContainer.Panel2.Controls.Add(buttonMaintenanceBike);
            wearedBikesSplitContainer.Size = new Size(790, 417);
            wearedBikesSplitContainer.SplitterDistance = 698;
            wearedBikesSplitContainer.TabIndex = 0;
            // 
            // wornBikesTable
            // 
            wornBikesTable.AllowUserToAddRows = false;
            wornBikesTable.AllowUserToDeleteRows = false;
            wornBikesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            wornBikesTable.Dock = DockStyle.Fill;
            wornBikesTable.Location = new Point(0, 0);
            wornBikesTable.Name = "wornBikesTable";
            wornBikesTable.ReadOnly = true;
            wornBikesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            wornBikesTable.Size = new Size(698, 417);
            wornBikesTable.TabIndex = 0;
            // 
            // wornBikesTablePage
            // 
            wornBikesTablePage.Location = new Point(2, 391);
            wornBikesTablePage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            wornBikesTablePage.Name = "wornBikesTablePage";
            wornBikesTablePage.Size = new Size(86, 23);
            wornBikesTablePage.TabIndex = 2;
            wornBikesTablePage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            wornBikesTablePage.ValueChanged += wornBikesTablePage_ValueChanged;
            // 
            // labelWornBikesPage
            // 
            labelWornBikesPage.AutoSize = true;
            labelWornBikesPage.Location = new Point(1, 373);
            labelWornBikesPage.Name = "labelWornBikesPage";
            labelWornBikesPage.Size = new Size(36, 15);
            labelWornBikesPage.TabIndex = 1;
            labelWornBikesPage.Text = "Page:";
            // 
            // buttonMaintenanceBike
            // 
            buttonMaintenanceBike.Location = new Point(1, 3);
            buttonMaintenanceBike.Name = "buttonMaintenanceBike";
            buttonMaintenanceBike.Size = new Size(87, 23);
            buttonMaintenanceBike.TabIndex = 0;
            buttonMaintenanceBike.Text = "Maintenance";
            buttonMaintenanceBike.UseVisualStyleBackColor = true;
            buttonMaintenanceBike.Click += buttonMaintenanceBike_Click;
            // 
            // TerrainPage
            // 
            TerrainPage.Controls.Add(splitContainer1);
            TerrainPage.Location = new Point(4, 24);
            TerrainPage.Name = "TerrainPage";
            TerrainPage.Padding = new Padding(3);
            TerrainPage.Size = new Size(796, 423);
            TerrainPage.TabIndex = 6;
            TerrainPage.Text = "Terrains";
            TerrainPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(terrainTable);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(terrainTablePage);
            splitContainer1.Panel2.Controls.Add(labelTerrrainPage);
            splitContainer1.Panel2.Controls.Add(buttonTerrainDelete);
            splitContainer1.Panel2.Controls.Add(buttonTerrainEdit);
            splitContainer1.Panel2.Controls.Add(buttonTerrainAdd);
            splitContainer1.Size = new Size(790, 417);
            splitContainer1.SplitterDistance = 690;
            splitContainer1.TabIndex = 0;
            // 
            // terrainTable
            // 
            terrainTable.AllowUserToAddRows = false;
            terrainTable.AllowUserToDeleteRows = false;
            terrainTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            terrainTable.Dock = DockStyle.Fill;
            terrainTable.Location = new Point(0, 0);
            terrainTable.Name = "terrainTable";
            terrainTable.ReadOnly = true;
            terrainTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            terrainTable.Size = new Size(690, 417);
            terrainTable.TabIndex = 0;
            // 
            // terrainTablePage
            // 
            terrainTablePage.Location = new Point(2, 391);
            terrainTablePage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            terrainTablePage.Name = "terrainTablePage";
            terrainTablePage.Size = new Size(97, 23);
            terrainTablePage.TabIndex = 4;
            terrainTablePage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            terrainTablePage.ValueChanged += terrainTablePage_ValueChanged;
            // 
            // labelTerrrainPage
            // 
            labelTerrrainPage.AutoSize = true;
            labelTerrrainPage.Location = new Point(3, 373);
            labelTerrrainPage.Name = "labelTerrrainPage";
            labelTerrrainPage.Size = new Size(36, 15);
            labelTerrrainPage.TabIndex = 3;
            labelTerrrainPage.Text = "Page:";
            // 
            // buttonTerrainDelete
            // 
            buttonTerrainDelete.Location = new Point(2, 61);
            buttonTerrainDelete.Name = "buttonTerrainDelete";
            buttonTerrainDelete.Size = new Size(89, 23);
            buttonTerrainDelete.TabIndex = 2;
            buttonTerrainDelete.Text = "Delete terrain";
            buttonTerrainDelete.UseVisualStyleBackColor = true;
            buttonTerrainDelete.Click += buttonTerrainDelete_Click;
            // 
            // buttonTerrainEdit
            // 
            buttonTerrainEdit.Location = new Point(3, 32);
            buttonTerrainEdit.Name = "buttonTerrainEdit";
            buttonTerrainEdit.Size = new Size(88, 23);
            buttonTerrainEdit.TabIndex = 1;
            buttonTerrainEdit.Text = "Edit terrain";
            buttonTerrainEdit.UseVisualStyleBackColor = true;
            buttonTerrainEdit.Click += buttonTerrainEdit_Click;
            // 
            // buttonTerrainAdd
            // 
            buttonTerrainAdd.Location = new Point(3, 3);
            buttonTerrainAdd.Name = "buttonTerrainAdd";
            buttonTerrainAdd.Size = new Size(88, 23);
            buttonTerrainAdd.TabIndex = 0;
            buttonTerrainAdd.Text = "Add terrain";
            buttonTerrainAdd.UseVisualStyleBackColor = true;
            buttonTerrainAdd.Click += buttonTerrainAdd_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 451);
            Controls.Add(menuTab);
            Name = "MainView";
            Text = "Bike Management System";
            ((System.ComponentModel.ISupportInitialize)BikeTable).EndInit();
            menuTab.ResumeLayout(false);
            pageDashborad.ResumeLayout(false);
            BikePage.ResumeLayout(false);
            bikeSplitContainer.Panel1.ResumeLayout(false);
            bikeSplitContainer.Panel2.ResumeLayout(false);
            bikeSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bikeSplitContainer).EndInit();
            bikeSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bikeTablePageNumber).EndInit();
            VendorPage.ResumeLayout(false);
            vendorSplitContainer.Panel1.ResumeLayout(false);
            vendorSplitContainer.Panel2.ResumeLayout(false);
            vendorSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vendorSplitContainer).EndInit();
            vendorSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vendorTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendorTablePageNumber).EndInit();
            TypePage.ResumeLayout(false);
            typeSplitContainer.Panel1.ResumeLayout(false);
            typeSplitContainer.Panel2.ResumeLayout(false);
            typeSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)typeSplitContainer).EndInit();
            typeSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)typeTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeTablePageNumber).EndInit();
            ActiveRentalsPage.ResumeLayout(false);
            activeRentalSplitContainer.Panel1.ResumeLayout(false);
            activeRentalSplitContainer.Panel2.ResumeLayout(false);
            activeRentalSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)activeRentalSplitContainer).EndInit();
            activeRentalSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)activeRentalTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)activeRentalPageNumber).EndInit();
            WornBikesPage.ResumeLayout(false);
            wearedBikesSplitContainer.Panel1.ResumeLayout(false);
            wearedBikesSplitContainer.Panel2.ResumeLayout(false);
            wearedBikesSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wearedBikesSplitContainer).EndInit();
            wearedBikesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wornBikesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)wornBikesTablePage).EndInit();
            TerrainPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)terrainTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)terrainTablePage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl menuTab;
        private TabPage pageDashborad;
        private TabPage BikePage;
        private TabPage VendorPage;
        private TabPage TypePage;
        private Button buttonDeleteBike;
        private Button buttonEditBike;
        private Button buttonAddBike;
        private SplitContainer typeSplitContainer;
        private DataGridView typeTable;
        private Button buttonTypeAdd;
        private Button buttonTypeDelete;
        private Button buttonTypeEdit;
        private SplitContainer vendorSplitContainer;
        private DataGridView vendorTable;
        private Button buttonVendorAdd;
        private Button buttonVendorDelete;
        private Button buttonVendorEdit;
        private SplitContainer bikeSplitContainer;
        private DataGridView BikeTable;
        private Label labelBikeTablePage;
        private NumericUpDown bikeTablePageNumber;
        private NumericUpDown vendorTablePageNumber;
        private Label labelVendorPage;
        private Label labelTypePage;
        private NumericUpDown typeTablePageNumber;
        private Button buttonRent;
        private TabPage ActiveRentalsPage;
        private SplitContainer activeRentalSplitContainer;
        private DataGridView activeRentalTable;
        private Button buttonActiveRentalsOpen;
        private NumericUpDown activeRentalPageNumber;
        private Label labelActiveRentalsPage;
        private TabPage WornBikesPage;
        private SplitContainer wearedBikesSplitContainer;
        private DataGridView wornBikesTable;
        private NumericUpDown wornBikesTablePage;
        private Label labelWornBikesPage;
        private Button buttonMaintenanceBike;
        private TabPage TerrainPage;
        private SplitContainer splitContainer1;
        private DataGridView terrainTable;
        private Button buttonTerrainAdd;
        private Button buttonTerrainEdit;
        private NumericUpDown terrainTablePage;
        private Label labelTerrrainPage;
        private Button buttonTerrainDelete;
        private Button buttonOpenWearRatios;
        private Button buttonMaintenanceHistory;
    }
}
