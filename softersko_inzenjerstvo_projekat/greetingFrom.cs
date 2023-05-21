using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softersko_inzenjerstvo_projekat
{
    public partial class greetingFrom : Form
    {
        public greetingFrom()
        {
            InitializeComponent();
        }

        private void greetingFrom_Load(object sender, EventArgs e) {
            //geting current date
            DateTime today = DateTime.Now;
            greetingMsg.Text = "Howdy admin, what is on your mind today?";
            dateLabel.Text = today.ToString();
        }
  
    }
}
