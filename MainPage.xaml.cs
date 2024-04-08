namespace dquicaliquinS1T1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                DisplayAlert("Alerta", "Completar todos los campos.", "Aceptar");
            }
            else
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int edad = Convert.ToInt32(txtEdad.Text);
                double salario = Convert.ToDouble(txtSalario.Text);

                double DatoCalculado = salario * 0.0945;

                DisplayAlert("Dato Informativo", "Bienvenido " + nombre + " " + apellido + "\nTienes " + edad + " años \nTu Aporte mensual al IESS es de " + DatoCalculado + " ", "Aceptar");

            }
        }
    }

}
