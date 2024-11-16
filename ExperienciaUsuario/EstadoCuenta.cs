using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperienciaUsuario
{
	public partial class EstadoCuenta : Form
	{
		public EstadoCuenta()
		{
			InitializeComponent();
		}
		Menu m = new Menu();

		private void label18_Click(object sender, EventArgs e)
		{

		}

		private void EstadoCuenta_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Close();
		}

		private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Close();
		}

		private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?",
													 "Confirmar Cierre de Sesión",
													 MessageBoxButtons.YesNo,
													 MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				MessageBox.Show("Has cerrado sesión con éxito.");

				Form1 form = new Form1();
				form.Show();
				this.Close();


			}
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			m.Show();
			this.Close();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			if (pcerrar.Visible)
			{
				pcerrar.Visible = false;
			}
			else
			{
				pcerrar.Visible = true;
			}
		}

		private void pictureBox14_Click(object sender, EventArgs e)
		{
			if (pcerrar.Visible)
			{
				pcerrar.Visible = false;
			}
			else
			{
				pcerrar.Visible = true;
			}
		}
	}
}
