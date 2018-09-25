namespace GUI_V_2
{
    partial class PruebasAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_box_num_prueba = new System.Windows.Forms.TextBox();
            this.combo_box_registro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combo_box_tecnico = new System.Windows.Forms.ComboBox();
            this.date_prueba = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.spiner_puntuacion = new System.Windows.Forms.NumericUpDown();
            this.spiner_horas = new System.Windows.Forms.NumericUpDown();
            this.spiner_calificacion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spiner_puntuacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiner_horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiner_calificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRUEBAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Prueba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Registro";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Horas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Puntuacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "DNI TECNICO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calificacion";
            // 
            // text_box_num_prueba
            // 
            this.text_box_num_prueba.Location = new System.Drawing.Point(171, 107);
            this.text_box_num_prueba.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.text_box_num_prueba.Name = "text_box_num_prueba";
            this.text_box_num_prueba.Size = new System.Drawing.Size(201, 20);
            this.text_box_num_prueba.TabIndex = 10;
            // 
            // combo_box_registro
            // 
            this.combo_box_registro.FormattingEnabled = true;
            this.combo_box_registro.Location = new System.Drawing.Point(171, 146);
            this.combo_box_registro.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.combo_box_registro.Name = "combo_box_registro";
            this.combo_box_registro.Size = new System.Drawing.Size(201, 21);
            this.combo_box_registro.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(511, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Buscar Tecnico";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // combo_box_tecnico
            // 
            this.combo_box_tecnico.FormattingEnabled = true;
            this.combo_box_tecnico.Location = new System.Drawing.Point(566, 138);
            this.combo_box_tecnico.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.combo_box_tecnico.Name = "combo_box_tecnico";
            this.combo_box_tecnico.Size = new System.Drawing.Size(201, 21);
            this.combo_box_tecnico.TabIndex = 15;
            // 
            // date_prueba
            // 
            this.date_prueba.Location = new System.Drawing.Point(171, 244);
            this.date_prueba.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.date_prueba.Name = "date_prueba";
            this.date_prueba.Size = new System.Drawing.Size(210, 20);
            this.date_prueba.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(171, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "CREAR PRUEBA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(566, 288);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(511, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Buscar Prueba";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(468, 291);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Numero de Prueba";
            // 
            // spiner_puntuacion
            // 
            this.spiner_puntuacion.Location = new System.Drawing.Point(171, 211);
            this.spiner_puntuacion.Name = "spiner_puntuacion";
            this.spiner_puntuacion.Size = new System.Drawing.Size(120, 20);
            this.spiner_puntuacion.TabIndex = 30;
            // 
            // spiner_horas
            // 
            this.spiner_horas.Location = new System.Drawing.Point(171, 278);
            this.spiner_horas.Name = "spiner_horas";
            this.spiner_horas.Size = new System.Drawing.Size(120, 20);
            this.spiner_horas.TabIndex = 31;
            // 
            // spiner_calificacion
            // 
            this.spiner_calificacion.Location = new System.Drawing.Point(171, 320);
            this.spiner_calificacion.Name = "spiner_calificacion";
            this.spiner_calificacion.Size = new System.Drawing.Size(120, 20);
            this.spiner_calificacion.TabIndex = 32;
            // 
            // PruebasAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 645);
            this.Controls.Add(this.spiner_calificacion);
            this.Controls.Add(this.spiner_horas);
            this.Controls.Add(this.spiner_puntuacion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_prueba);
            this.Controls.Add(this.combo_box_tecnico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combo_box_registro);
            this.Controls.Add(this.text_box_num_prueba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "PruebasAdd";
            this.Text = "Pruebas";
            this.Load += new System.EventHandler(this.Pruebas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spiner_puntuacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiner_horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiner_calificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_box_num_prueba;
        private System.Windows.Forms.ComboBox combo_box_registro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combo_box_tecnico;
        private System.Windows.Forms.DateTimePicker date_prueba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown spiner_puntuacion;
        private System.Windows.Forms.NumericUpDown spiner_horas;
        private System.Windows.Forms.NumericUpDown spiner_calificacion;
    }
}