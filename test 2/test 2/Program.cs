/*
 Name = Gurpreet Singh
 Student I.D = 30008846
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
        class bird
        {
            string name, sound;


           public string Name
            {
                get { return name; }
                set { name = value; }

            }
            public string Species
            {
                get { return species; }
                set { species = value; }

            }
            
            public string Sex
            {
              get { return Sex; }
              set { sex = value; }
            }
            public string Weight
            {
            get { }
            }
            //public constructor
            public bird(string _name, string _sound)
            {
                Name = _name;
                Sound = _sound;
            }
            //public method that returns a string.
            public string Birdsays()
            {
                return "The " + Name + "say" + Sound;

            }
            class program
            {
                static void Main(string[] args)
                {
                    Console.Write("please enter the bird name:");
                    string birdtype = Console.ReadLine();
                    Console.Write("please enter the bird species:");
                    string birdSound = Console.ReadLine();

                    bird first = new bird(birdtype, birdSound);

                    Console.WriteLine(first.Birdsays());

                }
            } 
