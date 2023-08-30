namespace Person
{
    public class PersonMain
    {

        public double Weight;
        public double HeightCm;
        public PersonMain(double weight, double heightCm)
        {
            Weight = weight;
            HeightCm = heightCm;
        }

        public double CalculoAlturaMetros()
        {
            return HeightCm / 100;
        }
    }
}