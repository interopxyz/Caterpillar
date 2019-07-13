
namespace Caterpillar.Areas
{
    class JPUnit : Area
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

namespace Caterpillar.Areas
{
    public struct JP
    {
        public static readonly JP Empty;

        public static Unit Cho { get { return new JPUnit("Square Cho", "", 9917.355371901); } }
        public static Unit Tan { get { return new JPUnit("Square Tan", "", 991.7355371901); } }
        public static Unit Se { get { return new JPUnit("Square Se", "", 99.17355371901); } }
        public static Unit Bu { get { return new JPUnit("Square Bu", "", 3.305785124); } }
        public static Unit Tsubo { get { return new JPUnit("Square Tsubo", "", 3.305785124); } }
        public static Unit Jo { get { return new JPUnit("Square Jo", "", 1.652892562); } }
        public static Unit Go { get { return new JPUnit("Square Go", "", 0.3305785124); } }
        public static Unit Shaku { get { return new JPUnit("Square Shaku", "", 0.03305785124); } }

    }
}