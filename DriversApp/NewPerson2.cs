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
    public partial class NewPerson2 : Form
    {
        public NewPerson2()
        {
            InitializeComponent();
        }

        private void amogusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.amogusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driversDataSetNew);

        }

        private void amogusBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.amogusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driversDataSetNew);

        }

        private void NewPerson2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDataSetNew.Amogus". При необходимости она может быть перемещена или удалена.
            this.amogusTableAdapter.Fill(this.driversDataSetNew.Amogus);

        }
    }
}
