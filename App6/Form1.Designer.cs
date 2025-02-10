namespace App6
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
            btnShipperList = new Button();
            btnGoster1 = new Button();
            listBox1 = new ListBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnShipperList
            // 
            btnShipperList.Location = new Point(55, 41);
            btnShipperList.Name = "btnShipperList";
            btnShipperList.Size = new Size(120, 23);
            btnShipperList.TabIndex = 0;
            btnShipperList.Text = "Shipers List";
            btnShipperList.UseVisualStyleBackColor = true;
            btnShipperList.Click += btnShipperList_Click;
            // 
            // btnGoster1
            // 
            btnGoster1.Location = new Point(183, 41);
            btnGoster1.Name = "btnGoster1";
            btnGoster1.Size = new Size(130, 23);
            btnGoster1.TabIndex = 1;
            btnGoster1.Text = "Siparilerini Göster";
            btnGoster1.UseVisualStyleBackColor = true;
            btnGoster1.Click += btnGoster1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(34, 121);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 124);
            listBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(166, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(601, 124);
            dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(483, 42);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 4;
            button1.Text = "Lazy Loading";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(649, 42);
            button2.Name = "button2";
            button2.Size = new Size(103, 23);
            button2.TabIndex = 5;
            button2.Text = "Egear Loaing";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(340, 42);
            button3.Name = "button3";
            button3.Size = new Size(137, 23);
            button3.TabIndex = 6;
            button3.Text = "Normal Getirme";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(btnGoster1);
            Controls.Add(btnShipperList);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShipperList;
        private Button btnGoster1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
