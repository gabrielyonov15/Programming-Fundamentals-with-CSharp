namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string input;
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            int[] bestSequence = null;
            int bestSubsequenceLength = 0;
            int bestSubsequenceStartingIndex = int.MaxValue;
            int sequenceCounter = 0;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                sequenceCounter++;
                int[] dnaSequence = input
                    .Split(new char[] { '!', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currentSubsequenceLength = 0;
                int maxSubsequenceLength = 0;
                int currentStartingIndex = 0;
                int maxStartingIndex = 0;
                int sequenceSum = dnaSequence.Sum();
                for (int i = 0; i < dnaSequence.Length; i++)
                {
                    if (dnaSequence[i] == 1)
                    {
                        currentSubsequenceLength++;

                        if (currentSubsequenceLength > maxSubsequenceLength)
                        {
                            maxSubsequenceLength = currentSubsequenceLength;
                            maxStartingIndex = currentStartingIndex;
                        }
                    }
                    else
                    {
                        currentSubsequenceLength = 0;
                        currentStartingIndex = i + 1;
                    }
                }
                if (maxSubsequenceLength > bestSubsequenceLength ||
                    (maxSubsequenceLength == bestSubsequenceLength && maxStartingIndex < bestSubsequenceStartingIndex) ||
                    (maxSubsequenceLength == bestSubsequenceLength && maxStartingIndex == bestSubsequenceStartingIndex && sequenceSum > bestSequenceSum))
                {
                    bestSubsequenceLength = maxSubsequenceLength;
                    bestSubsequenceStartingIndex = maxStartingIndex;
                    bestSequenceSum = sequenceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = dnaSequence;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
