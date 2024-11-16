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
	public partial class Registrarse : Form
	{
		public Registrarse()
		{
			InitializeComponent();
		}


		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnIniciarSesion_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
				string.IsNullOrWhiteSpace(textBox1.Text) ||
				string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("Por favor, rellene todos los campos.");
			}
			else
			{
				MessageBox.Show("Se enviará un correo de confirmación");
				Form1 f = new Form1();
				f.Show();
				this.Close();
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form1 f = new Form1();
			f.Show();
			this.Close();
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}

