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
    public partial class AllPersonForm : Form
    {
        public AllPersonForm()
        {
            InitializeComponent();
        }

        private void AllPersonForm_Load(object sender, EventArgs e)
        {
            using(DepoziteDbContext db=new DepoziteDbContext())
            {
                var People= db.People.ToList();
                var Credits = db.Credits.ToList();

                var newPerson= People.GroupJoin(Credits, p => p.Id, c => c.Person_Id, (person, credits) => new
                {
                    PersonName=person.Name,
                    PersonSurname=person.Surname,
                    PersonPasportNumber = person.PasportNumber,
                    SumAmount=credits.Sum(x=>x.Amount),
                });


                int index = 0;
                foreach (var person in newPerson)
                {
                    Dgw_AllPerson.Rows.Add();
                    Dgw_AllPerson.Rows[index].Cells[0].Value = person.PersonName;
                    Dgw_AllPerson.Rows[index].Cells[1].Value = person.PersonSurname;
                    Dgw_AllPerson.Rows[index].Cells[2].Value = person.PersonPasportNumber;
                    Dgw_AllPerson.Rows[index].Cells[3].Value = person.SumAmount;

                    index++;
                }

            }

        }
    }
}
