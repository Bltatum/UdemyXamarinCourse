using System;
using System.Collections.Generic;

namespace UdemyHelloWorld.Models
{
    public class ContactGroup : List<Contacts>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup( string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }
    }
}
