namespace v23athletics.wod.quantity
{
    ///
    /// these are things like kilograms, pounds, seconds
    public class UnitOfMeasure
    {
        public string Code {get; set; }
        public string Description { get; set; }
        
        
        public static UnitOfMeasure Reps = new UnitOfMeasure();
        public static UnitOfMeasure Seconds = new UnitOfMeasure();
    }
}