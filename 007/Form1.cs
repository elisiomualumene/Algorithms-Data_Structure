namespace _007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            double note1 = double.Parse(value1.Text);
            double note2 = double.Parse(value2.Text);
            double note3 = double.Parse(value3.Text);
            double note4 = double.Parse(value4.Text);

            double result = (note1 + note2 + note3 + note4) / 4;

            if(result > 10 || result < 0)
            {
                MessageBox.Show("Numeros Invalidos, Apenas aceitamos valores no Intervalo de 0 - 10", "Erro");
            }else
            {
                value.Text = result.ToString();
            }

        }
    }
}