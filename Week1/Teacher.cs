namespace School
{
    enum Function { JUNIOR_DOCENT, DOCENT_1, DOCENT_2, INTERNSHIP_COORDINATOR, TEAM_LEADER, DIRECTOR }

    class Teacher : Person
    {

        //private string name;           // full name of the teacher
        //private int pcn;               // personal pcn Fontyus number 
        //private int age;               // age of the teacher
        //private int yearsAtFontys;     // how many years the teacher works at Fontys 
        private Function function;     // function. E,g, DOCENT_1, DOCENT_2, TEAM_LEADER, ...
        private double salary;         // monthly salary 

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        /// <summary>
        /// must be in range 111111  to 999999
        /// </summary>
        //public int PCN
        //{
        //    get { return pcn; }
        //    set
        //    {
        //        if (value >= 111111 && value <= 999999)
        //            pcn = value;
        //        else
        //        {
        //            if (value < 111111)
        //                pcn = 11111;
        //            else pcn = 999999;
        //        }
        //    }
        //}

        ///// <summary>
        /// Cannot be set outside this class.
        /// Must be more than 18
        /// </summary>
        //public int Age
        //{
        //    get { return age; }
        //    private set
        //    {
        //        if (value > 18)
        //            age = value;
        //        else age = 18;
        //    }
        //}

        /// <summary>
        /// Cannot be set outside this class.
        /// Cannot be a negative number.
        /// </summary>
        //public int YearsAtFontys
        //{
        //    get { return yearsAtFontys;  }
        //    private set
        //    {
        //        if (value >= 0)
        //        {
        //            yearsAtFontys = value;
        //        }
        //        else
        //        {
        //            yearsAtFontys = 0;
        //        }
        //    }
        //}

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Function Function
        {
            get { return function; }
            set { function = value; }
        }

        /// <summary>
        /// The only constructor.</summary>
        /// <param name="name">Initial name of the teacher.</param>
        /// <param name="pcn">Personal Fontys number of the teacher.</param>
        /// <param name="age">Age of the teacher.</param>
        /// <param name="function">Function of the teacher.</param>
        /// <param name="salary">Monthly salary of the teacher.</param>
        public Teacher(string name, int pcn, int age, Function function, int salary)
        {
            this.Name = name;
            this.PCN = pcn;
            this.Age = age;
            this.YearsAtFontys = 0;
            this.Function = function;
            this.Salary = salary;
        }

        /// <summary>
        /// Increases property YearsAtFontys by 1. 
        /// </summary>
        //public void AnotherSchoolYear()
        //{
        //    YearsAtFontys++;
        //}

        /// <summary>
        /// Increases property Age by 1. 
        /// </summary>
        //public void CelebrateBirthDay()
        //{
        //    Age++;
        //}

        /// <summary>
        /// Returns values of all properties in the following string format:
        /// "John Doe (12456)
        ///  age 45, 15 years at Fontys
        ///  function: DOCENT_1
        ///  salary:   15000"
        /// </summary>
        public string InfoString()
        {
            string info = "";
            info += base.InfoString();

            info += "\nfunction:\t" + this.Function.ToString();
            info += "\nsalary:\t" + this.Salary.ToString();

            return info;
        }

        /// <summary>
        /// Promotes the teacher by one function. 
        /// For example, DOCENT_1 is promoted into DOCENT_2.
        /// </summary>
        public void Promote()
        {
            if (function < Function.DIRECTOR)
                function++;
        }



    }
}
