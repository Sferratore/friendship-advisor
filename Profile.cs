using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendshipAdvisor
{
    /// <summary>
    /// Class <c>Profile</c> defines a profile of the FriendshipAdvisor application. <br></br>
    /// +Name (String) <br></br> +Age (Int) <br></br> +City (String) <br></br>+Country (String) <br></br>+Hobbies (String[])<br></br> 
    /// </summary>
    class Profile
    {
        //CONSTRUCTORS
        public Profile(string nm, int age, string city, string country, string[] hobbies = null)
        {
            this.Name = nm;
            this.Age = age;
            this.City = city;
            this.Country = country;
            if(hobbies == null)
            {
                this.Hobbies = new string[1] { "No hobbies specified!" };
            }
            else { this.Hobbies = hobbies; }
        }




        //METHODS

        /// <summary>
        /// <c>GetHobbies</c> returns a singular string with all the hobbies of a profile.
        /// </summary>
        /// <returns></returns>
        public string GetHobbies()
        {
            string s = "";
            foreach(string str in this.Hobbies)
            {
                s = str + " " + s;
            }
            return s;
        }


        /// <summary>
        /// <c>ViewProfile</c> method prints all the info about a profile.
        /// </summary>
        /// <returns></returns>
        public string ViewProfile() 
        {
            return $"****************\nPROFILE DESCRIPTION\n****************\n\nName: {this.Name}\nAge: {this.Age}\nCity: {this.City}\nCountry: {this.Country}\nHobbies: {this.GetHobbies()}";
        }




        //PROPERTIES
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string[] Hobbies { get; set; }

    }
}
