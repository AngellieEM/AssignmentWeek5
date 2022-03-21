namespace AssignmentWeek5
{
    partial class FormMateri
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
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.radioButtonMerah = new System.Windows.Forms.RadioButton();
            this.radioButtonBiru = new System.Windows.Forms.RadioButton();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelOutputTulisan = new System.Windows.Forms.Label();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(32, 38);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(36, 13);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data: ";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(73, 35);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(317, 20);
            this.textBoxData.TabIndex = 1;
            this.textBoxData.TextChanged += new System.EventHandler(this.textBoxData_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(406, 35);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(309, 91);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(47, 17);
            this.checkBoxAktif.TabIndex = 3;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(258, 91);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(43, 13);
            this.labelSetting.TabIndex = 4;
            this.labelSetting.Text = "Setting:";
            // 
            // radioButtonMerah
            // 
            this.radioButtonMerah.AutoSize = true;
            this.radioButtonMerah.Location = new System.Drawing.Point(281, 114);
            this.radioButtonMerah.Name = "radioButtonMerah";
            this.radioButtonMerah.Size = new System.Drawing.Size(90, 17);
            this.radioButtonMerah.TabIndex = 5;
            this.radioButtonMerah.TabStop = true;
            this.radioButtonMerah.Text = "Warna Merah";
            this.radioButtonMerah.UseVisualStyleBackColor = true;
            this.radioButtonMerah.CheckedChanged += new System.EventHandler(this.radioButtonMerah_CheckedChanged);
            // 
            // radioButtonBiru
            // 
            this.radioButtonBiru.AutoSize = true;
            this.radioButtonBiru.Location = new System.Drawing.Point(281, 137);
            this.radioButtonBiru.Name = "radioButtonBiru";
            this.radioButtonBiru.Size = new System.Drawing.Size(78, 17);
            this.radioButtonBiru.TabIndex = 6;
            this.radioButtonBiru.TabStop = true;
            this.radioButtonBiru.Text = "Warna Biru";
            this.radioButtonBiru.UseVisualStyleBackColor = true;
            this.radioButtonBiru.CheckedChanged += new System.EventHandler(this.radioButtonBiru_CheckedChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(258, 176);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(42, 13);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "Output:";
            // 
            // labelOutputTulisan
            // 
            this.labelOutputTulisan.AutoSize = true;
            this.labelOutputTulisan.Location = new System.Drawing.Point(297, 289);
            this.labelOutputTulisan.Name = "labelOutputTulisan";
            this.labelOutputTulisan.Size = new System.Drawing.Size(16, 13);
            this.labelOutputTulisan.TabIndex = 8;
            this.labelOutputTulisan.Text = "...";
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(32, 118);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(44, 13);
            this.labelKoleksi.TabIndex = 9;
            this.labelKoleksi.Text = "Koleksi:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 290);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FormMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 459);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.labelOutputTulisan);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.radioButtonBiru);
            this.Controls.Add(this.radioButtonMerah);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelData);
            this.Name = "FormMateri";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.FormMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.RadioButton radioButtonMerah;
        private System.Windows.Forms.RadioButton radioButtonBiru;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelOutputTulisan;
        private System.Windows.Forms.Label labelKoleksi;
        private System.Windows.Forms.ListBox listBox1;
    }
}

