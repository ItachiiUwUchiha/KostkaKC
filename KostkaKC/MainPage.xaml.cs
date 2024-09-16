namespace KostkaKC
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random r = new Random();
            int diceRoll = r.Next(1, 7);
            CounterBtn.Text = "Wynik rzutu: " + diceRoll.ToString();
            int diceRoll = 6;
            if (K4.IsChecked)
            {
                diceRoll = r.Next(1, 5);
            }
            if (K6.IsChecked)
            {
                diceRoll = r.Next(1, 7);
            }
            if (K10.IsChecked)
            {
                diceRoll = r.Next(1, 11);
            }
            if (K12.IsChecked)
            {

                diceRoll = r.Next(1, 13);
            }

            RollLabel.Text = "Wynik rzutu: " + diceRoll.ToString();
        }


    }


}