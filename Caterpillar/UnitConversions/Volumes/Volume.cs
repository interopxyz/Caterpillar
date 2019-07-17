
namespace Caterpillar
{
    abstract class Volume: Unit
    {
        
        public Volume() : base()
        {
            type = Types.Volume;
        }

        public Volume(Volume obj) : base(obj)
        {

        }
        
    }
}
