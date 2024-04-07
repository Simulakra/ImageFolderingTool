namespace ImageFolderingTool.DialogForms
{
    partial class ImageSelectDialog
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
            bt_cancel = new Button();
            bt_select = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bt_cancel
            // 
            bt_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_cancel.Location = new Point(454, 698);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(112, 34);
            bt_cancel.TabIndex = 99;
            bt_cancel.TabStop = false;
            bt_cancel.Text = "Cancel";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // bt_select
            // 
            bt_select.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_select.Location = new Point(12, 698);
            bt_select.Name = "bt_select";
            bt_select.Size = new Size(436, 34);
            bt_select.TabIndex = 1;
            bt_select.Text = "Select";
            bt_select.UseVisualStyleBackColor = true;
            bt_select.Click += bt_select_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(554, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Leave += textBox1_Leave;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 643);
            panel1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(554, 643);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // ImageSelectDialog
            // 
            AcceptButton = bt_select;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bt_cancel;
            ClientSize = new Size(578, 744);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(bt_select);
            Controls.Add(bt_cancel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImageSelectDialog";
            Text = "ImageSelectDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_cancel;
        private Button bt_select;
        private TextBox textBox1;
        private Panel panel1;
        private ListBox listBox1;
    }
}