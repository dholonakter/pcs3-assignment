namespace School
{
    class Student : Person
    {
        #region Private Fields

        private int totaleç;


        #endregion

        #region Properties



        public int EC
        {
            get { return totaleç; }
            private set
            {
                if (value >= 0)
                {
                    totaleç = value;
                }
            }
        }
        #endregion

        #region Auto-implemented Properties
        public string Name { get; set; }
        public string HomeCountry { get; set; }
        #endregion

        #region Constructor
        public Student(string homecountry) : base(name, pcn, age)
        {

            this.HomeCountry = homecountry;
            this.EC = 0;
        }
        #endregion

        #region Public Methods

        public string InfoString()
        {
            string info = "";
            info += this.Name + " (" + this.PCN.ToString() + ")";
            info += "\nage " + this.Age.ToString() + ", " + this.YearsAtFontys.ToString() + " years at Fontys";

            info += "\nCountry:\t" + this.HomeCountry.ToString();
            info += "\nEC:\t" + this.EC.ToString();

            return info;
        }
        public void AddOneModuleEC()
        {
            EC += 3;
        }

        #endregion
    }
}
