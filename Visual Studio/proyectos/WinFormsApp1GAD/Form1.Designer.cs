namespace WinFormsApp1GAD
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
            BotonTon = new Button();
            Cerrar = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // BotonTon
            // 
            BotonTon.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BotonTon.FlatAppearance.BorderSize = 3;
            BotonTon.FlatAppearance.MouseDownBackColor = Color.Red;
            BotonTon.FlatAppearance.MouseOverBackColor = Color.White;
            BotonTon.ForeColor = SystemColors.ActiveCaptionText;
            BotonTon.Location = new Point(402, 196);
            BotonTon.Name = "BotonTon";
            BotonTon.Size = new Size(75, 23);
            BotonTon.TabIndex = 0;
            BotonTon.Text = "clic";
            BotonTon.UseVisualStyleBackColor = true;
            BotonTon.Click += button1_Click;
            // 
            // Cerrar
            // 
            Cerrar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            Cerrar.FlatAppearance.BorderSize = 3;
            Cerrar.FlatAppearance.MouseDownBackColor = Color.Red;
            Cerrar.FlatAppearance.MouseOverBackColor = Color.White;
            Cerrar.ForeColor = SystemColors.ActiveCaptionText;
            Cerrar.Location = new Point(638, 196);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 23);
            Cerrar.TabIndex = 1;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(182, 196);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "clic";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Honeydew;
            textBox1.Location = new Point(182, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(531, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(98, 53);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(197, 309);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(492, 271);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 69);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 69);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(492, 69);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 27);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(492, 69);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 27);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(484, 240);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(785, 635);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Cerrar);
            Controls.Add(BotonTon);
            Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            // Load event handler removed so the designer can load without requiring the code-behind.
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonTon;
        private Button Cerrar;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
    }
}
