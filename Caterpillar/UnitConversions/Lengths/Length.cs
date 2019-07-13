
namespace Caterpillar
{
    abstract class Length : Unit
    {
        
        public Length() : base()
        {
            type = Types.Length;
        }

        public Length(Length obj) : base(obj)
        {

        }
        
    }
}
