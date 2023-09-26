namespace _001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            int first_value = Int32.Parse(first_input.Text);
            int second_value = Int32.Parse(second_input.Text);
            int value = first_value + second_value;
            result.Text = value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void new_calc_Click(object sender, EventArgs e)
        {
            first_input.Clear();
            second_input.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}