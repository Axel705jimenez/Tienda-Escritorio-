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
	public partial class Carrito : Form
	{
		public Carrito()
		{
			InitializeComponent();
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
			Catacio c = new Catacio();
			c.Show();
		}

		private void label2_Click(object sender, EventArgs e)
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
			pagos p = new pagos();
			p.Show();
		}

		private void pictureBox14_Click(object sender, EventArgs e)
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

		private void pictureBox9_Click(object sender, EventArgs e)
		{

		}

		private void Carrito_Load(object sender, EventArgs e)
		{
			pcerrar.Visible = false;

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			label5.Visible = false;
			pictureBox5.Visible = false;
			label1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			comboBox1.Visible = false;
			linkLabel1.Visible = false;
			pictureBox3.Visible = false; 
			label8.Visible = false;
			label4.Text = "0";
		}
	}
}