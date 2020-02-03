namespace dam2_di_ut3_ej2_david_gutierrez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_mas2010yBarcelona = new System.Windows.Forms.RadioButton();
            this.rbtn_madridbarcelona = new System.Windows.Forms.RadioButton();
            this.rbtn_comienzaporA = new System.Windows.Forms.RadioButton();
            this.rbtn_entre1020 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lBox_notIncluded = new System.Windows.Forms.ListBox();
            this.lBox_included = new System.Windows.Forms.ListBox();
            this.btn_toRight = new System.Windows.Forms.Button();
            this.btn_toLeft = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(12, 24);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(121, 21);
            this.combo.TabIndex = 1;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select una tabla";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_mas2010yBarcelona);
            this.groupBox1.Controls.Add(this.rbtn_madridbarcelona);
            this.groupBox1.Controls.Add(this.rbtn_comienzaporA);
            this.groupBox1.Controls.Add(this.rbtn_entre1020);
            this.groupBox1.Location = new System.Drawing.Point(139, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbtn_mas2010yBarcelona
            // 
            this.rbtn_mas2010yBarcelona.AutoSize = true;
            this.rbtn_mas2010yBarcelona.Location = new System.Drawing.Point(199, 83);
            this.rbtn_mas2010yBarcelona.Name = "rbtn_mas2010yBarcelona";
            this.rbtn_mas2010yBarcelona.Size = new System.Drawing.Size(176, 17);
            this.rbtn_mas2010yBarcelona.TabIndex = 3;
            this.rbtn_mas2010yBarcelona.TabStop = true;
            this.rbtn_mas2010yBarcelona.Text = "Superior al 2020 y de Barcelona";
            this.rbtn_mas2010yBarcelona.UseVisualStyleBackColor = true;
            this.rbtn_mas2010yBarcelona.CheckedChanged += new System.EventHandler(this.Rbtn_mas2010yBarcelona_CheckedChanged);
            // 
            // rbtn_madridbarcelona
            // 
            this.rbtn_madridbarcelona.AutoSize = true;
            this.rbtn_madridbarcelona.Location = new System.Drawing.Point(7, 83);
            this.rbtn_madridbarcelona.Name = "rbtn_madridbarcelona";
            this.rbtn_madridbarcelona.Size = new System.Drawing.Size(166, 17);
            this.rbtn_madridbarcelona.TabIndex = 2;
            this.rbtn_madridbarcelona.TabStop = true;
            this.rbtn_madridbarcelona.Text = "Localidad Madrid o Barcelona";
            this.rbtn_madridbarcelona.UseVisualStyleBackColor = true;
            this.rbtn_madridbarcelona.CheckedChanged += new System.EventHandler(this.Rbtn_madridbarcelona_CheckedChanged);
            // 
            // rbtn_comienzaporA
            // 
            this.rbtn_comienzaporA.AutoSize = true;
            this.rbtn_comienzaporA.Location = new System.Drawing.Point(199, 19);
            this.rbtn_comienzaporA.Name = "rbtn_comienzaporA";
            this.rbtn_comienzaporA.Size = new System.Drawing.Size(138, 17);
            this.rbtn_comienzaporA.TabIndex = 1;
            this.rbtn_comienzaporA.TabStop = true;
            this.rbtn_comienzaporA.Text = "Nombre comienza por A";
            this.rbtn_comienzaporA.UseVisualStyleBackColor = true;
            this.rbtn_comienzaporA.CheckedChanged += new System.EventHandler(this.Rbtn_comienzaporA_CheckedChanged);
            // 
            // rbtn_entre1020
            // 
            this.rbtn_entre1020.AutoSize = true;
            this.rbtn_entre1020.Location = new System.Drawing.Point(7, 20);
            this.rbtn_entre1020.Name = "rbtn_entre1020";
            this.rbtn_entre1020.Size = new System.Drawing.Size(153, 17);
            this.rbtn_entre1020.TabIndex = 0;
            this.rbtn_entre1020.TabStop = true;
            this.rbtn_entre1020.Text = "Codigo grupo entre 10 y 20";
            this.rbtn_entre1020.UseVisualStyleBackColor = true;
            this.rbtn_entre1020.CheckedChanged += new System.EventHandler(this.Rbtn_entre1020_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_order);
            this.groupBox2.Controls.Add(this.btn_toLeft);
            this.groupBox2.Controls.Add(this.btn_toRight);
            this.groupBox2.Controls.Add(this.lBox_included);
            this.groupBox2.Controls.Add(this.lBox_notIncluded);
            this.groupBox2.Location = new System.Drawing.Point(566, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 129);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lBox_notIncluded
            // 
            this.lBox_notIncluded.FormattingEnabled = true;
            this.lBox_notIncluded.Location = new System.Drawing.Point(6, 19);
            this.lBox_notIncluded.Name = "lBox_notIncluded";
            this.lBox_notIncluded.Size = new System.Drawing.Size(120, 95);
            this.lBox_notIncluded.TabIndex = 0;
            // 
            // lBox_included
            // 
            this.lBox_included.FormattingEnabled = true;
            this.lBox_included.Location = new System.Drawing.Point(191, 19);
            this.lBox_included.Name = "lBox_included";
            this.lBox_included.Size = new System.Drawing.Size(120, 95);
            this.lBox_included.TabIndex = 1;
            // 
            // btn_toRight
            // 
            this.btn_toRight.Location = new System.Drawing.Point(132, 31);
            this.btn_toRight.Name = "btn_toRight";
            this.btn_toRight.Size = new System.Drawing.Size(53, 23);
            this.btn_toRight.TabIndex = 2;
            this.btn_toRight.Text = ">>";
            this.btn_toRight.UseVisualStyleBackColor = true;
            this.btn_toRight.Click += new System.EventHandler(this.Btn_toRight_Click);
            // 
            // btn_toLeft
            // 
            this.btn_toLeft.Location = new System.Drawing.Point(132, 77);
            this.btn_toLeft.Name = "btn_toLeft";
            this.btn_toLeft.Size = new System.Drawing.Size(53, 23);
            this.btn_toLeft.TabIndex = 3;
            this.btn_toLeft.Text = "<<";
            this.btn_toLeft.UseVisualStyleBackColor = true;
            this.btn_toLeft.Click += new System.EventHandler(this.Btn_toLeft_Click);
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(317, 53);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 4;
            this.btn_order.Text = "Ordenar";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.Btn_order_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_mas2010yBarcelona;
        private System.Windows.Forms.RadioButton rbtn_madridbarcelona;
        private System.Windows.Forms.RadioButton rbtn_comienzaporA;
        private System.Windows.Forms.RadioButton rbtn_entre1020;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_toLeft;
        private System.Windows.Forms.Button btn_toRight;
        private System.Windows.Forms.ListBox lBox_included;
        private System.Windows.Forms.ListBox lBox_notIncluded;
    }
}

