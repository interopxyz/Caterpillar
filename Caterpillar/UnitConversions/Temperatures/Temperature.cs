
namespace Caterpillar
{
    abstract class Temperature : Unit
    {
        
        public Temperature() : base()
        {
            type = Types.Temperature;
        }

        public Temperature(Temperature obj) : base(obj)
        {

        }
        
    }
}
