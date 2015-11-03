namespace v23athletics.wod.workout
{
    using System;
    using System.Collections.Generic;

    public class Workout
    {
        //optional - default to date
        public DateTime On { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public List<Step> Steps { get; set; }
        public TimeSpan SessionDuration { get; set; }
    }
}
