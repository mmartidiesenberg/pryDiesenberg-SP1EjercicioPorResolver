namespace pryDiesenberg_SP1EjercicioPorResolver
{
    partial class frmNavegacion
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
            this.lblNav = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNav
            // 
            this.lblNav.AutoSize = true;
            this.lblNav.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNav.ForeColor = System.Drawing.Color.Indigo;
            this.lblNav.Location = new System.Drawing.Point(32, 118);
            this.lblNav.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNav.Name = "lblNav";
            this.lblNav.Size = new System.Drawing.Size(384, 24);
            this.lblNav.TabIndex = 0;
            this.lblNav.Text = "Comience a Navegar en Nuestra Página";
            // 
            // frmNavegacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(452, 305);
            this.Controls.Add(this.lblNav);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNavegacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navegación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNav;
    }
}