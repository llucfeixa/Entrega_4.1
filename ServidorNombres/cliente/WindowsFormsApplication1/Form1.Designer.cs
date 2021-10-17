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
            this.nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Palindromo = new System.Windows.Forms.RadioButton();
            this.AlturaLabel = new System.Windows.Forms.Label();
            this.AlturaBox = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.RadioButton();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.ConectarButton = new System.Windows.Forms.Button();
            this.DesconectarButton = new System.Windows.Forms.Button();
            this.Mayusculas = new System.Windows.Forms.RadioButton();
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
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(174, 48);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(244, 26);
            this.nombre.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 292);
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
            this.groupBox1.Controls.Add(this.Mayusculas);
            this.groupBox1.Controls.Add(this.Palindromo);
            this.groupBox1.Controls.Add(this.AlturaLabel);
            this.groupBox1.Controls.Add(this.AlturaBox);
            this.groupBox1.Controls.Add(this.Altura);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(544, 434);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Palindromo
            // 
            this.Palindromo.AutoSize = true;
            this.Palindromo.Location = new System.Drawing.Point(174, 208);
            this.Palindromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Palindromo.Name = "Palindromo";
            this.Palindromo.Size = new System.Drawing.Size(267, 24);
            this.Palindromo.TabIndex = 12;
            this.Palindromo.TabStop = true;
            this.Palindromo.Text = "Dime si mi nombre es palíndromo";
            this.Palindromo.UseVisualStyleBackColor = true;
            // 
            // AlturaLabel
            // 
            this.AlturaLabel.AutoSize = true;
            this.AlturaLabel.Location = new System.Drawing.Point(37, 144);
            this.AlturaLabel.Name = "AlturaLabel";
            this.AlturaLabel.Size = new System.Drawing.Size(51, 20);
            this.AlturaLabel.TabIndex = 11;
            this.AlturaLabel.Text = "Altura";
            // 
            // AlturaBox
            // 
            this.AlturaBox.Location = new System.Drawing.Point(30, 172);
            this.AlturaBox.Name = "AlturaBox";
            this.AlturaBox.Size = new System.Drawing.Size(100, 26);
            this.AlturaBox.TabIndex = 10;
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(174, 174);
            this.Altura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(144, 24);
            this.Altura.TabIndex = 9;
            this.Altura.TabStop = true;
            this.Altura.Text = "Dime si soy alto";
            this.Altura.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(174, 140);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(247, 24);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(174, 105);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(233, 24);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
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
            this.DesconectarButton.Location = new System.Drawing.Point(43, 565);
            this.DesconectarButton.Name = "DesconectarButton";
            this.DesconectarButton.Size = new System.Drawing.Size(248, 100);
            this.DesconectarButton.TabIndex = 8;
            this.DesconectarButton.Text = "Desconectar";
            this.DesconectarButton.UseVisualStyleBackColor = true;
            this.DesconectarButton.Click += new System.EventHandler(this.DesconectarButton_Click);
            // 
            // Mayusculas
            // 
            this.Mayusculas.AutoSize = true;
            this.Mayusculas.Location = new System.Drawing.Point(174, 242);
            this.Mayusculas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mayusculas.Name = "Mayusculas";
            this.Mayusculas.Size = new System.Drawing.Size(308, 24);
            this.Mayusculas.TabIndex = 13;
            this.Mayusculas.TabStop = true;
            this.Mayusculas.Text = "Devuélveme mi nombre en mayúsculas";
            this.Mayusculas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 865);
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
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Label AlturaLabel;
        private System.Windows.Forms.TextBox AlturaBox;
        private System.Windows.Forms.RadioButton Altura;
        private System.Windows.Forms.Button ConectarButton;
        private System.Windows.Forms.Button DesconectarButton;
        private System.Windows.Forms.RadioButton Palindromo;
        private System.Windows.Forms.RadioButton Mayusculas;
    }
}

