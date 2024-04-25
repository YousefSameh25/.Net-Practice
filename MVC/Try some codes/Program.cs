namespace Try_some_codes
{
    using System;
    using System.Globalization;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string correctAnswer = "Ronny"; // Replace with the Arabic equivalent if needed
            Console.Write("Enter the player's name: ");
            string userInput = Console.ReadLine();

            if (ValidateAnswer(userInput, correctAnswer))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is: {correctAnswer}");
            }
        }

        static bool ValidateAnswer(string userInput, string correctAnswer, double threshold = 0.6)
        {
            // Convert both strings to lowercase and normalize Unicode characters
            string userInputNormalized = userInput.ToLowerInvariant().Normalize(NormalizationForm.FormKD);
            string correctAnswerNormalized = correctAnswer.ToLowerInvariant().Normalize(NormalizationForm.FormKD);

            // Use Levenshtein distance to calculate similarity
            double similarity = LevenshteinRatio(userInputNormalized, correctAnswerNormalized);
            return similarity >= threshold;
        }

        static double LevenshteinRatio(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;

            if (n == 0)
                return m;
            if (m == 0)
                return n;

            int[,] d = new int[n + 1, m + 1];

            for (int i = 0; i <= n; d[i, 0] = i++) ;
            for (int j = 0; j <= m; d[0, j] = j++) ;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost
                    );
                }
            }

            return 1.0 - (double) d[n, m] / Math.Max(s.Length, t.Length);
        }
    }

}
