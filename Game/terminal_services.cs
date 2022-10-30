namespace jumper {
    /// <summary>
    /// Responsible for interacting with the terminal
    /// </summary>
    public class Terminal_services {   
        public Terminal_services() {
        }
        /// <summary>
        /// Converts string from user to Char type
        /// </summary>
        public char getCharacter(string prompt) {
            char choice = char.Parse(getString(prompt));
            return choice;
        }
        /// <summary>
        /// Gets user input
        /// </summary>
        private string getString(string prompt) {
            Console.Write(prompt);
            string? response = Console.ReadLine();
            if (response is not null) {
                return response;
            }
            else {
                response = " ";
                return response;
            }            
        }
        /// <summary>
        /// Writes string to terminal
        /// </summary>
        public void write(string text) {
            Console.WriteLine(text);
        }
        /// <summary>
        /// Creates blank line
        /// </summary>
        public void blankLine() {
            Console.WriteLine();
        }

    }
}

