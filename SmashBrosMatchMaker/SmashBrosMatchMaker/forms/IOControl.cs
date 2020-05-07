using SmashBrosMatchMaker.MatchInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SmashBrosMatchMaker.forms
{
    public sealed class IOControl
    {
        private static readonly object padlock = new object();     
        private static IOControl instance;
        public static IOControl Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new IOControl();
                    }
                    return instance;
                }
            }
        }                                                        //this and above makes class singleton
        Rules rulesForm;
        CharacterSelection selectionForm;
        public IOControl()
        {
            rulesForm = new Rules();
            selectionForm = new CharacterSelection();   

        }

        List<Character> characterList = new List<Character>();

        public void SetCharList(List<Character> newChar)
        {
            characterList = newChar;
        }
        public void openSelectionScreen(int numPlayers)
        {
            selectionForm.numPlayers = numPlayers;
            selectionForm.makeVisible();
            selectionForm.Show();
        }
    }
}
