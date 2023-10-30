
namespace Aplicacion_Windows_Forms
{
    partial class Formaempleado
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
            this.dataGridViewempleado = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textsalario = new System.Windows.Forms.TextBox();
            this.texthorario = new System.Windows.Forms.TextBox();
            this.textcorreo = new System.Windows.Forms.TextBox();
            this.texttelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.combopuesto = new System.Windows.Forms.ComboBox();
            this.textfecha = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelfecha = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewempleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewempleado
            // 
            this.dataGridViewempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewempleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fecha,
            this.Telefono,
            this.Correo,
            this.Puesto,
            this.Horario,
            this.Salario});
            this.dataGridViewempleado.Location = new System.Drawing.Point(0, 351);
            this.dataGridViewempleado.Name = "dataGridViewempleado";
            this.dataGridViewempleado.Size = new System.Drawing.Size(724, 124);
            this.dataGridViewempleado.TabIndex = 22;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Aplicacion_Windows_Forms.Properties.Resources.Fondo_para_wallpapers;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textsalario);
            this.groupBox1.Controls.Add(this.texthorario);
            this.groupBox1.Controls.Add(this.textcorreo);
            this.groupBox1.Controls.Add(this.texttelefono);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.combopuesto);
            this.groupBox1.Controls.Add(this.textfecha);
            this.groupBox1.Controls.Add(this.textnombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelfecha);
            this.groupBox1.Controls.Add(this.labelnombre);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Aplicacion_Windows_Forms.Properties.Resources.lupa;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(436, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 40);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Aplicacion_Windows_Forms.Properties.Resources.boton_editar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(360, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 40);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Aplicacion_Windows_Forms.Properties.Resources.eliminar1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(276, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 40);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Aplicacion_Windows_Forms.Properties.Resources.boton_mas;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(195, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 40);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textsalario
            // 
            this.textsalario.Location = new System.Drawing.Point(175, 242);
            this.textsalario.Name = "textsalario";
            this.textsalario.Size = new System.Drawing.Size(100, 20);
            this.textsalario.TabIndex = 21;
            // 
            // texthorario
            // 
            this.texthorario.Location = new System.Drawing.Point(146, 210);
            this.texthorario.Name = "texthorario";
            this.texthorario.Size = new System.Drawing.Size(100, 20);
            this.texthorario.TabIndex = 20;
            // 
            // textcorreo
            // 
            this.textcorreo.Location = new System.Drawing.Point(81, 155);
            this.textcorreo.Name = "textcorreo";
            this.textcorreo.Size = new System.Drawing.Size(100, 20);
            this.textcorreo.TabIndex = 18;
            // 
            // texttelefono
            // 
            this.texttelefono.Location = new System.Drawing.Point(80, 129);
            this.texttelefono.Name = "texttelefono";
            this.texttelefono.Size = new System.Drawing.Size(100, 20);
            this.texttelefono.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salario o tarifa por hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Horario de trabajo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Aplicacion_Windows_Forms.Properties.Resources.e669a8378bfdde37b3dfa6988702e7c4;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(360, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(104, 86);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Aplicacion_Windows_Forms.Properties.Resources.e7cedd23dc0b73fd307c4deff50889ff;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(418, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 91);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // combopuesto
            // 
            this.combopuesto.FormattingEnabled = true;
            this.combopuesto.Location = new System.Drawing.Point(69, 183);
            this.combopuesto.Name = "combopuesto";
            this.combopuesto.Size = new System.Drawing.Size(121, 21);
            this.combopuesto.TabIndex = 9;
            // 
            // textfecha
            // 
            this.textfecha.Location = new System.Drawing.Point(156, 96);
            this.textfecha.Name = "textfecha";
            this.textfecha.Size = new System.Drawing.Size(100, 20);
            this.textfecha.TabIndex = 8;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(81, 64);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(100, 20);
            this.textnombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "teléfono";
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.BackColor = System.Drawing.Color.Transparent;
            this.labelfecha.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecha.Location = new System.Drawing.Point(12, 96);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(138, 18);
            this.labelfecha.TabIndex = 2;
            this.labelfecha.Text = "Fecha de nacimiento";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.BackColor = System.Drawing.Color.Transparent;
            this.labelnombre.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(12, 67);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(60, 18);
            this.labelnombre.TabIndex = 0;
            this.labelnombre.Text = "Nombre";
            // 
            // Formaempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 469);
            this.Controls.Add(this.dataGridViewempleado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formaempleado";
            this.Text = "Formaempleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewempleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox combopuesto;
        private System.Windows.Forms.TextBox textfecha;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texthorario;
        private System.Windows.Forms.TextBox textcorreo;
        private System.Windows.Forms.TextBox texttelefono;
        private System.Windows.Forms.TextBox textsalario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
    }
}