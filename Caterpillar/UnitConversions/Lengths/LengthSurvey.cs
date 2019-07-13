
namespace Caterpillar.Lengths
{
    class SurveyUnit : Length
    {
        public SurveyUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Survey;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Lengths
{
    public struct Survey
    {
        public static readonly Survey Empty;

        public static Unit Furlong { get { return new SurveyUnit("Furlong", " ", 201.16840234); } }
        public static Unit Rod { get { return new SurveyUnit("Rod", " ", 5.0292100584); } }
        public static Unit Foot { get { return new SurveyUnit("Foot", " ", 0.3048006096); } }

    }
}