namespace UI
{
    partial class Generala
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_FinalizarPartida = new System.Windows.Forms.Button();
            this.button_IniciarPartida = new System.Windows.Forms.Button();
            this.groupBox_Dados = new System.Windows.Forms.GroupBox();
            this.checkBox_Dado5 = new System.Windows.Forms.CheckBox();
            this.checkBox_Dado4 = new System.Windows.Forms.CheckBox();
            this.checkBox_Dado3 = new System.Windows.Forms.CheckBox();
            this.checkBox_Dado2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Dado1 = new System.Windows.Forms.CheckBox();
            this.label_LanzadasRest = new System.Windows.Forms.Label();
            this.button_LanzarDados = new System.Windows.Forms.Button();
            this.groupBox_Jugador2 = new System.Windows.Forms.GroupBox();
            this.button_AplicarPuntosJug2 = new System.Windows.Forms.Button();
            this.dataGridView_Jugador2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Jugador1 = new System.Windows.Forms.GroupBox();
            this.button_AplicarPuntosJug1 = new System.Windows.Forms.Button();
            this.dataGridView_Jugador1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_NuevoPartida = new System.Windows.Forms.Button();
            this.button_BorrarPartida = new System.Windows.Forms.Button();
            this.dataGridView_ABMPartidas = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox_ABMPersonas = new System.Windows.Forms.GroupBox();
            this.dataGridView_ABMPersonas = new System.Windows.Forms.DataGridView();
            this.label_Persona_Nom = new System.Windows.Forms.Label();
            this.button_Borrar = new System.Windows.Forms.Button();
            this.label_Persona_Passw = new System.Windows.Forms.Label();
            this.button_Grabar = new System.Windows.Forms.Button();
            this.textBox_Persona_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Persona_Passw = new System.Windows.Forms.TextBox();
            this.button_Nuevo = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox_LogIn2 = new System.Windows.Forms.GroupBox();
            this.button_CanP2 = new System.Windows.Forms.Button();
            this.button_IngP2 = new System.Windows.Forms.Button();
            this.textBox_PassP2 = new System.Windows.Forms.TextBox();
            this.textBox_NomP2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_LogIn1 = new System.Windows.Forms.GroupBox();
            this.button_CanP1 = new System.Windows.Forms.Button();
            this.button_IngP1 = new System.Windows.Forms.Button();
            this.textBox_PassP1 = new System.Windows.Forms.TextBox();
            this.textBox_NomP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_Dados.SuspendLayout();
            this.groupBox_Jugador2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jugador2)).BeginInit();
            this.groupBox_Jugador1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jugador1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ABMPartidas)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox_ABMPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ABMPersonas)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox_LogIn2.SuspendLayout();
            this.groupBox_LogIn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 515);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_FinalizarPartida);
            this.tabPage1.Controls.Add(this.button_IniciarPartida);
            this.tabPage1.Controls.Add(this.groupBox_Dados);
            this.tabPage1.Controls.Add(this.groupBox_Jugador2);
            this.tabPage1.Controls.Add(this.groupBox_Jugador1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Juego";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_FinalizarPartida
            // 
            this.button_FinalizarPartida.Enabled = false;
            this.button_FinalizarPartida.Location = new System.Drawing.Point(109, 6);
            this.button_FinalizarPartida.Name = "button_FinalizarPartida";
            this.button_FinalizarPartida.Size = new System.Drawing.Size(95, 25);
            this.button_FinalizarPartida.TabIndex = 3;
            this.button_FinalizarPartida.Text = "Finalizar partida";
            this.button_FinalizarPartida.UseVisualStyleBackColor = true;
            this.button_FinalizarPartida.Click += new System.EventHandler(this.button_FinalizarPartida_Click);
            // 
            // button_IniciarPartida
            // 
            this.button_IniciarPartida.Enabled = false;
            this.button_IniciarPartida.Location = new System.Drawing.Point(8, 6);
            this.button_IniciarPartida.Name = "button_IniciarPartida";
            this.button_IniciarPartida.Size = new System.Drawing.Size(95, 25);
            this.button_IniciarPartida.TabIndex = 2;
            this.button_IniciarPartida.Text = "Iniciar partida";
            this.button_IniciarPartida.UseVisualStyleBackColor = true;
            this.button_IniciarPartida.Click += new System.EventHandler(this.button_IniciarPartida_Click);
            // 
            // groupBox_Dados
            // 
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado5);
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado4);
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado3);
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado2);
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado1);
            this.groupBox_Dados.Controls.Add(this.label_LanzadasRest);
            this.groupBox_Dados.Controls.Add(this.button_LanzarDados);
            this.groupBox_Dados.Enabled = false;
            this.groupBox_Dados.Location = new System.Drawing.Point(404, 37);
            this.groupBox_Dados.Name = "groupBox_Dados";
            this.groupBox_Dados.Size = new System.Drawing.Size(109, 440);
            this.groupBox_Dados.TabIndex = 1;
            this.groupBox_Dados.TabStop = false;
            this.groupBox_Dados.Text = "Dados";
            // 
            // checkBox_Dado5
            // 
            this.checkBox_Dado5.Image = global::UI.Properties.Resources._64px_dado5;
            this.checkBox_Dado5.Location = new System.Drawing.Point(14, 298);
            this.checkBox_Dado5.Name = "checkBox_Dado5";
            this.checkBox_Dado5.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado5.TabIndex = 12;
            this.checkBox_Dado5.UseVisualStyleBackColor = true;
            this.checkBox_Dado5.Click += new System.EventHandler(this.checkBox_Dado5_Click);
            // 
            // checkBox_Dado4
            // 
            this.checkBox_Dado4.Image = global::UI.Properties.Resources._64px_dado4;
            this.checkBox_Dado4.Location = new System.Drawing.Point(14, 233);
            this.checkBox_Dado4.Name = "checkBox_Dado4";
            this.checkBox_Dado4.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado4.TabIndex = 11;
            this.checkBox_Dado4.UseVisualStyleBackColor = true;
            this.checkBox_Dado4.Click += new System.EventHandler(this.checkBox_Dado4_Click);
            // 
            // checkBox_Dado3
            // 
            this.checkBox_Dado3.Image = global::UI.Properties.Resources._64px_dado3;
            this.checkBox_Dado3.Location = new System.Drawing.Point(14, 168);
            this.checkBox_Dado3.Name = "checkBox_Dado3";
            this.checkBox_Dado3.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado3.TabIndex = 10;
            this.checkBox_Dado3.UseVisualStyleBackColor = true;
            this.checkBox_Dado3.Click += new System.EventHandler(this.checkBox_Dado3_Click);
            // 
            // checkBox_Dado2
            // 
            this.checkBox_Dado2.Image = global::UI.Properties.Resources._64px_dado2;
            this.checkBox_Dado2.Location = new System.Drawing.Point(14, 103);
            this.checkBox_Dado2.Name = "checkBox_Dado2";
            this.checkBox_Dado2.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado2.TabIndex = 9;
            this.checkBox_Dado2.UseVisualStyleBackColor = true;
            this.checkBox_Dado2.Click += new System.EventHandler(this.checkBox_Dado2_Click);
            // 
            // checkBox_Dado1
            // 
            this.checkBox_Dado1.Image = global::UI.Properties.Resources._64px_dado1;
            this.checkBox_Dado1.Location = new System.Drawing.Point(14, 38);
            this.checkBox_Dado1.Name = "checkBox_Dado1";
            this.checkBox_Dado1.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado1.TabIndex = 8;
            this.checkBox_Dado1.UseVisualStyleBackColor = true;
            this.checkBox_Dado1.Click += new System.EventHandler(this.checkBox_Dado1_Click);
            // 
            // label_LanzadasRest
            // 
            this.label_LanzadasRest.AutoSize = true;
            this.label_LanzadasRest.Location = new System.Drawing.Point(6, 393);
            this.label_LanzadasRest.Name = "label_LanzadasRest";
            this.label_LanzadasRest.Size = new System.Drawing.Size(53, 13);
            this.label_LanzadasRest.TabIndex = 7;
            this.label_LanzadasRest.Text = "Lanz rest:";
            // 
            // button_LanzarDados
            // 
            this.button_LanzarDados.Location = new System.Drawing.Point(8, 409);
            this.button_LanzarDados.Name = "button_LanzarDados";
            this.button_LanzarDados.Size = new System.Drawing.Size(95, 25);
            this.button_LanzarDados.TabIndex = 6;
            this.button_LanzarDados.Text = "Lanzar dados";
            this.button_LanzarDados.UseVisualStyleBackColor = true;
            this.button_LanzarDados.Click += new System.EventHandler(this.button_LanzarDados_Click);
            // 
            // groupBox_Jugador2
            // 
            this.groupBox_Jugador2.Controls.Add(this.button_AplicarPuntosJug2);
            this.groupBox_Jugador2.Controls.Add(this.dataGridView_Jugador2);
            this.groupBox_Jugador2.Enabled = false;
            this.groupBox_Jugador2.Location = new System.Drawing.Point(519, 37);
            this.groupBox_Jugador2.Name = "groupBox_Jugador2";
            this.groupBox_Jugador2.Size = new System.Drawing.Size(390, 440);
            this.groupBox_Jugador2.TabIndex = 1;
            this.groupBox_Jugador2.TabStop = false;
            this.groupBox_Jugador2.Text = "Jugador 2:";
            // 
            // button_AplicarPuntosJug2
            // 
            this.button_AplicarPuntosJug2.Location = new System.Drawing.Point(6, 409);
            this.button_AplicarPuntosJug2.Name = "button_AplicarPuntosJug2";
            this.button_AplicarPuntosJug2.Size = new System.Drawing.Size(95, 25);
            this.button_AplicarPuntosJug2.TabIndex = 4;
            this.button_AplicarPuntosJug2.Text = "Aplicar puntos";
            this.button_AplicarPuntosJug2.UseVisualStyleBackColor = true;
            this.button_AplicarPuntosJug2.Click += new System.EventHandler(this.button_AplicarPuntosJug2_Click);
            // 
            // dataGridView_Jugador2
            // 
            this.dataGridView_Jugador2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Jugador2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView_Jugador2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Jugador2.Name = "dataGridView_Jugador2";
            this.dataGridView_Jugador2.Size = new System.Drawing.Size(378, 384);
            this.dataGridView_Jugador2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Combinación";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Puntos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBox_Jugador1
            // 
            this.groupBox_Jugador1.Controls.Add(this.button_AplicarPuntosJug1);
            this.groupBox_Jugador1.Controls.Add(this.dataGridView_Jugador1);
            this.groupBox_Jugador1.Enabled = false;
            this.groupBox_Jugador1.Location = new System.Drawing.Point(8, 37);
            this.groupBox_Jugador1.Name = "groupBox_Jugador1";
            this.groupBox_Jugador1.Size = new System.Drawing.Size(390, 440);
            this.groupBox_Jugador1.TabIndex = 0;
            this.groupBox_Jugador1.TabStop = false;
            this.groupBox_Jugador1.Text = "Jugador 1:";
            // 
            // button_AplicarPuntosJug1
            // 
            this.button_AplicarPuntosJug1.Location = new System.Drawing.Point(6, 409);
            this.button_AplicarPuntosJug1.Name = "button_AplicarPuntosJug1";
            this.button_AplicarPuntosJug1.Size = new System.Drawing.Size(95, 25);
            this.button_AplicarPuntosJug1.TabIndex = 3;
            this.button_AplicarPuntosJug1.Text = "Aplicar puntos";
            this.button_AplicarPuntosJug1.UseVisualStyleBackColor = true;
            this.button_AplicarPuntosJug1.Click += new System.EventHandler(this.button_AplicarPuntosJug1_Click);
            // 
            // dataGridView_Jugador1
            // 
            this.dataGridView_Jugador1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Jugador1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_Jugador1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Jugador1.Name = "dataGridView_Jugador1";
            this.dataGridView_Jugador1.Size = new System.Drawing.Size(378, 384);
            this.dataGridView_Jugador1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Combinación";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Puntos";
            this.Column3.Name = "Column3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_NuevoPartida);
            this.tabPage2.Controls.Add(this.button_BorrarPartida);
            this.tabPage2.Controls.Add(this.dataGridView_ABMPartidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Partidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_NuevoPartida
            // 
            this.button_NuevoPartida.Location = new System.Drawing.Point(98, 34);
            this.button_NuevoPartida.Name = "button_NuevoPartida";
            this.button_NuevoPartida.Size = new System.Drawing.Size(75, 23);
            this.button_NuevoPartida.TabIndex = 2;
            this.button_NuevoPartida.Text = "Nuevo";
            this.button_NuevoPartida.UseVisualStyleBackColor = true;
            this.button_NuevoPartida.Click += new System.EventHandler(this.button_NuevoPartida_Click);
            // 
            // button_BorrarPartida
            // 
            this.button_BorrarPartida.Location = new System.Drawing.Point(487, 80);
            this.button_BorrarPartida.Name = "button_BorrarPartida";
            this.button_BorrarPartida.Size = new System.Drawing.Size(75, 23);
            this.button_BorrarPartida.TabIndex = 1;
            this.button_BorrarPartida.Text = "Borrar partida";
            this.button_BorrarPartida.UseVisualStyleBackColor = true;
            this.button_BorrarPartida.Click += new System.EventHandler(this.button_BorrarPartida_Click);
            // 
            // dataGridView_ABMPartidas
            // 
            this.dataGridView_ABMPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ABMPartidas.Location = new System.Drawing.Point(98, 80);
            this.dataGridView_ABMPartidas.Name = "dataGridView_ABMPartidas";
            this.dataGridView_ABMPartidas.Size = new System.Drawing.Size(382, 183);
            this.dataGridView_ABMPartidas.TabIndex = 0;
            this.dataGridView_ABMPartidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ABMPartidas_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox_ABMPersonas);
            this.tabPage3.Controls.Add(this.button_Nuevo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(919, 489);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ABM Personas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox_ABMPersonas
            // 
            this.groupBox_ABMPersonas.Controls.Add(this.dataGridView_ABMPersonas);
            this.groupBox_ABMPersonas.Controls.Add(this.label_Persona_Nom);
            this.groupBox_ABMPersonas.Controls.Add(this.button_Borrar);
            this.groupBox_ABMPersonas.Controls.Add(this.label_Persona_Passw);
            this.groupBox_ABMPersonas.Controls.Add(this.button_Grabar);
            this.groupBox_ABMPersonas.Controls.Add(this.textBox_Persona_Nom);
            this.groupBox_ABMPersonas.Controls.Add(this.textBox_Persona_Passw);
            this.groupBox_ABMPersonas.Enabled = false;
            this.groupBox_ABMPersonas.Location = new System.Drawing.Point(39, 45);
            this.groupBox_ABMPersonas.Name = "groupBox_ABMPersonas";
            this.groupBox_ABMPersonas.Size = new System.Drawing.Size(544, 289);
            this.groupBox_ABMPersonas.TabIndex = 12;
            this.groupBox_ABMPersonas.TabStop = false;
            this.groupBox_ABMPersonas.Text = "ABM Personas";
            // 
            // dataGridView_ABMPersonas
            // 
            this.dataGridView_ABMPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ABMPersonas.Location = new System.Drawing.Point(29, 105);
            this.dataGridView_ABMPersonas.Name = "dataGridView_ABMPersonas";
            this.dataGridView_ABMPersonas.Size = new System.Drawing.Size(386, 160);
            this.dataGridView_ABMPersonas.TabIndex = 11;
            this.dataGridView_ABMPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ABMPersonas_CellClick);
            // 
            // label_Persona_Nom
            // 
            this.label_Persona_Nom.AutoSize = true;
            this.label_Persona_Nom.Location = new System.Drawing.Point(26, 37);
            this.label_Persona_Nom.Name = "label_Persona_Nom";
            this.label_Persona_Nom.Size = new System.Drawing.Size(99, 13);
            this.label_Persona_Nom.TabIndex = 4;
            this.label_Persona_Nom.Text = "Nombre de usuario:";
            // 
            // button_Borrar
            // 
            this.button_Borrar.Location = new System.Drawing.Point(421, 163);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(75, 23);
            this.button_Borrar.TabIndex = 10;
            this.button_Borrar.Text = "Borrar";
            this.button_Borrar.UseVisualStyleBackColor = true;
            this.button_Borrar.Click += new System.EventHandler(this.button_Borrar_Click);
            // 
            // label_Persona_Passw
            // 
            this.label_Persona_Passw.AutoSize = true;
            this.label_Persona_Passw.Location = new System.Drawing.Point(26, 60);
            this.label_Persona_Passw.Name = "label_Persona_Passw";
            this.label_Persona_Passw.Size = new System.Drawing.Size(64, 13);
            this.label_Persona_Passw.TabIndex = 5;
            this.label_Persona_Passw.Text = "Contraseña:";
            // 
            // button_Grabar
            // 
            this.button_Grabar.Location = new System.Drawing.Point(421, 134);
            this.button_Grabar.Name = "button_Grabar";
            this.button_Grabar.Size = new System.Drawing.Size(75, 23);
            this.button_Grabar.TabIndex = 9;
            this.button_Grabar.Text = "Grabar";
            this.button_Grabar.UseVisualStyleBackColor = true;
            this.button_Grabar.Click += new System.EventHandler(this.button_Grabar_Click);
            // 
            // textBox_Persona_Nom
            // 
            this.textBox_Persona_Nom.Location = new System.Drawing.Point(131, 34);
            this.textBox_Persona_Nom.Name = "textBox_Persona_Nom";
            this.textBox_Persona_Nom.Size = new System.Drawing.Size(149, 20);
            this.textBox_Persona_Nom.TabIndex = 6;
            // 
            // textBox_Persona_Passw
            // 
            this.textBox_Persona_Passw.Location = new System.Drawing.Point(131, 60);
            this.textBox_Persona_Passw.Name = "textBox_Persona_Passw";
            this.textBox_Persona_Passw.Size = new System.Drawing.Size(149, 20);
            this.textBox_Persona_Passw.TabIndex = 7;
            // 
            // button_Nuevo
            // 
            this.button_Nuevo.Location = new System.Drawing.Point(39, 16);
            this.button_Nuevo.Name = "button_Nuevo";
            this.button_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.button_Nuevo.TabIndex = 8;
            this.button_Nuevo.Text = "Nuevo";
            this.button_Nuevo.UseVisualStyleBackColor = true;
            this.button_Nuevo.Click += new System.EventHandler(this.button_Nuevo_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox_LogIn2);
            this.tabPage4.Controls.Add(this.groupBox_LogIn1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(919, 489);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Login";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox_LogIn2
            // 
            this.groupBox_LogIn2.Controls.Add(this.button_CanP2);
            this.groupBox_LogIn2.Controls.Add(this.button_IngP2);
            this.groupBox_LogIn2.Controls.Add(this.textBox_PassP2);
            this.groupBox_LogIn2.Controls.Add(this.textBox_NomP2);
            this.groupBox_LogIn2.Controls.Add(this.label3);
            this.groupBox_LogIn2.Controls.Add(this.label4);
            this.groupBox_LogIn2.Location = new System.Drawing.Point(340, 36);
            this.groupBox_LogIn2.Name = "groupBox_LogIn2";
            this.groupBox_LogIn2.Size = new System.Drawing.Size(278, 132);
            this.groupBox_LogIn2.TabIndex = 12;
            this.groupBox_LogIn2.TabStop = false;
            this.groupBox_LogIn2.Text = "LogIn2";
            // 
            // button_CanP2
            // 
            this.button_CanP2.Location = new System.Drawing.Point(190, 97);
            this.button_CanP2.Name = "button_CanP2";
            this.button_CanP2.Size = new System.Drawing.Size(75, 23);
            this.button_CanP2.TabIndex = 11;
            this.button_CanP2.Text = "Cancelar";
            this.button_CanP2.UseVisualStyleBackColor = true;
            // 
            // button_IngP2
            // 
            this.button_IngP2.Location = new System.Drawing.Point(15, 98);
            this.button_IngP2.Name = "button_IngP2";
            this.button_IngP2.Size = new System.Drawing.Size(75, 23);
            this.button_IngP2.TabIndex = 10;
            this.button_IngP2.Text = "Ingresar";
            this.button_IngP2.UseVisualStyleBackColor = true;
            this.button_IngP2.Click += new System.EventHandler(this.button_IngP2_Click);
            // 
            // textBox_PassP2
            // 
            this.textBox_PassP2.Location = new System.Drawing.Point(117, 51);
            this.textBox_PassP2.Name = "textBox_PassP2";
            this.textBox_PassP2.Size = new System.Drawing.Size(149, 20);
            this.textBox_PassP2.TabIndex = 9;
            // 
            // textBox_NomP2
            // 
            this.textBox_NomP2.Location = new System.Drawing.Point(117, 25);
            this.textBox_NomP2.Name = "textBox_NomP2";
            this.textBox_NomP2.Size = new System.Drawing.Size(149, 20);
            this.textBox_NomP2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre de usuario:";
            // 
            // groupBox_LogIn1
            // 
            this.groupBox_LogIn1.Controls.Add(this.button_CanP1);
            this.groupBox_LogIn1.Controls.Add(this.button_IngP1);
            this.groupBox_LogIn1.Controls.Add(this.textBox_PassP1);
            this.groupBox_LogIn1.Controls.Add(this.textBox_NomP1);
            this.groupBox_LogIn1.Controls.Add(this.label2);
            this.groupBox_LogIn1.Controls.Add(this.label1);
            this.groupBox_LogIn1.Location = new System.Drawing.Point(31, 36);
            this.groupBox_LogIn1.Name = "groupBox_LogIn1";
            this.groupBox_LogIn1.Size = new System.Drawing.Size(278, 132);
            this.groupBox_LogIn1.TabIndex = 1;
            this.groupBox_LogIn1.TabStop = false;
            this.groupBox_LogIn1.Text = "LogIn1";
            // 
            // button_CanP1
            // 
            this.button_CanP1.Location = new System.Drawing.Point(190, 97);
            this.button_CanP1.Name = "button_CanP1";
            this.button_CanP1.Size = new System.Drawing.Size(75, 23);
            this.button_CanP1.TabIndex = 11;
            this.button_CanP1.Text = "Cancelar";
            this.button_CanP1.UseVisualStyleBackColor = true;
            // 
            // button_IngP1
            // 
            this.button_IngP1.Location = new System.Drawing.Point(15, 98);
            this.button_IngP1.Name = "button_IngP1";
            this.button_IngP1.Size = new System.Drawing.Size(75, 23);
            this.button_IngP1.TabIndex = 10;
            this.button_IngP1.Text = "Ingresar";
            this.button_IngP1.UseVisualStyleBackColor = true;
            this.button_IngP1.Click += new System.EventHandler(this.button_IngP1_Click);
            // 
            // textBox_PassP1
            // 
            this.textBox_PassP1.Location = new System.Drawing.Point(117, 51);
            this.textBox_PassP1.Name = "textBox_PassP1";
            this.textBox_PassP1.Size = new System.Drawing.Size(149, 20);
            this.textBox_PassP1.TabIndex = 9;
            // 
            // textBox_NomP1
            // 
            this.textBox_NomP1.Location = new System.Drawing.Point(117, 25);
            this.textBox_NomP1.Name = "textBox_NomP1";
            this.textBox_NomP1.Size = new System.Drawing.Size(149, 20);
            this.textBox_NomP1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de usuario:";
            // 
            // Generala
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(927, 515);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Generala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego - Generala";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_Dados.ResumeLayout(false);
            this.groupBox_Dados.PerformLayout();
            this.groupBox_Jugador2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jugador2)).EndInit();
            this.groupBox_Jugador1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jugador1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ABMPartidas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox_ABMPersonas.ResumeLayout(false);
            this.groupBox_ABMPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ABMPersonas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox_LogIn2.ResumeLayout(false);
            this.groupBox_LogIn2.PerformLayout();
            this.groupBox_LogIn1.ResumeLayout(false);
            this.groupBox_LogIn1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_FinalizarPartida;
        private System.Windows.Forms.Button button_IniciarPartida;
        private System.Windows.Forms.GroupBox groupBox_Dados;
        private System.Windows.Forms.GroupBox groupBox_Jugador2;
        private System.Windows.Forms.GroupBox groupBox_Jugador1;
        private System.Windows.Forms.DataGridView dataGridView_Jugador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.CheckBox checkBox_Dado5;
        private System.Windows.Forms.CheckBox checkBox_Dado4;
        private System.Windows.Forms.CheckBox checkBox_Dado3;
        private System.Windows.Forms.CheckBox checkBox_Dado2;
        private System.Windows.Forms.CheckBox checkBox_Dado1;
        private System.Windows.Forms.Label label_LanzadasRest;
        private System.Windows.Forms.Button button_LanzarDados;
        private System.Windows.Forms.Button button_AplicarPuntosJug2;
        private System.Windows.Forms.DataGridView dataGridView_Jugador2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button_AplicarPuntosJug1;
        private System.Windows.Forms.DataGridView dataGridView_ABMPersonas;
        private System.Windows.Forms.Button button_Borrar;
        private System.Windows.Forms.Button button_Grabar;
        private System.Windows.Forms.Button button_Nuevo;
        private System.Windows.Forms.TextBox textBox_Persona_Passw;
        private System.Windows.Forms.TextBox textBox_Persona_Nom;
        private System.Windows.Forms.Label label_Persona_Passw;
        private System.Windows.Forms.Label label_Persona_Nom;
        private System.Windows.Forms.GroupBox groupBox_ABMPersonas;
        private System.Windows.Forms.Button button_BorrarPartida;
        private System.Windows.Forms.DataGridView dataGridView_ABMPartidas;
        private System.Windows.Forms.Button button_NuevoPartida;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox_LogIn1;
        private System.Windows.Forms.GroupBox groupBox_LogIn2;
        private System.Windows.Forms.Button button_CanP2;
        private System.Windows.Forms.Button button_IngP2;
        private System.Windows.Forms.TextBox textBox_PassP2;
        private System.Windows.Forms.TextBox textBox_NomP2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_CanP1;
        private System.Windows.Forms.Button button_IngP1;
        private System.Windows.Forms.TextBox textBox_PassP1;
        private System.Windows.Forms.TextBox textBox_NomP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

