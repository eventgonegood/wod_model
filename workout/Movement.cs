namespace v23athletics.wod.workout
{
    using System;
    using quantity;

    public class Movement
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public Quantity Quantity { get; set; }
        public TimeSpan? Duration { get; set; }
        public UnitOfMeasure Weight { get; set; }
        public int Rounds { get; set; }
    }
}