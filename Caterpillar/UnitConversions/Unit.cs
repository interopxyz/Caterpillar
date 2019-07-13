namespace Caterpillar
{
    public abstract class Unit
    {

        #region members

        public enum Types { None = 0, Length = 1, Area = 2, Volume = 3, Mass = 4, Weight = 5, Pressure = 6, Temperature = 7, Energy = 8, Speed = 9, Force = 10, Angle = 11, Time = 12 };
        public enum Systems { None = 0, SI = 1, Metric = 2, Imperial = 3, Survey = 4, Nautical = 5, Engineering = 6, Astronomical = 7, Typography = 8, Chronological = 9, Troy = 10,
                US = 11, UK = 12, FR = 13, DE = 14, ES = 15, JP = 16, CH = 17, TH = 18, RU = 19, AT = 20, NL = 21, SUI = 22 };

        protected string name = string.Empty;
        protected string abbreviation = string.Empty;
        protected double factor = double.NaN;
        protected Types type = Types.None;
        protected Systems system = Systems.None;

        #endregion

        #region constructors

        public Unit()
        {

        }

        public Unit(Unit unit) : base()
        {
            this.name = unit.name;
            this.factor = unit.factor;
            this.type = unit.type;
            this.system = unit.system;
        }

        public Unit(Types type) : base()
        {
            this.type = type;
        }

        #endregion

        #region properties

        public virtual string Name
        {
            get { return name; }
        }

        public virtual string Abbreviation
        {
            get { return abbreviation; }
        }

        public virtual double Factor
        {
            get { return factor; }
        }

        public virtual Types Type
        {
            get { return type; }
        }

        public virtual Systems System
        {
            get { return system; }
        }

        #endregion

    }
}
