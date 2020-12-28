
namespace aeropuerto
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
            this.dgvpilotos = new System.Windows.Forms.DataGridView();
            this.lbpiloto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpilotos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpilotos
            // 
            this.dgvpilotos.AllowUserToResizeColumns = false;
            this.dgvpilotos.AllowUserToResizeRows = false;
            this.dgvpilotos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpilotos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvpilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpilotos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvpilotos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvpilotos.Location = new System.Drawing.Point(345, 133);
            this.dgvpilotos.Name = "dgvpilotos";
            this.dgvpilotos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpilotos.Size = new System.Drawing.Size(703, 158);
            this.dgvpilotos.TabIndex = 0;
            // 
            // lbpiloto
            // 
            this.lbpiloto.AutoSize = true;
            this.lbpiloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpiloto.Location = new System.Drawing.Point(562, 73);
            this.lbpiloto.Name = "lbpiloto";
            this.lbpiloto.Size = new System.Drawing.Size(247, 37);
            this.lbpiloto.TabIndex = 1;
            this.lbpiloto.Text = "Tabla de Pilotos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 709);
            this.Controls.Add(this.lbpiloto);
            this.Controls.Add(this.dgvpilotos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpilotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpilotos;
        private System.Windows.Forms.Label lbpiloto;
    }
}

