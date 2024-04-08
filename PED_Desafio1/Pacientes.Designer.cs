
namespace PED_Desafio1
{
    partial class Pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSangre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPresion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Operaciones = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxPacientes = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Operaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacientes Ingresados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Género";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxGenero.Location = new System.Drawing.Point(28, 68);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(192, 28);
            this.comboBoxGenero.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Sangre";
            // 
            // comboBoxSangre
            // 
            this.comboBoxSangre.FormattingEnabled = true;
            this.comboBoxSangre.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.comboBoxSangre.Location = new System.Drawing.Point(28, 143);
            this.comboBoxSangre.Name = "comboBoxSangre";
            this.comboBoxSangre.Size = new System.Drawing.Size(192, 28);
            this.comboBoxSangre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Presión";
            // 
            // comboBoxPresion
            // 
            this.comboBoxPresion.FormattingEnabled = true;
            this.comboBoxPresion.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.comboBoxPresion.Location = new System.Drawing.Point(28, 219);
            this.comboBoxPresion.Name = "comboBoxPresion";
            this.comboBoxPresion.Size = new System.Drawing.Size(192, 28);
            this.comboBoxPresion.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar Paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operaciones
            // 
            this.Operaciones.Controls.Add(this.button2);
            this.Operaciones.Controls.Add(this.button1);
            this.Operaciones.Controls.Add(this.label4);
            this.Operaciones.Controls.Add(this.comboBoxPresion);
            this.Operaciones.Controls.Add(this.label2);
            this.Operaciones.Controls.Add(this.label3);
            this.Operaciones.Controls.Add(this.comboBoxSangre);
            this.Operaciones.Controls.Add(this.comboBoxGenero);
            this.Operaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operaciones.Location = new System.Drawing.Point(523, 540);
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.Size = new System.Drawing.Size(693, 274);
            this.Operaciones.TabIndex = 9;
            this.Operaciones.TabStop = false;
            this.Operaciones.Text = "Operaciones";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 61);
            this.button2.TabIndex = 9;
            this.button2.Text = "Eliminar Paciente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxPacientes
            // 
            this.listBoxPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPacientes.FormattingEnabled = true;
            this.listBoxPacientes.ItemHeight = 18;
            this.listBoxPacientes.Location = new System.Drawing.Point(40, 615);
            this.listBoxPacientes.Name = "listBoxPacientes";
            this.listBoxPacientes.Size = new System.Drawing.Size(331, 184);
            this.listBoxPacientes.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(432, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(808, 481);
            this.treeView1.TabIndex = 13;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1283, 838);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxPacientes);
            this.Controls.Add(this.Operaciones);
            this.Controls.Add(this.label1);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Operaciones.ResumeLayout(false);
            this.Operaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSangre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPresion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Operaciones;
        private System.Windows.Forms.ListBox listBoxPacientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}