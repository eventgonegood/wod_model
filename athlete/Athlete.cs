namespace v23athletics.wod.athlete
{
    using System;

    public class Athlete
    {
        public Athlete()
        {
            Vitals = new Vitals();
            FMS = new FMS();
            
        }
        public string Name { get; set; }
        public Vitals Vitals { get; set; }
        public FMS FMS { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        //scores
        //CP Test Scores  (Power Clean)
        //Glycotic Scores (Row, KB, Burpee)
        //Oxidative Scores (Row, Run, Row)

        //Power Lifts
        // bench
        // squat
        // deadlift

        //oly lifts
        // clean
        // jerk
        // snatch

        //cf skills
        // double under
        // muscle ups
        // handstand warks

        //Injuries

        //Snatch Efficiency Test

        //Overall rating
        // RAG based on Games Events
        // R = +1 std deviation away
        // A = with in 1 std deviation
        // G = above by 1 std dev
    }

    public class FMS
    {
        //FMS metrics

        //Hip Mobility
        //Shoulder Mobility
        //Thorasic Mobility
    }

    public class EnergyPathways
    {
        //Anarobic
        //  CP
        //  Glycotic

        //Aerobic
        //  Oxidative - Levels 1-5

        //Graph of the 3 energy systems
    }

    public class Vitals
    {
        public int Age { get; set; }
        public DateTime? BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        //TODO: Division? to avoid gender issues?
        public string Gender { get; set; }

        //gorilla index
        //leg version of above
    }
}