using System;
using System.Windows.Forms;
using TradeApplication.Models;

namespace TradeApplication
{
    public partial class firmForm : Form
    {
        public firmForm()
        {
            InitializeComponent();
        }

        private void saveFirmsBtn_Click(object sender, EventArgs e)
        {
            using (var db = new dbContext())
            {
                var Firm = new Firm();

                db.Firms.Add(new Firm()
                {
                    Fullname = fulnameBox.Text,
                    Name = nameBox.Text,
                    Form = formBox.Text,
                    Director = directorlBox.Text,
                    Accountant = accountantBox.Text,
                    LegalAdress = legalAdressBox.Text,
                    Address = adressBox.Text,
                    Phone = phoneBox.Text,
                    Email = emailBox.Text,
                    Site = siteBox.Text,
                    INN = innBox.Text,
                    KPP = kppBox.Text,
                    OKPO = okpoBox.Text,
                    OGRN = ogrnBox.Text,
                    OKVED = okvdBox.Text,
                    OKATO = okatoBox.Text,
                    CheckingAccount = checkingAccountBox.Text,
                    CorrespondentAccount = correspondentAccountBox.Text,
                    Bank = bankBox.Text,
                    BIK = bikBox.Text
                });

                db.SaveChanges();
            }
        }
    }
}
