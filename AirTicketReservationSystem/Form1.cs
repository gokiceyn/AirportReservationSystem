namespace AirTicketReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Route:: " + comboBox1.Text + "-" + comboBox2.Text + "  Date: " + dateTimePicker1.Text + "  Hour: " + maskedTextBox1.Text + "  Name and Surname: " + textBox1.Text + "  Tc:" + maskedTextBox2.Text + "  Phone Number: " + maskedTextBox3.Text);
            MessageBox.Show("passenger registration has been made");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text=comboBox2.Text;
            comboBox2.Text=comboBox1.Text;
            comboBox1.Text = label8.Text;

        }
    }
}
