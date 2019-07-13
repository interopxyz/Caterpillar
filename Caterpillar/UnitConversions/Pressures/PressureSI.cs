
namespace Caterpillar.Pressures
{
    class SIUnit : Pressure
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

namespace Caterpillar.Pressures.SI
{
    public struct Pascals
    {
        public static readonly Pascals Empty;

        public static Unit Yoctopascal { get { return new SIUnit("Yoctopascal", "ypa", 0.000000000000000000000001); } }
        public static Unit Zeptopascal { get { return new SIUnit("Zeptopascal", "zpa", 0.000000000000000000001); } }
        public static Unit Attopascal { get { return new SIUnit("Attopascal", "apa", 0.000000000000000001); } }
        public static Unit Femtopascal { get { return new SIUnit("Femtopascal", "fpa", 0.000000000000001); } }
        public static Unit Picopascal { get { return new SIUnit("Picopascal", "ppa", 0.000000000001); } }
        public static Unit Nanopascal { get { return new SIUnit("Nanopascal", "npa", 0.000000001); } }
        public static Unit Micropascal { get { return new SIUnit("Micropascal", "upa", 0.000001); } }
        public static Unit Millipascal { get { return new SIUnit("Millipascal", "mpa", 0.001); } }
        public static Unit Centipascal { get { return new SIUnit("Centipascal", "cpa", 0.01); } }
        public static Unit Decipascal { get { return new SIUnit("Decipascal", "dpa", 0.1); } }
        public static Unit Pascal { get { return new SIUnit("Pascal", "pa", 1.0); } }
        public static Unit Decapascal { get { return new SIUnit("Decapascal", "dapa", 10.0); } }
        public static Unit Hectopascal { get { return new SIUnit("Hectopascal", "hpa", 100.0); } }
        public static Unit Kilopascal { get { return new SIUnit("Kilopascal", "kpa", 1000.0); } }
        public static Unit Megapascal { get { return new SIUnit("Megapascal", "Mpa", 1000000.0); } }
        public static Unit Gigapascal { get { return new SIUnit("Gigapascal", "Gpa", 1000000000.0); } }
        public static Unit Terapascal { get { return new SIUnit("Terapascal", "Tpa", 1000000000000.0); } }
        public static Unit Petapascal { get { return new SIUnit("Petapascal", "Ppa", 1000000000000000.0); } }
        public static Unit Exapascal { get { return new SIUnit("Exapascal", "Epa", 1000000000000000000.0); } }
        public static Unit Zettapascal { get { return new SIUnit("Zettapascal", "Zpa", 1000000000000000000000.0); } }
        public static Unit Yottapascal { get { return new SIUnit("Yottapascal", "Ypa", 1000000000000000000000000.0); } }

    }
}

namespace Caterpillar.Pressures.SI
{
    public struct Bars
    {
        public static readonly Bars Empty;

