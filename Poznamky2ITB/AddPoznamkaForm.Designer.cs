namespace Poznamky2ITB
{
    partial class AddPoznamkaForm
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
            textBox1 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Nadpis";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(587, 45);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 2;
            label2.Text = "Popis";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 113);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(587, 161);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 294);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 4;
            label3.Text = "Termín splnění";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(232, 294);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(328, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 348);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 6;
            label4.Text = "Projekt";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(232, 348);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(328, 33);
            comboBox1.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(14, 419);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(585, 154);
            listBox1.TabIndex = 8;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 579);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 31);
            textBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 391);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 10;
            label5.Text = "Podúkoly";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 579);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 11;
            label6.Text = "Nový podúkol";
            // 
            // button1
            // 
            button1.Location = new Point(448, 577);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "Přidat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 654);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "Zrušit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(435, 634);
            button3.Name = "button3";
            button3.Size = new Size(164, 54);
            button3.TabIndex = 14;
            button3.Text = "Uložit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddPoznamkaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 700);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddPoznamkaForm";
            Text = "Přidání poznámky";
            Load += AddPoznamkaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}