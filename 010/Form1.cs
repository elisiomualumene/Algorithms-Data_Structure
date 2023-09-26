namespace _010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(input.Text);

            double rad = angle * (Math.PI / 180);

            list.Items.Add($"Radiano: {rad}");
        }
    }
}