using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Sinema.UI
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Customer m = Genel.Service.Customer.SelectById(1);
            m.Name = "Serkan";
            m.Surname = "Karışan";
            m.Phone = "05355063330";
            Genel.Service.Customer.Update(m);
        }
    }
}
