namespace validaciones
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreIn = new System.Windows.Forms.TextBox();
            this.codigoIn = new System.Windows.Forms.TextBox();
            this.correoIn = new System.Windows.Forms.TextBox();
            this.btnValidacion = new System.Windows.Forms.Button();
            this.salida = new System.Windows.Forms.Label();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordIn = new System.Windows.Forms.TextBox();
            this.btnValPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // nombreIn
            // 
            this.nombreIn.Location = new System.Drawing.Point(153, 47);
            this.nombreIn.Name = "nombreIn";
            this.nombreIn.Size = new System.Drawing.Size(248, 22);
            this.nombreIn.TabIndex = 3;
            // 
            // codigoIn
            // 
            this.codigoIn.Location = new System.Drawing.Point(153, 106);
            this.codigoIn.Name = "codigoIn";
            this.codigoIn.Size = new System.Drawing.Size(248, 22);
            this.codigoIn.TabIndex = 4;
            // 
            // correoIn
            // 
            this.correoIn.Location = new System.Drawing.Point(153, 175);
            this.correoIn.Name = "correoIn";
            this.correoIn.Size = new System.Drawing.Size(248, 22);
            this.correoIn.TabIndex = 5;
            // 
            // btnValidacion
            // 
            this.btnValidacion.Location = new System.Drawing.Point(177, 220);
            this.btnValidacion.Name = "btnValidacion";
            this.btnValidacion.Size = new System.Drawing.Size(177, 40);
            this.btnValidacion.TabIndex = 6;
            this.btnValidacion.Text = "validar";
            this.btnValidacion.UseVisualStyleBackColor = true;
            this.btnValidacion.Click += new System.EventHandler(this.btnValidacion_Click);
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(342, 404);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(32, 17);
            this.salida.TabIndex = 7;
            this.salida.Text = " ----";
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // passwordIn
            // 
            this.passwordIn.Location = new System.Drawing.Point(531, 203);
            this.passwordIn.Name = "passwordIn";
            this.passwordIn.Size = new System.Drawing.Size(158, 22);
            this.passwordIn.TabIndex = 8;
            // 
            // btnValPass
            // 
            this.btnValPass.Location = new System.Drawing.Point(531, 240);
            this.btnValPass.Name = "btnValPass";
            this.btnValPass.Size = new System.Drawing.Size(167, 47);
            this.btnValPass.TabIndex = 9;
            this.btnValPass.Text = "ValidarPassWord";
            this.btnValPass.UseVisualStyleBackColor = true;
            this.btnValPass.Click += new System.EventHandler(this.btnValPass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValPass);
            this.Controls.Add(this.passwordIn);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.btnValidacion);
            this.Controls.Add(this.correoIn);
            this.Controls.Add(this.codigoIn);
            this.Controls.Add(this.nombreIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreIn;
        private System.Windows.Forms.TextBox codigoIn;
        private System.Windows.Forms.TextBox correoIn;
        private System.Windows.Forms.Button btnValidacion;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.ErrorProvider errorM;
        private System.Windows.Forms.Button btnValPass;
        private System.Windows.Forms.TextBox passwordIn;
    }
}

