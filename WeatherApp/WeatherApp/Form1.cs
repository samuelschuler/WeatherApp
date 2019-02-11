/*
	Created By:	Samuel Schuler
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
        }

        // Display the forecast.
        private void DisplayForecast(string xml)
        {
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
			con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\glori\source\repos\WeatherApp\WeatherApp\WeatherData.mdf;Integrated Security=True");
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
				cmd.Parameters.AddWithValue("@ZipCode", "null");
			}
			cmd.ExecuteNonQuery();


			// Get the precipitation.
			XmlNode precip_node = xml_doc.SelectSingleNode("//precipitation");
			string precip = precip_node.Attributes["type"].Value;
			txtWeather.Text = precip;
			lvwForecast.Items.Clear();
			char degrees = (char)176;
			
			// Loops through the doc and gets each time and temp.
            foreach (XmlNode time_node in xml_doc.SelectNodes("//time"))
            {
                // Get the time in UTC.
                DateTime time = DateTime.Parse(time_node.Attributes["from"].Value, null, DateTimeStyles.AssumeUniversal);

                // Get the temperature.
                XmlNode temp_node = time_node.SelectSingleNode("temperature");
                string temp = temp_node.Attributes["value"].Value;

				// Get the precipitation.
				XmlNode precip_node2 = time_node.SelectSingleNode("precipitation");
				string precip2 = precip_node.Attributes["type"].Value;

				ListViewItem item = lvwForecast.Items.Add(time.DayOfWeek.ToString());
                item.SubItems.Add(time.ToShortTimeString());
                item.SubItems.Add(temp + degrees);
				item.SubItems.Add(precip2);
            }
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
	}
}
