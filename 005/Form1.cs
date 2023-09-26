namespace _005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            double base_value = double.Parse(input.Text);

            value.Text = (base_value * 0.0012).ToString();
        }
    }
}