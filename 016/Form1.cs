namespace _016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input1.Text, out int quantidadeBroas) &&
           int.TryParse(input2.Text, out int quantidadePaes))
            {
                double Quantidade_paes = quantidadePaes * 0.12;
                double Quantidade_broas = quantidadeBroas * 1.50;

                list.Items.Clear();
                list.Items.Add($"Os paes vendido equivalem {Quantidade_paes}");
                list.Items.Add($"As Broas vendido equivalem {Quantidade_broas}");
                list.Items.Add($"Para a poupança {(Quantidade_broas + Quantidade_paes) * 0.1}");

            }
            else
            {
                MessageBox.Show("Digite quantidades válidas para pães e broas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleaner_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            input1.Clear();
            input2.Clear();
        }
    }
}