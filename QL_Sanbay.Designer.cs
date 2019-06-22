namespace QLBVMB
{
    partial class QL_Sanbay
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
            this.dataGridView_Sanbay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_masb = new System.Windows.Forms.TextBox();
            this.textBox_tensb = new System.Windows.Forms.TextBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.MASB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSANBAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sanbay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Sanbay
            // 
            this.dataGridView_Sanbay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sanbay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASB,
            this.TENSANBAY});
            this.dataGridView_Sanbay.Location = new System.Drawing.Point(12, 213);
            this.dataGridView_Sanbay.Name = "dataGridView_Sanbay";
            this.dataGridView_Sanbay.Size = new System.Drawing.Size(492, 356);
            this.dataGridView_Sanbay.TabIndex = 0;
            this.dataGridView_Sanbay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Sanbay_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sân bay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sân bay:";
            // 
            // textBox_masb
            // 
            this.textBox_masb.Location = new System.Drawing.Point(184, 37);
            this.textBox_masb.Name = "textBox_masb";
            this.textBox_masb.ReadOnly = true;
            this.textBox_masb.Size = new System.Drawing.Size(201, 20);
            this.textBox_masb.TabIndex = 3;
            // 
            // textBox_tensb
            // 
            this.textBox_tensb.Location = new System.Drawing.Point(184, 87);
            this.textBox_tensb.Name = "textBox_tensb";
            this.textBox_tensb.Size = new System.Drawing.Size(201, 20);
            this.textBox_tensb.TabIndex = 4;
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(96, 152);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(84, 39);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Cập nhật";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(219, 152);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(84, 39);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Thêm";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(350, 152);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(84, 39);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Xóa";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // MASB
            // 
            this.MASB.DataPropertyName = "MASB";
            this.MASB.HeaderText = "Mã sân bay";
            this.MASB.Name = "MASB";
            this.MASB.ReadOnly = true;
            this.MASB.Width = 150;
            // 
            // TENSANBAY
            // 
            this.TENSANBAY.DataPropertyName = "TENSANBAY";
            this.TENSANBAY.HeaderText = "Tên sân bay";
            this.TENSANBAY.Name = "TENSANBAY";
            this.TENSANBAY.ReadOnly = true;
            this.TENSANBAY.Width = 300;
            // 
            // QL_Sanbay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 581);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_tensb);
            this.Controls.Add(this.textBox_masb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Sanbay);
            this.Name = "QL_Sanbay";
            this.Text = "QL_Sanbay";
            this.Load += new System.EventHandler(this.QL_Sanbay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sanbay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Sanbay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_masb;
        private System.Windows.Forms.TextBox textBox_tensb;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSANBAY;
    }
}