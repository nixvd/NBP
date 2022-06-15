namespace FakultetskiOrganizator
{
    partial class PregledPredmeta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nazivPredmeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojBodova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojStudenata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivPredmeta,
            this.brojBodova,
            this.asistent,
            this.brojStudenata,
            this.profesor});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(655, 258);
            this.dataGridView.TabIndex = 1;
            // 
            // nazivPredmeta
            // 
            this.nazivPredmeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivPredmeta.DefaultCellStyle = dataGridViewCellStyle5;
            this.nazivPredmeta.HeaderText = "Naziv predmeta";
            this.nazivPredmeta.Name = "nazivPredmeta";
            this.nazivPredmeta.ReadOnly = true;
            this.nazivPredmeta.Width = 97;
            // 
            // brojBodova
            // 
            this.brojBodova.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brojBodova.HeaderText = "Broj bodova";
            this.brojBodova.Name = "brojBodova";
            this.brojBodova.ReadOnly = true;
            this.brojBodova.Width = 82;
            // 
            // asistent
            // 
            this.asistent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.asistent.HeaderText = "Asistent";
            this.asistent.Name = "asistent";
            this.asistent.ReadOnly = true;
            this.asistent.Width = 69;
            // 
            // brojStudenata
            // 
            this.brojStudenata.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brojStudenata.HeaderText = "Broj studenata";
            this.brojStudenata.Name = "brojStudenata";
            this.brojStudenata.ReadOnly = true;
            this.brojStudenata.Width = 92;
            // 
            // profesor
            // 
            this.profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.profesor.HeaderText = "Profesor";
            this.profesor.Name = "profesor";
            this.profesor.ReadOnly = true;
            this.profesor.Width = 71;
            // 
            // PregledPredmeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 288);
            this.Controls.Add(this.dataGridView);
            this.Name = "PregledPredmeta";
            this.Text = "PregledPredmeta";
            this.Load += new System.EventHandler(this.PregledPredmeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojBodova;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistent;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojStudenata;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesor;
    }
}