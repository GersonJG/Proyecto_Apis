namespace Proyecto_Apis
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
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
            BotonBuscar = new Button();
            textBoxId = new TextBox();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            labelPrecioMin = new Label();
            Botonform2 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            BotonLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(525, 53);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(108, 24);
            BotonBuscar.TabIndex = 0;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(269, 53);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(250, 23);
            textBoxId.TabIndex = 1;
            textBoxId.TextChanged += textBox1_TextChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Verdana", 12F, FontStyle.Bold);
            labelTitulo.Location = new Point(376, 86);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(60, 18);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "label1";
            labelTitulo.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 255, 192);
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(232, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.Location = new Point(326, 329);
            label2.Name = "label2";
            label2.Size = new Size(159, 18);
            label2.TabIndex = 7;
            label2.Text = "Precio Mas Bajo: ";
            // 
            // labelPrecioMin
            // 
            labelPrecioMin.AutoSize = true;
            labelPrecioMin.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecioMin.Location = new Point(400, 350);
            labelPrecioMin.Name = "labelPrecioMin";
            labelPrecioMin.Size = new Size(0, 28);
            labelPrecioMin.TabIndex = 9;
            labelPrecioMin.Visible = false;
            // 
            // Botonform2
            // 
            Botonform2.Location = new Point(645, 349);
            Botonform2.Name = "Botonform2";
            Botonform2.Size = new Size(119, 29);
            Botonform2.TabIndex = 10;
            Botonform2.Text = "CLICK AQUI";
            Botonform2.UseVisualStyleBackColor = true;
            Botonform2.Click += Botonform2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 20);
            label1.Name = "label1";
            label1.Size = new Size(176, 19);
            label1.TabIndex = 11;
            label1.Text = "Buscar juego por ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 331);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 12;
            label3.Text = "No sabes el ID?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(366, 353);
            label4.Name = "label4";
            label4.Size = new Size(28, 23);
            label4.TabIndex = 13;
            label4.Text = "$.";
            label4.Click += label4_Click;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(61, 312);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(94, 54);
            BotonLimpiar.TabIndex = 14;
            BotonLimpiar.Text = "Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonLimpiar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Botonform2);
            Controls.Add(labelPrecioMin);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Controls.Add(textBoxId);
            Controls.Add(BotonBuscar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonBuscar;
        private TextBox textBoxId;
        private Label labelTitulo;
        private PictureBox pictureBox1;
        private Label label2;
        private Label labelPrecioMin;
        private Button Botonform2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button BotonLimpiar;
    }
}
