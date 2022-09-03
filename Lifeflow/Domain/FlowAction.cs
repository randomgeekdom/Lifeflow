namespace Lifeflow.Domain
{
    public class FlowAction
    {
        public string Description { get; set; }

        public DateTime LastOccurrence { get; set; } = DateTime.MinValue;

        public int MaxTimesPerDay { get; set; }
        public FlowAction ParentAction { get; set; }

        /// <summary>
        /// The randomness level determines how often it will appear.  A 1 is standard but the higher the number, the more likely to appear.
        /// </summary>
        public int RandomnessLevel { get; set; } = 1;
    }
}