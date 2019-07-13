
namespace Caterpillar.Areas
{
    class SurveyUnit : Area
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

namespace Caterpillar.Areas
{
    public struct Survey
    {
        public static readonly Survey Empty;

        public static Unit Township { get { return new SurveyUnit("Township", "", 93239945.32); } }
        public static Unit Acre { get { return new SurveyUnit("Acre", "", 4046.8726267); } }

    }
}