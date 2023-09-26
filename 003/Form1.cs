namespace _003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(input.Text);
            // value*3, value^(1/2)
            list.Items.Add($"Dobro: {value*2}");
            list.Items.Add($"Triplo: {value * 3}");
            list.Items.Add($"Raiz Quadrada: {Math.Sqrt(value)}");
            list.Items.Add($"Raiz Quinta: {Math.Pow(value, 1.0 / 5.0)}");
        }
    }
}