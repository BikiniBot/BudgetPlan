
namespace BudgetPlan;

public partial class HomePage : ContentPage
{

	

	public HomePage()
	{
		InitializeComponent();
	}
    void PickerSelectedIndexChanged(object sender, EventArgs e)
    {
        header.Text = $"Вы выбрали: {languagePicker.SelectedItem}";
    }

    private void Buttonhis_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new HistiryPage());
    }
}