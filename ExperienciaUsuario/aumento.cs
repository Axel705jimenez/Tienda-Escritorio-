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
	public partial class aumento : Form
	{
		public aumento()
		{
			InitializeComponent();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text) ||
				string.IsNullOrWhiteSpace(textBox2.Text) ||
				string.IsNullOrWhiteSpace(textBox3.Text))
			{
				MessageBox.Show("Por favor, rellene todos los campos.");
			}
			else
			{
				MessageBox.Show("Se ha enviado la solicitud, se le enviará un correo de aceptación");
				Menu m = new Menu();
				m.Show();
				this.Close();
			}

		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Close();
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void aumento_Load(object sender, EventArgs e)
		{
			pcerrar.Visible = false;
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

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

		private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Close();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Close();
		}
	}
}
