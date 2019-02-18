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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.lvwForecast = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.Current_Conditions = new System.Windows.Forms.Label();
            this.CurrentWeatherIcon = new System.Windows.Forms.PictureBox();
            this.ForecastLabel = new System.Windows.Forms.Label();
            this.CurrentTempLabel = new System.Windows.Forms.Label();
            this.txtWeather = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLocation.Location = new System.Drawing.Point(91, 9);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(258, 20);
            this.txtLocation.TabIndex = 15;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitBtn.BackColor = System.Drawing.Color.White;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.Black;
            this.SubmitBtn.Location = new System.Drawing.Point(355, 8);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 16;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // lvwForecast
            // 
            this.lvwForecast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwForecast.BackColor = System.Drawing.Color.CadetBlue;
            this.lvwForecast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvwForecast.BackgroundImage")));
            this.lvwForecast.BackgroundImageTiled = true;
            this.lvwForecast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwForecast.ForeColor = System.Drawing.Color.Black;
            this.lvwForecast.Location = new System.Drawing.Point(0, 154);
            this.lvwForecast.Name = "lvwForecast";
            this.lvwForecast.Size = new System.Drawing.Size(442, 231);
            this.lvwForecast.TabIndex = 19;
            this.lvwForecast.UseCompatibleStateImageBehavior = false;
            this.lvwForecast.View = System.Windows.Forms.View.Details;
            this.lvwForecast.SelectedIndexChanged += new System.EventHandler(this.lvwForecast_SelectedIndexChanged);
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precipitation";
            this.columnHeader4.Width = 82;
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
            this.txtCity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCity.Location = new System.Drawing.Point(42, 32);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(101, 20);
            this.txtCity.TabIndex = 31;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCountry.Location = new System.Drawing.Point(205, 32);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 32;
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.BackColor = System.Drawing.Color.Transparent;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.ForeColor = System.Drawing.Color.White;
            this.City.Location = new System.Drawing.Point(12, 35);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(28, 13);
            this.City.TabIndex = 33;
            this.City.Text = "City";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.BackColor = System.Drawing.Color.Transparent;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.ForeColor = System.Drawing.Color.White;
            this.Country.Location = new System.Drawing.Point(149, 35);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(50, 13);
            this.Country.TabIndex = 34;
            this.Country.Text = "Country";
            // 
            // Current_Conditions
            // 
            this.Current_Conditions.AutoSize = true;
            this.Current_Conditions.BackColor = System.Drawing.Color.Transparent;
            this.Current_Conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Conditions.ForeColor = System.Drawing.Color.White;
            this.Current_Conditions.Location = new System.Drawing.Point(202, 65);
            this.Current_Conditions.Name = "Current_Conditions";
            this.Current_Conditions.Size = new System.Drawing.Size(111, 13);
            this.Current_Conditions.TabIndex = 36;
            this.Current_Conditions.Text = "Current Conditions";
            // 
            // CurrentWeatherIcon
            // 
            this.CurrentWeatherIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentWeatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.CurrentWeatherIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentWeatherIcon.Location = new System.Drawing.Point(9, 57);
            this.CurrentWeatherIcon.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentWeatherIcon.Name = "CurrentWeatherIcon";
            this.CurrentWeatherIcon.Size = new System.Drawing.Size(69, 62);
            this.CurrentWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentWeatherIcon.TabIndex = 37;
            this.CurrentWeatherIcon.TabStop = false;
            // 
            // ForecastLabel
            // 
            this.ForecastLabel.AutoSize = true;
            this.ForecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForecastLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.ForecastLabel.Location = new System.Drawing.Point(148, 131);
            this.ForecastLabel.Name = "ForecastLabel";
            this.ForecastLabel.Size = new System.Drawing.Size(132, 20);
            this.ForecastLabel.TabIndex = 38;
            this.ForecastLabel.Text = "5-Day Forecast";
            this.ForecastLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurrentTempLabel
            // 
            this.CurrentTempLabel.AutoSize = true;
            this.CurrentTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTempLabel.ForeColor = System.Drawing.Color.Black;
            this.CurrentTempLabel.Location = new System.Drawing.Point(68, 82);
            this.CurrentTempLabel.Name = "CurrentTempLabel";
            this.CurrentTempLabel.Size = new System.Drawing.Size(39, 37);
            this.CurrentTempLabel.TabIndex = 39;
            this.CurrentTempLabel.Text = "--";
            // 
            // txtWeather
            // 
            this.txtWeather.AutoSize = true;
            this.txtWeather.BackColor = System.Drawing.Color.Transparent;
            this.txtWeather.ForeColor = System.Drawing.Color.Black;
            this.txtWeather.Location = new System.Drawing.Point(202, 83);
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.Size = new System.Drawing.Size(10, 13);
            this.txtWeather.TabIndex = 40;
            this.txtWeather.Text = "-";
            // 
            // WeatherForm
            // 
            this.AcceptButton = this.SubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 386);
            this.Controls.Add(this.txtWeather);
            this.Controls.Add(this.CurrentTempLabel);
            this.Controls.Add(this.ForecastLabel);
            this.Controls.Add(this.CurrentWeatherIcon);
            this.Controls.Add(this.Current_Conditions);
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
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWeatherIcon)).EndInit();
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
		private System.Windows.Forms.Label Current_Conditions;
		private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox CurrentWeatherIcon;
        private System.Windows.Forms.Label ForecastLabel;
        private System.Windows.Forms.Label CurrentTempLabel;
        private System.Windows.Forms.Label txtWeather;
    }
}

