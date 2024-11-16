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
	public partial class Saldo : Form
	{
		private System.Windows.Forms.Timer timer;

		public Saldo()
		{
			InitializeComponent();
			timer = new System.Windows.Forms.Timer();
			timer.Interval = 1000;
			timer.Tick += timer1_Tick;
			timer.Start();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void Saldo_Load(object sender, EventArgs e)
		{
			pcerrar.Visible = false;
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Close();
		}

		private void pictureBox3_Click_1(object sender, EventArgs e)
		{
			pagos p = new pagos();
			p.Show();
		}

		private void label15_Click(object sender, EventArgs e)
		{
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label15.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
		}

		private void label12_Click(object sender, EventArgs e)
		{

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

		private void label14_Click(object sender, EventArgs e)
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

		private void pictureBox5_Click_1(object sender, EventArgs e)
		{
			Menu m = new Menu();
			m.Show();
			this.Close();
		}
	}
}
