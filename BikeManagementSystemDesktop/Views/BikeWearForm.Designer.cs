namespace BikeManagementSystemDesktop.Views
{
    partial class BikeWearForm
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
            labelBikeTypeText = new Label();
            labelTerrainText = new Label();
            labelBikeType = new Label();
            labelTerrain = new Label();
            labelWearRatio = new Label();
            wearRatio = new NumericUpDown();
            buttonAction = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)wearRatio).BeginInit();
            SuspendLayout();
            // 
            // labelBikeTypeText
            // 
            labelBikeTypeText.AutoSize = true;
            labelBikeTypeText.Location = new Point(12, 9);
            labelBikeTypeText.Name = "labelBikeTypeText";
            labelBikeTypeText.Size = new Size(58, 15);
            labelBikeTypeText.TabIndex = 0;
            labelBikeTypeText.Text = "Bike type:";
            // 
            // labelTerrainText
            // 
            labelTerrainText.AutoSize = true;
            labelTerrainText.Location = new Point(12, 24);
            labelTerrainText.Name = "labelTerrainText";
            labelTerrainText.Size = new Size(45, 15);
            labelTerrainText.TabIndex = 1;
            labelTerrainText.Text = "Terrain:";
            // 
            // labelBikeType
            // 
            labelBikeType.AutoSize = true;
            labelBikeType.Location = new Point(76, 9);
            labelBikeType.Name = "labelBikeType";
            labelBikeType.Size = new Size(55, 15);
            labelBikeType.TabIndex = 2;
            labelBikeType.Text = "bike type";
            // 
            // labelTerrain
            // 
            labelTerrain.AutoSize = true;
            labelTerrain.Location = new Point(63, 24);
            labelTerrain.Name = "labelTerrain";
            labelTerrain.Size = new Size(41, 15);
            labelTerrain.TabIndex = 3;
            labelTerrain.Text = "terrain";
            // 
            // labelWearRatio
            // 
            labelWearRatio.AutoSize = true;
            labelWearRatio.Location = new Point(12, 49);
            labelWearRatio.Name = "labelWearRatio";
            labelWearRatio.Size = new Size(64, 15);
            labelWearRatio.TabIndex = 5;
            labelWearRatio.Text = "Wear ratio:";
            // 
            // wearRatio
            // 
            wearRatio.Location = new Point(76, 47);
            wearRatio.Name = "wearRatio";
            wearRatio.Size = new Size(175, 23);
            wearRatio.TabIndex = 6;
            // 
            // buttonAction
            // 
            buttonAction.Location = new Point(70, 89);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(75, 23);
            buttonAction.TabIndex = 7;
            buttonAction.Text = "Action";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(151, 89);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // BikeWearForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 124);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAction);
            Controls.Add(wearRatio);
            Controls.Add(labelWearRatio);
            Controls.Add(labelTerrain);
            Controls.Add(labelBikeType);
            Controls.Add(labelTerrainText);
            Controls.Add(labelBikeTypeText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BikeWearForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bike Wear Form";
            ((System.ComponentModel.ISupportInitialize)wearRatio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBikeTypeText;
        private Label labelTerrainText;
        private Label labelBikeType;
        private Label labelTerrain;
        private Label labelWearRatio;
        private NumericUpDown wearRatio;
        private Button buttonAction;
        private Button buttonCancel;
    }
}