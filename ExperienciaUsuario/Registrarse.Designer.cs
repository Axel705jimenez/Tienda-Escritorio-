namespace ExperienciaUsuario
{
	partial class Registrarse
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrarse));
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			txtUsername = new TextBox();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			linkLabel1 = new LinkLabel();
			pictureBox3 = new PictureBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			textBox6 = new TextBox();
			textBox7 = new TextBox();
			btnIniciarSesion = new Button();
			button1 = new Button();
			button2 = new Button();
			pictureBox4 = new PictureBox();
			pictureBox5 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1193, 642);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources.pixelcut_export;
			pictureBox2.Location = new Point(366, 28);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(453, 587);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// txtUsername
			// 
			txtUsername.BackColor = Color.FromArgb(231, 232, 232);
			txtUsername.BorderStyle = BorderStyle.None;
			txtUsername.Font = new Font("Segoe UI", 10F);
			txtUsername.Location = new Point(437, 159);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(306, 23);
			txtUsername.TabIndex = 7;
			txtUsername.Text = "axeljimenez";
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.FromArgb(231, 232, 232);
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Font = new Font("Segoe UI", 10F);
			textBox1.Location = new Point(437, 243);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(306, 23);
			textBox1.TabIndex = 8;
			textBox1.Text = "axel@gmail.com";
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.FromArgb(231, 232, 232);
			textBox2.BorderStyle = BorderStyle.None;
			textBox2.Font = new Font("Segoe UI", 10F);
			textBox2.Location = new Point(437, 330);
			textBox2.Name = "textBox2";
			textBox2.PasswordChar = '*';
			textBox2.Size = new Size(306, 23);
			textBox2.TabIndex = 9;
			textBox2.Text = "123456";
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.BackColor = Color.FromArgb(245, 246, 246);
			linkLabel1.Font = new Font("Modern No. 20", 12F, FontStyle.Bold);
			linkLabel1.ForeColor = Color.Coral;
			linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
			linkLabel1.LinkColor = SystemColors.HotTrack;
			linkLabel1.Location = new Point(538, 559);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(133, 22);
			linkLabel1.TabIndex = 10;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Iniciar sesión";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// pictureBox3
			// 
			pictureBox3.BackColor = Color.White;
			pictureBox3.Location = new Point(381, 385);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(421, 122);
			pictureBox3.TabIndex = 11;
			pictureBox3.TabStop = false;
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.White;
			textBox3.BorderStyle = BorderStyle.None;
			textBox3.Font = new Font("Segoe UI", 10F);
			textBox3.Location = new Point(433, 214);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(306, 23);
			textBox3.TabIndex = 12;
			textBox3.Text = "Correo";
			// 
			// textBox4
			// 
			textBox4.BackColor = Color.White;
			textBox4.BorderStyle = BorderStyle.None;
			textBox4.Font = new Font("Segoe UI", 10F);
			textBox4.Location = new Point(433, 301);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(306, 23);
			textBox4.TabIndex = 13;
			textBox4.Text = "Contraseña";
			// 
			// textBox5
			// 
			textBox5.BackColor = Color.White;
			textBox5.BorderStyle = BorderStyle.None;
			textBox5.Font = new Font("Segoe UI", 10F);
			textBox5.Location = new Point(433, 121);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(306, 23);
			textBox5.TabIndex = 14;
			textBox5.Text = "Usuario";
			// 
			// textBox6
			// 
			textBox6.BackColor = Color.White;
			textBox6.BorderStyle = BorderStyle.None;
			textBox6.Font = new Font("Segoe UI", 10F);
			textBox6.Location = new Point(433, 385);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(306, 23);
			textBox6.TabIndex = 15;
			textBox6.Text = "Comprobante de domicilio";
			textBox6.TextChanged += textBox6_TextChanged;
			// 
			// textBox7
			// 
			textBox7.BackColor = Color.White;
			textBox7.BorderStyle = BorderStyle.None;
			textBox7.Font = new Font("Segoe UI", 10F);
			textBox7.Location = new Point(433, 442);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(306, 23);
			textBox7.TabIndex = 16;
			textBox7.Text = "Identificación(INE)";
			// 
			// btnIniciarSesion
			// 
			btnIniciarSesion.BackColor = Color.FromArgb(80, 154, 254);
			btnIniciarSesion.FlatStyle = FlatStyle.Flat;
			btnIniciarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnIniciarSesion.ForeColor = SystemColors.ButtonFace;
			btnIniciarSesion.Location = new Point(433, 508);
			btnIniciarSesion.Name = "btnIniciarSesion";
			btnIniciarSesion.Size = new Size(329, 48);
			btnIniciarSesion.TabIndex = 3;
			btnIniciarSesion.Text = "REGISTRARSE";
			btnIniciarSesion.UseVisualStyleBackColor = false;
			btnIniciarSesion.Click += btnIniciarSesion_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.Gray;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = SystemColors.ButtonFace;
			button1.Location = new Point(433, 414);
			button1.Name = "button1";
			button1.Size = new Size(204, 29);
			button1.TabIndex = 17;
			button1.Text = "Adjuntar PDF";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.Gray;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = SystemColors.ButtonFace;
			button2.Location = new Point(433, 471);
			button2.Name = "button2";
			button2.Size = new Size(204, 29);
			button2.TabIndex = 18;
			button2.Text = "Adjuntar PDF";
			button2.UseVisualStyleBackColor = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = Properties.Resources.Captura_de_pantalla_2024_11_08_174845;
			pictureBox4.Location = new Point(698, 389);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(60, 58);
			pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 19;
			pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new Point(699, 449);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(60, 58);
			pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 20;
			pictureBox5.TabStop = false;
			// 
			// Registrarse
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1193, 642);
			Controls.Add(pictureBox5);
			Controls.Add(pictureBox4);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox7);
			Controls.Add(textBox6);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(btnIniciarSesion);
			Controls.Add(pictureBox3);
			Controls.Add(linkLabel1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(txtUsername);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Name = "Registrarse";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Registrarse";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private TextBox txtUsername;
		private TextBox textBox1;
		private TextBox textBox2;
		private LinkLabel linkLabel1;
		private PictureBox pictureBox3;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox textBox6;
		private TextBox textBox7;
		private Button btnIniciarSesion;
		private Button button1;
		private Button button2;
		private PictureBox pictureBox4;
		private PictureBox pictureBox5;
	}
}