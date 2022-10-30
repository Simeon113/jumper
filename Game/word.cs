namespace jumper {
    /// <summary>
    /// keeps track of the word and how much player has guessed
    /// </summary>
    public class Word {
        private string word;
        private List<char> displayedWord = new List<char>();
        private string displayedWordString;
        /// <summary>
        /// Generates a new random word
        /// </summary>
        public Word() {
            Random random = new Random();
            string[] words = System.IO.File.ReadAllLines(@"Game/words.txt");
            word = words[random.Next(466550)];
            displayedWordString = generateInitialDisplay(word, displayedWord);
        }
        /// <summary>
        /// determines if a players guess was correct
        /// </summary>
        public bool isLetter(char guess) {
            bool isRight = false;
            int word_place = 0;
            foreach (char l in word) {
                if (l == guess) {
                    word_place ++;
                    isRight = true;
                }                
            }
            return isRight;            
        }
        /// <summary>
        /// determines how many blank spaces to diplay based off length of word
        /// </summary>
        private string generateInitialDisplay (string word, List<char> displayedWord) {
            // int length = word.Length;
            for (int i = 0; i < word.Length; i++) {
                displayedWord.Add('_');
                displayedWordString = new string(displayedWord.ToArray());
            }
            return displayedWordString;
        }
        /// <summary>
        /// Replaces blank spaces with correct guesss
        /// </summary>
        public void changeDisplay (char guess) {
            int word_place = -1;
            foreach (char l in word) {
                word_place ++;               
                if (l == guess) {                  
                    displayedWord[word_place] = l;
                    this.displayedWordString = new string(displayedWord.ToArray());          
                }
            }
        }
        /// <summary>
        /// Gets the current word display
        /// </summary>
        public string generateDisplay () {
            return displayedWordString;
        }       
    }
}

