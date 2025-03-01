namespace HelloWorld
{
    partial class Form1
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
            button1 = new Button();
            textoName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(88, 294);
            button1.Name = "button1";
            button1.Size = new Size(159, 32);
            button1.TabIndex = 2;
            button1.Text = "Alterar Texto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textoName
            // 
            textoName.Location = new Point(78, 140);
            textoName.Name = "textoName";
            textoName.Size = new Size(74, 23);
            textoName.TabIndex = 3;
            textoName.TextChanged += textoName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 96);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 4;
            label1.Text = " PRIMEIRO NÚMERO:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 196);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 5;
            label2.Text = " SEGUNDO NÚMERO:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(300, 9);
            label3.Name = "label3";
            label3.Size = new Size(179, 30);
            label3.TabIndex = 7;
            label3.Text = "CALCULADORA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textoName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textoName;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}
