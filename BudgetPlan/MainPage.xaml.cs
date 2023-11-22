namespace BudgetPlan
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void CounterBtn_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}