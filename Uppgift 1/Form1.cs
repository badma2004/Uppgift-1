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
            double celsiusValue = Double.Parse(txbCelsius.Text); // Hämta värdet som skrevs i Celsius-textrutan
            double result = (celsiusValue * 9 / 5) + 32; // Räkna ut
            txbfahrenheit.Text = result.ToString(); // Lagra resultatet i textrutan Fahrenheit

        }
    }
}
