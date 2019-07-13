
namespace Caterpillar
{
    abstract class Energy: Unit
    {
        
        public Energy() : base()
        {
            type = Types.Energy;
        }

        public Energy(Energy obj) : base(obj)
        {

        }
        
    }
}
