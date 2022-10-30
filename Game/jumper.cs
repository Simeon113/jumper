namespace jumper {
    /// <summary>
    /// Keeps track of position of player
    /// </summary>
    public class Jumper {   
        private List<string> status = new List<string> () {"  ___  ", @" /___\ ", @" \   / ", @"  \ /  ", "   0   ",@"  /|\  ",@"  / \  ","","^^^^^^^"};   
        public Jumper(){
        }
        /// <summary>
        /// creates graphic of player
        /// </summary>
        public string createStatus() {
            List<string> displayStatus = new List<string> ();
            for (int i = 0; i < status.Count; i++) {
                string line = status[i];
                displayStatus.Add(line);
            }
            string displayStatusString = string.Join('\n', displayStatus);
            return displayStatusString;
        }
        /// <summary>
        /// Determines if the player has lost
        /// </summary>
        public bool lost() {
            bool lost = false;
            if (status.Count < 6) {
                status[0] = "   x   ";
                lost = true;
            }
            return lost;
        }
        /// <summary>
        /// Determines if the player has won
        /// </summary>
        public bool won(string displayed_word) {
            bool won = false;
            bool complete = displayed_word.Contains('_');
            if (complete == false) {
                won = true;
            }
            return won;
        }
        /// <summary>
        /// determines whether life is taken away
        /// </summary>
        public void calculateLife(bool isRight) {
            if (isRight == false) {
                loseLife(status);
            }
        }
        /// <summary>
        /// takes away life
        /// </summary>
        private void loseLife(List<string> status) {
            status.RemoveAt(0);      
        }
    }
}

