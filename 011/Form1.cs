namespace _011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(input.Text);

            int unidades = numero % 10;
            int dezenas = (numero / 10) % 10;
            int centenas = (numero / 100) % 10;
            int milhares = numero / 1000;

            list.Items.Clear();

            list.Items.Add($"{milhares} milhar(es)");
            list.Items.Add($"{centenas} centena(s)");
            list.Items.Add($"{dezenas} dezena(s)");
            list.Items.Add($"{unidades} unidade(s)");
        }
    }
}