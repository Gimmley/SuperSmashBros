using SmashBrosMatchMaker.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmashBrosMatchMaker
{
    public partial class Rules : Form
    {
        static IOControl controller = IOControl.Instance;
        public Rules()
        {
            
            InitializeComponent();
        }
        //public int numPlayers { get; set; }

        private void bttConfirm_Click(object sender, EventArgs e)
        {
            int numPlayers = Convert.ToInt32(txtAIPlayers.Text) + Convert.ToInt32(txtHumanPlayers.Text);
            this.Hide();
            controller.openSelectionScreen(numPlayers);
            
        }
    }
}
