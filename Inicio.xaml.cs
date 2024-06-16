namespace TrabajoPractico3;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
       Navigation.PushAsync(new Acerca());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}