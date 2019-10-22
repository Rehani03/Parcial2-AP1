namespace Parcial2_AP1.UI.Registros
{
    partial class rVenta
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
            this.components = new System.ComponentModel.Container();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.Totallabel = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Estudiantelabel = new System.Windows.Forms.Label();
            this.EstudiantetextBox = new System.Windows.Forms.TextBox();
            this.Serviciopanel = new System.Windows.Forms.Panel();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.ServiciocomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Importelabel = new System.Windows.Forms.Label();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.Cantidadlabel = new System.Windows.Forms.Label();
            this.Serviciolabel = new System.Windows.Forms.Label();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            this.Serviciopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(5, 22);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(68, 15);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(89, 20);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(256, 20);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 0;
            this.Fechalabel.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(300, 14);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.FechadateTimePicker.TabIndex = 2;
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(8, 196);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.Size = new System.Drawing.Size(406, 138);
            this.DetalledataGridView.TabIndex = 3;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Location = new System.Drawing.Point(256, 348);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(31, 13);
            this.Totallabel.TabIndex = 0;
            this.Totallabel.Text = "Total";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(300, 343);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(101, 20);
            this.TotaltextBox.TabIndex = 4;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Parcial2_AP1.Properties.Resources.eliminar44px;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(300, 413);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(99, 51);
            this.Eliminarbutton.TabIndex = 9;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Parcial2_AP1.Properties.Resources.guardar44px;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(163, 413);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(99, 51);
            this.Guardarbutton.TabIndex = 8;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Parcial2_AP1.Properties.Resources.anadirOriginal38px_opt;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(28, 413);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(99, 51);
            this.Nuevobutton.TabIndex = 7;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::Parcial2_AP1.Properties.Resources.cancelar_opt;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(8, 340);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(106, 23);
            this.Removerbutton.TabIndex = 6;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial2_AP1.Properties.Resources.buscar20px;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(174, 11);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(76, 23);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Estudiantelabel
            // 
            this.Estudiantelabel.AutoSize = true;
            this.Estudiantelabel.Location = new System.Drawing.Point(5, 64);
            this.Estudiantelabel.Name = "Estudiantelabel";
            this.Estudiantelabel.Size = new System.Drawing.Size(57, 13);
            this.Estudiantelabel.TabIndex = 0;
            this.Estudiantelabel.Text = "Estudiante";
            // 
            // EstudiantetextBox
            // 
            this.EstudiantetextBox.Location = new System.Drawing.Point(68, 57);
            this.EstudiantetextBox.Name = "EstudiantetextBox";
            this.EstudiantetextBox.Size = new System.Drawing.Size(346, 20);
            this.EstudiantetextBox.TabIndex = 10;
            // 
            // Serviciopanel
            // 
            this.Serviciopanel.Controls.Add(this.Agregarbutton);
            this.Serviciopanel.Controls.Add(this.ImportetextBox);
            this.Serviciopanel.Controls.Add(this.PreciotextBox);
            this.Serviciopanel.Controls.Add(this.CantidadtextBox);
            this.Serviciopanel.Controls.Add(this.ServiciocomboBox);
            this.Serviciopanel.Controls.Add(this.label2);
            this.Serviciopanel.Controls.Add(this.label1);
            this.Serviciopanel.Controls.Add(this.Importelabel);
            this.Serviciopanel.Controls.Add(this.Preciolabel);
            this.Serviciopanel.Controls.Add(this.Cantidadlabel);
            this.Serviciopanel.Controls.Add(this.Serviciolabel);
            this.Serviciopanel.Location = new System.Drawing.Point(13, 92);
            this.Serviciopanel.Name = "Serviciopanel";
            this.Serviciopanel.Size = new System.Drawing.Size(401, 84);
            this.Serviciopanel.TabIndex = 11;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(311, 54);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 5;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(318, 28);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.ReadOnly = true;
            this.ImportetextBox.Size = new System.Drawing.Size(68, 20);
            this.ImportetextBox.TabIndex = 4;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(218, 28);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(62, 20);
            this.PreciotextBox.TabIndex = 3;
            this.PreciotextBox.TextChanged += new System.EventHandler(this.PreciotextBox_TextChanged);
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(112, 29);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(67, 20);
            this.CantidadtextBox.TabIndex = 2;
            // 
            // ServiciocomboBox
            // 
            this.ServiciocomboBox.FormattingEnabled = true;
            this.ServiciocomboBox.Location = new System.Drawing.Point(6, 29);
            this.ServiciocomboBox.Name = "ServiciocomboBox";
            this.ServiciocomboBox.Size = new System.Drawing.Size(80, 21);
            this.ServiciocomboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // Importelabel
            // 
            this.Importelabel.AutoSize = true;
            this.Importelabel.Location = new System.Drawing.Point(315, 12);
            this.Importelabel.Name = "Importelabel";
            this.Importelabel.Size = new System.Drawing.Size(42, 13);
            this.Importelabel.TabIndex = 0;
            this.Importelabel.Text = "Importe";
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Location = new System.Drawing.Point(215, 12);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(37, 13);
            this.Preciolabel.TabIndex = 0;
            this.Preciolabel.Text = "Precio";
            // 
            // Cantidadlabel
            // 
            this.Cantidadlabel.AutoSize = true;
            this.Cantidadlabel.Location = new System.Drawing.Point(109, 12);
            this.Cantidadlabel.Name = "Cantidadlabel";
            this.Cantidadlabel.Size = new System.Drawing.Size(49, 13);
            this.Cantidadlabel.TabIndex = 0;
            this.Cantidadlabel.Text = "Cantidad";
            // 
            // Serviciolabel
            // 
            this.Serviciolabel.AutoSize = true;
            this.Serviciolabel.Location = new System.Drawing.Point(3, 12);
            this.Serviciolabel.Name = "Serviciolabel";
            this.Serviciolabel.Size = new System.Drawing.Size(45, 13);
            this.Serviciolabel.TabIndex = 0;
            this.Serviciolabel.Text = "Servicio";
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // rVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 476);
            this.Controls.Add(this.Serviciopanel);
            this.Controls.Add(this.EstudiantetextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.Estudiantelabel);
            this.Controls.Add(this.IDlabel);
            this.MaximizeBox = false;
            this.Name = "rVenta";
            this.Text = "Registro de Factura";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            this.Serviciopanel.ResumeLayout(false);
            this.Serviciopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label Estudiantelabel;
        private System.Windows.Forms.TextBox EstudiantetextBox;
        private System.Windows.Forms.Panel Serviciopanel;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.ComboBox ServiciocomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Importelabel;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.Label Cantidadlabel;
        private System.Windows.Forms.Label Serviciolabel;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
    }
}