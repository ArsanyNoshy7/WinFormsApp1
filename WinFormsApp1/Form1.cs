namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        #region Var(s)
        string Name;
        string Job;
        string DOB;
        string Status;
        string habites;
        string Genderr;
        string Salary;
        string Description;
        string Csharp;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBox1.Text;
            Job = textBox6.Text;
            DOB = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            Status = comboBox1.SelectedItem.ToString();
            habites = "";
            if (TV.Checked) habites += TV.Text + ", ";
            if (football.Checked) habites += football.Text + ", ";
            if (bodyblulding.Checked) habites += bodyblulding.Text + ", ";
            if (swimming.Checked) habites += swimming.Text + ", ";

            Genderr = "";
            if (male.Checked) Genderr = male.Text;
            else if (female.Checked) Genderr = female.Text;

            Description = richTextBox1.Text;
            Salary = numericUpDown2.Value.ToString();
            Csharp = numericUpDown1.Value.ToString();

            richTextBox2.Text = $"Name: {Name}\n" +
                $"Job: {Job}\n" +
                $"DOB: {DOB}\n" +
                $"Status: {Status}\n" +
                $"Habits: {habites.TrimEnd(',', ' ')}\n" +
                $"Gender: {Genderr}\n" +
                $"Description: {Description}\n" +
                $"Salary: {Salary}\n" +
                $"C# Experience: {Csharp} years\n";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox2.Text, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }

        private void habbits_Enter(object sender, EventArgs e)
        {

        }
    }
}
