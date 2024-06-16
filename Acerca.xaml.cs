namespace TrabajoPractico3;

public partial class Acerca : ContentPage
{
	public Acerca()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}