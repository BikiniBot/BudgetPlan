
namespace BudgetPlan;

public partial class HomePage : ContentPage
{

	

	public HomePage()
	{
		InitializeComponent();

        int odejda = 0;
        int prochie = 0;
        int komun= 0;

        int total = 0;



    }
    void PickerSelectedIndexChanged(object sender, EventArgs e)
    {
        header.Text = $"Вы выбрали: {languagePicker.SelectedItem}";
    }

    private void Buttonhis_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new HistiryPage());
    }

    private void Buttondob_Clicked(object sender, EventArgs e)
    {
        if(header == "Одежда")
        {

        }
    }
}