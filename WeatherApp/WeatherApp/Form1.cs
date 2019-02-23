/*
	Created By:	Samuel Schuler and Jamie Wyatt
	Date:		2/8/2019
	Usage:		Open

	Summary:
	C# application that will display the current temperature, weather conditions, and 
	a graphical image of the conditions (if applicable) for a given location. The user can specify the 
	location by either postal code or city/state. The application communicates with https://openweathermap.org
	to obtain the weather data. The results of each request are persisted to a relational database SQL Server 
	Local DB and a list of previous results are available for the user to select from (Not yet implemented).

	Notes:
	When selecting a city to use the openweather maps has a difficut time dealing with this due to there
	being multiple citys with the same name. To avoid this problem it is best if zip code is chosen.

*/

using System;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.IO;
using System.Globalization;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
		SqlCommand cmd;
		SqlConnection con;
		SqlDataAdapter da;

        public WeatherForm()
        {
            InitializeComponent();
        }

		// My Private API
        private const string API_KEY = "9aefeb2e318701f2f141c8038f59b4fd";

		// Gets Weather Data (not emplemented yet).
        //private const string CurrentUrl = "http://api.openweathermap.org/data/2.5/weather?" + "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;

		// Gets The Weather Forcast
        private const string ForecastUrl = "http://api.openweathermap.org/data/2.5/forecast?" + "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;

        // Query codes q is location
        private string[] QueryCodes = { "q", "zip" };

		// Used for getting dropdown box choice.
		// Note: City is not recomended as it picks the first city on the list as there could be multiple.
		private void Form1_Load(object sender, EventArgs e)
        {
            DropDown.Items.Add("City");
            DropDown.Items.Add("ZIP");
            DropDown.SelectedIndex = 1;
        }
        
        // Gets the forcast of city/zip.
        private void btnForecast_Click(object sender, EventArgs e)
        {

            
            // Makes the url for the location or zip
            string url = ForecastUrl.Replace("@LOC@", txtLocation.Text);
            url = url.Replace("@QUERY@", QueryCodes[DropDown.SelectedIndex]);

            // Creates the web client.
            using (WebClient client = new WebClient())
            {
                // Get the response string from the URL and error checking.
                try
                {
                    this.Height = 100;
                    this.Cursor = Cursors.WaitCursor;
                    DisplayForecast(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    DisplayError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown Error\n" + ex.Message);
                }
            }
            this.Cursor = Cursors.Default;
        }

        // Display the forecast.
        private void DisplayForecast(string xml)
        {
            progressBar1.Value = 0;

            // Load the response into an XML document.
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);

			// Get the city, country, and geoid.
			XmlNode loc_node = xml_doc.SelectSingleNode("weatherdata/location");
			string city = loc_node.SelectSingleNode("name").InnerText;
			txtCity.Text = city;
			string country = loc_node.SelectSingleNode("country").InnerText;
			txtCountry.Text = country;
			XmlNode geo_node = loc_node.SelectSingleNode("location");
			string id = geo_node.Attributes["geobaseid"].Value;

			// Add the infromation to the database.
			con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emie1\Desktop\WeatherApp\WeatherApp\WeatherApp\WeatherData.mdf");
			con.Open();
			cmd = new SqlCommand("INSERT INTO WeatherData (City,ZipCode) Values (@City,@Zipcode)", con);
			cmd.Parameters.AddWithValue("@City", city);
			
			// If Zipcode was selected add to the database else don't.
			if (DropDown.SelectedIndex == 1)
			{
				cmd.Parameters.AddWithValue("@ZipCode", txtLocation.Text);
			}
			else
			{
				cmd.Parameters.AddWithValue("@ZipCode", "NULL");
			}
			cmd.ExecuteNonQuery();


            // Get the precipitation.
            try
            {
                XmlNode precip_node = xml_doc.SelectSingleNode("//precipitation");
                string precip = precip_node.Attributes["type"].Value;
                precip = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(precip);
                txtWeather.Text = precip;
            }
            catch(Exception ex)
            {
                txtWeather.Text = "Clear";
            }


            // Get Current Weather IconID and Temperature
            try
            {
                string urlweatherID = "http://openweathermap.org/img/w/@PICID@.png";
                XmlNode weather_node = xml_doc.SelectSingleNode("//symbol");
                string weatherID = weather_node.Attributes["var"].Value;
                urlweatherID = urlweatherID.Replace("@PICID@", weatherID);
                CurrentWeatherIcon.Load(urlweatherID);
                CurrentWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;


                XmlNode current_temp_node = xml_doc.SelectSingleNode("//temperature");
                string currentTemp = current_temp_node.Attributes["value"].Value;
                CurrentTempLabel.Text = currentTemp + "\'";

            }
            catch(Exception ex)
            {

            }

			lvwForecast.Items.Clear();
            
			char degrees = (char)176;
            ImageList list = new ImageList();
         
            // Loops through the doc and gets each time and temp.
            foreach (XmlNode time_node in xml_doc.SelectNodes("//time"))
            {
                // Get the time in UTC.
                DateTime time = DateTime.Parse(time_node.Attributes["from"].Value, null, DateTimeStyles.AssumeUniversal);

                // Get the temperature.
                XmlNode temp_node = time_node.SelectSingleNode("temperature");
                string temp = temp_node.Attributes["value"].Value;
                
                // Get the precipitation
                string precip2;
                string precipVal;
                try
                {
                    XmlNode precip_node2 = time_node.SelectSingleNode("precipitation");
                    precip2 = precip_node2.Attributes["type"].Value;
                    precipVal = precip_node2.Attributes["value"].Value;
                    precip2 = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(precip2);
                    precip2 += " " + precipVal + "%";
                }
                catch(Exception ex)
                {
                    precip2 = "Clear 0%";
                }


                //Load images
                string imageName = "";
            
                try
                {
                    string urlweatherID2 = "http://openweathermap.org/img/w/@PICID@.png";
                    XmlNode image_node = time_node.SelectSingleNode("symbol");
                    string weatherID2 = image_node.Attributes["var"].Value;
                    imageName = weatherID2;
                    urlweatherID2 = urlweatherID2.Replace("@PICID@", weatherID2);
                    WebClient _web = new WebClient();
                    byte[] _data = _web.DownloadData(urlweatherID2);
                    MemoryStream _ms = new MemoryStream(_data);

                    list.Images.Add(imageName, System.Drawing.Image.FromStream(_ms));
                    // bind listview
                    lvwForecast.SmallImageList = list;
                }catch(Exception ex) { }

                ListViewItem item = lvwForecast.Items.Add(time.DayOfWeek.ToString());
                item.SubItems.Add(time.ToShortTimeString());
                item.SubItems.Add(temp + degrees);
				item.SubItems.Add(precip2);
                item.ImageKey = imageName;

                if (progressBar1.Value + 3 < 100)
                    progressBar1.Value += 3;
                else progressBar1.Value = 100;
            }
            this.Height = 425;

        }

        // Error Handling
        private void DisplayError(WebException exception)
        {
            try
            {
                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode message_node = response_doc.SelectSingleNode("//message");
                MessageBox.Show(message_node.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Error\n" + ex.Message);
            }
        }

        private void lvwForecast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
