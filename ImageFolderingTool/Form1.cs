using Microsoft.VisualBasic;
using System.Diagnostics;

namespace ImageFolderingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int img_index;
        List<string> images;
        string[] image_seperators;
        string[] folder_names;
        private void Form1_Load(object sender, EventArgs e)
        {
            tb_foldertext.Text = Application.StartupPath;
            images = new List<string>();
            image_seperators = new string[0];
            folder_names = new string[9];
            lbl_properties.Text = "";
            getDirectoryImages();
        }

        private void getDirectoryImages()
        {
            groupBox2.Enabled = false;
            images.Clear();
            image_seperators = new string[0];
            folder_names = new string[9];
            images.AddRange(new List<string>(Directory.GetFiles(tb_foldertext.Text, "*.jpg")));
            images.AddRange(new List<string>(Directory.GetFiles(tb_foldertext.Text, "*.jpeg")));
            images.AddRange(new List<string>(Directory.GetFiles(tb_foldertext.Text, "*.png")));
            images.Sort();
            webView2.Hide();
            webView2.Enabled = false;
            img_index = 0;
            this.Text = "Folder: " + tb_foldertext.Text.Substring(tb_foldertext.Text.LastIndexOf('\\') + 1)
                          + " - Count: " + images.Count.ToString();
            image_seperators = new string[images.Count];
            if (images.Count > 0)
            {
                webView2.Show();
                webView2.Enabled = true;
                setImageDisplay();
                groupBox2.Enabled = true;
            }
        }

        private void btn_folderset_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tb_foldertext.Text = fbd.SelectedPath;
            }
            getDirectoryImages();
        }

        private void setImageDisplay()
        {
            webView2.Source = new Uri(images[img_index]);
            //webView2.Refresh();
            setNumpadButtonBackcolor();
        }

        private void bt_nav_1_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                img_index = 0;
                setImageDisplay();
            }
        }

        private void bt_nav_5_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                img_index = images.Count - 1;
                setImageDisplay();
            }
        }

        private void bt_nav_2_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                img_index -= 1;
                if (img_index < 0) img_index = 0;
                setImageDisplay();
            }
        }

        private void bt_nav_4_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                img_index += 1;
                if (img_index >= images.Count) img_index = images.Count - 1;
                setImageDisplay();
            }
        }

        private void bt_nav_3_Click(object sender, EventArgs e)
        {
            DialogForms.ImageSelectDialog dia_imageselect = new DialogForms.ImageSelectDialog(images);
            if (dia_imageselect.ShowDialog() == DialogResult.OK)
            {
                img_index = dia_imageselect.selected_image;
                if (img_index < 0) img_index = 0;
                if (img_index >= images.Count) img_index = images.Count - 1;
                setImageDisplay();

            }
        }

        private void button_numpad_click(object sender, EventArgs e)
        {
            Button bt_sender = (Button)sender;
            if (bt_sender == null) return;
            SetButtonNumpad(bt_sender.Tag.ToString());

        }
        private void SetButtonNumpad(string bt_value)
        {
            if (groupBox2.Enabled == true)
            {
                if (string.IsNullOrEmpty(folder_names[int.Parse(bt_value) - 1]))
                {
                    string seperator_folder_name = Interaction.InputBox(
                        "Enter folder name for Numpad" + bt_value + " seperator.",
                        "Folder Name", "Example Folder", 0, 0);
                    if (string.IsNullOrEmpty(seperator_folder_name))
                    {
                        return;
                    }
                    folder_names[int.Parse(bt_value) - 1] = seperator_folder_name;
                }
                image_seperators[img_index] = bt_value;
                setNumpadButtonBackcolor();
            }
        }

        private void setNumpadButtonBackcolor()
        {
            button1.BackColor = (image_seperators[img_index] == "1") ? Color.Green : Color.White;
            button2.BackColor = (image_seperators[img_index] == "2") ? Color.Green : Color.White;
            button3.BackColor = (image_seperators[img_index] == "3") ? Color.Green : Color.White;
            button4.BackColor = (image_seperators[img_index] == "4") ? Color.Green : Color.White;
            button5.BackColor = (image_seperators[img_index] == "5") ? Color.Green : Color.White;
            button6.BackColor = (image_seperators[img_index] == "6") ? Color.Green : Color.White;
            button7.BackColor = (image_seperators[img_index] == "7") ? Color.Green : Color.White;
            button8.BackColor = (image_seperators[img_index] == "8") ? Color.Green : Color.White;
            button9.BackColor = (image_seperators[img_index] == "9") ? Color.Green : Color.White;

            lbl_properties.Text = "";
            for (int i = 0; i < 9; i++)
            {
                int i_ = i + 1;
                if (!string.IsNullOrEmpty(folder_names[i]))
                {
                    lbl_properties.Text += "Num" + i_ + "=\"" + folder_names[i] + "\"\n";
                }

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0: SetButtonNumpad("0"); break;
                case Keys.NumPad1: SetButtonNumpad("1"); break;
                case Keys.NumPad2: SetButtonNumpad("2"); break;
                case Keys.NumPad3: SetButtonNumpad("3"); break;
                case Keys.NumPad4: SetButtonNumpad("4"); break;
                case Keys.NumPad5: SetButtonNumpad("5"); break;
                case Keys.NumPad6: SetButtonNumpad("6"); break;
                case Keys.NumPad7: SetButtonNumpad("7"); break;
                case Keys.NumPad8: SetButtonNumpad("8"); break;
                case Keys.NumPad9: SetButtonNumpad("9"); break;
                case Keys.A: bt_nav_2_Click(null, null); break;
                case Keys.D: bt_nav_4_Click(null, null); break;
                case Keys.Q: bt_nav_1_Click(null, null); break;
                case Keys.E: bt_nav_5_Click(null, null); break;
                case Keys.W: bt_nav_3_Click(null, null); break;
            }
        }

        private void bt_summarize_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(images, image_seperators, folder_names, tb_foldertext.Text);
            form2.ShowDialog();
        }
    }
}
