using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Error = false;

            // Check the name field
            if (NameText.Text.Length == 0)
            {
                NameTextTips.Text = "Error! Empty name!";
                Error = true;
            }
            else
            {
                NameTextTips.Text = "i.e. Adam Smith";
            }

            // Check the address field
            if (AddressText.Text.Length == 0)
            {
                AddressTextTips.Text = "Error! Empty address!";
                Error = true;
            }
            else
            {
                AddressTextTips.Text = "Street City, State, Zip";
            }

            // Check the phone field
            if (PhoneText.Text.Length == 0)
            {
                PhoneTextTips.Text = "Error! Empty phone!";
                Error = true;
            }
            else
            {
                PhoneTextTips.Text = "i.e. 9405652000";
            }

            // Check the save as field
            if (SaveAsText.Text.Length == 0)
            {
                SaveAsTextTips.Text = "Error! Empty filename!";
                Error = true;
            }
            else
            {
                SaveAsTextTips.Text = "i.e. File1";
            }

            if (Error == false)
            {
                // Create XML
                XDocument Person =
                    new XDocument(
                        new XDeclaration("1.0", "ISO-8859-1", "yes"),
                        new XComment("Edit by WindowsFormsApplication."),
                        new XElement("Person",
                                new XElement("Name", NameText.Text),
                                new XElement("Address", AddressText.Text),
                                new XElement("Phone", PhoneText.Text)
                        )
                    );
                
                // Write to file
                TextWriter TW = new StreamWriter(SaveAsText.Text + ".xml");
                TW.WriteLine(Person.Declaration);
                TW.WriteLine(Person);

                // Close file
                TW.Close();

                // Close app
                Close();
            }
        }

        private void nameTextTips_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextTips_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ReadFileDirectoryText_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadFilesButton_Click(object sender, EventArgs e)
        {
            // Get current directory
            String CurrentDirectory = Directory.GetCurrentDirectory();

            // Save CurrentDirectory to DirectoryInfo
            DirectoryInfo DirectoryInfo = new DirectoryInfo(@CurrentDirectory);

            // Get all the xml files 
            FileInfo[] Files = DirectoryInfo.GetFiles("*.xml");

            // Load the file names to the box
            foreach (FileInfo file in Files)
            {
                LoadFilesBox.Items.Add(file.Name);
            }

            if (LoadFilesBox.Items.Count <= 0)
                LoadFilesDirectoryTips.Text = "No files found!";

        }

        private void SaveAsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox. 
            string SelectedItem = LoadFilesBox.SelectedItem.ToString();

            // int SelectedItemSize = SelectedItem.Length;

            //for(int i = 0; i < SelectedItemSize - 3; i++)
            //    Selected
            
            // SaveAsText.Text = SelectedItem;

            int count = 0;

            XmlTextReader XmlTextReader = new XmlTextReader(SelectedItem);
            while (XmlTextReader.Read())
            {
                switch (XmlTextReader.NodeType)
                {
                    case XmlNodeType.Element:
                        break;
                    case XmlNodeType.Text:
                        if (count == 0)
                        {
                            NameText.Text = (XmlTextReader.Value);
                            count++;
                        }
                        else if (count == 1)
                        {
                            AddressText.Text = (XmlTextReader.Value);
                            count++;
                        }
                        else
                        {
                            PhoneText.Text = (XmlTextReader.Value);
                            count++;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        break;
                }                
 
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
