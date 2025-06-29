namespace zoo
{
    partial class ReservesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView zapovednikGridView;
        private System.Windows.Forms.DataGridView reserveGridView;
        private System.Windows.Forms.Label lblZapovednik;
        private System.Windows.Forms.Label lblReserve;
        private System.Windows.Forms.Button btnBack;

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
            this.zapovednikGridView = new System.Windows.Forms.DataGridView();
            this.reserveGridView = new System.Windows.Forms.DataGridView();
            this.lblZapovednik = new System.Windows.Forms.Label();
            this.lblReserve = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zapovednikGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // zapovednikGridView
            // 
            this.zapovednikGridView.AllowUserToAddRows = false;
            this.zapovednikGridView.AllowUserToDeleteRows = false;
            this.zapovednikGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zapovednikGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zapovednikGridView.Location = new System.Drawing.Point(12, 35);
            this.zapovednikGridView.Name = "zapovednikGridView";
            this.zapovednikGridView.ReadOnly = true;
            this.zapovednikGridView.Size = new System.Drawing.Size(760, 180);
            this.zapovednikGridView.TabIndex = 0;
            // 
            // reserveGridView
            // 
            this.reserveGridView.AllowUserToAddRows = false;
            this.reserveGridView.AllowUserToDeleteRows = false;
            this.reserveGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reserveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserveGridView.Location = new System.Drawing.Point(12, 250);
            this.reserveGridView.Name = "reserveGridView";
            this.reserveGridView.ReadOnly = true;
            this.reserveGridView.Size = new System.Drawing.Size(760, 180);
            this.reserveGridView.TabIndex = 1;
            // 
            // lblZapovednik
            // 
            this.lblZapovednik.AutoSize = true;
            this.lblZapovednik.Location = new System.Drawing.Point(12, 15);
            this.lblZapovednik.Name = "lblZapovednik";
            this.lblZapovednik.Size = new System.Drawing.Size(77, 13);
            this.lblZapovednik.TabIndex = 2;
            this.lblZapovednik.Text = "Заповедники:";
            // 
            // lblReserve
            // 
            this.lblReserve.AutoSize = true;
            this.lblReserve.Location = new System.Drawing.Point(12, 230);
            this.lblReserve.Name = "lblReserve";
            this.lblReserve.Size = new System.Drawing.Size(55, 13);
            this.lblReserve.TabIndex = 3;
            this.lblReserve.Text = "Резервы:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(672, 440);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReservesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblReserve);
            this.Controls.Add(this.lblZapovednik);
            this.Controls.Add(this.reserveGridView);
            this.Controls.Add(this.zapovednikGridView);
            this.Name = "ReservesForm";
            this.Text = "Заповедники и Резервы";
            ((System.ComponentModel.ISupportInitialize)(this.zapovednikGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}