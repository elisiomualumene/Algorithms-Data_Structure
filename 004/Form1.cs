namespace _004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            double value = Double.Parse(input.Text);

            list.Items.Add($"Kilometro: {value/1000}km");
            list.Items.Add($"Hectometro: {value / 100}hm");
            list.Items.Add($"Centimetro: {value * 100}cm");
            list.Items.Add($"Decimetro: {value * 10}dm");
            list.Items.Add($"Decametro: {value / 10}dc");
            list.Items.Add($"Milimetro: {value * 1000}mm");
        }
    }
}