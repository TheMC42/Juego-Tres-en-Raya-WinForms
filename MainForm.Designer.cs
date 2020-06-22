/*
 * Creado por SharpDevelop.
 * Usuario: HP
 * Fecha: 17/06/2020
 * Hora: 11:39
 * 
 * Proyecto: Tres en Raya 
 */

using System.Windows.Forms;
namespace TresEnRaya
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJugador2 = new System.Windows.Forms.TextBox();
            this.txtJugador1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTablero1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.BtnTablero2 = new System.Windows.Forms.Button();
            this.BtnTablero3 = new System.Windows.Forms.Button();
            this.BtnTablero4 = new System.Windows.Forms.Button();
            this.BtnTablero5 = new System.Windows.Forms.Button();
            this.BtnTablero6 = new System.Windows.Forms.Button();
            this.BtnTablero7 = new System.Windows.Forms.Button();
            this.BtnTablero8 = new System.Windows.Forms.Button();
            this.BtnTablero9 = new System.Windows.Forms.Button();
            this.NombreJugadoresBox = new System.Windows.Forms.GroupBox();
            this.XGroupBox = new System.Windows.Forms.GroupBox();
            this.XJugador2Check = new System.Windows.Forms.RadioButton();
            this.XJugador1Check = new System.Windows.Forms.RadioButton();
            this.InicioGroupBox = new System.Windows.Forms.GroupBox();
            this.IniciaJugador2 = new System.Windows.Forms.RadioButton();
            this.IniciaJugador1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.NombreJugadoresBox.SuspendLayout();
            this.XGroupBox.SuspendLayout();
            this.InicioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jugador 2:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jugador 1:";
            // 
            // txtJugador2
            // 
            this.txtJugador2.AccessibleName = "txtJugador2";
            this.txtJugador2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJugador2.Location = new System.Drawing.Point(116, 53);
            this.txtJugador2.Name = "txtJugador2";
            this.txtJugador2.Size = new System.Drawing.Size(137, 22);
            this.txtJugador2.TabIndex = 1;
            this.txtJugador2.Text = "J2";
            // 
            // txtJugador1
            // 
            this.txtJugador1.AccessibleName = "txtJugador1";
            this.txtJugador1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJugador1.Location = new System.Drawing.Point(116, 25);
            this.txtJugador1.Name = "txtJugador1";
            this.txtJugador1.Size = new System.Drawing.Size(137, 22);
            this.txtJugador1.TabIndex = 1;
            this.txtJugador1.Text = "J1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.juegoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.reiniciarJuegoToolStripMenuItem});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoToolStripMenuItem.Text = "Nueva partida";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.NuevoToolStripMenuItemClick);
            // 
            // reiniciarJuegoToolStripMenuItem
            // 
            this.reiniciarJuegoToolStripMenuItem.Name = "reiniciarJuegoToolStripMenuItem";
            this.reiniciarJuegoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reiniciarJuegoToolStripMenuItem.Text = "Reiniciar Juego";
            this.reiniciarJuegoToolStripMenuItem.Click += new System.EventHandler(this.ReiniciarJuegoToolStripMenuItemClick);
            // 
            // BtnTablero1
            // 
            this.BtnTablero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablero1.Location = new System.Drawing.Point(375, 52);
            this.BtnTablero1.Name = "BtnTablero1";
            this.BtnTablero1.Size = new System.Drawing.Size(90, 90);
            this.BtnTablero1.TabIndex = 2;
            this.BtnTablero1.UseVisualStyleBackColor = true;
            this.BtnTablero1.Click += new System.EventHandler(this.BotonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            // 
            // BtnTablero2
            // 
            this.BtnTablero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablero2.Location = new System.Drawing.Point(471, 52);
            this.BtnTablero2.Name = "BtnTablero2";
            this.BtnTablero2.Size = new System.Drawing.Size(90, 90);
            this.BtnTablero2.TabIndex = 2;
            this.BtnTablero2.UseVisualStyleBackColor = true;
            this.BtnTablero2.Click += new System.EventHandler(this.BotonClick);
            // 
            // BtnTablero3
            // 
            this.BtnTablero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablero3.Location = new System.Drawing.Point(567, 52);
            this.BtnTablero3.Name = "BtnTablero3";
            this.BtnTablero3.Size = new System.Drawing.Size(90, 90);
            this.BtnTablero3.TabIndex = 2;
            this.BtnTablero3.UseVisualStyleBackColor = true;
            this.BtnTablero3.Click += new System.EventHandler(this.BotonClick);
            // 
            // BtnTablero4
            // 
            this.BtnTablero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablero4.Location = new System.Drawing.Point(375, 148);
            this.BtnTablero4.Name = "BtnTablero4";
            this.BtnTablero4.Size = new System.Drawing.Size(90, 90);
            this.BtnTablero4.TabIndex = 2;
            this.BtnTablero4.UseVisualStyleBackColor = true;
            this.BtnTablero4.Click += new System.EventHandler(this.BotonClick);
            // 
            // BtnTablero5
            // 
            this.BtnTablero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablero5.Location = new System.Drawing.Point(471, 148);
            this.BtnTablero5.Name = "BtnTablero5";
            this.BtnTablero5.Size = new System.Drawing.Size(90, 90);
            this.BtnTablero5.TabIndex = 2;
            this.BtnTablero5.UseVisualStyleBackColor = true;
            this.BtnTablero5.Click += new System.EventHandler(this.BotonClick);
            // 
            // BtnTablero6
            // 
            this.BtnTablero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablero6.Location = new System.Drawing.Point(567, 148);
            this.BtnTablero6.Name = "BtnTablero6";
            this.BtnTablero6.Size = new System.Drawing.Size(90, 90);
            this.BtnTablero6.TabIndex = 2;
            this.BtnTablero6.UseVisualStyleBackColor = true;
            this.BtnTablero6.Click += new System.EventHandler(this.BotonClick);
            // 
            // BtnTablero7
            // 
            this.BtnTablero7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablero7.Location = new System.Drawing.Point(375, 244);
            this.BtnTablero7.Name = "BtnTablero7";
            this.BtnTablero7.Size = new System.Drawing.Size(90, 90);
            this.BtnTablero7.TabIndex = 2;
            this.BtnTablero7.UseVisualStyleBackColor = true;
            this.BtnTablero7.Click += new System.EventHandler(this.BotonClick);
            // 
            // BtnTablero8
            // 
            this.BtnTablero8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablero8.Location = new System.Drawing.Point(471, 244);
            this.BtnTablero8.Name = "BtnTablero8";
            this.BtnTablero8.Size = new System.Drawing.Size(90, 90);
            this.BtnTablero8.TabIndex = 2;
            this.BtnTablero8.UseVisualStyleBackColor = true;
            this.BtnTablero8.Click += new System.EventHandler(this.BotonClick);
            // 
            // BtnTablero9
            // 
            this.BtnTablero9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTablero9.Location = new System.Drawing.Point(567, 244);
            this.BtnTablero9.Name = "BtnTablero9";
            this.BtnTablero9.Size = new System.Drawing.Size(90, 90);
            this.BtnTablero9.TabIndex = 2;
            this.BtnTablero9.UseVisualStyleBackColor = true;
            this.BtnTablero9.Click += new System.EventHandler(this.BotonClick);
            // 
            // NombreJugadoresBox
            // 
            this.NombreJugadoresBox.Controls.Add(this.label1);
            this.NombreJugadoresBox.Controls.Add(this.label2);
            this.NombreJugadoresBox.Controls.Add(this.txtJugador1);
            this.NombreJugadoresBox.Controls.Add(this.txtJugador2);
            this.NombreJugadoresBox.Location = new System.Drawing.Point(29, 52);
            this.NombreJugadoresBox.Name = "NombreJugadoresBox";
            this.NombreJugadoresBox.Size = new System.Drawing.Size(310, 90);
            this.NombreJugadoresBox.TabIndex = 3;
            this.NombreJugadoresBox.TabStop = false;
            this.NombreJugadoresBox.Text = "Alias";
            // 
            // XGroupBox
            // 
            this.XGroupBox.Controls.Add(this.XJugador2Check);
            this.XGroupBox.Controls.Add(this.XJugador1Check);
            this.XGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.XGroupBox.Location = new System.Drawing.Point(29, 148);
            this.XGroupBox.Name = "XGroupBox";
            this.XGroupBox.Size = new System.Drawing.Size(310, 90);
            this.XGroupBox.TabIndex = 4;
            this.XGroupBox.TabStop = false;
            this.XGroupBox.Text = "X para";
            // 
            // XJugador2Check
            // 
            this.XJugador2Check.Location = new System.Drawing.Point(127, 42);
            this.XJugador2Check.Name = "XJugador2Check";
            this.XJugador2Check.Size = new System.Drawing.Size(104, 24);
            this.XJugador2Check.TabIndex = 0;
            this.XJugador2Check.Text = "Jugador 2";
            this.XJugador2Check.UseVisualStyleBackColor = true;
            // 
            // XJugador1Check
            // 
            this.XJugador1Check.Checked = true;
            this.XJugador1Check.Location = new System.Drawing.Point(17, 42);
            this.XJugador1Check.Name = "XJugador1Check";
            this.XJugador1Check.Size = new System.Drawing.Size(104, 24);
            this.XJugador1Check.TabIndex = 0;
            this.XJugador1Check.TabStop = true;
            this.XJugador1Check.Text = "Jugador 1";
            this.XJugador1Check.UseVisualStyleBackColor = true;
            // 
            // InicioGroupBox
            // 
            this.InicioGroupBox.Controls.Add(this.IniciaJugador2);
            this.InicioGroupBox.Controls.Add(this.IniciaJugador1);
            this.InicioGroupBox.Location = new System.Drawing.Point(29, 250);
            this.InicioGroupBox.Name = "InicioGroupBox";
            this.InicioGroupBox.Size = new System.Drawing.Size(310, 84);
            this.InicioGroupBox.TabIndex = 4;
            this.InicioGroupBox.TabStop = false;
            this.InicioGroupBox.Text = "Primer Turno";
            // 
            // IniciaJugador2
            // 
            this.IniciaJugador2.Location = new System.Drawing.Point(127, 36);
            this.IniciaJugador2.Name = "IniciaJugador2";
            this.IniciaJugador2.Size = new System.Drawing.Size(104, 24);
            this.IniciaJugador2.TabIndex = 0;
            this.IniciaJugador2.Text = "Jugador 2";
            this.IniciaJugador2.UseVisualStyleBackColor = true;
            // 
            // IniciaJugador1
            // 
            this.IniciaJugador1.Checked = true;
            this.IniciaJugador1.Location = new System.Drawing.Point(17, 36);
            this.IniciaJugador1.Name = "IniciaJugador1";
            this.IniciaJugador1.Size = new System.Drawing.Size(104, 24);
            this.IniciaJugador1.TabIndex = 0;
            this.IniciaJugador1.TabStop = true;
            this.IniciaJugador1.Text = "Jugador 1";
            this.IniciaJugador1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(213, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desarrollado por: César Duque";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(678, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InicioGroupBox);
            this.Controls.Add(this.XGroupBox);
            this.Controls.Add(this.NombreJugadoresBox);
            this.Controls.Add(this.BtnTablero9);
            this.Controls.Add(this.BtnTablero6);
            this.Controls.Add(this.BtnTablero3);
            this.Controls.Add(this.BtnTablero8);
            this.Controls.Add(this.BtnTablero7);
            this.Controls.Add(this.BtnTablero5);
            this.Controls.Add(this.BtnTablero4);
            this.Controls.Add(this.BtnTablero2);
            this.Controls.Add(this.BtnTablero1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tres en Raya - Juego";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.NombreJugadoresBox.ResumeLayout(false);
            this.NombreJugadoresBox.PerformLayout();
            this.XGroupBox.ResumeLayout(false);
            this.InicioGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton IniciaJugador1;
		private System.Windows.Forms.RadioButton IniciaJugador2;
		private System.Windows.Forms.GroupBox InicioGroupBox;
		private System.Windows.Forms.RadioButton XJugador1Check;
		private System.Windows.Forms.RadioButton XJugador2Check;
		private System.Windows.Forms.GroupBox XGroupBox;
		private System.Windows.Forms.GroupBox NombreJugadoresBox;
		private System.Windows.Forms.Button BtnTablero9;
		private System.Windows.Forms.Button BtnTablero8;
		private System.Windows.Forms.Button BtnTablero7;
		private System.Windows.Forms.Button BtnTablero6;
		private System.Windows.Forms.Button BtnTablero5;
		private System.Windows.Forms.Button BtnTablero4;
		private System.Windows.Forms.Button BtnTablero3;
		private System.Windows.Forms.Button BtnTablero2;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button BtnTablero1;
		private System.Windows.Forms.ToolStripMenuItem reiniciarJuegoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtJugador1;
		private System.Windows.Forms.TextBox txtJugador2;
		
		//Funcion salir del programa
		void SalirToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		//Carga del formulario
		void MainFormLoad(object sender, System.EventArgs e)
		{
			//Inicia los botones desactivados
			ActivarBotones(false);
			
			nuevoToolStripMenuItem.Enabled = true;
			reiniciarJuegoToolStripMenuItem.Enabled = false;//Opcion desactivada
		}
		
		void NuevoToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			//Inicia los botones activados
			ActivarBotones(true);
			
			nuevoToolStripMenuItem.Enabled = false;
			reiniciarJuegoToolStripMenuItem.Enabled = true;
			
			//Habilita a los jugadores
			ActivarOpcionesJugador(false);
			
			TurnoJugadorUno = IniciaJugador1.Checked;
			contadorClicks = 0;
		}
		
		void ReiniciarJuegoToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			ReiniciarJuego();
		}
		
		private void ReiniciarJuego()
		{
			ActivarBotones(false);
			
			nuevoToolStripMenuItem.Enabled = true;
			reiniciarJuegoToolStripMenuItem.Enabled = false;
			
			ActivarOpcionesJugador(true);
			
			LimpiarBotones();
		}
		
		private void LimpiarBotones()
		{
			BtnTablero1.Text = "";
			BtnTablero2.Text = "";
			BtnTablero3.Text = "";
			BtnTablero4.Text = "";
			BtnTablero5.Text = "";
			BtnTablero6.Text = "";
			BtnTablero7.Text = "";
			BtnTablero8.Text = "";
			BtnTablero9.Text = "";
		}
		
		private void ActivarBotones(bool enable)
		{
			BtnTablero1.Enabled = enable;
			BtnTablero2.Enabled = enable;
			BtnTablero3.Enabled = enable;
			BtnTablero4.Enabled = enable;
			BtnTablero5.Enabled = enable;
			BtnTablero6.Enabled = enable;
			BtnTablero7.Enabled = enable;
			BtnTablero8.Enabled = enable;
			BtnTablero9.Enabled = enable;
		}
		
		private void ActivarOpcionesJugador(bool enable)
		{
			NombreJugadoresBox.Enabled = enable;
			InicioGroupBox.Enabled = enable;
			XGroupBox.Enabled = enable;
			
		}
		
		void BotonClick(object sender, System.EventArgs e)
		{
			Button b = (Button)sender;
			if (TurnoJugadorUno == true) {
				if (XJugador1Check.Checked) {
					b.Text = "X";
				}else{
					b.Text = "O";
				}
				
				TurnoJugadorUno = false;
				b.Enabled = false;
			}else{
				if (XJugador2Check.Checked) {
					b.Text = "X";
					
				}else{
					b.Text = "O";
					
				}
				
				TurnoJugadorUno = true;
				b.Enabled = false;
			}
			contadorClicks++;
			
			VerificarGanador();
		}
		
		private void VerificarGanador()
		{
			
			////			txtJugador1 = txtJugador1.Text;
			////			txtJugador2= txtJugador2.Text;
		
//			if(contadorClicks == 9){
//				MessageBox.Show("Sin ganador, el juego quedo empate", "Juego terminado", MessageBoxButtons.OK);
//				ReiniciarJuego();
//			}else
//			{
			bool banderaGanador = false;
			if(   ((BtnTablero1.Text == BtnTablero2.Text && BtnTablero2.Text == BtnTablero3.Text) && !BtnTablero1.Enabled)
			   || ((BtnTablero4.Text == BtnTablero5.Text && BtnTablero5.Text == BtnTablero6.Text) && !BtnTablero4.Enabled)
			   || ((BtnTablero7.Text == BtnTablero8.Text && BtnTablero8.Text == BtnTablero9.Text) && !BtnTablero7.Enabled)
			   
			   || ((BtnTablero1.Text == BtnTablero4.Text && BtnTablero4.Text == BtnTablero7.Text) && !BtnTablero1.Enabled)
			   || ((BtnTablero2.Text == BtnTablero5.Text && BtnTablero5.Text == BtnTablero8.Text) && !BtnTablero2.Enabled)
			   || ((BtnTablero3.Text == BtnTablero6.Text && BtnTablero6.Text == BtnTablero9.Text) && !BtnTablero3.Enabled)
			   
			   || ((BtnTablero1.Text == BtnTablero5.Text && BtnTablero5.Text == BtnTablero9.Text) && !BtnTablero1.Enabled)
			   || ((BtnTablero3.Text == BtnTablero5.Text && BtnTablero5.Text == BtnTablero7.Text) && !BtnTablero3.Enabled)
			  )
				banderaGanador = true;
			
			if(banderaGanador==true)
			{
				if(TurnoJugadorUno == false)
				{
					MessageBox.Show(txtJugador1.Text+ " es el ganador", "Juego terminado", MessageBoxButtons.OK);
					ReiniciarJuego();
				}else
					MessageBox.Show(txtJugador2.Text+ " es el ganador", "Juego terminado", MessageBoxButtons.OK);
				ReiniciarJuego();
				
			}else if(contadorClicks == 9 && !banderaGanador){
				MessageBox.Show("Empate, sin ganador", "Juego terminado", MessageBoxButtons.OK);
				ReiniciarJuego();
			}
			
		}
	}

}
