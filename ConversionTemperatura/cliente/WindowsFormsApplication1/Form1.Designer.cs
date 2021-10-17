namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.temperatura = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CaF = new System.Windows.Forms.RadioButton();
            this.FaC = new System.Windows.Forms.RadioButton();
            this.ConectarButton = new System.Windows.Forms.Button();
            this.DesconectarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura";
            // 
            // temperatura
            // 
            this.temperatura.Location = new System.Drawing.Point(243, 48);
            this.temperatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.temperatura.Name = "temperatura";
            this.temperatura.Size = new System.Drawing.Size(244, 26);
            this.temperatura.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 190);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.CaF);
            this.groupBox1.Controls.Add(this.FaC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.temperatura);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(544, 273);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // CaF
            // 
            this.CaF.AutoSize = true;
            this.CaF.Location = new System.Drawing.Point(242, 140);
            this.CaF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaF.Name = "CaF";
            this.CaF.Size = new System.Drawing.Size(84, 24);
            this.CaF.TabIndex = 7;
            this.CaF.TabStop = true;
            this.CaF.Text = "ºC a ºF";
            this.CaF.UseVisualStyleBackColor = true;
            // 
            // FaC
            // 
            this.FaC.AutoSize = true;
            this.FaC.Location = new System.Drawing.Point(243, 106);
            this.FaC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FaC.Name = "FaC";
            this.FaC.Size = new System.Drawing.Size(84, 24);
            this.FaC.TabIndex = 8;
            this.FaC.TabStop = true;
            this.FaC.Text = "ºF a ºC";
            this.FaC.UseVisualStyleBackColor = true;
            // 
            // ConectarButton
            // 
            this.ConectarButton.Location = new System.Drawing.Point(43, 12);
            this.ConectarButton.Name = "ConectarButton";
            this.ConectarButton.Size = new System.Drawing.Size(200, 75);
            this.ConectarButton.TabIndex = 7;
            this.ConectarButton.Text = "Conectar";
            this.ConectarButton.UseVisualStyleBackColor = true;
            this.ConectarButton.Click += new System.EventHandler(this.ConectarButton_Click);
            // 
            // DesconectarButton
            // 
            this.DesconectarButton.Location = new System.Drawing.Point(43, 408);
            this.DesconectarButton.Name = "DesconectarButton";
            this.DesconectarButton.Size = new System.Drawing.Size(248, 100);
            this.DesconectarButton.TabIndex = 8;
            this.DesconectarButton.Text = "Desconectar";
            this.DesconectarButton.UseVisualStyleBackColor = true;
            this.DesconectarButton.Click += new System.EventHandler(this.DesconectarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 533);
            this.Controls.Add(this.DesconectarButton);
            this.Controls.Add(this.ConectarButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox temperatura;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CaF;
        private System.Windows.Forms.RadioButton FaC;
        private System.Windows.Forms.Button ConectarButton;
        private System.Windows.Forms.Button DesconectarButton;
    }
}

