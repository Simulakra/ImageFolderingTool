namespace ImageFolderingTool
{
    partial class Form2
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(584, 476);
            button1.Name = "button1";
            button1.Size = new Size(182, 56);
            button1.TabIndex = 0;
            button1.Text = "Complete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 520);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Summarize";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(408, 490);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(432, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 73);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Foldering";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(94, 30);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 29);
            radioButton2.TabIndex = 0;
            radioButton2.Text = "Copy";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Move";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(432, 436);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(334, 34);
            progressBar1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(432, 476);
            button2.Name = "button2";
            button2.Size = new Size(146, 56);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(button2);
            Controls.Add(progressBar1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private ProgressBar progressBar1;
        private Button button2;
    }
}