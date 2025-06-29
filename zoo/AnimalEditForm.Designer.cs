namespace zoo
{
    partial class AnimalEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.ComboBox cmbCaretaker;
        private System.Windows.Forms.ComboBox cmbEnclosure;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblCaretaker;
        private System.Windows.Forms.Label lblEnclosure;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.cmbCaretaker = new System.Windows.Forms.ComboBox();
            this.cmbEnclosure = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblCaretaker = new System.Windows.Forms.Label();
            this.lblEnclosure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(114, 41);
            this.numNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(120, 20);
            this.numNumber.TabIndex = 3;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.Location = new System.Drawing.Point(114, 72);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(200, 20);
            this.dtpArrivalDate.TabIndex = 5;
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.Location = new System.Drawing.Point(114, 102);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(200, 21);
            this.cmbSpecies.TabIndex = 7;
            // 
            // cmbCaretaker
            // 
            this.cmbCaretaker.Location = new System.Drawing.Point(114, 129);
            this.cmbCaretaker.Name = "cmbCaretaker";
            this.cmbCaretaker.Size = new System.Drawing.Size(200, 21);
            this.cmbCaretaker.TabIndex = 9;
            // 
            // cmbEnclosure
            // 
            this.cmbEnclosure.Location = new System.Drawing.Point(114, 162);
            this.cmbEnclosure.Name = "cmbEnclosure";
            this.cmbEnclosure.Size = new System.Drawing.Size(200, 21);
            this.cmbEnclosure.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(112, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя:";
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(12, 45);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 23);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Номер:";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.Location = new System.Drawing.Point(12, 75);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(100, 23);
            this.lblArrivalDate.TabIndex = 4;
            this.lblArrivalDate.Text = "Дата прибытия:";
            // 
            // lblSpecies
            // 
            this.lblSpecies.Location = new System.Drawing.Point(12, 105);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(100, 23);
            this.lblSpecies.TabIndex = 6;
            this.lblSpecies.Text = "Вид:";
            // 
            // lblCaretaker
            // 
            this.lblCaretaker.Location = new System.Drawing.Point(12, 135);
            this.lblCaretaker.Name = "lblCaretaker";
            this.lblCaretaker.Size = new System.Drawing.Size(100, 23);
            this.lblCaretaker.TabIndex = 8;
            this.lblCaretaker.Text = "Смотритель:";
            // 
            // lblEnclosure
            // 
            this.lblEnclosure.Location = new System.Drawing.Point(12, 165);
            this.lblEnclosure.Name = "lblEnclosure";
            this.lblEnclosure.Size = new System.Drawing.Size(100, 23);
            this.lblEnclosure.TabIndex = 10;
            this.lblEnclosure.Text = "Вольер:";
            // 
            // AnimalEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.numNumber);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.dtpArrivalDate);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.cmbSpecies);
            this.Controls.Add(this.lblCaretaker);
            this.Controls.Add(this.cmbCaretaker);
            this.Controls.Add(this.lblEnclosure);
            this.Controls.Add(this.cmbEnclosure);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AnimalEditForm";
            this.Text = "AnimalEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}