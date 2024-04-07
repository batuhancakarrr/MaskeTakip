using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "BATUHAN";
            person.LastName = "ÇAKAR";
            person.DateOfBirthYear = 2001;
            person.NationalIdentity = 1;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);

            Console.ReadLine();
        }
    }
}