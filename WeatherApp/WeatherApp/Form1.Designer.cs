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
            this.Current_Conditions = new System.Windows.Forms.Label();
            this.CurrentWeatherIcon = new System.Windows.Forms.PictureBox();
            this.ForecastLabel = new System.Windows.Forms.Label();
            this.CurrentTempLabel = new System.Windows.Forms.Label();
            this.txtWeather = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.txtLocation.Size = new System.Drawing.Size(272, 20);
            this.txtLocation.TabIndex = 15;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitBtn.BackColor = System.Drawing.Color.White;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.Black;
            this.SubmitBtn.Location = new System.Drawing.Point(362, 8);
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
            this.lvwForecast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwForecast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwForecast.ForeColor = System.Drawing.Color.Black;
            this.lvwForecast.Location = new System.Drawing.Point(0, 154);
            this.lvwForecast.Name = "lvwForecast";
            this.lvwForecast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvwForecast.Size = new System.Drawing.Size(456, 0);
            this.lvwForecast.TabIndex = 19;
            this.lvwForecast.UseCompatibleStateImageBehavior = false;
            this.lvwForecast.View = System.Windows.Forms.View.Details;
            this.lvwForecast.SelectedIndexChanged += new System.EventHandler(this.lvwForecast_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Day";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Temperature";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precipitation";
            this.columnHeader4.Width = 128;
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
            // Current_Conditions
            // 
            this.Current_Conditions.AutoSize = true;
            this.Current_Conditions.BackColor = System.Drawing.Color.Transparent;
            this.Current_Conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Conditions.ForeColor = System.Drawing.Color.Black;
            this.Current_Conditions.Location = new System.Drawing.Point(202, 65);
            this.Current_Conditions.Name = "Current_Conditions";
            this.Current_Conditions.Size = new System.Drawing.Size(111, 13);
            this.Current_Conditions.TabIndex = 36;
            this.Current_Conditions.Text = "Current Conditions";
            // 
            // CurrentWeatherIcon
            // 
            this.CurrentWeatherIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentWeatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.CurrentWeatherIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentWeatherIcon.Location = new System.Drawing.Point(9, -81);
            this.CurrentWeatherIcon.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentWeatherIcon.Name = "CurrentWeatherIcon";
            this.CurrentWeatherIcon.Size = new System.Drawing.Size(83, 62);
            this.CurrentWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentWeatherIcon.TabIndex = 37;
            this.CurrentWeatherIcon.TabStop = false;
            this.CurrentWeatherIcon.WaitOnLoad = true;
            // 
            // ForecastLabel
            // 
            this.ForecastLabel.AutoSize = true;
            this.ForecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForecastLabel.ForeColor = System.Drawing.Color.Black;
            this.ForecastLabel.Location = new System.Drawing.Point(155, 131);
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
            this.CurrentTempLabel.Location = new System.Drawing.Point(68, 94);
            this.CurrentTempLabel.Name = "CurrentTempLabel";
            this.CurrentTempLabel.Size = new System.Drawing.Size(39, 37);
            this.CurrentTempLabel.TabIndex = 39;
            this.CurrentTempLabel.Text = "--";
            // 
            // txtWeather
            // 
            this.txtWeather.AutoSize = true;
            this.txtWeather.BackColor = System.Drawing.Color.Transparent;
            this.txtWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeather.ForeColor = System.Drawing.Color.Black;
            this.txtWeather.Location = new System.Drawing.Point(202, 83);
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.Size = new System.Drawing.Size(11, 13);
            this.txtWeather.TabIndex = 40;
            this.txtWeather.Text = "-";
            // 
            // txtCountry
            // 
            this.txtCountry.AutoSize = true;
            this.txtCountry.BackColor = System.Drawing.Color.Transparent;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(8, 76);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(0, 20);
            this.txtCountry.TabIndex = 41;
            // 
            // txtCity
            // 
            this.txtCity.AutoSize = true;
            this.txtCity.BackColor = System.Drawing.Color.Transparent;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(8, 56);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(0, 20);
            this.txtCity.TabIndex = 42;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(423, 10);
            this.progressBar1.TabIndex = 43;
            // 
            // WeatherForm
            // 
            this.AcceptButton = this.SubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 61);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtWeather);
            this.Controls.Add(this.CurrentTempLabel);
            this.Controls.Add(this.ForecastLabel);
            this.Controls.Add(this.CurrentWeatherIcon);
            this.Controls.Add(this.Current_Conditions);
            this.Controls.Add(this.DropDown);
            this.Controls.Add(this.lvwForecast);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.SubmitBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
		private System.Windows.Forms.Label Current_Conditions;
		private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox CurrentWeatherIcon;
        private System.Windows.Forms.Label ForecastLabel;
        private System.Windows.Forms.Label CurrentTempLabel;
        private System.Windows.Forms.Label txtWeather;
        private System.Windows.Forms.Label txtCountry;
        private System.Windows.Forms.Label txtCity;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

