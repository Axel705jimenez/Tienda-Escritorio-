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
	public partial class Catacio : Form
	{
		public Catacio()
		{
			InitializeComponent();
		}

		private void label2_Click_1(object sender, EventArgs e)
		{
			if (pmenu.Visible)
			{
				pmenu.Visible = false;
			}
			else
			{
				pmenu.Visible = true;
			}
		}

		private void Catacio_Load(object sender, EventArgs e)
		{
			pmenu.Visible = false;
			panel2.Visible = false;
			panel3.Visible = false;
			panel4.Visible = false;
			pcerrar.Visible = false;
		}

		private void pictureBox7_Click_1(object sender, EventArgs e)
		{
			if (pmenu.Visible)
			{
				pmenu.Visible = false;
			}
			else
			{
				pmenu.Visible = true;
			}
		}

		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel1.Visible = true;
			panel2.Visible = false;
			panel3.Visible = false;
			panel4.Visible = false;
		}

		private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel2.Visible = true;
			panel3.Visible = false;
			panel4.Visible = false;
		}

		private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel3.Visible = true;
			panel4.Visible = false;
		}

		private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel4.Visible = true;
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pmenu_Paint(object sender, PaintEventArgs e)
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

		private void pictureBox13_Click(object sender, EventArgs e)
		{
			Carrito c = new Carrito();
			c.Show();
			this.Close();
		}
	}
}
