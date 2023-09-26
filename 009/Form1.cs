namespace _009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            double oposto = double.Parse(input1.Text);
            double adjacente = double.Parse(input2.Text);

            double hip = Math.Pow(oposto, 2) + Math.Pow(adjacente, 2);

            int hipotenusa = Convert.ToInt32(Math.Sqrt(hip));

            value.Text = hipotenusa.ToString();
        }
    }
}