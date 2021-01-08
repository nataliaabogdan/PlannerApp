namespace PlannerApp.Model
{
    public class LengthOfLongestDay
    {
        public int getLengthOfLongestDay(PlannerData plannerData)
        {
            int lengthOfLongestDay = 0;
            for (int i = 0; i < 7; i++)
            {
                if (plannerData.week[i].Count > lengthOfLongestDay) lengthOfLongestDay = plannerData.week[i].Count;
            }

            return lengthOfLongestDay;
        }
    }
}