namespace Sudoku
{
    partial class frmSudoku
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRjesenje = new System.Windows.Forms.Button();
            this.cmbRazina = new System.Windows.Forms.ComboBox();
            this.lblRazina = new System.Windows.Forms.Label();
            this.btnNova = new System.Windows.Forms.Button();
            this.dgvSlagalica = new System.Windows.Forms.DataGridView();
            this.clm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProvjeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlagalica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRjesenje
            // 
            this.btnRjesenje.Location = new System.Drawing.Point(168, 245);
            this.btnRjesenje.Name = "btnRjesenje";
            this.btnRjesenje.Size = new System.Drawing.Size(72, 23);
            this.btnRjesenje.TabIndex = 9;
            this.btnRjesenje.Text = "Rješenje";
            this.btnRjesenje.UseVisualStyleBackColor = true;
            this.btnRjesenje.Click += new System.EventHandler(this.btnRjesenje_Click);
            // 
            // cmbRazina
            // 
            this.cmbRazina.FormattingEnabled = true;
            this.cmbRazina.Items.AddRange(new object[] {
            "Lagana",
            "Srednja",
            "Teška"});
            this.cmbRazina.Location = new System.Drawing.Point(58, 8);
            this.cmbRazina.Name = "cmbRazina";
            this.cmbRazina.Size = new System.Drawing.Size(182, 21);
            this.cmbRazina.TabIndex = 8;
            // 
            // lblRazina
            // 
            this.lblRazina.AutoSize = true;
            this.lblRazina.Location = new System.Drawing.Point(9, 11);
            this.lblRazina.Name = "lblRazina";
            this.lblRazina.Size = new System.Drawing.Size(43, 13);
            this.lblRazina.TabIndex = 7;
            this.lblRazina.Text = "Razina:";
            // 
            // btnNova
            // 
            this.btnNova.Location = new System.Drawing.Point(12, 245);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(72, 23);
            this.btnNova.TabIndex = 6;
            this.btnNova.Text = "Nova igra";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // dgvSlagalica
            // 
            this.dgvSlagalica.AllowUserToAddRows = false;
            this.dgvSlagalica.AllowUserToDeleteRows = false;
            this.dgvSlagalica.AllowUserToOrderColumns = true;
            this.dgvSlagalica.AllowUserToResizeColumns = false;
            this.dgvSlagalica.AllowUserToResizeRows = false;
            this.dgvSlagalica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlagalica.ColumnHeadersVisible = false;
            this.dgvSlagalica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm1,
            this.clm2,
            this.clm3,
            this.clm4,
            this.clm5,
            this.clm6,
            this.clm7,
            this.clm8,
            this.clm9});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSlagalica.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSlagalica.Location = new System.Drawing.Point(12, 35);
            this.dgvSlagalica.Name = "dgvSlagalica";
            this.dgvSlagalica.RowHeadersVisible = false;
            this.dgvSlagalica.Size = new System.Drawing.Size(228, 201);
            this.dgvSlagalica.TabIndex = 5;
            this.dgvSlagalica.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlagalica_CellValueChanged);
            this.dgvSlagalica.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSlagalica_Paint);
            // 
            // clm1
            // 
            this.clm1.HeaderText = "Redak1";
            this.clm1.Name = "clm1";
            this.clm1.Width = 25;
            // 
            // clm2
            // 
            this.clm2.HeaderText = "Redak2";
            this.clm2.Name = "clm2";
            this.clm2.Width = 25;
            // 
            // clm3
            // 
            this.clm3.HeaderText = "Redak3";
            this.clm3.Name = "clm3";
            this.clm3.Width = 25;
            // 
            // clm4
            // 
            this.clm4.HeaderText = "Redak4";
            this.clm4.Name = "clm4";
            this.clm4.Width = 25;
            // 
            // clm5
            // 
            this.clm5.HeaderText = "Redak5";
            this.clm5.Name = "clm5";
            this.clm5.Width = 25;
            // 
            // clm6
            // 
            this.clm6.HeaderText = "Redak6";
            this.clm6.Name = "clm6";
            this.clm6.Width = 25;
            // 
            // clm7
            // 
            this.clm7.HeaderText = "Redak7";
            this.clm7.Name = "clm7";
            this.clm7.Width = 25;
            // 
            // clm8
            // 
            this.clm8.HeaderText = "Redak8";
            this.clm8.Name = "clm8";
            this.clm8.Width = 25;
            // 
            // clm9
            // 
            this.clm9.HeaderText = "Redak9";
            this.clm9.Name = "clm9";
            this.clm9.Width = 25;
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Location = new System.Drawing.Point(90, 245);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(72, 23);
            this.btnProvjeri.TabIndex = 10;
            this.btnProvjeri.Text = "Provjeri";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // frmSudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 284);
            this.Controls.Add(this.btnProvjeri);
            this.Controls.Add(this.dgvSlagalica);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.lblRazina);
            this.Controls.Add(this.cmbRazina);
            this.Controls.Add(this.btnRjesenje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.frmSudoku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlagalica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRjesenje;
        private System.Windows.Forms.ComboBox cmbRazina;
        private System.Windows.Forms.Label lblRazina;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.DataGridView dgvSlagalica;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm9;
        private System.Windows.Forms.Button btnProvjeri;
    }
}

