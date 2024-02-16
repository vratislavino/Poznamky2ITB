namespace Poznamky2ITB
{
    partial class ProjectManagerForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(618, 532);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 31);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 550);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 198);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(484, 133);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 6;
            button2.Text = "Přidat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(289, 79);
            button1.Name = "button1";
            button1.Size = new Size(186, 34);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 51);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 4;
            label3.Text = "Barva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 51);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 3;
            label2.Text = "Název";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(214, 38);
            label1.TabIndex = 2;
            label1.Text = "Přidání projektu";
            // 
            // button3
            // 
            button3.Location = new Point(443, 771);
            button3.Name = "button3";
            button3.Size = new Size(187, 47);
            button3.TabIndex = 7;
            button3.Text = "Zavřít";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ProjectManagerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 830);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProjectManagerForm";
            Text = "Správce projektů";
            Load += ProjectManagerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private Panel panel1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ColorDialog colorDialog1;
        private Button button2;
        private Button button3;
    }
}