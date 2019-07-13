
namespace Caterpillar.Areas
{
    class UKUnit : Area
    {
        public UKUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.UK;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Areas
{
    public struct UK
    {
        public static readonly UK Empty;

        public static Unit Hundred { get { return new UKUnit("Hundred", " ", 50000000.0); } }
        public static Unit Hide { get { return new UKUnit("Hide", "", 486000.0); } }
        public static Unit Carucate { get { return new UKUnit("Carucate", "", 486000.0); } }
        public static Unit Virgate { get { return new UKUnit("Virgate", "", 120000.0); } }
        public static Unit Bovate { get { return new UKUnit("Bovate (Oxgang)", "", 60000.0); } }
        public static Unit Rood { get { return new UKUnit("Rood", "", 1011.7141); } }
        public static Unit SquarePerch { get { return new UKUnit("Square Perch", "", 25.292954); } }
        public static Unit Perch { get { return new UKUnit("Perch", "", 25.29285264); } }

    }
}