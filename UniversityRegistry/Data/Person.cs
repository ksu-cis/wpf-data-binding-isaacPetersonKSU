using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace UniversityRegistry.Data
{
    /// <summary>
    /// A class representing a person associated with the university
    /// </summary>
    public class Person : INotifyPropertyChanged
    {
        private uint _iD;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private bool _active;
        private Role _role;

        /// <summary>
        /// Event triggered when properties of Person change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The next ID to assign to a newly-created person
        /// </summary>
        public static uint NextID = 80000000;

        /// <summary>
        /// The uinque identifier of this person
        /// </summary>
        public uint ID
        {
            get
            {
                return _iD;
            }
            set
            {
                if(_iD != value)
                {
                    _iD = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ID"));
                }
                
            }
        }

        /// <summary>
        /// The person's first name
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if(_firstName != value)
                {
                    _firstName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));
                }
            }
        }

        /// <summary>
        /// The person's last name
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if(_lastName != value)
                {
                    _lastName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));
                }
            }
        }

        /// <summary>
        /// The person's date of birth
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if(_dateOfBirth != value)
                {
                    _dateOfBirth = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateOfBirth"));
                }
            }
        }

        /// <summary>
        /// If this person is active in the university (currently a part of the university)
        /// </summary>
        public bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                if(_active != value)
                {
                    _active = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Active"));
                }
            }
        }

        /// <summary>
        /// The person's role
        /// </summary>
        public Role Role
        {
            get
            {
                return _role;
            }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Role"));
                }
            }
        }
        
        /// <summary>
        /// Creates a new user, assigning them an ID
        /// </summary>
        public Person()
        {
            ID = NextID++;
        }

        /// <summary>
        /// Returns a text representation of the perosn
        /// </summary>
        /// <returns>The person's name and ID number</returns>
        public override string ToString()
        {
            return $"{LastName}, {FirstName} [{ID}]";
        }
    }
}
