using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__Day54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label click event
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Handle radioButton1 checked changed event
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Handle radioButton2 checked changed event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new profile object
            Profile pfp = new Profile()
            {
                Name = textBox1.Text,
                Age = int.Parse(textBox2.Text),
                Gender = maleRadio.Checked ? "Male" : "Female"
            };

            // Create a list to store profiles
            List<Profile> profileList;

            // Specify the file path
            string filePath = "E:\\userInfo.json";

            try
            {
                // Read existing JSON data from the file
                string jsonString = File.ReadAllText(filePath);

                // Check if the existing JSON data is an array or a single object
                if (jsonString.StartsWith("["))
                {
                    // Deserialize the existing JSON data into a list of profiles
                    profileList = JsonSerializer.Deserialize<List<Profile>>(jsonString);
                }
                else
                {
                    // Create a new list with the single object
                    profileList = new List<Profile> { JsonSerializer.Deserialize<Profile>(jsonString) };
                }

                // Add the new profile to the existing list
                profileList.Add(pfp);

                // Output profile names to the debug window
                foreach (var item in profileList)
                {
                    Debug.WriteLine(item.Name);
                }

                // Serialize the updated list of profiles to JSON
                string updatedJsonString = JsonSerializer.Serialize(profileList, new JsonSerializerOptions { WriteIndented = true });

                // Write the updated JSON data back to the file
                File.WriteAllText(filePath, updatedJsonString);
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., file not found or invalid JSON format
                Debug.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    [Serializable]
    public class Profile
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
