namespace ExperienciaUsuario
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			btnIniciarSesion = new Button();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			txtUsername = new TextBox();
			txtContraseña = new TextBox();
			pictureBox2 = new PictureBox();
			linkLabel1 = new LinkLabel();
			tableLayoutPanel1 = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// btnIniciarSesion
			// 
			btnIniciarSesion.BackColor = Color.FromArgb(80, 154, 254);
			btnIniciarSesion.FlatStyle = FlatStyle.Flat;
			btnIniciarSesion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnIniciarSesion.ForeColor = SystemColors.ButtonFace;
			btnIniciarSesion.Location = new Point(429, 400);
			btnIniciarSesion.Name = "btnIniciarSesion";
			btnIniciarSesion.Size = new Size(322, 58);
			btnIniciarSesion.TabIndex = 3;
			btnIniciarSesion.Text = "INICIAR SESION";
			btnIniciarSesion.UseVisualStyleBackColor = false;
			btnIniciarSesion.Click += button1_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.BackgroundImage = Properties.Resources.login_transformed;
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(344, 95);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(489, 461);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.BackColor = Color.Gainsboro;
			label1.Location = new Point(436, 242);
			label1.Name = "label1";
			label1.Size = new Size(306, 34);
			label1.TabIndex = 4;
			label1.Text = "axeljimenez";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			label2.BackColor = Color.Gainsboro;
			label2.Location = new Point(436, 338);
			label2.Name = "label2";
			label2.Size = new Size(306, 34);
			label2.TabIndex = 5;
			label2.Text = "Admin";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtUsername
			// 
			txtUsername.BackColor = Color.Gainsboro;
			txtUsername.BorderStyle = BorderStyle.None;
			txtUsername.Font = new Font("Segoe UI", 10F);
			txtUsername.Location = new Point(436, 247);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(306, 23);
			txtUsername.TabIndex = 1;
			// 
			// txtContraseña
			// 
			txtContraseña.BackColor = Color.Gainsboro;
			txtContraseña.BorderStyle = BorderStyle.None;
			txtContraseña.Font = new Font("Segoe UI", 10F);
			txtContraseña.Location = new Point(436, 346);
			txtContraseña.Name = "txtContraseña";
			txtContraseña.PasswordChar = '*';
			txtContraseña.Size = new Size(306, 23);
			txtContraseña.TabIndex = 2;
			txtContraseña.KeyDown += txtContraseña_KeyDown;
			// 
			// pictureBox2
			// 
			pictureBox2.Dock = DockStyle.Fill;
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(0, 0);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(1189, 638);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.BackColor = Color.FromArgb(234, 234, 230);
			linkLabel1.Font = new Font("Modern No. 20", 12F, FontStyle.Bold);
			linkLabel1.ForeColor = Color.Coral;
			linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
			linkLabel1.LinkColor = SystemColors.HotTrack;
			linkLabel1.Location = new Point(545, 495);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(123, 22);
			linkLabel1.TabIndex = 4;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Crear cuenta";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.57143F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.42857F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 252F));
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.3049F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.6951F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 191F));
			tableLayoutPanel1.Size = new Size(1189, 638);
			tableLayoutPanel1.TabIndex = 9;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(1189, 638);
			Controls.Add(linkLabel1);
			Controls.Add(txtContraseña);
			Controls.Add(txtUsername);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnIniciarSesion);
			Controls.Add(pictureBox1);
			Controls.Add(pictureBox2);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Form1_Load;
			KeyDown += Form1_KeyDown;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnIniciarSesion;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private TextBox txtUsername;
		private TextBox txtContraseña;
		private PictureBox pictureBox2;
		private LinkLabel linkLabel1;
		private TableLayoutPanel tableLayoutPanel1;
	}
}
