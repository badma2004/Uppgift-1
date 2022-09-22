namespace Uppgift_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsiusValue = Double.Parse(txbCelsius.Text);
            double result = (celsiusValue * 9 / 5) + 32;
            txbfahrenheit.Text = result.ToString();

        }
    }
}