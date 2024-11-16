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
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void panel1_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Saldo s = new Saldo();
			s.Show();
			this.Close();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_MouseClick(object sender, MouseEventArgs e)
		{
			Saldo s = new Saldo();
			s.Show();
			this.Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			EstadoCuenta ec = new EstadoCuenta();
			ec.Show();
			this.Close();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			aumento a = new aumento();
			a.Show();
			this.Close();
		}

		private void pictureBox5_Click_1(object sender, EventArgs e)
		{

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

		private void Menu_Load(object sender, EventArgs e)
		{
			pcerrar.Visible = false;
		}

		private void label10_Click(object sender, EventArgs e)
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

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			Catacio c = new Catacio();
			c.Show();
			this.Close();
		}
	}
}
