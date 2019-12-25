using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgestorAdministrator.View.Components.DefualtHeader
{
    public partial class TopHeader : UserControl
    {
        public TopHeader(string title, string sub_title)
        {
            InitializeComponent();
            _title = title;
            _sub_title = sub_title;
        }
        private string _title     = null;
        private string _sub_title = null;
        private void TopHeader_Load(object sender, EventArgs e)
        {
            lbl_title.Text = $"{_title}/{_sub_title}";
        }
    }
}
