namespace BikeManagementSystemDesktop.Views
{
    partial class ActiveRentalForm
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
            labelClientText = new Label();
            labelClient = new Label();
            labelPhoneNumberText = new Label();
            labelPhoneNumber = new Label();
            labelClientIdText = new Label();
            labelClientId = new Label();
            splitBody = new SplitContainer();
            labelRentedTo = new Label();
            labelRentedToText = new Label();
            labelRentedFrom = new Label();
            labelRentedFromText = new Label();
            splitBikeContainer = new SplitContainer();
            rentedBikes = new DataGridView();
            panelButtons = new Panel();
            buttonReturnBike = new Button();
            buttonClose = new Button();
            splitter2 = new Splitter();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)splitBody).BeginInit();
            splitBody.Panel1.SuspendLayout();
            splitBody.Panel2.SuspendLayout();
            splitBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitBikeContainer).BeginInit();
            splitBikeContainer.Panel1.SuspendLayout();
            splitBikeContainer.Panel2.SuspendLayout();
            splitBikeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rentedBikes).BeginInit();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // labelClientText
            // 
            labelClientText.AutoSize = true;
            labelClientText.Location = new Point(8, 9);
            labelClientText.Name = "labelClientText";
            labelClientText.Size = new Size(41, 15);
            labelClientText.TabIndex = 0;
            labelClientText.Text = "Client:";
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point(55, 9);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(117, 15);
            labelClient.TabIndex = 1;
            labelClient.Text = "FirstName LastName";
            // 
            // labelPhoneNumberText
            // 
            labelPhoneNumberText.AutoSize = true;
            labelPhoneNumberText.Location = new Point(8, 33);
            labelPhoneNumberText.Name = "labelPhoneNumberText";
            labelPhoneNumberText.Size = new Size(89, 15);
            labelPhoneNumberText.TabIndex = 2;
            labelPhoneNumberText.Text = "Phone number:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(103, 33);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(67, 15);
            labelPhoneNumber.TabIndex = 3;
            labelPhoneNumber.Text = "123 456 789";
            // 
            // labelClientIdText
            // 
            labelClientIdText.AutoSize = true;
            labelClientIdText.Location = new Point(8, 57);
            labelClientIdText.Name = "labelClientIdText";
            labelClientIdText.Size = new Size(95, 15);
            labelClientIdText.TabIndex = 4;
            labelClientIdText.Text = "Identity number:";
            // 
            // labelClientId
            // 
            labelClientId.AutoSize = true;
            labelClientId.Location = new Point(109, 57);
            labelClientId.Name = "labelClientId";
            labelClientId.Size = new Size(90, 15);
            labelClientId.TabIndex = 5;
            labelClientId.Text = "ABC1234567890";
            // 
            // splitBody
            // 
            splitBody.Dock = DockStyle.Fill;
            splitBody.Location = new Point(0, 0);
            splitBody.Name = "splitBody";
            splitBody.Orientation = Orientation.Horizontal;
            // 
            // splitBody.Panel1
            // 
            splitBody.Panel1.Controls.Add(labelRentedTo);
            splitBody.Panel1.Controls.Add(labelRentedToText);
            splitBody.Panel1.Controls.Add(labelRentedFrom);
            splitBody.Panel1.Controls.Add(labelRentedFromText);
            splitBody.Panel1.Controls.Add(labelClient);
            splitBody.Panel1.Controls.Add(labelClientId);
            splitBody.Panel1.Controls.Add(labelClientText);
            splitBody.Panel1.Controls.Add(labelClientIdText);
            splitBody.Panel1.Controls.Add(labelPhoneNumberText);
            splitBody.Panel1.Controls.Add(labelPhoneNumber);
            // 
            // splitBody.Panel2
            // 
            splitBody.Panel2.Controls.Add(splitBikeContainer);
            splitBody.Size = new Size(800, 450);
            splitBody.SplitterDistance = 88;
            splitBody.TabIndex = 6;
            // 
            // labelRentedTo
            // 
            labelRentedTo.AutoSize = true;
            labelRentedTo.Location = new Point(393, 33);
            labelRentedTo.Name = "labelRentedTo";
            labelRentedTo.Size = new Size(106, 15);
            labelRentedTo.TabIndex = 9;
            labelRentedTo.Text = "01.01.2025 10:00:00";
            // 
            // labelRentedToText
            // 
            labelRentedToText.AutoSize = true;
            labelRentedToText.Location = new Point(326, 33);
            labelRentedToText.Name = "labelRentedToText";
            labelRentedToText.Size = new Size(61, 15);
            labelRentedToText.TabIndex = 8;
            labelRentedToText.Text = "Rented to:";
            // 
            // labelRentedFrom
            // 
            labelRentedFrom.AutoSize = true;
            labelRentedFrom.Location = new Point(410, 9);
            labelRentedFrom.Name = "labelRentedFrom";
            labelRentedFrom.Size = new Size(106, 15);
            labelRentedFrom.TabIndex = 7;
            labelRentedFrom.Text = "01.01.2025 10:00:00";
            // 
            // labelRentedFromText
            // 
            labelRentedFromText.AutoSize = true;
            labelRentedFromText.Location = new Point(326, 9);
            labelRentedFromText.Name = "labelRentedFromText";
            labelRentedFromText.Size = new Size(76, 15);
            labelRentedFromText.TabIndex = 6;
            labelRentedFromText.Text = "Rented from:";
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
            splitBikeContainer.Panel1.Controls.Add(rentedBikes);
            // 
            // splitBikeContainer.Panel2
            // 
            splitBikeContainer.Panel2.Controls.Add(panelButtons);
            splitBikeContainer.Panel2.Controls.Add(splitter2);
            splitBikeContainer.Panel2.Controls.Add(splitter1);
            splitBikeContainer.Size = new Size(800, 358);
            splitBikeContainer.SplitterDistance = 320;
            splitBikeContainer.TabIndex = 0;
            // 
            // rentedBikes
            // 
            rentedBikes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentedBikes.Dock = DockStyle.Fill;
            rentedBikes.Location = new Point(0, 0);
            rentedBikes.MultiSelect = false;
            rentedBikes.Name = "rentedBikes";
            rentedBikes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rentedBikes.Size = new Size(800, 320);
            rentedBikes.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonReturnBike);
            panelButtons.Controls.Add(buttonClose);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(318, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(164, 34);
            panelButtons.TabIndex = 5;
            // 
            // buttonReturnBike
            // 
            buttonReturnBike.Location = new Point(5, 3);
            buttonReturnBike.Name = "buttonReturnBike";
            buttonReturnBike.Size = new Size(75, 23);
            buttonReturnBike.TabIndex = 0;
            buttonReturnBike.Text = "Retun Bike";
            buttonReturnBike.UseVisualStyleBackColor = true;
            buttonReturnBike.Click += buttonReturnBike_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(86, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Right;
            splitter2.Location = new Point(482, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(318, 34);
            splitter2.TabIndex = 4;
            splitter2.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(318, 34);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // ActiveRentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitBody);
            Name = "ActiveRentalForm";
            Text = "Active Rental Form";
            splitBody.Panel1.ResumeLayout(false);
            splitBody.Panel1.PerformLayout();
            splitBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitBody).EndInit();
            splitBody.ResumeLayout(false);
            splitBikeContainer.Panel1.ResumeLayout(false);
            splitBikeContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitBikeContainer).EndInit();
            splitBikeContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rentedBikes).EndInit();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelClientText;
        private Label labelClient;
        private Label labelPhoneNumberText;
        private Label labelPhoneNumber;
        private Label labelClientIdText;
        private Label labelClientId;
        private SplitContainer splitBody;
        private SplitContainer splitBikeContainer;
        private DataGridView rentedBikes;
        private Button buttonClose;
        private Button buttonReturnBike;
        private Label labelRentedFromText;
        private Label labelRentedTo;
        private Label labelRentedToText;
        private Label labelRentedFrom;
        private Splitter splitter2;
        private Splitter splitter1;
        private Panel panelButtons;
    }
}