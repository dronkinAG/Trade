using System.Data.Entity;
using System.Windows.Forms;

namespace TradeApplication
{
    public partial class firmsForm : Form
    {
        class FirmData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public int Age { get; set; }
        }

        public firmsForm()
        {
            InitializeComponent();

            using (var db = new dbContext())
            {
                grid.DataSource = db.Firms.Local.ToBindingList();
            }
        }

        private void addBtn_Click(object sender, System.EventArgs e)
        {
            var f = new firmForm();
            f.Show();
        }
    }
}
