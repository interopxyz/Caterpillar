
namespace Caterpillar
{
    abstract class Force: Unit
    {
        
        public Force() : base()
        {
            type = Types.Force;
        }

        public Force(Force obj) : base(obj)
        {

        }
        
    }
}
