namespace jumper {
    /// <sumary>
    /// Controls game play loop
    /// </sumary>
    public class Director {
        private Jumper jumper = new Jumper();
        private Word word = new Word();
        private bool playing = true;
        private Terminal_services terminal = new Terminal_services();
        /// <summary>
        /// Makes new intance of director
        /// </summary>
        public Director() {
        }
        /// <summary>
        /// loops through gameplay loop
        /// </summary>
        public void startGame() {
            while (playing) {
                inputs();
                updates();
                outputs();
            }
        }
        /// <summary>
        /// Gets inputs from user
        /// </summary>
        private void inputs() {
            char guess = terminal.getCharacter("Guess a letter [a-z]: ");
            bool isRight = word.isLetter(guess);
            jumper.calculateLife(isRight);
            word.changeDisplay(guess);
        }
        /// <summary>
        /// Calculates whether game has been won or lost
        /// </summary>
        private void updates() {
            bool lost = jumper.lost();
            bool won = jumper.won(word.generateDisplay());
        }
        /// <summary>
        /// Outputs to the terminal, determines if game is over
        /// </summary>
        private void outputs() {
            terminal.blankLine();
            terminal.write(word.generateDisplay());
            terminal.blankLine();
            terminal.write(jumper.createStatus());
            terminal.blankLine();
            if (jumper.lost()) {
                playing = false;
            }
            if (jumper.won(word.generateDisplay())) {
                playing = false;
                terminal.write("You Won!!!");
            }
        }
    }
}