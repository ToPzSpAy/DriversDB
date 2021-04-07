using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversApp
{
    public partial class NewPersonAuto : Form
    {
        public NewPersonAuto()
        {
            InitializeComponent();
        }

        private void autoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driversDataSetNew);

        }

        private void NewPersonAuto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDataSetNew.auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.driversDataSetNew.auto);

        }
    }
}
