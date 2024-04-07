using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImageFolderingTool
{
    public partial class Form2 : Form
    {
        List<string> _images;
        string[] _image_seperators;
        string[] _folder_names;
        string _main_folder;

        int[] _file_counts;
        int _total_file_count;
        public Form2(List<string> images, string[] image_seperators, string[] folder_names, string main_folder)
        {
            _images = images;
            _image_seperators = image_seperators;
            _folder_names = folder_names;
            _main_folder = main_folder;
            _file_counts = new int[9];
            _total_file_count = 0;
            foreach (string seperate_choice in _image_seperators)
            {
                if (!string.IsNullOrEmpty(seperate_choice))
                {
                    int _i = int.Parse(seperate_choice);
                    _file_counts[_i - 1] += 1;
                    _total_file_count += 1;
                }
            }
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 9; i++)
            {
                int i_ = i + 1;
                if (_file_counts[i] != 0 && string.IsNullOrEmpty(_folder_names[i]))
                {
                    string seperator_folder_name = Interaction.InputBox(
                      "Enter folder name for Numpad" + i_ + " seperator.",
                      "Folder Name", "Example Folder", 0, 0);
                    if (string.IsNullOrEmpty(seperator_folder_name))
                    {
                        DialogResult = DialogResult.Cancel;
                        return;
                    }
                    _folder_names[i] = seperator_folder_name;
                }
                if (!string.IsNullOrEmpty(_folder_names[i]))
                {
                    label1.Text += "Num" + i_ + " = \"" + _folder_names[i] + "\"\n";
                    label1.Text += "Count = " + _file_counts[i] + "\n";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = _total_file_count;
            for (int i = 0; i < 9; i++)
            {
                if (!Directory.Exists(_main_folder + "\\" + _folder_names[i]))
                {
                    Directory.CreateDirectory(_main_folder + "\\" + _folder_names[i]);
                }
            }
            int j = 0;
            foreach (string seperate_choice in _image_seperators)
            {
                if (!string.IsNullOrEmpty(seperate_choice))
                {
                    string destination_folder = _main_folder + "\\" + _folder_names[int.Parse(seperate_choice) - 1];
                    string filename = _images[j].Substring(_images[j].LastIndexOf('\\'));
                    destination_folder += filename;
                    if (radioButton1.Checked)
                    {
                        File.Move(_images[j], destination_folder);
                    }
                    else
                    {
                        File.Copy(_images[j], destination_folder);
                    }
                    progressBar1.Value += 1;
                }
                j++;
            }
            MessageBox.Show("Image Seperating Progress Completed.\nPlease check related folders.");
            //System.Diagnostics.Process.Start("explorer.exe", _main_folder);
            System.Windows.Forms.Application.Exit();
        }
    }
}
