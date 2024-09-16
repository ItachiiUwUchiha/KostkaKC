namespace KostkaKC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
            Random r = new Random();
            int diceRoll = r.Next(1, 7);
            CounterBtn.Text = "Wynik rzutu: " + diceRoll.ToString();
        }
    }

}