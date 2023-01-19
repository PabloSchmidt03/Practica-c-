namespace Ej1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeColor.BackgroundImage = global::MiPrimeraAplicacion.Properties.Resources.WhatsApp_Image_2022_09_21_at_17_54_13;
            this.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor.Location = new System.Drawing.Point(52, 12);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(692, 54);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "Change color";
            this.btnChangeColor.UseVisualStyleBackColor = false;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeColor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion de prueba | Pablo Schmidt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChangeColor;
    }
}