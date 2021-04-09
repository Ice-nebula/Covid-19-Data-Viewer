
namespace CovidViewer.UI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.SelectCountryLabel = new System.Windows.Forms.Label();
            this.CountryList = new System.Windows.Forms.ListBox();
            this.GetData = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CovidDataLabel = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.DataGridView();
            this.BinData = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinData)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectCountryLabel
            // 
            this.SelectCountryLabel.AccessibleName = "Select Country";
            this.SelectCountryLabel.AutoSize = true;
            this.SelectCountryLabel.Location = new System.Drawing.Point(0, 0);
            this.SelectCountryLabel.Name = "SelectCountryLabel";
            this.SelectCountryLabel.Size = new System.Drawing.Size(76, 13);
            this.SelectCountryLabel.TabIndex = 0;
            this.SelectCountryLabel.Text = "Select Country";
            // 
            // CountryList
            // 
            this.CountryList.AccessibleName = "Select Country";
            this.CountryList.BackColor = System.Drawing.SystemColors.Window;
            this.CountryList.FormattingEnabled = true;
            this.CountryList.Location = new System.Drawing.Point(8, 8);
            this.CountryList.Name = "CountryList";
            this.CountryList.Size = new System.Drawing.Size(120, 95);
            this.CountryList.TabIndex = 1;
            // 
            // GetData
            // 
            this.GetData.AccessibleName = "GetData";
            this.GetData.Location = new System.Drawing.Point(16, 16);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(75, 23);
            this.GetData.TabIndex = 2;
            this.GetData.Text = "Get Data";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AccessibleName = "Clear";
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.Location = new System.Drawing.Point(24, 24);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CovidDataLabel
            // 
            this.CovidDataLabel.AccessibleName = "Covid Data";
            this.CovidDataLabel.AutoSize = true;
            this.CovidDataLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CovidDataLabel.Location = new System.Drawing.Point(32, 32);
            this.CovidDataLabel.Name = "CovidDataLabel";
            this.CovidDataLabel.Size = new System.Drawing.Size(60, 13);
            this.CovidDataLabel.TabIndex = 4;
            this.CovidDataLabel.Text = "Covid Data";
            // 
            // DataBox
            // 
            this.DataBox.AccessibleName = "Covid Data";
            this.DataBox.AllowUserToAddRows = false;
            this.DataBox.AllowUserToDeleteRows = false;
            this.DataBox.AllowUserToResizeColumns = false;
            this.DataBox.AllowUserToResizeRows = false;
            this.DataBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBox.Location = new System.Drawing.Point(40, 40);
            this.DataBox.Name = "DataBox";
            this.DataBox.ReadOnly = true;
            this.DataBox.Size = new System.Drawing.Size(240, 150);
            this.DataBox.TabIndex = 5;
            this.DataBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBox_CellContentClick);
            // 
            // BinData
            // 
            this.BinData.CurrentChanged += new System.EventHandler(this.BinData_CurrentChanged);
            // 
            // Main
            // 
            this.AccessibleName = "Covid Viewer";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.CovidDataLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.CountryList);
            this.Controls.Add(this.SelectCountryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "Covid Viewer";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectCountryLabel;
        private System.Windows.Forms.ListBox CountryList;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label CovidDataLabel;
        private System.Windows.Forms.DataGridView DataBox;
        private System.Windows.Forms.BindingSource BinData;
    }
}