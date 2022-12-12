namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_maloai = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.tb_giatien = new System.Windows.Forms.TextBox();
            this.tb_msp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_khoitao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 23);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(732, 228);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.tb_maloai);
            this.groupBox2.Controls.Add(this.tb_ten);
            this.groupBox2.Controls.Add(this.tb_soluong);
            this.groupBox2.Controls.Add(this.tb_giatien);
            this.groupBox2.Controls.Add(this.tb_msp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(37, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(269, 208);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(18, 22);
            this.textBox7.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(227, 208);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(18, 22);
            this.textBox6.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(181, 208);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(18, 22);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 208);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(18, 22);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(18, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(18, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(18, 22);
            this.textBox1.TabIndex = 11;
            // 
            // tb_maloai
            // 
            this.tb_maloai.Location = new System.Drawing.Point(127, 167);
            this.tb_maloai.Name = "tb_maloai";
            this.tb_maloai.Size = new System.Drawing.Size(236, 22);
            this.tb_maloai.TabIndex = 10;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(127, 62);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(236, 22);
            this.tb_ten.TabIndex = 8;
            // 
            // tb_soluong
            // 
            this.tb_soluong.Location = new System.Drawing.Point(127, 134);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(236, 22);
            this.tb_soluong.TabIndex = 7;
            // 
            // tb_giatien
            // 
            this.tb_giatien.Location = new System.Drawing.Point(127, 99);
            this.tb_giatien.Name = "tb_giatien";
            this.tb_giatien.Size = new System.Drawing.Size(236, 22);
            this.tb_giatien.TabIndex = 6;
            // 
            // tb_msp
            // 
            this.tb_msp.Location = new System.Drawing.Point(127, 27);
            this.tb_msp.Name = "tb_msp";
            this.tb_msp.Size = new System.Drawing.Size(236, 22);
            this.tb_msp.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô tả";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(580, 338);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(70, 27);
            this.bt_them.TabIndex = 2;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(580, 378);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(70, 27);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(580, 415);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(70, 27);
            this.bt_sua.TabIndex = 4;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_khoitao
            // 
            this.bt_khoitao.Location = new System.Drawing.Point(580, 450);
            this.bt_khoitao.Name = "bt_khoitao";
            this.bt_khoitao.Size = new System.Drawing.Size(70, 27);
            this.bt_khoitao.TabIndex = 5;
            this.bt_khoitao.Text = "Khởi tạo";
            this.bt_khoitao.UseVisualStyleBackColor = true;
            this.bt_khoitao.Click += new System.EventHandler(this.bt_khoitao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(831, 602);
            this.Controls.Add(this.bt_khoitao);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_maloai;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_soluong;
        private System.Windows.Forms.TextBox tb_giatien;
        private System.Windows.Forms.TextBox tb_msp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_khoitao;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

