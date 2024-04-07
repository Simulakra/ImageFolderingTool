namespace ImageFolderingTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_foldertext = new TextBox();
            label1 = new Label();
            btn_folderset = new Button();
            groupBox1 = new GroupBox();
            lbl_properties = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            bt_summarize = new Button();
            button3 = new Button();
            bt_undo = new Button();
            button9 = new Button();
            button6 = new Button();
            button8 = new Button();
            button5 = new Button();
            button7 = new Button();
            button4 = new Button();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1 = new Panel();
            bt_nav_5 = new Button();
            bt_nav_4 = new Button();
            bt_nav_2 = new Button();
            bt_nav_3 = new Button();
            bt_nav_1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_foldertext
            // 
            tb_foldertext.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_foldertext.Enabled = false;
            tb_foldertext.Location = new Point(80, 12);
            tb_foldertext.Name = "tb_foldertext";
            tb_foldertext.Size = new Size(1016, 31);
            tb_foldertext.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 1;
            label1.Text = "Folder";
            // 
            // btn_folderset
            // 
            btn_folderset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_folderset.Location = new Point(1102, 12);
            btn_folderset.Name = "btn_folderset";
            btn_folderset.Size = new Size(64, 34);
            btn_folderset.TabIndex = 2;
            btn_folderset.Text = "Set";
            btn_folderset.UseVisualStyleBackColor = true;
            btn_folderset.Click += btn_folderset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(lbl_properties);
            groupBox1.Location = new Point(931, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 375);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Properties";
            // 
            // lbl_properties
            // 
            lbl_properties.Dock = DockStyle.Fill;
            lbl_properties.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_properties.Location = new Point(3, 27);
            lbl_properties.Name = "lbl_properties";
            lbl_properties.Size = new Size(229, 345);
            lbl_properties.TabIndex = 0;
            lbl_properties.Text = "lbl_properties";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(bt_summarize);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(bt_undo);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(931, 433);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(235, 299);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seperator Folders";
            // 
            // button1
            // 
            button1.Location = new Point(6, 182);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Tag = "1";
            button1.Text = "Num1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_numpad_click;
            // 
            // button2
            // 
            button2.Location = new Point(82, 182);
            button2.Name = "button2";
            button2.Size = new Size(70, 70);
            button2.TabIndex = 0;
            button2.TabStop = false;
            button2.Tag = "2";
            button2.Text = "Num2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_numpad_click;
            // 
            // bt_summarize
            // 
            bt_summarize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_summarize.Location = new Point(113, 258);
            bt_summarize.Name = "bt_summarize";
            bt_summarize.Size = new Size(115, 34);
            bt_summarize.TabIndex = 5;
            bt_summarize.Text = "Summarize";
            bt_summarize.UseVisualStyleBackColor = true;
            bt_summarize.Click += bt_summarize_Click;
            // 
            // button3
            // 
            button3.Location = new Point(158, 182);
            button3.Name = "button3";
            button3.Size = new Size(70, 70);
            button3.TabIndex = 0;
            button3.TabStop = false;
            button3.Tag = "3";
            button3.Text = "Num3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_numpad_click;
            // 
            // bt_undo
            // 
            bt_undo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_undo.Location = new Point(6, 258);
            bt_undo.Name = "bt_undo";
            bt_undo.Size = new Size(101, 34);
            bt_undo.TabIndex = 4;
            bt_undo.Text = "Undo";
            bt_undo.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(158, 30);
            button9.Name = "button9";
            button9.Size = new Size(70, 70);
            button9.TabIndex = 0;
            button9.TabStop = false;
            button9.Tag = "9";
            button9.Text = "Num9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_numpad_click;
            // 
            // button6
            // 
            button6.Location = new Point(158, 106);
            button6.Name = "button6";
            button6.Size = new Size(70, 70);
            button6.TabIndex = 0;
            button6.TabStop = false;
            button6.Tag = "6";
            button6.Text = "Num6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_numpad_click;
            // 
            // button8
            // 
            button8.Location = new Point(82, 30);
            button8.Name = "button8";
            button8.Size = new Size(70, 70);
            button8.TabIndex = 0;
            button8.TabStop = false;
            button8.Tag = "8";
            button8.Text = "Num8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_numpad_click;
            // 
            // button5
            // 
            button5.Location = new Point(82, 106);
            button5.Name = "button5";
            button5.Size = new Size(70, 70);
            button5.TabIndex = 0;
            button5.TabStop = false;
            button5.Tag = "5";
            button5.Text = "Num5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_numpad_click;
            // 
            // button7
            // 
            button7.Location = new Point(6, 30);
            button7.Name = "button7";
            button7.Size = new Size(70, 70);
            button7.TabIndex = 0;
            button7.TabStop = false;
            button7.Tag = "7";
            button7.Text = "Num7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_numpad_click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 106);
            button4.Name = "button4";
            button4.Size = new Size(70, 70);
            button4.TabIndex = 0;
            button4.TabStop = false;
            button4.Tag = "4";
            button4.Text = "Num4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_numpad_click;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView2.BackColor = SystemColors.ControlDarkDark;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(12, 52);
            webView2.Name = "webView2";
            webView2.Size = new Size(913, 640);
            webView2.TabIndex = 6;
            webView2.ZoomFactor = 1D;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(bt_nav_5);
            panel1.Controls.Add(bt_nav_4);
            panel1.Controls.Add(bt_nav_2);
            panel1.Controls.Add(bt_nav_3);
            panel1.Controls.Add(bt_nav_1);
            panel1.Location = new Point(12, 698);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 34);
            panel1.TabIndex = 7;
            // 
            // bt_nav_5
            // 
            bt_nav_5.Anchor = AnchorStyles.None;
            bt_nav_5.Location = new Point(636, 0);
            bt_nav_5.Name = "bt_nav_5";
            bt_nav_5.Size = new Size(112, 34);
            bt_nav_5.TabIndex = 0;
            bt_nav_5.TabStop = false;
            bt_nav_5.Text = "Last⇥";
            bt_nav_5.UseVisualStyleBackColor = true;
            bt_nav_5.Click += bt_nav_5_Click;
            // 
            // bt_nav_4
            // 
            bt_nav_4.Anchor = AnchorStyles.None;
            bt_nav_4.Location = new Point(518, 0);
            bt_nav_4.Name = "bt_nav_4";
            bt_nav_4.Size = new Size(112, 34);
            bt_nav_4.TabIndex = 0;
            bt_nav_4.TabStop = false;
            bt_nav_4.Text = "Next→";
            bt_nav_4.UseVisualStyleBackColor = true;
            bt_nav_4.Click += bt_nav_4_Click;
            // 
            // bt_nav_2
            // 
            bt_nav_2.Anchor = AnchorStyles.None;
            bt_nav_2.Location = new Point(282, 0);
            bt_nav_2.Name = "bt_nav_2";
            bt_nav_2.Size = new Size(112, 34);
            bt_nav_2.TabIndex = 0;
            bt_nav_2.TabStop = false;
            bt_nav_2.Text = "←Prev";
            bt_nav_2.UseVisualStyleBackColor = true;
            bt_nav_2.Click += bt_nav_2_Click;
            // 
            // bt_nav_3
            // 
            bt_nav_3.Anchor = AnchorStyles.None;
            bt_nav_3.Location = new Point(400, 0);
            bt_nav_3.Name = "bt_nav_3";
            bt_nav_3.Size = new Size(112, 34);
            bt_nav_3.TabIndex = 0;
            bt_nav_3.TabStop = false;
            bt_nav_3.Text = "⇋Select⇋";
            bt_nav_3.UseVisualStyleBackColor = true;
            bt_nav_3.Click += bt_nav_3_Click;
            // 
            // bt_nav_1
            // 
            bt_nav_1.Anchor = AnchorStyles.None;
            bt_nav_1.Location = new Point(164, 0);
            bt_nav_1.Name = "bt_nav_1";
            bt_nav_1.Size = new Size(112, 34);
            bt_nav_1.TabIndex = 0;
            bt_nav_1.TabStop = false;
            bt_nav_1.Text = "⇤First";
            bt_nav_1.UseVisualStyleBackColor = true;
            bt_nav_1.Click += bt_nav_1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 744);
            Controls.Add(panel1);
            Controls.Add(webView2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_folderset);
            Controls.Add(label1);
            Controls.Add(tb_foldertext);
            KeyPreview = true;
            MinimumSize = new Size(1200, 800);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_foldertext;
        private Label label1;
        private Button btn_folderset;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button9;
        private Button button6;
        private Button button3;
        private Button button8;
        private Button button5;
        private Button button2;
        private Button button7;
        private Button button4;
        private Button button1;
        private Button bt_undo;
        private Button bt_summarize;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private Panel panel1;
        private Button bt_nav_5;
        private Button bt_nav_4;
        private Button bt_nav_2;
        private Button bt_nav_3;
        private Button bt_nav_1;
        private Label lbl_properties;
    }
}
