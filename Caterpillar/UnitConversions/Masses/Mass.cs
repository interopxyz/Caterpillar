
namespace Caterpillar
{
    abstract class Mass : Unit
    {
        
        public Mass() : base()
        {
            type = Types.Mass;
        }

        public Mass(Mass obj) : base(obj)
        {

        }
        
    }
}
