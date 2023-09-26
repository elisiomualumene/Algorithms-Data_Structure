namespace _006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void execute_Click(object sender, EventArgs e)
        {
            double base_input = double.Parse(input.Text);

            value1.Text = (base_input + 273.15).ToString();
            //!!
            value2.Text = ((base_input * 9/5) + 32).ToString();
        }
    }
}