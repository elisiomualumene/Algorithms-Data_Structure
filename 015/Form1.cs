namespace _015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(input.Text, out int numeroCavalos))
            {
                // Calcular o número de ferraduras necessárias
                int numeroFerraduras = numeroCavalos * 4; // Cada cavalo tem 4 patas

                // Exibir o resultado
                value.Text = $"Você precisa de {numeroFerraduras} ferraduras.";
            }
            else
            {
                // Exibir uma mensagem de erro se a entrada não for válida
                MessageBox.Show("Digite um número válido de cavalos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}