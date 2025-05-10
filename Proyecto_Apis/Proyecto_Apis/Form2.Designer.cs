namespace Proyecto_Apis
{
    partial class Form2
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
            textBox1 = new TextBox();
            BotonBuscar2 = new Button();
            dataGridView1 = new DataGridView();
            botonregresar = new Button();
            label1 = new Label();
            Botonlimpiar2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 23);
            textBox1.TabIndex = 0;
            // 
            // BotonBuscar2
            // 
            BotonBuscar2.Location = new Point(515, 52);
            BotonBuscar2.Name = "BotonBuscar2";
            BotonBuscar2.Size = new Size(130, 25);
            BotonBuscar2.TabIndex = 1;
            BotonBuscar2.Text = "Buscar";
            BotonBuscar2.UseVisualStyleBackColor = true;
            BotonBuscar2.Click += BotonBuscar2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(237, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(359, 265);
            dataGridView1.TabIndex = 2;
            // 
            // botonregresar
            // 
            botonregresar.Location = new Point(638, 345);
            botonregresar.Name = "botonregresar";
            botonregresar.Size = new Size(134, 34);
            botonregresar.TabIndex = 3;
            botonregresar.Text = "Regresar";
            botonregresar.UseVisualStyleBackColor = true;
            botonregresar.Click += botonregresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 20);
            label1.Name = "label1";
            label1.Size = new Size(241, 19);
            label1.TabIndex = 4;
            label1.Text = "Lista de Juegos por Nombre:";
            // 
            // Botonlimpiar2
            // 
            Botonlimpiar2.Location = new Point(96, 345);
            Botonlimpiar2.Name = "Botonlimpiar2";
            Botonlimpiar2.Size = new Size(95, 34);
            Botonlimpiar2.TabIndex = 5;
            Botonlimpiar2.Text = "Limpiar";
            Botonlimpiar2.UseVisualStyleBackColor = true;
            Botonlimpiar2.Click += Botonlimpiar2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Botonlimpiar2);
            Controls.Add(label1);
            Controls.Add(botonregresar);
            Controls.Add(dataGridView1);
            Controls.Add(BotonBuscar2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button BotonBuscar2;
        private DataGridView dataGridView1;
        private Button botonregresar;
        private Label label1;
        private Button Botonlimpiar2;
    }
}