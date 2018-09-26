using CodeFirstDepozite.Forms;
using CodeFirstDepozite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstDepozite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            using(DepoziteDbContext db=new DepoziteDbContext())
            {
                try
                {
                    db.People.Add(new Person()
                    {
                        Name = Txb_Name.Text,
                        Surname = Txb_Surname.Text,
                        PasportNumber = Txb_PasportNumber.Text
                    });

                    db.SaveChanges();

                    new AddCredite().ShowDialog();
                }
                catch (DbEntityValidationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void Btn_AddCredit_Click(object sender, EventArgs e)
        {

        }
    }
}
