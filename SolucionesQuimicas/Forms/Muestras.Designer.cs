namespace SolucionesQuimicas.Forms
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
            controlLabel = new Label();
            limpiarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 377);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 433);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 1;
            label2.Text = "NIF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 488);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Cultivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 538);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 3;
            label4.Text = "Solucion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(459, 32);
            label5.Name = "label5";
            label5.Size = new Size(219, 54);
            label5.TabIndex = 4;
            label5.Text = "MUESTRAS";
            // 
            // solucionListBox
            // 
            solucionListBox.FormattingEnabled = true;
            solucionListBox.ItemHeight = 25;
            solucionListBox.Location = new Point(189, 538);
            solucionListBox.Name = "solucionListBox";
            solucionListBox.Size = new Size(864, 129);
            solucionListBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(189, 372);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(864, 31);
            idTextBox.TabIndex = 6;
            // 
            // nifTextBox
            // 
            nifTextBox.Location = new Point(189, 427);
            nifTextBox.Name = "nifTextBox";
            nifTextBox.Size = new Size(864, 31);
            nifTextBox.TabIndex = 7;
            // 
            // cultivoTextBox
            // 
            cultivoTextBox.Location = new Point(189, 483);
            cultivoTextBox.Name = "cultivoTextBox";
            cultivoTextBox.Size = new Size(864, 31);
            cultivoTextBox.TabIndex = 8;
            // 
            // insertarButton
            // 
            insertarButton.Location = new Point(90, 747);
            insertarButton.Name = "insertarButton";
            insertarButton.Size = new Size(111, 33);
            insertarButton.TabIndex = 9;
            insertarButton.Text = "Insertar";
            insertarButton.UseVisualStyleBackColor = true;
            insertarButton.Click += insertarButton_Click;
            // 
            // borrarButton
            // 
            borrarButton.Location = new Point(300, 747);
            borrarButton.Name = "borrarButton";
            borrarButton.Size = new Size(111, 33);
            borrarButton.TabIndex = 10;
            borrarButton.Text = "Borrar";
            borrarButton.UseVisualStyleBackColor = true;
            borrarButton.Click += borrarButton_Click;
            // 
            // actualizarButton
            // 
            actualizarButton.Location = new Point(531, 747);
            actualizarButton.Name = "actualizarButton";
            actualizarButton.Size = new Size(111, 33);
            actualizarButton.TabIndex = 11;
            actualizarButton.Text = "Actualizar";
            actualizarButton.UseVisualStyleBackColor = true;
            actualizarButton.Click += actualizarButton_Click;
            // 
            // salirButton
            // 
            salirButton.Location = new Point(748, 747);
            salirButton.Name = "salirButton";
            salirButton.Size = new Size(111, 33);
            salirButton.TabIndex = 12;
            salirButton.Text = "Salir";
            salirButton.UseVisualStyleBackColor = true;
            salirButton.Click += salirButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(90, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(961, 225);
            dataGridView1.TabIndex = 13;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // controlLabel
            // 
            controlLabel.AutoSize = true;
            controlLabel.Location = new Point(90, 689);
            controlLabel.Margin = new Padding(4, 0, 4, 0);
            controlLabel.Name = "controlLabel";
            controlLabel.Size = new Size(0, 25);
            controlLabel.TabIndex = 14;
            // 
            // limpiarButton
            // 
            limpiarButton.Location = new Point(942, 747);
            limpiarButton.Name = "limpiarButton";
            limpiarButton.Size = new Size(121, 33);
            limpiarButton.TabIndex = 15;
            limpiarButton.Text = "Limpiar";
            limpiarButton.UseVisualStyleBackColor = true;
            limpiarButton.Click += limpiarButton_Click;
            // 
            // Muestras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 820);
            Controls.Add(limpiarButton);
            Controls.Add(controlLabel);
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
            Controls.Add(dataGridView1);
            Name = "Muestras";
            Text = "Muestras";
            FormClosed += Muestras_FormClosed;
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
        private Label controlLabel;
        private Button limpiarButton;
    }
}