using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageFolderingTool.DialogForms
{
    public partial class ImageSelectDialog : Form
    {
        public ImageSelectDialog(List<string> image_list)
        {
            _image_list = image_list;
            selected_image = -1;
            InitializeComponent();
            foreach (string image in _image_list)
            {
                listBox1.Items.Add(image);
            }
        }
        List<string> _image_list;
        public int selected_image;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //SearchBarUpdate();
        }

        private void SearchBarUpdate()
        {
            listBox1.Items.Clear();
            foreach (string image in _image_list)
            {
                if (image.IndexOf(textBox1.Text) != -1)
                {
                    listBox1.Items.Add(image);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                selected_image = _image_list.IndexOf(listBox1.SelectedItem.ToString());
                DialogResult = DialogResult.OK;
            }
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                selected_image = _image_list.IndexOf(listBox1.SelectedItem.ToString());
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            SearchBarUpdate();
        }
    }
}
