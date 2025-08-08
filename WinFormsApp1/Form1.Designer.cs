namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            Gender = new GroupBox();
            male = new RadioButton();
            female = new RadioButton();
            habbits = new GroupBox();
            swimming = new CheckBox();
            TV = new CheckBox();
            bodyblulding = new CheckBox();
            football = new CheckBox();
            shwresult = new Button();
            richTextBox2 = new RichTextBox();
            pageSetupDialog1 = new PageSetupDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            label8 = new Label();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            Gender.SuspendLayout();
            habbits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 72);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Job";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 282);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "description";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 29);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "report";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 105);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 105);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 4;
            label5.Text = "statues";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 438);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 5;
            label6.Text = "C#";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 36);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 6;
            label7.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(92, 65);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(400, 27);
            textBox6.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(92, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(172, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2025, 8, 13, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "married", "divorced", "single" });
            comboBox1.Location = new Point(341, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(54, 305);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(394, 120);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(92, 436);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 6;
            // 
            // Gender
            // 
            Gender.Controls.Add(male);
            Gender.Controls.Add(female);
            Gender.Location = new Point(242, 157);
            Gender.Name = "Gender";
            Gender.Size = new Size(250, 86);
            Gender.TabIndex = 20;
            Gender.TabStop = false;
            Gender.Text = "Gender";
            Gender.Enter += groupBox1_Enter;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(127, 43);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 1;
            male.TabStop = true;
            male.Text = "male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(6, 43);
            female.Name = "female";
            female.Size = new Size(76, 24);
            female.TabIndex = 0;
            female.TabStop = true;
            female.Text = "female";
            female.UseVisualStyleBackColor = true;
            // 
            // habbits
            // 
            habbits.Controls.Add(swimming);
            habbits.Controls.Add(TV);
            habbits.Controls.Add(bodyblulding);
            habbits.Controls.Add(football);
            habbits.Location = new Point(45, 133);
            habbits.Name = "habbits";
            habbits.Size = new Size(128, 146);
            habbits.TabIndex = 4;
            habbits.TabStop = false;
            habbits.Text = "habbits";
            habbits.Enter += habbits_Enter;
            // 
            // swimming
            // 
            swimming.AutoSize = true;
            swimming.Location = new Point(9, 116);
            swimming.Name = "swimming";
            swimming.Size = new Size(99, 24);
            swimming.TabIndex = 3;
            swimming.Text = "swimming";
            swimming.UseVisualStyleBackColor = true;
            // 
            // TV
            // 
            TV.AutoSize = true;
            TV.Location = new Point(9, 86);
            TV.Name = "TV";
            TV.Size = new Size(48, 24);
            TV.TabIndex = 2;
            TV.Text = "TV";
            TV.UseVisualStyleBackColor = true;
            // 
            // bodyblulding
            // 
            bodyblulding.AutoSize = true;
            bodyblulding.Location = new Point(9, 56);
            bodyblulding.Name = "bodyblulding";
            bodyblulding.Size = new Size(120, 24);
            bodyblulding.TabIndex = 1;
            bodyblulding.Text = "bodyblulding";
            bodyblulding.UseVisualStyleBackColor = true;
            // 
            // football
            // 
            football.AutoSize = true;
            football.Location = new Point(9, 26);
            football.Name = "football";
            football.Size = new Size(84, 24);
            football.TabIndex = 0;
            football.Text = "football";
            football.UseVisualStyleBackColor = true;
            // 
            // shwresult
            // 
            shwresult.Location = new Point(310, 438);
            shwresult.Name = "shwresult";
            shwresult.Size = new Size(122, 49);
            shwresult.TabIndex = 7;
            shwresult.Text = "show result";
            shwresult.UseVisualStyleBackColor = true;
            shwresult.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(566, 52);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(388, 435);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(226, 259);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 21;
            label8.Text = "salary";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(279, 259);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(560, 498);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 23;
            button1.Text = "page setup";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(678, 498);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 24;
            button2.Text = "preview";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(822, 498);
            button3.Name = "button3";
            button3.Size = new Size(110, 29);
            button3.TabIndex = 25;
            button3.Text = "print";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 539);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown2);
            Controls.Add(label8);
            Controls.Add(richTextBox2);
            Controls.Add(shwresult);
            Controls.Add(habbits);
            Controls.Add(Gender);
            Controls.Add(numericUpDown1);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            Gender.ResumeLayout(false);
            Gender.PerformLayout();
            habbits.ResumeLayout(false);
            habbits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private NumericUpDown numericUpDown1;
        private GroupBox Gender;
        private GroupBox habbits;
        private CheckBox TV;
        private CheckBox bodyblulding;
        private CheckBox football;
        private RadioButton male;
        private RadioButton female;
        private CheckBox swimming;
        private Button shwresult;
        private RichTextBox richTextBox2;
        private PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label8;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
