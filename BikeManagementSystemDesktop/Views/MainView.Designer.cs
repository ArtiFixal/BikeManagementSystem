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
            tabMenu = new TabControl();
            DashboardPage = new TabPage();
            BikePage = new TabPage();
            bikeSplitContainer = new SplitContainer();
            labelBikeTablePage = new Label();
            bikeTablePageNumber = new NumericUpDown();
            deleteBike = new Button();
            addBike = new Button();
            editBike = new Button();
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
            labelTypePage = new Label();
            typeTablePageNumber = new NumericUpDown();
            buttonTypeDelete = new Button();
            buttonTypeEdit = new Button();
            buttonTypeAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)BikeTable).BeginInit();
            tabMenu.SuspendLayout();
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
            BikeTable.Size = new Size(700, 417);
            BikeTable.TabIndex = 4;
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(DashboardPage);
            tabMenu.Controls.Add(BikePage);
            tabMenu.Controls.Add(VendorPage);
            tabMenu.Controls.Add(TypePage);
            tabMenu.Dock = DockStyle.Fill;
            tabMenu.Location = new Point(0, 0);
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(804, 451);
            tabMenu.TabIndex = 0;
            // 
            // DashboardPage
            // 
            DashboardPage.Location = new Point(4, 24);
            DashboardPage.Name = "DashboardPage";
            DashboardPage.Padding = new Padding(3);
            DashboardPage.Size = new Size(796, 423);
            DashboardPage.TabIndex = 0;
            DashboardPage.Text = "Dashboard";
            DashboardPage.UseVisualStyleBackColor = true;
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
            bikeSplitContainer.Panel2.Controls.Add(labelBikeTablePage);
            bikeSplitContainer.Panel2.Controls.Add(bikeTablePageNumber);
            bikeSplitContainer.Panel2.Controls.Add(deleteBike);
            bikeSplitContainer.Panel2.Controls.Add(addBike);
            bikeSplitContainer.Panel2.Controls.Add(editBike);
            bikeSplitContainer.Size = new Size(790, 417);
            bikeSplitContainer.SplitterDistance = 700;
            bikeSplitContainer.TabIndex = 7;
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
            // deleteBike
            // 
            deleteBike.Location = new Point(3, 61);
            deleteBike.Name = "deleteBike";
            deleteBike.Size = new Size(75, 23);
            deleteBike.TabIndex = 8;
            deleteBike.Text = "Delete Bike";
            deleteBike.UseVisualStyleBackColor = true;
            // 
            // addBike
            // 
            addBike.Location = new Point(3, 3);
            addBike.Name = "addBike";
            addBike.Size = new Size(75, 23);
            addBike.TabIndex = 6;
            addBike.Text = "Add Bike";
            addBike.UseVisualStyleBackColor = true;
            // 
            // editBike
            // 
            editBike.Location = new Point(3, 32);
            editBike.Name = "editBike";
            editBike.Size = new Size(75, 23);
            editBike.TabIndex = 7;
            editBike.Text = "Edit Bike";
            editBike.UseVisualStyleBackColor = true;
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
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 451);
            Controls.Add(tabMenu);
            Name = "MainView";
            Text = "Bike Management System";
            ((System.ComponentModel.ISupportInitialize)BikeTable).EndInit();
            tabMenu.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMenu;
        private TabPage DashboardPage;
        private TabPage BikePage;
        private TabPage VendorPage;
        private TabPage TypePage;
        private Button deleteBike;
        private Button editBike;
        private Button addBike;
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
    }
}
