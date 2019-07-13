
namespace Caterpillar.Volumes
{
    class UKUnit : Volume
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

namespace Caterpillar.Volumes
{
    public struct UK
    {
        public static readonly UK Empty;

        public static Unit OunceLiquid { get { return new UKUnit("Ounce Liquid", "--", 0.0000284130625); } }
        public static Unit Peck { get { return new UKUnit("Peck", "--", 0.00909218); } }
        public static Unit Pint { get { return new UKUnit("Pint", "--", 0.00056826125); } }
        public static Unit Quart { get { return new UKUnit("Quart", "--", 0.0011365225); } }
        public static Unit Gill { get { return new UKUnit("Gill", "--", 0.0001420653125); } }
        public static Unit Gallon { get { return new UKUnit("Gallon", "--", 0.00454609); } }
        public static Unit Barrel { get { return new UKUnit("Barrel", "--", 0.16365924); } }
        public static Unit Bucket { get { return new UKUnit("Bucket", "--", 0.01818436); } }
        public static Unit Bushel { get { return new UKUnit("Bushel", "--", 0.03636872); } }
        public static Unit Pipe { get { return new UKUnit("Pipe", "--", 0.49097772); } }
        public static Unit Tablespoon { get { return new UKUnit("Tablespoon", "--", 0.00001420653125); } }
        public static Unit Teaspoon { get { return new UKUnit("Teaspoon", "--", 0.0000035516328125); } }
        public static Unit Drum { get { return new UKUnit("Drum", "--", 0.2); } }

    }

}