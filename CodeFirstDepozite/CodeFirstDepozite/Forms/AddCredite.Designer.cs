namespace CodeFirstDepozite.Forms
{
    partial class AddCredite
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dtp_CrediteDate = new System.Windows.Forms.DateTimePicker();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_name = new System.Windows.Forms.Label();
            this.Btn_ShowAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Dtp_CrediteDate);
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txb_Price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Lbl_name);
            this.panel1.Location = new System.Drawing.Point(70, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 248);
            this.panel1.TabIndex = 0;
            // 
            // Dtp_CrediteDate
            // 
            this.Dtp_CrediteDate.CustomFormat = "dd-MM-yyyy";
            this.Dtp_CrediteDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_CrediteDate.Location = new System.Drawing.Point(28, 151);
            this.Dtp_CrediteDate.Name = "Dtp_CrediteDate";
            this.Dtp_CrediteDate.Size = new System.Drawing.Size(176, 20);
            this.Dtp_CrediteDate.TabIndex = 3;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(131, 190);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(73, 29);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.Text = "SAVE";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Credit";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txb_Price
            // 
            this.Txb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Price.Location = new System.Drawing.Point(28, 90);
            this.Txb_Price.Multiline = true;
            this.Txb_Price.Name = "Txb_Price";
            this.Txb_Price.Size = new System.Drawing.Size(176, 27);
            this.Txb_Price.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_name
            // 
            this.Lbl_name.AutoSize = true;
            this.Lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_name.Location = new System.Drawing.Point(24, 27);
            this.Lbl_name.Name = "Lbl_name";
            this.Lbl_name.Size = new System.Drawing.Size(51, 20);
            this.Lbl_name.TabIndex = 0;
            this.Lbl_name.Text = "Name";
            // 
            // Btn_ShowAll
            // 
            this.Btn_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ShowAll.Location = new System.Drawing.Point(227, 305);
            this.Btn_ShowAll.Name = "Btn_ShowAll";
            this.Btn_ShowAll.Size = new System.Drawing.Size(82, 27);
            this.Btn_ShowAll.TabIndex = 1;
            this.Btn_ShowAll.Text = "Show All";
            this.Btn_ShowAll.UseVisualStyleBackColor = true;
            this.Btn_ShowAll.Click += new System.EventHandler(this.Btn_ShowAll_Click);
            // 
            // AddCredite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 370);
            this.Controls.Add(this.Btn_ShowAll);
            this.Controls.Add(this.panel1);
            this.Name = "AddCredite";
            this.Text = "AddCredite";
            this.Load += new System.EventHandler(this.AddCredite_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txb_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_name;
        private System.Windows.Forms.DateTimePicker Dtp_CrediteDate;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_ShowAll;
    }
}