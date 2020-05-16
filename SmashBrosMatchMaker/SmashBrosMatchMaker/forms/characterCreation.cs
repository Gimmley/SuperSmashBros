using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmashBrosMatchMaker.Database.Entities;
using SmashBrosMatchMaker.MatchInfo;

namespace SmashBrosMatchMaker.forms
{
    public partial class CharacterCreation : Form
    {
        static IOControl controller = IOControl.Instance;
        public CharacterCreation()
        {
            InitializeComponent();
        }
        public Match match = new Match();
        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (isEmpty()||!isValid())
                return;
            
            int ai;
            if (rdbAi.Checked == true)
            {
                ai = 2;
            }
            else
                ai = 1;
            Player newPlayer = new Player
            {
                PlayerName = txtName.Text,
                PlayerTypeId = ai
            };
            Database.DatabaseContext.Instance.Add(newPlayer);
            Database.DatabaseContext.Instance.SaveChanges();
            this.Hide();
            controller.openSelectionScreen(match);
            
        }
        private bool isEmpty()
        {
            if (txtName.Text == "")
            {
                lblError.Text = "Please input a Name";
                return true;
            }
            return false;
        }
        private bool isValid()
        {
            int count;
            count  = Database.DatabaseContext.Instance.CharacterTable.Where(foundChar => foundChar.CharacterName == txtName.Text).Count();
            if( count == 0)
            {
                lblError.Text = "That name is alreay taken";
                return true;
            }
            return false;

        }
    }
}
