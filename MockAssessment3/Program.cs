using System;
using System.Collections.Generic;

namespace MockAssessment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Town town = new Town();
            Console.WriteLine(town.SurviveTheWinter());
        }
    }





    public abstract class Villager
    {
        public int Hunger
        {
            get; set;
        }
        public abstract int Farm();
        public string Name { get; set; }

    }          
              
        public class Slacker : Villager
        {
            public Slacker(string name)
            {
                Hunger = 3;
                Name = name;
            }
            public override int Farm()
            {
                return 0;
            }

        }

        public class Farmer : Villager
        {
            public Farmer(string name)
            {
                Hunger = 1;
                Name = name;
            }
            public override int Farm()
            {
                return 2;
            } 
        }
        


     public class Town
     {


       
        public List<Villager> Villagers { get; set; }
        public Town()
        {
            Villagers = new List<Villager>();

            Villagers.Add(new Farmer("Bill"));
            Villagers.Add(new Slacker(""));
            Villagers.Add(new Slacker(""));
            Villagers.Add(new Slacker(""));
        }


         
        
        public int Harvest()
        {
            int HarvestTotal = 0;
            foreach (var villager in Villagers)
            {
                HarvestTotal = villager.Farm() + HarvestTotal;

            }
            
            return HarvestTotal;
        }



        public int CalcFoodConsumption()
        {
            int CalcFoodTotal = 0;
            foreach (var villager in Villagers)
            {
                CalcFoodTotal = villager.Hunger + CalcFoodTotal;
            }

            return CalcFoodTotal;
            
            
        }
        public bool SurviveTheWinter()
        {
            int harvest = Harvest();
            int foodCalc = CalcFoodConsumption();

            if(foodCalc <= harvest)
            {
                return true;
            }
            else //foodCalc >= harvest
            {
                return false;
            }
            
        }

     }
}
