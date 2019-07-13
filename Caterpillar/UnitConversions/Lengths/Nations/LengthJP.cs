
namespace Caterpillar.Lengths
{
    class JPUnit : Length
    {
        public JPUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.JP;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct JP
    {
        public static readonly JP Empty;

        public static Unit Ri { get { return new JPUnit("Ri", " ", 3927.0); } }
        public static Unit Cho { get { return new JPUnit("Cho", " ", 109.090909091); } }
        public static Unit Jo { get { return new JPUnit("Jo", " ", 3.030303030); } }
        public static Unit Hiro { get { return new JPUnit("Hiro", " ", 1.818); } }
        public static Unit Ken { get { return new JPUnit("Ken", " ", 1.818); } }
        public static Unit Shaku { get { return new JPUnit("Shaku", " ", 0.3030303); } }
        public static Unit Sun { get { return new JPUnit("Sun", " ", 0.03030303); } }
        public static Unit Bu { get { return new JPUnit("Bu", " ", 0.003030303); } }
        public static Unit Rin { get { return new JPUnit("Rin", " ", 0.0003030303); } }
        public static Unit Mo { get { return new JPUnit("Mo", " ", 0.00003030303); } }

    }
}