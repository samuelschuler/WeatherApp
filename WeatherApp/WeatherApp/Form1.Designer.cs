namespace WeatherApp
{
    partial class WeatherForm
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
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.SubmitBtn = new System.Windows.Forms.Button();
			this.lvwForecast = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DropDown = new System.Windows.Forms.ComboBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.City = new System.Windows.Forms.Label();
			this.Country = new System.Windows.Forms.Label();
			this.txtWeather = new System.Windows.Forms.TextBox();
			this.Current_Conditions = new System.Windows.Forms.Label();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// txtLocation
			// 
			this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLocation.Location = new System.Drawing.Point(91, 9);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.Size = new System.Drawing.Size(347, 20);
			this.txtLocation.TabIndex = 15;
			// 
			// SubmitBtn
			// 
			this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SubmitBtn.Location = new System.Drawing.Point(12, 35);
			this.SubmitBtn.Name = "SubmitBtn";
			this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
			this.SubmitBtn.TabIndex = 16;
			this.SubmitBtn.Text = "Submit";
			this.SubmitBtn.UseVisualStyleBackColor = true;
			this.SubmitBtn.Click += new System.EventHandler(this.btnForecast_Click);
			// 
			// lvwForecast
			// 
			this.lvwForecast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvwForecast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lvwForecast.Location = new System.Drawing.Point(12, 108);
			this.lvwForecast.Name = "lvwForecast";
			this.lvwForecast.Size = new System.Drawing.Size(426, 266);
			this.lvwForecast.TabIndex = 19;
			this.lvwForecast.UseCompatibleStateImageBehavior = false;
			this.lvwForecast.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Day";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Time";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Temperature";
			this.columnHeader3.Width = 100;
			// 
			// DropDown
			// 
			this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DropDown.FormattingEnabled = true;
			this.DropDown.Location = new System.Drawing.Point(12, 8);
			this.DropDown.Name = "DropDown";
			this.DropDown.Size = new System.Drawing.Size(73, 21);
			this.DropDown.TabIndex = 30;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(12, 82);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(101, 20);
			this.txtCity.TabIndex = 31;
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(122, 82);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(100, 20);
			this.txtCountry.TabIndex = 32;
			// 
			// City
			// 
			this.City.AutoSize = true;
			this.City.BackColor = System.Drawing.SystemColors.HighlightText;
			this.City.Location = new System.Drawing.Point(9, 63);
			this.City.Name = "City";
			this.City.Size = new System.Drawing.Size(24, 13);
			this.City.TabIndex = 33;
			this.City.Text = "City";
			// 
			// Country
			// 
			this.Country.AutoSize = true;
			this.Country.BackColor = System.Drawing.SystemColors.HighlightText;
			this.Country.Location = new System.Drawing.Point(119, 63);
			this.Country.Name = "Country";
			this.Country.Size = new System.Drawing.Size(43, 13);
			this.Country.TabIndex = 34;
			this.Country.Text = "Country";
			// 
			// txtWeather
			// 
			this.txtWeather.Location = new System.Drawing.Point(228, 82);
			this.txtWeather.Name = "txtWeather";
			this.txtWeather.Size = new System.Drawing.Size(100, 20);
			this.txtWeather.TabIndex = 35;
			// 
			// Current_Conditions
			// 
			this.Current_Conditions.AutoSize = true;
			this.Current_Conditions.Location = new System.Drawing.Point(225, 66);
			this.Current_Conditions.Name = "Current_Conditions";
			this.Current_Conditions.Size = new System.Drawing.Size(93, 13);
			this.Current_Conditions.TabIndex = 36;
			this.Current_Conditions.Text = "Current Conditions";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Presipitation";
			this.columnHeader4.Width = 82;
			// 
			// WeatherForm
			// 
			this.AcceptButton = this.SubmitBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ClientSize = new System.Drawing.Size(450, 386);
			this.Controls.Add(this.Current_Conditions);
			this.Controls.Add(this.txtWeather);
			this.Controls.Add(this.Country);
			this.Controls.Add(this.City);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.DropDown);
			this.Controls.Add(this.lvwForecast);
			this.Controls.Add(this.txtLocation);
			this.Controls.Add(this.SubmitBtn);
			this.Name = "WeatherForm";
			this.Text = "Weather";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ListView lvwForecast;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox DropDown;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.Label City;
		private System.Windows.Forms.Label Country;
		private System.Windows.Forms.TextBox txtWeather;
		private System.Windows.Forms.Label Current_Conditions;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}

