namespace AlgoExpert
{
    using System.Collections.Generic;
    using System.Linq;

    public class PhoneNumberMnemonics
    {
        // O(4^n*n) Time | O(4^n*n) Space, where n = length of the phoneNumber
        public List<string> Solve(string phoneNumber)
        {
            var literals = this.ConvertToLiterals(phoneNumber);
            var solution = this.Imm_Solve(literals);
            return solution;
        }

        private List<string> Imm_Solve(List<List<char>> allNumberLiterals)
        {
            if (!allNumberLiterals.Any()) return new List<string>{""};

            var currentSolution = new List<string>();

            var currentNumberLiterals = allNumberLiterals.First();
            allNumberLiterals.RemoveAt(0);
            var subArraySolution = this.Imm_Solve(allNumberLiterals);

            foreach (var currentNumberLiteral in currentNumberLiterals)
            {
                foreach (var subArraySolutionRegistry in subArraySolution)
                {
                    currentSolution.Add($"{currentNumberLiteral}{subArraySolutionRegistry}");
                }
            }

            return currentSolution;
        }

        private List<List<char>> ConvertToLiterals(string phoneNumber)
        {
            List<List<char>> literals = new List<List<char>>();
            foreach (var number in phoneNumber)
            {
                switch (number)
                {
                    case '0':
                        literals.Add(new List<char> {'0'});
                        break;
                    case '1':
                        literals.Add(new List<char> {'1'});
                        break;
                    case '2':
                        literals.Add(new List<char> {'a', 'b', 'c'});
                        break;
                    case '3':
                        literals.Add(new List<char> {'d', 'e', 'f'});
                        break;
                    case '4':
                        literals.Add(new List<char> {'g', 'h', 'i'});
                        break;
                    case '5':
                        literals.Add(new List<char> {'j', 'k', 'l'});
                        break;
                    case '6':
                        literals.Add(new List<char> {'m', 'n', 'o'});
                        break;
                    case '7':
                        literals.Add(new List<char> {'p', 'q', 'r', 's'});
                        break;
                    case '8':
                        literals.Add(new List<char> {'t', 'u', 'v'});
                        break;
                    case '9':
                        literals.Add(new List<char> {'w', 'x', 'y', 'z'});
                        break;
                }
            }

            return literals;
        }
    }
}
