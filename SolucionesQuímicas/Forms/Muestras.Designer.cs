namespace SolucionesQuímicas.Forms
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            solucionListBox = new ListBox();
            idTextBox = new TextBox();
            nifTextBox = new TextBox();
            cultivoTextBox = new TextBox();
            insertarButton = new Button();
            borrarButton = new Button();
            actualizarButton = new Button();
            salirButton = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            usuarioLabel = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 226);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 260);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "NIF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 293);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Cultivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 323);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Solucion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(321, 19);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 37);
            label5.TabIndex = 4;
            label5.Text = "MUESTRAS";
            // 
            // solucionListBox
            // 
            solucionListBox.FormattingEnabled = true;
            solucionListBox.ItemHeight = 15;
            solucionListBox.Location = new Point(132, 323);
            solucionListBox.Margin = new Padding(2);
            solucionListBox.Name = "solucionListBox";
            solucionListBox.Size = new Size(606, 79);
            solucionListBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(132, 223);
            idTextBox.Margin = new Padding(2);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(606, 23);
            idTextBox.TabIndex = 6;
            // 
            // nifTextBox
            // 
            nifTextBox.Location = new Point(132, 256);
            nifTextBox.Margin = new Padding(2);
            nifTextBox.Name = "nifTextBox";
            nifTextBox.Size = new Size(606, 23);
            nifTextBox.TabIndex = 7;
            // 
            // cultivoTextBox
            // 
            cultivoTextBox.Location = new Point(132, 290);
            cultivoTextBox.Margin = new Padding(2);
            cultivoTextBox.Name = "cultivoTextBox";
            cultivoTextBox.Size = new Size(606, 23);
            cultivoTextBox.TabIndex = 8;
            // 
            // insertarButton
            // 
            insertarButton.Location = new Point(82, 448);
            insertarButton.Margin = new Padding(2);
            insertarButton.Name = "insertarButton";
            insertarButton.Size = new Size(78, 20);
            insertarButton.TabIndex = 9;
            insertarButton.Text = "Insertar";
            insertarButton.UseVisualStyleBackColor = true;
            insertarButton.Click += insertarButton_Click;
            // 
            // borrarButton
            // 
            borrarButton.Location = new Point(257, 448);
            borrarButton.Margin = new Padding(2);
            borrarButton.Name = "borrarButton";
            borrarButton.Size = new Size(78, 20);
            borrarButton.TabIndex = 10;
            borrarButton.Text = "Borrar";
            borrarButton.UseVisualStyleBackColor = true;
            borrarButton.Click += borrarButton_Click;
            // 
            // actualizarButton
            // 
            actualizarButton.Location = new Point(455, 448);
            actualizarButton.Margin = new Padding(2);
            actualizarButton.Name = "actualizarButton";
            actualizarButton.Size = new Size(78, 20);
            actualizarButton.TabIndex = 11;
            actualizarButton.Text = "Actualizar";
            actualizarButton.UseVisualStyleBackColor = true;
            actualizarButton.Click += actualizarButton_Click;
            // 
            // salirButton
            // 
            salirButton.Location = new Point(643, 448);
            salirButton.Margin = new Padding(2);
            salirButton.Name = "salirButton";
            salirButton.Size = new Size(78, 20);
            salirButton.TabIndex = 12;
            salirButton.Text = "Salir";
            salirButton.UseVisualStyleBackColor = true;
            salirButton.Click += salirButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 67);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(673, 135);
            dataGridView1.TabIndex = 13;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 28);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 14;
            label6.Text = "Sesión Iniciada por";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new Point(136, 28);
            usuarioLabel.Margin = new Padding(2, 0, 2, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(0, 15);
            usuarioLabel.TabIndex = 15;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 0;
            // 
            // Muestras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 492);
            Controls.Add(label7);
            Controls.Add(usuarioLabel);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(salirButton);
            Controls.Add(actualizarButton);
            Controls.Add(borrarButton);
            Controls.Add(insertarButton);
            Controls.Add(cultivoTextBox);
            Controls.Add(nifTextBox);
            Controls.Add(idTextBox);
            Controls.Add(solucionListBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Muestras";
            Text = "Muestras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox solucionListBox;
        private TextBox idTextBox;
        private TextBox nifTextBox;
        private TextBox cultivoTextBox;
        private Button insertarButton;
        private Button borrarButton;
        private Button actualizarButton;
        private Button salirButton;
        private DataGridView dataGridView1;
        private Label label6;
        private Label usuarioLabel;
        private Label label7;
    }
}