namespace _014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            string[] sizes = input.Text.Split('x');
            int v1 = Int32.Parse(sizes[0]);
            int v2 = Int32.Parse(sizes[1]);
            int result = v1 * v2;
            value.Text = result.ToString();
        }
    }
}