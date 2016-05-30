using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GoFish
{
    internal class Game
    {
        private List<string> list;
        private string text;
        private TextBox textProgress;

        public Game(string text, List<string> list, TextBox textProgress)
        {
            this.text = text;
            this.list = list;
            this.textProgress = textProgress;
        }

        internal IEnumerable<string> GetPlayerCardNames()
        {
            throw new NotImplementedException();
        }

        internal string DescribeBooks()
        {
            throw new NotImplementedException();
        }

        internal string DescribePlayerHands()
        {
            throw new NotImplementedException();
        }

        internal bool PlayOneRound(int selectedIndex)
        {
            throw new NotImplementedException();
        }

        internal string GetWinnerName()
        {
            throw new NotImplementedException();
        }
    }
}