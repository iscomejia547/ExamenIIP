namespace ExamenIIP.UI
{
    partial class ExtDLG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.brandfield = new System.Windows.Forms.TextBox();
            this.qtyfield = new System.Windows.Forms.TextBox();
            this.clfield = new System.Windows.Forms.TextBox();
            this.catcmb = new System.Windows.Forms.ComboBox();
            this.typecmb = new System.Windows.Forms.ComboBox();
            this.unitcmb = new System.Windows.Forms.ComboBox();
            this.datefield = new System.Windows.Forms.DateTimePicker();
            this.fieldpanel = new System.Windows.Forms.Panel();
            this.okbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.placefield = new System.Windows.Forms.TextBox();
            this.fieldpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(41, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(41, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(41, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(41, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unidad de medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(41, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de vencimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(41, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID Cliente";
            // 
            // brandfield
            // 
            this.brandfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.brandfield.Location = new System.Drawing.Point(14, 68);
            this.brandfield.Name = "brandfield";
            this.brandfield.Size = new System.Drawing.Size(200, 23);
            this.brandfield.TabIndex = 7;
            this.brandfield.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // qtyfield
            // 
            this.qtyfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.qtyfield.Location = new System.Drawing.Point(14, 157);
            this.qtyfield.Name = "qtyfield";
            this.qtyfield.Size = new System.Drawing.Size(200, 23);
            this.qtyfield.TabIndex = 8;
            // 
            // clfield
            // 
            this.clfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clfield.Location = new System.Drawing.Point(14, 360);
            this.clfield.Name = "clfield";
            this.clfield.Size = new System.Drawing.Size(200, 23);
            this.clfield.TabIndex = 10;
            // 
            // catcmb
            // 
            this.catcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.catcmb.FormattingEnabled = true;
            this.catcmb.Items.AddRange(new object[] {
            "A",
            "B",
            "E"});
            this.catcmb.Location = new System.Drawing.Point(14, 19);
            this.catcmb.Name = "catcmb";
            this.catcmb.Size = new System.Drawing.Size(200, 24);
            this.catcmb.TabIndex = 11;
            // 
            // typecmb
            // 
            this.typecmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.typecmb.FormattingEnabled = true;
            this.typecmb.Location = new System.Drawing.Point(14, 113);
            this.typecmb.Name = "typecmb";
            this.typecmb.Size = new System.Drawing.Size(200, 24);
            this.typecmb.TabIndex = 12;
            // 
            // unitcmb
            // 
            this.unitcmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.unitcmb.FormattingEnabled = true;
            this.unitcmb.Items.AddRange(new object[] {
            "Lts",
            "Glns",
            "Oz"});
            this.unitcmb.Location = new System.Drawing.Point(14, 206);
            this.unitcmb.Name = "unitcmb";
            this.unitcmb.Size = new System.Drawing.Size(200, 24);
            this.unitcmb.TabIndex = 13;
            // 
            // datefield
            // 
            this.datefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datefield.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefield.Location = new System.Drawing.Point(14, 306);
            this.datefield.Name = "datefield";
            this.datefield.Size = new System.Drawing.Size(200, 23);
            this.datefield.TabIndex = 14;
            // 
            // fieldpanel
            // 
            this.fieldpanel.Controls.Add(this.placefield);
            this.fieldpanel.Controls.Add(this.clfield);
            this.fieldpanel.Controls.Add(this.datefield);
            this.fieldpanel.Controls.Add(this.catcmb);
            this.fieldpanel.Controls.Add(this.unitcmb);
            this.fieldpanel.Controls.Add(this.brandfield);
            this.fieldpanel.Controls.Add(this.typecmb);
            this.fieldpanel.Controls.Add(this.qtyfield);
            this.fieldpanel.Location = new System.Drawing.Point(193, 12);
            this.fieldpanel.Name = "fieldpanel";
            this.fieldpanel.Size = new System.Drawing.Size(229, 401);
            this.fieldpanel.TabIndex = 15;
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(193, 431);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 16;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(42, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lugar de inst.";
            // 
            // placefield
            // 
            this.placefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.placefield.Location = new System.Drawing.Point(14, 256);
            this.placefield.Name = "placefield";
            this.placefield.Size = new System.Drawing.Size(200, 23);
            this.placefield.TabIndex = 15;
            // 
            // ExtDLG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 466);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtDLG";
            this.Text = "Extintor";
            this.Load += new System.EventHandler(this.ExtDLG_Load);
            this.fieldpanel.ResumeLayout(false);
            this.fieldpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox brandfield;
        private System.Windows.Forms.TextBox qtyfield;
        private System.Windows.Forms.TextBox clfield;
        private System.Windows.Forms.ComboBox catcmb;
        private System.Windows.Forms.ComboBox typecmb;
        private System.Windows.Forms.ComboBox unitcmb;
        private System.Windows.Forms.DateTimePicker datefield;
        private System.Windows.Forms.Panel fieldpanel;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.TextBox placefield;
        private System.Windows.Forms.Label label8;
    }
}