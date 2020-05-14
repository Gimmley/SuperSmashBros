using SmashBrosMatchMaker.MatchInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data;

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
        Choose_Winner chooseWinnerForm;
        Records recordsForm;
        public IOControl()
        {
            rulesForm = new Rules();
            selectionForm = new CharacterSelection();
            chooseWinnerForm = new Choose_Winner();
            recordsForm = new Records();

        }
        public List<Player> GetPlayers()
        {
            return playerList;
        }

        List<Player> playerList = new List<Player>();
        public int numPlayers;
        public bool firstGame;

        public void SetPlayerList(List<Player> newPlayers)
        {
            foreach(Player newPlayer in newPlayers)
            {

                playerList.Add(newPlayer);

            }
            
        }
        public void openSelectionScreen(int numPlayers, bool isItems, int itemPercent)
        {
            this.numPlayers = numPlayers;
            if(firstGame)
                selectionForm.numPlayers = numPlayers;
            selectionForm.firstGame = firstGame;
            selectionForm.isItems = isItems;
            selectionForm.itemPercent = itemPercent;
            selectionForm.makeVisible();
            selectionForm.Show();
        }
        public void openChooseWinner(int numPlayers)
        {
            if(firstGame)
            {
                chooseWinnerForm.fillCombobox();
                chooseWinnerForm.numPlayers = numPlayers;
            }
            chooseWinnerForm.setPlayers(playerList);
            chooseWinnerForm.Show();
        }

        public void openRecords(Player winner)
        {
            recordsForm.winner = winner;
            recordsForm.fillFields();
            recordsForm.Show();
        }

        public void openRules()
        {
           rulesForm.newGame();
           rulesForm.Show();
        }
   }
}
