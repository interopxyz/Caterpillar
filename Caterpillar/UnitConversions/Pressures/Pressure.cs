
namespace Caterpillar
{
    abstract class Pressure : Unit
    {
        
        public Pressure() : base()
        {
            type = Types.Pressure;
        }

        public Pressure(Pressure obj) : base(obj)
        {

        }
        
    }
}
