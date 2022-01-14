using System;
using Microsoft.AspNetCore.Mvc;

namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ContactEmail { get; set; }

        public EventCategory Category { get; set;}
        public int CategoryId { get; set; }

        public int Id { get; set; }
        //static private int nextId = 1;

        //Entity mapper will take care of incrementing Id for us -
        //it uses Id field as key because of its name.
        //It needs Id to have a setter
        public Event()
        {
            //Id = nextId;
            //nextId++;
        }

        //Calling no-arg constructor is not necessary if the no-arg constructor 
        //is not handling Id incrementing for us.
        public Event(string name, string description, string contactEmail) 
            //: this()
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
        }

        

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
