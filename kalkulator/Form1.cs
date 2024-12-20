namespace kalkulator
{
    public partial class Form1 : Form
    {
        private string firstCurrency;
        private string secondCurrency;
        private int amountValue;
        private Dictionary<string, decimal> exchangeRates;

        public Form1()
        {
            InitializeComponent();
            firstCurrency = "";
            secondCurrency = "";
            amountValue = 1;
            exchangeRates = new Dictionary<string, decimal>
            {
                { "PLNUSD", 0.26m },
                { "PLNEUR", 0.23m },
                { "PLNNOK", 2.74m },
                { "PLNCHF", 0.22m },
                { "USDPLN", 3.87m },
                { "USDEUR", 0.90m },
                { "USDNOK", 10.60m },
                { "USDCHF", 0.85m },
                { "EURPLN", 4.29m },
                { "EURUSD", 1.11m },
                { "EURNOK", 11.74m },
                { "EURCHF", 0.94m },
                { "NOKPLN", 0.37m },
                { "NOKUSD", 0.094m },
                { "NOKEUR", 0.085m },
                { "NOKCHF", 0.080m },
                { "CHFPLN", 4.58m },
                { "CHFUSD", 1.18m },
                { "CHFEUR", 1.07m },
                { "CHFNOK", 12.54m },
            };
        }

        private void firstPLN_CheckedChanged(object sender, EventArgs e)
        {
            firstCurrency = "PLN";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void secondPLN_CheckedChanged(object sender, EventArgs e)
        {
            secondCurrency = "PLN";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void firstUSD_CheckedChanged(object sender, EventArgs e)
        {
            firstCurrency = "USD";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void secondUSD_CheckedChanged(object sender, EventArgs e)
        {
            secondCurrency = "USD";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void firstEUR_CheckedChanged(object sender, EventArgs e)
        {
            firstCurrency = "EUR";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void secondEUR_CheckedChanged(object sender, EventArgs e)
        {
            secondCurrency = "EUR";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void firstNOK_CheckedChanged(object sender, EventArgs e)
        {
            firstCurrency = "NOK";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void secondNOK_CheckedChanged(object sender, EventArgs e)
        {
            secondCurrency = "NOK";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void firstCHF_CheckedChanged(object sender, EventArgs e)
        {
            firstCurrency = "CHF";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void secondCHF_CheckedChanged(object sender, EventArgs e)
        {
            secondCurrency = "CHF";
            wynikHeader.Text = firstCurrency + " - " + secondCurrency;
        }

        private void amount_ValueChanged(object sender, EventArgs e)
        {
            amountValue = (int)amount.Value;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string key = firstCurrency + secondCurrency;
            if (exchangeRates.ContainsKey(key))
            {
                decimal rate = exchangeRates[key];
                decimal result = amountValue * rate;
                wynikText.Text = $"{amountValue} {firstCurrency} = {result:F2} {secondCurrency}";
            }
            else
            {
                wynikText.Text = "Wystąpił błąd.\nPrawdopodobnie nie zaznaczyłeś\nwaluty lub dwie takie same.";
            }
        }
    }
}
