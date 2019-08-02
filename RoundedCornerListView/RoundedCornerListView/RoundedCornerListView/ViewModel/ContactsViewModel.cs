﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sorting 
{
    public class ContactsViewModel
    {
        #region Public Properties

        public ObservableCollection<Contacts> customerDetails
        {
            get;
            set;
        }

        #endregion

        #region Fields

        private Random random = new Random();

        #endregion

        #region Ctor

        public ContactsViewModel()
        {
            this.GetContactDetails(75);
        }

        #endregion

        #region Get Contacts Details

        private void GetContactDetails(int count)
        {
            customerDetails = new ObservableCollection<Contacts>();

            for (int i = 0; i < count; i++)
            {
                var details = new Contacts()
                {
                    ContactType = contactType[random.Next(0, 4)],
                    ContactNumber = random.Next(100, 400).ToString() + "-" + random.Next(500, 800).ToString() + "-" + random.Next(1000, 2000).ToString(),
                    ContactName = CustomerNames[i],
                };
                customerDetails.Add(details);
            }
        }

        #endregion

        #region Customer Information

        string[] contactType = new string[]
        {
            "HOME",
            "WORK",
            "MOBILE",
            "OTHER",
        };

        string[] CustomerNames = new string[] {
           "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Michael",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Jennifer",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Zeke",
            "Aiden",
            "Jackson",
            "Mason",
            "Liam",
            "Jacob",
            "Jayden",
            "Ethan",
            "Noah",
            "Lucas",
            "Logan"    ,
            "Caleb"    ,
            "Caden"    ,
            "Jack"    ,
            "Ryan"    ,
            "Connor"    ,
            "Michael"    ,
            "Elijah"    ,
            "Brayden"    ,
            "Benjamin"   ,
            "Nicholas"   ,
            "Alexander"  ,
            "William"    ,
            "Matthew"    ,
            "James"    ,
            "Lando"    ,
            "Nathan"    ,
            "Dylan"    ,
            "Evan"    ,
            "Luke"    ,
            "Andrew"    ,
            "Gabriel"    ,
            "Gavin"    ,
            "Joshua"    ,
            "Owen"    ,
            "Daniel"    ,
            "Carter"    ,
            "Tyler"    ,
            "Cameron"    ,
            "Christian"  ,
            "Wyatt"    ,
            "Henry"    ,
            "Eli"    ,
            "Joseph"    ,
            "Max"    ,
            "Isaac"    ,
            "Samuel"    ,
            "Anthony"    ,
            "Grayson"    ,
            "Zachary"    ,
            "David"    ,
            "Christopher",
            "John"    ,
            "Isaiah"    ,
            "Levi"    ,
            "Jonathan"   ,
            "Oliver"    ,
            "Chase"    ,
            "Cooper"    ,
            "Tristan"    ,
            "Colton"    ,
            "Austin"    ,
            "Colin"    ,
            "Charlie"    ,
            "Dominic"    ,
            "Parker"    ,
            "Hunter"    ,
            "Thomas"    ,
            "Alex"    ,
            "Ian"    ,
            "Jordan"    ,
            "Cole"    ,
            "Julian"    ,
            "Aaron"    ,
            "Carson"    ,
            "Miles"    ,
            "Blake"    ,
            "Brody"    ,
            "Adam"    ,
            "Sebastian"  ,
            "Adrian"    ,
            "Nolan"    ,
            "Sean"    ,
            "Riley"    ,
            "Bentley"    ,
            "Xavier"    ,
            "Hayden"    ,
            "Jeremiah"   ,
            "Jason"    ,
            "Jake"    ,
            "Asher"    ,
            "Micah"    ,
            "Jace"    ,
            "Brandon"    ,
            "Josiah"    ,
            "Hudson"    ,
            "Nathaniel"  ,
            "Bryson"    ,
            "Ryder"    ,
            "Justin"    ,
            "Bryce"    ,
        };

        #endregion

    }
}
