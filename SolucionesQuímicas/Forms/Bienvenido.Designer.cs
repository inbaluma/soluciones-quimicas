namespace SolucionesQuimicas.Forms
{
    partial class Bienvenido
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
            okButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usuarioTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginLabel = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(109, 357);
            okButton.Name = "okButton";
            okButton.Size = new Size(111, 33);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(313, 357);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(111, 33);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 30);
            label1.Name = "label1";
            label1.Size = new Size(272, 67);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 160);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 230);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(247, 155);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(150, 31);
            usuarioTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(247, 225);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(150, 31);
            passwordTextBox.TabIndex = 6;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.Red;
            loginLabel.Location = new Point(16, 302);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(461, 21);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Credenciales Incorrectas: compruebe los datos de inicio de sesión";
            loginLabel.Visible = false;
            // 
            // Bienvenido
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
            Controls.Add(loginLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usuarioTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            KeyPreview = true;
            Name = "Bienvenido";
            Text = "Hola";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Button cancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usuarioTextBox;
        private TextBox passwordTextBox;
        private Label loginLabel;
    }
}