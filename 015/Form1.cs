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
                // Calcular o n�mero de ferraduras necess�rias
                int numeroFerraduras = numeroCavalos * 4; // Cada cavalo tem 4 patas

                // Exibir o resultado
                value.Text = $"Voc� precisa de {numeroFerraduras} ferraduras.";
            }
            else
            {
                // Exibir uma mensagem de erro se a entrada n�o for v�lida
                MessageBox.Show("Digite um n�mero v�lido de cavalos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}