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
            BikeTablePageNumber = new NumericUpDown();
            deleteBike = new Button();
            addBike = new Button();
            editBike = new Button();
            VendorPage = new TabPage();
            vendorSplitContainer = new SplitContainer();
            dataGridView2 = new DataGridView();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            TypePage = new TabPage();
            typeSplitContainer = new SplitContainer();
            dataGridView1 = new DataGridView();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)BikeTable).BeginInit();
            tabMenu.SuspendLayout();
            BikePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bikeSplitContainer).BeginInit();
            bikeSplitContainer.Panel1.SuspendLayout();
            bikeSplitContainer.Panel2.SuspendLayout();
            bikeSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BikeTablePageNumber).BeginInit();
            VendorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vendorSplitContainer).BeginInit();
            vendorSplitContainer.Panel1.SuspendLayout();
            vendorSplitContainer.Panel2.SuspendLayout();
            vendorSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            TypePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)typeSplitContainer).BeginInit();
            typeSplitContainer.Panel1.SuspendLayout();
            typeSplitContainer.Panel2.SuspendLayout();
            typeSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            bikeSplitContainer.Panel2.Controls.Add(BikeTablePageNumber);
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
            // BikeTablePageNumber
            // 
            BikeTablePageNumber.Location = new Point(2, 389);
            BikeTablePageNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            BikeTablePageNumber.Name = "BikeTablePageNumber";
            BikeTablePageNumber.Size = new Size(81, 23);
            BikeTablePageNumber.TabIndex = 9;
            BikeTablePageNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            BikeTablePageNumber.ValueChanged += BikeTablePageNumber_ValueChanged;
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
            vendorSplitContainer.Panel1.Controls.Add(dataGridView2);
            // 
            // vendorSplitContainer.Panel2
            // 
            vendorSplitContainer.Panel2.Controls.Add(button11);
            vendorSplitContainer.Panel2.Controls.Add(button10);
            vendorSplitContainer.Panel2.Controls.Add(button9);
            vendorSplitContainer.Size = new Size(790, 417);
            vendorSplitContainer.SplitterDistance = 690;
            vendorSplitContainer.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(690, 417);
            dataGridView2.TabIndex = 0;
            // 
            // button11
            // 
            button11.Location = new Point(3, 61);
            button11.Name = "button11";
            button11.Size = new Size(90, 23);
            button11.TabIndex = 2;
            button11.Text = "Delete vendor";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(3, 32);
            button10.Name = "button10";
            button10.Size = new Size(90, 23);
            button10.TabIndex = 1;
            button10.Text = "Edit vendor";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(3, 3);
            button9.Name = "button9";
            button9.Size = new Size(90, 23);
            button9.TabIndex = 0;
            button9.Text = "Add vendor";
            button9.UseVisualStyleBackColor = true;
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
            typeSplitContainer.Panel1.Controls.Add(dataGridView1);
            // 
            // typeSplitContainer.Panel2
            // 
            typeSplitContainer.Panel2.Controls.Add(button8);
            typeSplitContainer.Panel2.Controls.Add(button7);
            typeSplitContainer.Panel2.Controls.Add(button6);
            typeSplitContainer.Size = new Size(790, 417);
            typeSplitContainer.SplitterDistance = 703;
            typeSplitContainer.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(703, 417);
            dataGridView1.TabIndex = 0;
            // 
            // button8
            // 
            button8.Location = new Point(2, 61);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 2;
            button8.Text = "Delete type";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(2, 32);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 1;
            button7.Text = "Edit type";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 3);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 0;
            button6.Text = "Add type";
            button6.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)BikeTablePageNumber).EndInit();
            VendorPage.ResumeLayout(false);
            vendorSplitContainer.Panel1.ResumeLayout(false);
            vendorSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vendorSplitContainer).EndInit();
            vendorSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            TypePage.ResumeLayout(false);
            typeSplitContainer.Panel1.ResumeLayout(false);
            typeSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)typeSplitContainer).EndInit();
            typeSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button button6;
        private Button button8;
        private Button button7;
        private SplitContainer vendorSplitContainer;
        private DataGridView dataGridView2;
        private Button button9;
        private Button button11;
        private Button button10;
        private SplitContainer bikeSplitContainer;
        private DataGridView BikeTable;
        private Label labelBikeTablePage;
        private NumericUpDown BikeTablePageNumber;
    }
}
