namespace _008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            double number = double.Parse(input.Text);

            double entire_part = Math.Floor(number);
            double broken_part = number - entire_part;

            value1.Text = (entire_part).ToString();
            value2.Text = (broken_part).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}