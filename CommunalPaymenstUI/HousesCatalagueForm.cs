using CPLogic.Model;
using System.Data.Entity;
using System.Windows.Forms;

namespace CommunalPaymenstUI
{
    public partial class HousesCatalogueForm : Form
    {
        CPContext db;
        public HousesCatalogueForm()
        {
            InitializeComponent();
            db = new CPContext();
            HousesDataGridView.DataSource = db.Houses.Local.ToBindingList();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            AddHouse addHouse = new AddHouse();
            if (addHouse.ShowDialog() == DialogResult.OK)
            {
                db.Houses.Add(addHouse.House);
                db.SaveChanges();
            }
        }

        private void HousesCatalogueForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
