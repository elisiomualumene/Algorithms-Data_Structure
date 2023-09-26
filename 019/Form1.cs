namespace _019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input.Text, out double weight))
            {
                value.Text = (weight * 12.00).ToString();
            }
            else
            {
                MessageBox.Show("Numero Invalid", "ERRO");
            }
        }
    }
}