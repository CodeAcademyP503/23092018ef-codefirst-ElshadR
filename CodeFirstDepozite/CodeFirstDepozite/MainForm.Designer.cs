namespace CodeFirstDepozite
{
    partial class MainForm
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
            this.Pa_AddPerson = new System.Windows.Forms.Panel();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Txb_PasportNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_Surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_Name = new System.Windows.Forms.TextBox();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.Btn_AddCredit = new System.Windows.Forms.Button();
            this.Pa_AddPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pa_AddPerson
            // 
            this.Pa_AddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pa_AddPerson.Controls.Add(this.Btn_AddCredit);
            this.Pa_AddPerson.Controls.Add(this.Btn_Save);
            this.Pa_AddPerson.Controls.Add(this.Txb_PasportNumber);
            this.Pa_AddPerson.Controls.Add(this.label2);
            this.Pa_AddPerson.Controls.Add(this.Txb_Surname);
            this.Pa_AddPerson.Controls.Add(this.label1);
            this.Pa_AddPerson.Controls.Add(this.Txb_Name);
            this.Pa_AddPerson.Controls.Add(this.Lb_Name);
            this.Pa_AddPerson.Location = new System.Drawing.Point(76, 45);
            this.Pa_AddPerson.Name = "Pa_AddPerson";
            this.Pa_AddPerson.Size = new System.Drawing.Size(265, 296);
            this.Pa_AddPerson.TabIndex = 0;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Location = new System.Drawing.Point(142, 235);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(78, 33);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "SAVE";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txb_PasportNumber
            // 
            this.Txb_PasportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_PasportNumber.Location = new System.Drawing.Point(35, 189);
            this.Txb_PasportNumber.Multiline = true;
            this.Txb_PasportNumber.Name = "Txb_PasportNumber";
            this.Txb_PasportNumber.Size = new System.Drawing.Size(185, 27);
            this.Txb_PasportNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pasport Number";
            // 
            // Txb_Surname
            // 
            this.Txb_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Surname.Location = new System.Drawing.Point(35, 119);
            this.Txb_Surname.Multiline = true;
            this.Txb_Surname.Name = "Txb_Surname";
            this.Txb_Surname.Size = new System.Drawing.Size(185, 27);
            this.Txb_Surname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Surname";
            // 
            // Txb_Name
            // 
            this.Txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Name.Location = new System.Drawing.Point(35, 50);
            this.Txb_Name.Multiline = true;
            this.Txb_Name.Name = "Txb_Name";
            this.Txb_Name.Size = new System.Drawing.Size(185, 27);
            this.Txb_Name.TabIndex = 3;
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.Location = new System.Drawing.Point(31, 27);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(51, 20);
            this.Lb_Name.TabIndex = 2;
            this.Lb_Name.Text = "Name";
            // 
            // Btn_AddCredit
            // 
            this.Btn_AddCredit.Location = new System.Drawing.Point(30, 235);
            this.Btn_AddCredit.Name = "Btn_AddCredit";
            this.Btn_AddCredit.Size = new System.Drawing.Size(75, 33);
            this.Btn_AddCredit.TabIndex = 1;
            this.Btn_AddCredit.Text = "Add Credit";
            this.Btn_AddCredit.UseVisualStyleBackColor = true;
            this.Btn_AddCredit.Click += new System.EventHandler(this.Btn_AddCredit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 388);
            this.Controls.Add(this.Pa_AddPerson);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Pa_AddPerson.ResumeLayout(false);
            this.Pa_AddPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pa_AddPerson;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox Txb_PasportNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_Surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_Name;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.Button Btn_AddCredit;
    }
}

