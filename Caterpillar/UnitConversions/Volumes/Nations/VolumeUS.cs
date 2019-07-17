
namespace Caterpillar.Volumes
{
    class USUnit : Volume
    {
        public USUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.US;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }

    }

}

namespace Caterpillar.Volumes
{
    public struct US
    {
        public static readonly US Empty;

        public static Unit Cup { get { return new USUnit("Cup", "--", 0.2365882365); } }
        public static Unit OunceLiquid { get { return new USUnit("Ounce Liquid", "--", 0.000029573529563); } }
        public static Unit Peck { get { return new USUnit("Peck", "--", 0.0088097676); } }
        public static Unit PintLiquid { get { return new USUnit("Pint Liquid", "--", 0.000473176473); } }
        public static Unit Pint { get { return new USUnit("Pint", "--", 0.000550610475); } }
        public static Unit Quart { get { return new USUnit("Quart", "--", 0.00110122095); } }
        public static Unit LiquidQuart { get { return new USUnit("Quart Liquid", "--", 0.000946352946); } }
        public static Unit Gill { get { return new USUnit("Gill", "--", 0.00011829411825); } }
        public static Unit Gallon { get { return new USUnit("Gallon", "--", 0.0044048838); } }
        public static Unit GallonLiquid { get { return new USUnit("Gallon Liquid", "--", 0.003785411784); } }
        public static Unit Barrel { get { return new USUnit("Barrel", "--", 0.11562712358); } }
        public static Unit BarrelFederal { get { return new USUnit("Barrel Federal", "--", 0.1173477653); } }
        public static Unit BarrelLiquid { get { return new USUnit("Barrel Liquid", "--", 0.1192404712); } }
        public static Unit Bucket { get { return new USUnit("Bucket", "--", 0.01892705892); } }
        public static Unit Bushel { get { return new USUnit("Bushel", "--", 0.0352390704); } }
        public static Unit Pipe { get { return new USUnit("Pipe", "--", 0.47696188478); } }
        public static Unit Tablespoon { get { return new USUnit("Tablespoon", "--", 0.01478677470870053823859939669959188501803986514461465665109126397); } }
        public static Unit Teaspoon { get { return new USUnit("Teaspoon", "--", 0.004928924902900179412866465566530628339346621714871552217030421325); } }
        public static Unit Drum { get { return new USUnit("Drum", "--", 0.20819764812); } }
        public static Unit Fifth { get { return new USUnit("Fifth", "--", 0.0007570823568); } }
        public static Unit Jigger { get { return new USUnit("Jigger", "--", 0.000044360294344); } }
        public static Unit Shot { get { return new USUnit("Shot", "--", 0.000029573529563); } }
        public static Unit Pony { get { return new USUnit("Pony", "--", 0.000029573529563); } }

    }

}