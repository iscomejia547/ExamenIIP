namespace ExamenIIP.UI
{
    partial class ClienteDLG
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
            this.label8 = new System.Windows.Forms.Label();
            this.fieldpanel = new System.Windows.Forms.Panel();
            this.cedufield = new System.Windows.Forms.MaskedTextBox();
            this.celnumfield = new System.Windows.Forms.MaskedTextBox();
            this.emailfield = new System.Windows.Forms.TextBox();
            this.addressfield = new System.Windows.Forms.TextBox();
            this.snamefield = new System.Windows.Forms.TextBox();
            this.namefield = new System.Windows.Forms.TextBox();
            this.statefield = new System.Windows.Forms.TextBox();
            this.cityfield = new System.Windows.Forms.TextBox();
            this.okbtn = new System.Windows.Forms.Button();
            this.fieldpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(40, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(40, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(40, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(40, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(40, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Municipio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(40, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Departamento";
            // 
            // fieldpanel
            // 
            this.fieldpanel.Controls.Add(this.cityfield);
            this.fieldpanel.Controls.Add(this.statefield);
            this.fieldpanel.Controls.Add(this.namefield);
            this.fieldpanel.Controls.Add(this.snamefield);
            this.fieldpanel.Controls.Add(this.addressfield);
            this.fieldpanel.Controls.Add(this.emailfield);
            this.fieldpanel.Controls.Add(this.celnumfield);
            this.fieldpanel.Controls.Add(this.cedufield);
            this.fieldpanel.Location = new System.Drawing.Point(144, 12);
            this.fieldpanel.Name = "fieldpanel";
            this.fieldpanel.Size = new System.Drawing.Size(227, 448);
            this.fieldpanel.TabIndex = 8;
            // 
            // cedufield
            // 
            this.cedufield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cedufield.Location = new System.Drawing.Point(0, 137);
            this.cedufield.Mask = "###-######-####L";
            this.cedufield.Name = "cedufield";
            this.cedufield.Size = new System.Drawing.Size(200, 23);
            this.cedufield.TabIndex = 0;
            // 
            // celnumfield
            // 
            this.celnumfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.celnumfield.Location = new System.Drawing.Point(0, 197);
            this.celnumfield.Mask = "########";
            this.celnumfield.Name = "celnumfield";
            this.celnumfield.Size = new System.Drawing.Size(200, 23);
            this.celnumfield.TabIndex = 1;
            // 
            // emailfield
            // 
            this.emailfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailfield.Location = new System.Drawing.Point(0, 252);
            this.emailfield.Name = "emailfield";
            this.emailfield.Size = new System.Drawing.Size(200, 23);
            this.emailfield.TabIndex = 2;
            // 
            // addressfield
            // 
            this.addressfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressfield.Location = new System.Drawing.Point(0, 305);
            this.addressfield.Name = "addressfield";
            this.addressfield.Size = new System.Drawing.Size(200, 23);
            this.addressfield.TabIndex = 3;
            // 
            // snamefield
            // 
            this.snamefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.snamefield.Location = new System.Drawing.Point(0, 77);
            this.snamefield.Name = "snamefield";
            this.snamefield.Size = new System.Drawing.Size(200, 23);
            this.snamefield.TabIndex = 4;
            // 
            // namefield
            // 
            this.namefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.namefield.Location = new System.Drawing.Point(0, 17);
            this.namefield.Name = "namefield";
            this.namefield.Size = new System.Drawing.Size(200, 23);
            this.namefield.TabIndex = 5;
            // 
            // statefield
            // 
            this.statefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.statefield.Location = new System.Drawing.Point(0, 416);
            this.statefield.Name = "statefield";
            this.statefield.Size = new System.Drawing.Size(200, 23);
            this.statefield.TabIndex = 6;
            // 
            // cityfield
            // 
            this.cityfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cityfield.Location = new System.Drawing.Point(0, 365);
            this.cityfield.Name = "cityfield";
            this.cityfield.Size = new System.Drawing.Size(200, 23);
            this.cityfield.TabIndex = 7;
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(137, 466);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 9;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            // 
            // ClienteDLG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 501);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.fieldpanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteDLG";
            this.Shown += new System.EventHandler(this.ClienteDLG_Shown);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel fieldpanel;
        private System.Windows.Forms.TextBox cityfield;
        private System.Windows.Forms.TextBox statefield;
        private System.Windows.Forms.TextBox namefield;
        private System.Windows.Forms.TextBox snamefield;
        private System.Windows.Forms.TextBox addressfield;
        private System.Windows.Forms.TextBox emailfield;
        private System.Windows.Forms.MaskedTextBox celnumfield;
        private System.Windows.Forms.MaskedTextBox cedufield;
        private System.Windows.Forms.Button okbtn;
    }
}