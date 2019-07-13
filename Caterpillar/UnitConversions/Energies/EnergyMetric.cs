
namespace Caterpillar.Energies
{
    class MetricUnit : Energy
    {
        public MetricUnit(string name, string abbreviation, double factor) : base()
        {
            this.system = Systems.Metric;

            this.name = name;
            this.abbreviation = abbreviation;
            this.factor = factor;
        }
    }
}

namespace Caterpillar.Energies
{
    public struct Metric
    {
        public static readonly Metric Empty;

        public static Unit Yoctotherm { get { return new MetricUnit("Yoctotherm", "ythm", 0.000000000000000105505585); } }
        public static Unit Zeptotherm { get { return new MetricUnit("Zeptotherm", "zthm", 0.000000000000105505585257); } }
        public static Unit Attotherm { get { return new MetricUnit("Attotherm", "athm", 0.000000000105505585257348); } }
        public static Unit Femtotherm { get { return new MetricUnit("Femtotherm", "fthm", 0.000000105505585257348); } }
        public static Unit Picotherm { get { return new MetricUnit("Picotherm", "pthm", 0.000105505585257348000000); } }
        public static Unit Nanotherm { get { return new MetricUnit("Nanotherm", "nthm", 0.105505585257348); } }
        public static Unit Microtherm { get { return new MetricUnit("Microtherm", "uthm", 105.505585257348); } }
        public static Unit Millitherm { get { return new MetricUnit("Millitherm", "mthm", 105505.585257348); } }
        public static Unit Centitherm { get { return new MetricUnit("Centitherm", "cthm", 1055055.85257348); } }
        public static Unit Decitherm { get { return new MetricUnit("Decitherm", "dthm", 10550558.5257348); } }
        public static Unit Therm { get { return new MetricUnit("Therm", "thm", 105505585.257348); } }
        public static Unit Decatherm { get { return new MetricUnit("Decatherm", "dathm", 1055055852.57348); } }
        public static Unit Hectotherm { get { return new MetricUnit("Hectotherm", "hthm", 10550558525.73480); } }
        public static Unit Kilotherm { get { return new MetricUnit("Kilotherm", "kthm", 105505585257.3480); } }
        public static Unit Megatherm { get { return new MetricUnit("Megatherm", "Mthm", 105505585257348.0); } }
        public static Unit Gigatherm { get { return new MetricUnit("Gigatherm", "Gthm", 105505585257348000.0); } }
        public static Unit Teratherm { get { return new MetricUnit("Teratherm", "Tthm", 105505585257348000000.0); } }
        public static Unit Petatherm { get { return new MetricUnit("Petatherm", "Pthm", 105505585257348000000000.0); } }
        public static Unit Exatherm { get { return new MetricUnit("Exatherm", "Ethm", 105505585257348000000000000.0); } }
        public static Unit Zettatherm { get { return new MetricUnit("Zettatherm", "Zthm", 105505585257348000000000000000.0); } }
        public static Unit Yottatherm { get { return new MetricUnit("Yottatherm", "Ythm", 105505585257348000000000000000000.0); } }

    }
}