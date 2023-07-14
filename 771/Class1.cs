namespace _771
{
    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int count = 0;
            foreach (char cS in stones) 
            {
                foreach (char cJ in jewels)
                {
                    if (cS == cJ)
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}