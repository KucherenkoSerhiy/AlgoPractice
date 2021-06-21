namespace AlgoExpert
{
    using System.Collections.Generic;

    public class ValidIPAddresses
    {
        // O(1) Time | O(1) Space, because max length of the input = 12
        public List<string> Solve(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length > 12) return new List<string>();
            return this.Imm_Solve(str, 4);
        }

        private List<string> Imm_Solve(string str, int buckets)
        {
            if (!string.IsNullOrEmpty(str) && long.Parse(str) < 256 && buckets == 1 && (!str.StartsWith('0') || str.Equals("0")))
                return new List<string>{str};
            if (buckets == 0 || string.IsNullOrEmpty(str))
                return new List<string>();

            var solution = new List<string>();
            for (int i = 1; i <= 3; i++)
            {
                if (i <= str.Length)
                {
                    var current = str.Substring(0, i);
                    var currentValue = long.Parse(current);
                    if (currentValue < 256 && (!current.StartsWith('0') || current.Equals("0")))
                    {
                        var rest = str.Substring(i);
                        var subsolutions = this.Imm_Solve(rest, buckets - 1);

                        foreach (var subsolution in subsolutions)
                        {
                            solution.Add($"{current}.{subsolution}");
                        }
                    }
                }
            }

            return solution;
        }
    }
}
