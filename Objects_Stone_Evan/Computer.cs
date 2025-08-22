using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Stone_Evan
{
    class Computer : IBootUp
    {
        //gets and sets IsOn, Brand, and Type
        public bool IsOn { get; set; }

        public string Brand {  get; set; }  

        public string Type { get; set; }    

        //sets up Computer with strings brand and type and bool isOn, as well as give them the value of Brand, Type, and IsOn
        public Computer(string brand, string type, bool isOn) 
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        //makes IsOn equal to IsOn, and if IsOn equals true write a line about the computer booting up, if false or else, writes a line about the computer shutting down
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if (IsOn == true) 
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The Computer is shutting down!");
            }
        }

        //overrides ToString in order to have the value of a string stating a computer is made by Brand is a(n) Type computer and weither it is on or not
        public override string ToString()
        {
            return $"The Computer is made by {Brand} and is a(n) {Type} computer, is it on? {IsOn}!";
        }
    }
}
