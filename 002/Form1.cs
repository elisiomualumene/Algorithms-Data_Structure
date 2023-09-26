namespace _002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(input.Text);
            
            before.Text = (value - 1).ToString();
            after.Text = (value + 1).ToString();
        }
    }
}