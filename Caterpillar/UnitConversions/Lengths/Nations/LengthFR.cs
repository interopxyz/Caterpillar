
namespace Caterpillar.Lengths
{
    class FRUnit : Length
    {
        public FRUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.FR;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct FR
    {
        public static readonly FR Empty;

        public static Unit LieueCommune { get { return new FRUnit("Lieue Commune", " ", 4452.35975066785); } }
        public static Unit LieueMetriqueMetric { get { return new FRUnit("Lieue Metrique (Metric)", " ", 4000.0); } }
        public static Unit LieueDePostPost { get { return new FRUnit("Lieue De Post (Post)", " ", 3898.63547758285); } }
        public static Unit Mille { get { return new FRUnit("Mille", " ", 1948.93782888326); } }
        public static Unit Arpent { get { return new FRUnit("Arpent", " ", 58.4713256618954); } }
        public static Unit Perche { get { return new FRUnit("Perche", " ", 5.84711889063783); } }
        public static Unit Canne { get { return new FRUnit("Canne", " ", 2.0); } }
        public static Unit Toise { get { return new FRUnit("Toise", " ", 1.94904001008823); } }
        public static Unit Foot { get { return new FRUnit("Foot", " ", 0.324840603152338); } }
        public static Unit Pouce { get { return new FRUnit("Pouce", " ", 0.0270699999935573); } }
        public static Unit Ligne { get { return new FRUnit("Ligne", " ", 0.00211669999992909); } }

    }
}