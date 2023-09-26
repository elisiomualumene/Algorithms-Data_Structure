namespace _012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(input1.Text);
            int numero2 = Convert.ToInt32(input2.Text);

            double resultadoA = Math.Pow(numero1, 2);
            int resultadoB = numero1 * (numero2 + 1);
            double resultadoC = 1.0 / numero2;
            double resultadoD = numero2 + (numero1 / 2.0);
            int resultadoE = numero1 - numero2;
            int resultadoF = -numero2;

            list.Items.Clear();

            list.Items.Add($"a) {numero1} elevado � raiz quadrada de {numero2} � {resultadoA}");
            list.Items.Add($"b) {numero1} vezes o sucessor de {numero2} � {resultadoB}");
            list.Items.Add($"c) O n�mero inverso de {numero2} � {resultadoC}");
            list.Items.Add($"d) A soma de {numero2} com a metade de {numero1} � {resultadoD}");
            list.Items.Add($"e) A diferen�a entre {numero1} e {numero2} � {resultadoE}");
            list.Items.Add($"f) O valor oposto de {numero2} � {resultadoF}");
        }
    }
}