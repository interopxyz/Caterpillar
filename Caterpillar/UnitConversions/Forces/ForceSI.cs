
namespace Caterpillar.Forces
{
    class SIUnit : Force
    {
        public SIUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.SI;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Forces
{
    public struct SI
    {
        public static readonly SI Empty;

        public static Unit Yoctonewton { get { return new SIUnit("Yoctonewton", " ", 0.000000000000000000000001); } }
        public static Unit Zeptonewton { get { return new SIUnit("Zeptonewton", " ", 0.000000000000000000001); } }
        public static Unit Attonewton { get { return new SIUnit("Attonewton", " ", 0.000000000000000001); } }
        public static Unit Femtonewton { get { return new SIUnit("Femtonewton", " ", 0.000000000000001); } }
        public static Unit Piconewton { get { return new SIUnit("Piconewton", " ", 0.000000000001); } }
        public static Unit Nanonewton { get { return new SIUnit("Nanonewton", " ", 0.000000001); } }
        public static Unit Micronewton { get { return new SIUnit("Micronewton", " ", 0.000001); } }
        public static Unit Millinewton { get { return new SIUnit("Millinewton", " ", 0.001); } }
        public static Unit Centinewton { get { return new SIUnit("Centinewton", " ", 0.01); } }
        public static Unit Decinewton { get { return new SIUnit("Decinewton", " ", 0.1); } }
        public static Unit Newton { get { return new SIUnit("Newton", " ", 1.0); } }
        public static Unit Decanewton { get { return new SIUnit("Decanewton", " ", 10.0); } }
        public static Unit Hectonewton { get { return new SIUnit("Hectonewton", " ", 100.0); } }
        public static Unit Kilonewton { get { return new SIUnit("Kilonewton", " ", 1000.0); } }
        public static Unit Meganewton { get { return new SIUnit("Meganewton", " ", 1000000.0); } }
        public static Unit Giganewton { get { return new SIUnit("Giganewton", " ", 1000000000.0); } }
        public static Unit Teranewton { get { return new SIUnit("Teranewton", " ", 1000000000000.0); } }
        public static Unit Petanewton { get { return new SIUnit("Petanewton", " ", 1000000000000000.0); } }
        public static Unit Exanewton { get { return new SIUnit("Exanewton", " ", 1000000000000000000.0); } }
        public static Unit Zettanewton { get { return new SIUnit("Zettanewton", " ", 1000000000000000000000.0); } }
        public static Unit Yottanewton { get { return new SIUnit("Yottanewton", " ", 1000000000000000000000000.0); } }
    }
}