namespace Generala
{
    partial class Form1
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
            this.button_AplicarPuntosJug2 = new System.Windows.Forms.Button();
            this.groupBox_Jugador2 = new System.Windows.Forms.GroupBox();
            this.groupBox_Dados = new System.Windows.Forms.GroupBox();
            this.label_LanzadasRest = new System.Windows.Forms.Label();
            this.checkBox_Dado5 = new System.Windows.Forms.CheckBox();
            this.checkBox_Dado4 = new System.Windows.Forms.CheckBox();
            this.button_LanzarDados = new System.Windows.Forms.Button();
            this.checkBox_Dado3 = new System.Windows.Forms.CheckBox();
            this.checkBox_Dado2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Dado1 = new System.Windows.Forms.CheckBox();
            this.groupBox_Jugador1 = new System.Windows.Forms.GroupBox();
            this.button_AplicarPuntosJug1 = new System.Windows.Forms.Button();
            this.button_FinalizarPartida = new System.Windows.Forms.Button();
            this.button_IniciarPartida = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_Jugador1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_Jugador2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_Jugador2.SuspendLayout();
            this.groupBox_Dados.SuspendLayout();
            this.groupBox_Jugador1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jugador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jugador2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_Jugador2);
            this.tabPage1.Controls.Add(this.groupBox_Dados);
            this.tabPage1.Controls.Add(this.groupBox_Jugador1);
            this.tabPage1.Controls.Add(this.button_FinalizarPartida);
            this.tabPage1.Controls.Add(this.button_IniciarPartida);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Juego";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_AplicarPuntosJug2
            // 
            this.button_AplicarPuntosJug2.Location = new System.Drawing.Point(6, 409);
            this.button_AplicarPuntosJug2.Name = "button_AplicarPuntosJug2";
            this.button_AplicarPuntosJug2.Size = new System.Drawing.Size(95, 25);
            this.button_AplicarPuntosJug2.TabIndex = 1;
            this.button_AplicarPuntosJug2.Text = "Aplicar puntos";
            this.button_AplicarPuntosJug2.UseVisualStyleBackColor = true;
            this.button_AplicarPuntosJug2.Click += new System.EventHandler(this.button_AplicarPuntosJug2_Click);
            // 
            // groupBox_Jugador2
            // 
            this.groupBox_Jugador2.Controls.Add(this.dataGridView_Jugador2);
            this.groupBox_Jugador2.Controls.Add(this.button_AplicarPuntosJug2);
            this.groupBox_Jugador2.Enabled = false;
            this.groupBox_Jugador2.Location = new System.Drawing.Point(519, 37);
            this.groupBox_Jugador2.Name = "groupBox_Jugador2";
            this.groupBox_Jugador2.Size = new System.Drawing.Size(390, 440);
            this.groupBox_Jugador2.TabIndex = 4;
            this.groupBox_Jugador2.TabStop = false;
            this.groupBox_Jugador2.Text = "Jugador 2:";
            // 
            // groupBox_Dados
            // 
            this.groupBox_Dados.Controls.Add(this.label_LanzadasRest);
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado5);
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado4);
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado3);
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado2);
            this.groupBox_Dados.Controls.Add(this.button_LanzarDados);
            this.groupBox_Dados.Controls.Add(this.checkBox_Dado1);
            this.groupBox_Dados.Enabled = false;
            this.groupBox_Dados.Location = new System.Drawing.Point(404, 37);
            this.groupBox_Dados.Name = "groupBox_Dados";
            this.groupBox_Dados.Size = new System.Drawing.Size(109, 440);
            this.groupBox_Dados.TabIndex = 3;
            this.groupBox_Dados.TabStop = false;
            this.groupBox_Dados.Text = "Dados";
            // 
            // label_LanzadasRest
            // 
            this.label_LanzadasRest.AutoSize = true;
            this.label_LanzadasRest.Location = new System.Drawing.Point(6, 393);
            this.label_LanzadasRest.Name = "label_LanzadasRest";
            this.label_LanzadasRest.Size = new System.Drawing.Size(53, 13);
            this.label_LanzadasRest.TabIndex = 6;
            this.label_LanzadasRest.Text = "Lanz rest:";
            // 
            // checkBox_Dado5
            // 
            this.checkBox_Dado5.Image = global::Generala.Properties.Resources._64px_dado5;
            this.checkBox_Dado5.Location = new System.Drawing.Point(15, 318);
            this.checkBox_Dado5.Name = "checkBox_Dado5";
            this.checkBox_Dado5.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado5.TabIndex = 4;
            this.checkBox_Dado5.UseVisualStyleBackColor = true;
            this.checkBox_Dado5.Click += new System.EventHandler(this.checkBox_Dado5_Click);
            // 
            // checkBox_Dado4
            // 
            this.checkBox_Dado4.Image = global::Generala.Properties.Resources._64px_dado4;
            this.checkBox_Dado4.Location = new System.Drawing.Point(15, 244);
            this.checkBox_Dado4.Name = "checkBox_Dado4";
            this.checkBox_Dado4.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado4.TabIndex = 3;
            this.checkBox_Dado4.UseVisualStyleBackColor = true;
            this.checkBox_Dado4.Click += new System.EventHandler(this.checkBox_Dado4_Click);
            // 
            // button_LanzarDados
            // 
            this.button_LanzarDados.Location = new System.Drawing.Point(6, 409);
            this.button_LanzarDados.Name = "button_LanzarDados";
            this.button_LanzarDados.Size = new System.Drawing.Size(95, 25);
            this.button_LanzarDados.TabIndex = 5;
            this.button_LanzarDados.Text = "Lanzar dados";
            this.button_LanzarDados.UseVisualStyleBackColor = true;
            this.button_LanzarDados.Click += new System.EventHandler(this.button_LanzarDados_Click);
            // 
            // checkBox_Dado3
            // 
            this.checkBox_Dado3.Image = global::Generala.Properties.Resources._64px_dado3;
            this.checkBox_Dado3.Location = new System.Drawing.Point(15, 170);
            this.checkBox_Dado3.Name = "checkBox_Dado3";
            this.checkBox_Dado3.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado3.TabIndex = 2;
            this.checkBox_Dado3.UseVisualStyleBackColor = true;
            this.checkBox_Dado3.Click += new System.EventHandler(this.checkBox_Dado3_Click);
            // 
            // checkBox_Dado2
            // 
            this.checkBox_Dado2.Image = global::Generala.Properties.Resources._64px_dado2;
            this.checkBox_Dado2.Location = new System.Drawing.Point(15, 96);
            this.checkBox_Dado2.Name = "checkBox_Dado2";
            this.checkBox_Dado2.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado2.TabIndex = 1;
            this.checkBox_Dado2.UseVisualStyleBackColor = true;
            this.checkBox_Dado2.Click += new System.EventHandler(this.checkBox_Dado2_Click);
            // 
            // checkBox_Dado1
            // 
            this.checkBox_Dado1.Image = global::Generala.Properties.Resources._64px_dado1;
            this.checkBox_Dado1.Location = new System.Drawing.Point(15, 22);
            this.checkBox_Dado1.Name = "checkBox_Dado1";
            this.checkBox_Dado1.Size = new System.Drawing.Size(80, 65);
            this.checkBox_Dado1.TabIndex = 0;
            this.checkBox_Dado1.UseVisualStyleBackColor = true;
            this.checkBox_Dado1.Click += new System.EventHandler(this.checkBox_Dado1_Click);
            // 
            // groupBox_Jugador1
            // 
            this.groupBox_Jugador1.Controls.Add(this.dataGridView_Jugador1);
            this.groupBox_Jugador1.Controls.Add(this.button_AplicarPuntosJug1);
            this.groupBox_Jugador1.Enabled = false;
            this.groupBox_Jugador1.Location = new System.Drawing.Point(8, 37);
            this.groupBox_Jugador1.Name = "groupBox_Jugador1";
            this.groupBox_Jugador1.Size = new System.Drawing.Size(390, 440);
            this.groupBox_Jugador1.TabIndex = 2;
            this.groupBox_Jugador1.TabStop = false;
            this.groupBox_Jugador1.Text = "Jugador 1:";
            // 
            // button_AplicarPuntosJug1
            // 
            this.button_AplicarPuntosJug1.Location = new System.Drawing.Point(6, 409);
            this.button_AplicarPuntosJug1.Name = "button_AplicarPuntosJug1";
            this.button_AplicarPuntosJug1.Size = new System.Drawing.Size(95, 25);
            this.button_AplicarPuntosJug1.TabIndex = 0;
            this.button_AplicarPuntosJug1.Text = "Aplicar puntos";
            this.button_AplicarPuntosJug1.UseVisualStyleBackColor = true;
            this.button_AplicarPuntosJug1.Click += new System.EventHandler(this.button_AplicarPuntosJug1_Click);
            // 
            // button_FinalizarPartida
            // 
            this.button_FinalizarPartida.Location = new System.Drawing.Point(107, 6);
            this.button_FinalizarPartida.Name = "button_FinalizarPartida";
            this.button_FinalizarPartida.Size = new System.Drawing.Size(95, 25);
            this.button_FinalizarPartida.TabIndex = 1;
            this.button_FinalizarPartida.Text = "Finalizar partida";
            this.button_FinalizarPartida.UseVisualStyleBackColor = true;
            this.button_FinalizarPartida.Click += new System.EventHandler(this.button_FinalizarPartida_Click);
            // 
            // button_IniciarPartida
            // 
            this.button_IniciarPartida.Location = new System.Drawing.Point(6, 6);
            this.button_IniciarPartida.Name = "button_IniciarPartida";
            this.button_IniciarPartida.Size = new System.Drawing.Size(95, 25);
            this.button_IniciarPartida.TabIndex = 0;
            this.button_IniciarPartida.Text = "Iniciar partida";
            this.button_IniciarPartida.UseVisualStyleBackColor = true;
            this.button_IniciarPartida.Click += new System.EventHandler(this.button_IniciarPartida_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Partidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(866, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Usuarios";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.dataGridView_Jugador1.TabIndex = 1;
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
            this.dataGridView_Jugador2.TabIndex = 2;
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(927, 515);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generala";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_Jugador2.ResumeLayout(false);
            this.groupBox_Dados.ResumeLayout(false);
            this.groupBox_Dados.PerformLayout();
            this.groupBox_Jugador1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jugador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Jugador2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox_Jugador2;
        private System.Windows.Forms.GroupBox groupBox_Dados;
        private System.Windows.Forms.GroupBox groupBox_Jugador1;
        private System.Windows.Forms.Button button_FinalizarPartida;
        private System.Windows.Forms.Button button_IniciarPartida;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_LanzarDados;
        private System.Windows.Forms.Button button_AplicarPuntosJug2;
        private System.Windows.Forms.Button button_AplicarPuntosJug1;
        private System.Windows.Forms.CheckBox checkBox_Dado5;
        private System.Windows.Forms.CheckBox checkBox_Dado4;
        private System.Windows.Forms.CheckBox checkBox_Dado3;
        private System.Windows.Forms.CheckBox checkBox_Dado2;
        private System.Windows.Forms.CheckBox checkBox_Dado1;
        private System.Windows.Forms.Label label_LanzadasRest;
        private System.Windows.Forms.DataGridView dataGridView_Jugador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridView_Jugador2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

