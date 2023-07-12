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
            buttondeserialize = new Button();
            listView1 = new ListView();
            panel1 = new Panel();
            barname = new TextBox();
            barsexbox = new ComboBox();
            age = new Label();
            Sex = new Label();
            Username = new Label();
            label1 = new Label();
            buttonserializable = new Button();
            barage = new NumericUpDown();
            buttonadd = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)barage).BeginInit();
            SuspendLayout();
            // 
            // buttondeserialize
            // 
            buttondeserialize.BackColor = SystemColors.Highlight;
            buttondeserialize.FlatStyle = FlatStyle.Flat;
            buttondeserialize.Location = new Point(605, 376);
            buttondeserialize.Name = "buttondeserialize";
            buttondeserialize.Size = new Size(92, 35);
            buttondeserialize.TabIndex = 0;
            buttondeserialize.Text = "deserialize ";
            buttondeserialize.UseVisualStyleBackColor = false;
            buttondeserialize.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Info;
            listView1.Location = new Point(12, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(266, 384);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonadd);
            panel1.Controls.Add(barage);
            panel1.Controls.Add(barname);
            panel1.Controls.Add(barsexbox);
            panel1.Controls.Add(age);
            panel1.Controls.Add(Sex);
            panel1.Controls.Add(Username);
            panel1.Location = new Point(358, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 343);
            panel1.TabIndex = 2;
            // 
            // barname
            // 
            barname.Location = new Point(33, 54);
            barname.Name = "barname";
            barname.Size = new Size(243, 23);
            barname.TabIndex = 4;
            barname.Text = " ";
            // 
            // barsexbox
            // 
            barsexbox.FormattingEnabled = true;
            barsexbox.Items.AddRange(new object[] { "Male", "Female" });
            barsexbox.Location = new Point(33, 135);
            barsexbox.Name = "barsexbox";
            barsexbox.Size = new Size(108, 23);
            barsexbox.TabIndex = 3;
            barsexbox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Location = new Point(33, 216);
            age.Name = "age";
            age.Size = new Size(28, 15);
            age.TabIndex = 2;
            age.Text = "Age";
            // 
            // Sex
            // 
            Sex.AutoSize = true;
            Sex.Location = new Point(33, 117);
            Sex.Name = "Sex";
            Sex.Size = new Size(25, 15);
            Sex.TabIndex = 1;
            Sex.Text = "Sex";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(33, 36);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 0;
            Username.Text = "Username\r\n";
            Username.Click += Username_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "Users";
            label1.Click += label1_Click;
            // 
            // buttonserializable
            // 
            buttonserializable.BackColor = Color.FromArgb(192, 192, 0);
            buttonserializable.FlatStyle = FlatStyle.Flat;
            buttonserializable.Location = new Point(391, 376);
            buttonserializable.Name = "buttonserializable";
            buttonserializable.Size = new Size(104, 35);
            buttonserializable.TabIndex = 4;
            buttonserializable.Text = "serializable ";
            buttonserializable.UseVisualStyleBackColor = false;
            // 
            // barage
            // 
            barage.Location = new Point(33, 234);
            barage.Name = "barage";
            barage.Size = new Size(120, 23);
            barage.TabIndex = 6;
            // 
            // buttonadd
            // 
            buttonadd.Location = new Point(249, 270);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(75, 23);
            buttonadd.TabIndex = 7;
            buttonadd.Text = "ADD";
            buttonadd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonserializable);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Controls.Add(buttondeserialize);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)barage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttondeserialize;
        private ListView listView1;
        private Panel panel1;
        private Label label1;
        private Label age;
        private Label Sex;
        private Label Username;
        private ComboBox barsexbox;
        private TextBox barname;
        private Button buttonserializable;
        private Button buttonadd;
        private NumericUpDown barage;
    }
}