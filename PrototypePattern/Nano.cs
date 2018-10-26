namespace PrototypePattern
{
    public class Nano : BasicCar
    {
        public Nano(string m)
        {
            ModelName = m;
        }
        public override BasicCar Clone()
        {
            // Return shallow clone
            return (Nano)this.MemberwiseClone();
        }
    }
}
