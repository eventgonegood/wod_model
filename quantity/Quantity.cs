namespace v23athletics.wod.quantity
{
    public class Quantity
    {
        public static Quantity MaxEffort = new Quantity();

        public int Measure { get; set; }
        public UnitOfMeasure UOM { get; set; }

        public static Quantity Reps(int i)
        {
            return new Quantity
            {
                Measure = 2,
                UOM = UnitOfMeasure.Reps
            };
        }
        
        public static Quantity Duration(int i)
        {
            return new Quantity
            {
                Measure = i,
                UOM = UnitOfMeasure.Seconds
            }
        }
    }
}