        public static Unit Yoctobar { get { return new SIUnit("Yoctobar", "ybar", 0.0000000000000000001); } }
        public static Unit Zeptobar { get { return new SIUnit("Zeptobar", "zbar", 0.0000000000000001); } }
        public static Unit Attobar { get { return new SIUnit("Attobar", "abar", 0.0000000000001); } }
        public static Unit Femtobar { get { return new SIUnit("Femtobar", "fbar", 0.0000000001); } }
        public static Unit Picobar { get { return new SIUnit("Picobar", "pbar", 0.0000001); } }
        public static Unit Nanobar { get { return new SIUnit("Nanobar", "nbar", 0.0001); } }
        public static Unit Microbar { get { return new SIUnit("Microbar", "ubar", 0.1); } }
        public static Unit Millibar { get { return new SIUnit("Millibar", "mbar", 100.0); } }
        public static Unit Centibar { get { return new SIUnit("Centibar", "cbar", 1000.0); } }
        public static Unit Decibar { get { return new SIUnit("Decibar", "dbar", 10000.0); } }
        public static Unit Bar { get { return new SIUnit("Bar", "bar", 100000.0); } }
        public static Unit Decabar { get { return new SIUnit("Decabar", "dabar", 1000000.0); } }
        public static Unit Hectobar { get { return new SIUnit("Hectobar", "hbar", 10000000.0); } }
        public static Unit Kilobar { get { return new SIUnit("Kilobar", "kbar", 100000000.0); } }
        public static Unit Megabar { get { return new SIUnit("Megabar", "Mbar", 100000000000.0); } }
        public static Unit Gigabar { get { return new SIUnit("Gigabar", "Gbar", 100000000000000.0); } }
        public static Unit Terabar { get { return new SIUnit("Terabar", "Tbar", 100000000000000000.0); } }
        public static Unit Petabar { get { return new SIUnit("Petabar", "Pbar", 100000000000000000000.0); } }
        public static Unit Exabar { get { return new SIUnit("Exabar", "Ebar", 100000000000000000000000.0); } }
        public static Unit Zettabar { get { return new SIUnit("Zettabar", "Zbar", 100000000000000000000000000.0); } }
        public static Unit Yottabar { get { return new SIUnit("Yottabar", "Ybar", 100000000000000000000000000000.0); } }

    }
}

namespace Caterpillar.Pressures.SI
{
    public struct Torrs
    {
        public static readonly Torrs Empty;

        public static Unit Yoctotorr { get { return new SIUnit("Yoctotorr", "yTorr", 0.00000000000000000000013332237); } }
        public static Unit Zeptotorr { get { return new SIUnit("Zeptotorr", "zTorr", 0.00000000000000000013332237); } }
        public static Unit Attotorr { get { return new SIUnit("Attotorr", "aTorr", 0.00000000000000013332237); } }
        public static Unit Femtotorr { get { return new SIUnit("Femtotorr", "fTorr", 0.00000000000013332237); } }
        public static Unit Picotorr { get { return new SIUnit("Picotorr", "pTorr", 0.00000000013332237); } }
        public static Unit Nanotorr { get { return new SIUnit("Nanotorr", "nTorr", 0.00000013332237); } }
        public static Unit Microtorr { get { return new SIUnit("Microtorr", "uTorr", 0.00013332237); } }
        public static Unit Millitorr { get { return new SIUnit("Millitorr", "mTorr", 0.13332237); } }
        public static Unit Centitorr { get { return new SIUnit("Centitorr", "cTorr", 1.3332237); } }
        public static Unit Decitorr { get { return new SIUnit("Decitorr", "dTorr", 13.332237); } }
        public static Unit Torr { get { return new SIUnit("Torr", "Torr", 133.32237); } }
        public static Unit Decatorr { get { return new SIUnit("Decatorr", "daTorr", 1333.2237); } }
        public static Unit Hectotorr { get { return new SIUnit("Hectotorr", "hTorr", 13332.237); } }
        public static Unit Kilotorr { get { return new SIUnit("Kilotorr", "kTorr", 133322.37); } }
        public static Unit Megatorr { get { return new SIUnit("Megatorr", "MTorr", 133322370.0); } }
        public static Unit Gigatorr { get { return new SIUnit("Gigatorr", "GTorr", 133322370000.0); } }
        public static Unit Teratorr { get { return new SIUnit("Teratorr", "TTorr", 133322370000000.0); } }
        public static Unit Petatorr { get { return new SIUnit("Petatorr", "PTorr", 133322370000000000.0); } }
        public static Unit Exatorr { get { return new SIUnit("Exatorr", "ETorr", 133322370000000000000.0); } }
        public static Unit Zettatorr { get { return new SIUnit("Zettatorr", "ZTorr", 133322370000000000000000.0); } }
        public static Unit Yottatorr { get { return new SIUnit("Yottatorr", "YTorr", 133322370000000000000000000.0); } }

    }
}