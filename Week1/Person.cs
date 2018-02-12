namespace School
{
    class Person
    {


        #region Private Fields
        private int _pcn;
        private int _age;
        private int _yearsAtFontys;
        #endregion

        #region Properties
        public int PCN
        {
            get { return pcn; }
            set
            {
                if (value >= 111111 && value <= 999999)
                    pcn = value;
                else
                {
                    if (value < 111111)
                        pcn = 11111;
                    else pcn = 999999;
                }
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value >= 18)
                    age = value;
                else age = 18;
            }
        }
        public int YearsAtFontys
        {
            get { return yearsAtFontys; }
            private set
            {
                if (value >= 0)
                {
                    yearsAtFontys = value;
                }
                else
                {
                    yearsAtFontys = 0;
                }
            }
        }

        #endregion


        #region Auto-implemented Properties
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Person(string name, int pcn, int age)
        {
            this.Name = name;
            this.PCN = pcn;
            this.Age = age;
            this.YearsAtFontys = 0;

        }
        #endregion

        #region Public Methods
        public void AnotherSchoolYear()
        {
            YearsAtFontys++;
        }
        public void CelebrateBirthDay()
        {
            Age++;
        }
        public string InfoString()
        {
            string info = "";
            info += this.Name + " (" + this.PCN.ToString() + ")";
            info += "\nage " + this.Age.ToString() + ", " + this.YearsAtFontys.ToString() + " years at Fontys";
            ;

            return info;
        }
        #endregion
    }
}
