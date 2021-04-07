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
    public partial class NewPersonDL : Form
    {
        public NewPersonDL()
        {
            InitializeComponent();
        }

        private void driver_licenceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driver_licenceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driversDataSetNew);

        }

        private void NewPersonDL_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDataSetNew.driver_licence". При необходимости она может быть перемещена или удалена.
            this.driver_licenceTableAdapter.Fill(this.driversDataSetNew.driver_licence);

        }
    }
}
