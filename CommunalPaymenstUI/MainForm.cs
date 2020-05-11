using System.Linq;
using System.Windows.Forms;
using CPLogic.Model;

namespace CommunalPaymenstUI
{
    public partial class MainForm : Form
    {
        CPContext db;
        public MainForm()
        {
            InitializeComponent();
            db = new CPContext();
            var Rates = db.Rates.Where(rate => rate.Value != null);

            if (!Rates.Any())
            {
                MainLabel.Text = "В данный момент в справочнике \"Тарифы\" нет записей. Добавьте тариф.";
            }
            else
            {
                MainLabel.Text = $"Текукщий тариф: {Rates.Last()} р/м2";
            }
        }

        private void HousesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
