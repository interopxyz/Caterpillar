
namespace Caterpillar
{
    abstract class Speed : Unit
    {
        
        public Speed() : base()
        {
            type = Types.Speed;
        }

        public Speed(Speed obj) : base(obj)
        {

        }
        
    }
}
