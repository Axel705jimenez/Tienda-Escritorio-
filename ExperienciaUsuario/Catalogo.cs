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
	public partial class Catalogo : Form
	{
		public Catalogo()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void Catalogo_Load(object sender, EventArgs e)
		{
			pmenu.Visible = false;
			panel2.Visible = false;
			panel3.Visible = false;
			panel4.Visible = false;

		}

		private void pictureBox7_Click(object sender, EventArgs e)
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

		private void siToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void picMenui_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
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

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel1.Visible = true;
			panel2.Visible = false;
			panel3.Visible = false;
			panel4.Visible = false;

		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel2.Visible = true;
			panel3.Visible = false;
			panel4.Visible = false;

		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel3.Visible = true;
			panel4.Visible = false;
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{

		}

		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel4.Visible = true;
		}

		private void label7_Click(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.Show();
			this.Close();
		}

		private void pictureBox13_Click(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("¿Desea iniciar sesión para continuar?",
																 "Iniciar sesión",
																 MessageBoxButtons.YesNo,
																 MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				Form1 c = new Form1();
				c.Show();
				this.Close();


			}
		}
	}
}
