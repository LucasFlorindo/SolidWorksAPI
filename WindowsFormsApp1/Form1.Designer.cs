
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnAbrirSW = new System.Windows.Forms.Button();
            this.Visivel = new System.Windows.Forms.CheckBox();
            this.btnFecharSW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirSW
            // 
            this.btnAbrirSW.Location = new System.Drawing.Point(12, 66);
            this.btnAbrirSW.Name = "btnAbrirSW";
            this.btnAbrirSW.Size = new System.Drawing.Size(118, 65);
            this.btnAbrirSW.TabIndex = 0;
            this.btnAbrirSW.Text = "Abrir SW";
            this.btnAbrirSW.UseVisualStyleBackColor = true;
            this.btnAbrirSW.Click += new System.EventHandler(this.btnAbrirSW_Click);
            // 
            // Visivel
            // 
            this.Visivel.AutoSize = true;
            this.Visivel.Location = new System.Drawing.Point(153, 89);
            this.Visivel.Name = "Visivel";
            this.Visivel.Size = new System.Drawing.Size(70, 21);
            this.Visivel.TabIndex = 1;
            this.Visivel.Text = "Visível";
            this.Visivel.UseVisualStyleBackColor = true;
            this.Visivel.CheckedChanged += new System.EventHandler(this.chkinv_CheckedChanged);
            // 
            // btnFecharSW
            // 
            this.btnFecharSW.Location = new System.Drawing.Point(12, 237);
            this.btnFecharSW.Name = "btnFecharSW";
            this.btnFecharSW.Size = new System.Drawing.Size(118, 65);
            this.btnFecharSW.TabIndex = 2;
            this.btnFecharSW.Text = "Fechar SW";
            this.btnFecharSW.UseVisualStyleBackColor = true;
            this.btnFecharSW.Click += new System.EventHandler(this.btnFecharSW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.btnFecharSW);
            this.Controls.Add(this.Visivel);
            this.Controls.Add(this.btnAbrirSW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirSW;
        private System.Windows.Forms.CheckBox Visivel;
        private System.Windows.Forms.Button btnFecharSW;
    }
}

