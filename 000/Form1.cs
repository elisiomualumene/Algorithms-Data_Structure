namespace _000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 07 && hour < 12)
                MessageBox.Show($"Bom Dia, {input.Text}");
            else if (hour >= 12 && hour < 19)
                MessageBox.Show($"Boa Tarde, {input.Text}");
            else if (hour >= 19)
                MessageBox.Show($"Boa Noite, {input.Text}");
            else if (hour < 7)
                MessageBox.Show($"Boa Noite, {input.Text}");
        }
    }
}