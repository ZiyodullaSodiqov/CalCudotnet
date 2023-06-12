namespace Calcu.Classes
{  
    class Animal 
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public int AgeDifference { get; set; }

        public Animal() 
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
        }

        public Animal(int userAge)
        {
            Name = "No name";
            AgeDifference = userAge - Age;
        }   

        private int CalculateAgeDifference(int userAge, int AnimalAge)
        {
            return userAge - AnimalAge;
        }
    } 
}