namespace TrabajoPractico3;

public partial class Principal : ContentPage
{
  
   
    public Principal()
	{
		InitializeComponent();

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string Usuario = NombreUsuario.Text;
        string Contraseņa= ContraseņaUsuario.Text;
        if(Usuario=="alumno" && Contraseņa == "1234")
        {
            NombreUsuario.Text = "";
            ContraseņaUsuario.Text = "";

            await DisplayAlert("Inicio de sesion", "Inicio de sesion exitoso!", "OK");
            await Navigation.PushAsync(new Inicio());
        }
        else
        {
            await DisplayAlert("Inicio de sesion fallido", "Usuario o contraseņa incorrectos.", "OK");
        }

    }
}