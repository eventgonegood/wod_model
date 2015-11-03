namespace v23athletics.wod.athlete
{
    using System;

    public class AthleteMetric
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string UnitOfMeasure { get; set; }
        public DateTime RecordedOn { get; set; }
    }
}