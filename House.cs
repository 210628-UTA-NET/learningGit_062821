using System;

namespace HouseFunction 
{
    public class House
    {
        private string _color;

        private int _price;

        // This is a constrcutor, a method called upon when an object is instantiated
        public House()
        {
            Console.WriteLine("The constructor of this class was used.");
            _color = "red";
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string Name { get; set; }

        // Java way to get information from class
        public string getColor()
        {
            return _color;
        }

        // Some methods have parameters to send information
        public void setColor(string p_color)
        {
            _color = p_color;
        }
    }
}