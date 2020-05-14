using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashBrosMatchMaker.forms
{
   public partial class Records : Form
   {
      static IOControl controller = IOControl.Instance;
      public String winner { get; set; }
      public Records()
      {
         InitializeComponent();
      }

      public void fillFields()
      {
         txbPlayer.Text = winner;
      }

      private void btnNewMatch_Click(object sender, EventArgs e)
      {
         this.Hide();
         controller.openRules();
      }
   }
}
