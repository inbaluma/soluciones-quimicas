namespace Vista
{
    partial class Muestras
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nifTextBox = new System.Windows.Forms.TextBox();
            this.cultivoTextBox = new System.Windows.Forms.TextBox();
            this.solucionComboBox = new System.Windows.Forms.ComboBox();
            this.insertarButton = new System.Windows.Forms.Button();
            this.borrarButton = new System.Windows.Forms.Button();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(238, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "BIENVENIDO";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(246, 104);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(246, 284);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 26);
            this.idTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "NIF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cultivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Solucion";
            // 
            // nifTextBox
            // 
            this.nifTextBox.Location = new System.Drawing.Point(246, 339);
            this.nifTextBox.Name = "nifTextBox";
            this.nifTextBox.Size = new System.Drawing.Size(100, 26);
            this.nifTextBox.TabIndex = 12;
            // 
            // cultivoTextBox
            // 
            this.cultivoTextBox.Location = new System.Drawing.Point(237, 382);
            this.cultivoTextBox.Name = "cultivoTextBox";
            this.cultivoTextBox.Size = new System.Drawing.Size(100, 26);
            this.cultivoTextBox.TabIndex = 13;
            // 
            // solucionComboBox
            // 
            this.solucionComboBox.FormattingEnabled = true;
            this.solucionComboBox.Location = new System.Drawing.Point(237, 421);
            this.solucionComboBox.Name = "solucionComboBox";
            this.solucionComboBox.Size = new System.Drawing.Size(121, 28);
            this.solucionComboBox.TabIndex = 14;
            // 
            // insertarButton
            // 
            this.insertarButton.Location = new System.Drawing.Point(155, 494);
            this.insertarButton.Name = "insertarButton";
            this.insertarButton.Size = new System.Drawing.Size(75, 30);
            this.insertarButton.TabIndex = 15;
            this.insertarButton.Text = "Insertar";
            this.insertarButton.UseVisualStyleBackColor = true;
            // 
            // borrarButton
            // 
            this.borrarButton.Location = new System.Drawing.Point(271, 494);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(75, 30);
            this.borrarButton.TabIndex = 16;
            this.borrarButton.Text = "Borrar";
            this.borrarButton.UseVisualStyleBackColor = true;
            // 
            // actualizarButton
            // 
            this.actualizarButton.Location = new System.Drawing.Point(393, 494);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(93, 30);
            this.actualizarButton.TabIndex = 17;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = true;
            // 
            // salirButton
            // 
            this.salirButton.Location = new System.Drawing.Point(538, 494);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(75, 30);
            this.salirButton.TabIndex = 18;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            // 
            // Muestras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.borrarButton);
            this.Controls.Add(this.insertarButton);
            this.Controls.Add(this.solucionComboBox);
            this.Controls.Add(this.cultivoTextBox);
            this.Controls.Add(this.nifTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Muestras";
            this.Text = "Muestras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nifTextBox;
        private System.Windows.Forms.TextBox cultivoTextBox;
        private System.Windows.Forms.ComboBox solucionComboBox;
        private System.Windows.Forms.Button insertarButton;
        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.Button salirButton;
    }
}