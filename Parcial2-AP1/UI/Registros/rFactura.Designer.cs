namespace Parcial2_AP1.UI.Registros
{
    partial class rFactura
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Totallabel = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(25, 22);
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
            this.FechadateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.FechadateTimePicker.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 138);
            this.dataGridView1.TabIndex = 3;
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
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::Parcial2_AP1.Properties.Resources.cancelar_opt;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(28, 340);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(106, 23);
            this.Removerbutton.TabIndex = 6;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial2_AP1.Properties.Resources.buscar20px;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(163, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(76, 23);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // rFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 476);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.IDlabel);
            this.MaximizeBox = false;
            this.Name = "rFactura";
            this.Text = "Registro de Factura";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
    }
}