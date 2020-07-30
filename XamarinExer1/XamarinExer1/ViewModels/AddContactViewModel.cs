using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace XamarinExer1.ViewModels
{
    class AddContactViewModel
    {

        public AddContactViewModel()
        {
           
        }

        string name = "Reymart";
        string address = "Pakpakan";
        string email = "reymart.com";
        string phoneNumber = "995023165333";
       

       

        public string Name
        {
            get { return name; }

            set
            { 
                name = value;
                
            }

        }

        public string Address
        {
            get { return address; }

            set
            {
                address = value;
               
            }
        }

        public string Email
        {
            get { return email; }

            set
            {
                email = value;
            }
        }
        
        public string PhoneNumber
        {
            
            get { return phoneNumber; }
            
            set
            {         

                phoneNumber = value;
        
            }
        }

    }
}
