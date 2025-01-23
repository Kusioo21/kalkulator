namespace kalkulator
{
    public partial class Form1 : Form
    {
        private string firstCurrency;
        private string secondCurrency;
        private int amountValue;
        private Dictionary<string, double> exchangeRates;  

        public Form1()
        {
            InitializeComponent();
            firstCurrency = "";
            secondCurrency = "";
            amountValue = 1;
            exchangeRates = new Dictionary<string, double>  
            {
                { "PLNUSD", 0.26 },
                { "PLNEUR", 0.23 },
                { "PLNNOK", 2.74 },
                { "PLNCHF", 0.22 },
                { "USDPLN", 3.87 },
                { "USDEUR", 0.90 },
                { "USDNOK", 10.60 },
                { "USDCHF", 0.85 },
                { "EURPLN", 4.29 },
                { "EURUSD", 1.11 },
                { "EURNOK", 11.74 },
                { "EURCHF", 0.94 },
                { "NOKPLN", 0.37 },
                { "NOKUSD", 0.094 },
                { "NOKEUR", 0.085 },
                { "NOKCHF", 0.080 },
                { "CHFPLN", 4.58 },
                { "CHFUSD", 1.18 },
                { "CHFEUR", 1.07 },
                { "CHFNOK", 12.54 },
            };
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string key = firstCurrency + secondCurrency;
            if (exchangeRates.ContainsKey(key))
            {
                double rate = exchangeRates[key];  
                double result = amountValue * rate;  
                wynikText.Text = $"{amountValue} {firstCurrency} = {result:F2} {secondCurrency}";
            }
            else
            {
                wynikText.Text = "Wystąpił błąd.\nPrawdopodobnie nie zaznaczyłeś\nwaluty lub dwie takie same.";
            }
        }
    }
}
