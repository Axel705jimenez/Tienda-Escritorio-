namespace ExperienciaUsuario
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private string correctUsername = "usuario";
		private string correctPassword = "12345";

		private void button1_Click(object sender, EventArgs e)
		{
			string enteredUsername = txtUsername.Text;
			string enteredPassword = txtContraseña.Text;

			if (enteredUsername == correctUsername && enteredPassword == correctPassword)
			{
				Catacio c = new Catacio();
				c.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrecta");
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Registrarse r = new Registrarse();
			r.Show();
			this.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
	
		}

		private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnIniciarSesion.PerformClick();
			}
		}
	}
}
