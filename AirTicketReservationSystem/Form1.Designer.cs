namespace AirTicketReservationSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            label8 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(426, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 233);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Passenger Information";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(199, 153);
            button1.Name = "button1";
            button1.Size = new Size(105, 29);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 121);
            label7.Name = "label7";
            label7.Size = new Size(119, 21);
            label7.TabIndex = 12;
            label7.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 87);
            label6.Name = "label6";
            label6.Size = new Size(30, 21);
            label6.TabIndex = 11;
            label6.Text = "TC:";
            label6.Click += label6_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(156, 118);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(185, 29);
            maskedTextBox3.TabIndex = 10;
            maskedTextBox3.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(156, 82);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(185, 29);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 29);
            textBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 46);
            label5.Name = "label5";
            label5.Size = new Size(152, 21);
            label5.TabIndex = 1;
            label5.Text = "Name and Surname:";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Where from:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 82);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 1;
            label2.Text = "Where:";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "Elazığ", "İzmir", "Antalya" });
            comboBox1.Location = new Point(111, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 29);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "İstanbul", "Elazığ", "İzmir", "Antalya" });
            comboBox2.Location = new Point(111, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(185, 29);
            comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 118);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 4;
            label3.Text = "Date:";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(111, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(185, 29);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flight Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(161, 193);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 8;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(302, 61);
            button2.Name = "button2";
            button2.Size = new Size(46, 42);
            button2.TabIndex = 4;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(111, 150);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(185, 29);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 150);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 6;
            label4.Text = "Hour:";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 445);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 88);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 176);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(511, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 571);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private Button button1;
        private Label label7;
        private ListBox listBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Label label8;
    }
}
