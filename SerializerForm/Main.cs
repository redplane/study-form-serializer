using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializerForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnStoreForm_Click(object sender, EventArgs e)
        {
            var applicationPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
        }
    }
}
