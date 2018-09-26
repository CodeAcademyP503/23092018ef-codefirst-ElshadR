using CodeFirstDepozite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstDepozite.Forms
{
    public partial class AddCredite : Form
    {
        public AddCredite()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            using (DepoziteDbContext db = new DepoziteDbContext())
            {
                decimal amount;
                Decimal.TryParse(Txb_Price.Text,out amount);
                if (amount != 0)
                {
                    db.Credits.Add(new Credit()
                    {
                        Amount = amount,
                        OpenDatetime = Dtp_CrediteDate.Value,
                        Person_Id = db.People.ToList().Last().Id,
                    });
                    db.SaveChanges();
                }
            }
        }

        private void AddCredite_Load(object sender, EventArgs e)
        {
            using(DepoziteDbContext db = new DepoziteDbContext())
            {
                Lbl_name.Text = db.People.ToList().Last().Name;
            }
        }

        private void Btn_ShowAll_Click(object sender, EventArgs e)
        {
            new AllPersonForm().ShowDialog();
        }
    }
}
