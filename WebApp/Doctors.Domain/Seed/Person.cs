using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors.Domain.Seed
{

    public enum Gender
    {
        Male,
        Female

    }
    public abstract class Person
    {
        #region Properties and Fields

        public Gender Gender { get; set; }

        public int Id { get; private set; }

        public string Name
    {
        get { return this.name; }

        internal set
        {
            Debug.Assert(condition: !String.IsNullOrWhiteSpace(value));

            this.name = value;
        }
    }

        public string Surname
        {
            get { return this.surname; }

            internal set
            {
                Debug.Assert(condition: !String.IsNullOrWhiteSpace(value));

                this.surname = value;
            }
        }

        private string name;
        private string surname;

    #endregion

    #region Constructors

    public Person(int id, string name, string surname, Gender gender)
    {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Surname = surname;
    }


    #endregion

    #region Methods

    public virtual string GetDescription()
    {
        return String.Format("{0} of gender {1}", this.Name, this.Gender);
    }

    //public abstract int GetAuthorities();

    #endregion
}
}
