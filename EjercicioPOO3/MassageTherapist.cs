using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class MassageTherapist : SoccerTeam
    {
        private string title;
        private int yearExperience;

        public MassageTherapist(string title, int yearExperience,int id, string name, string surname, int age) : base(id, name, surname, age)
        {
            this.title = title;
            this.yearExperience = yearExperience;
        }

        public string getTitle() { return title; }
        public void setTitle(string title) { this.title = title; }

        public int getYearExperience() { return yearExperience; }
        public void setYearExperience(int yearExperience) { this.yearExperience = yearExperience; }

        public override void getMeet()
        {
            Console.WriteLine("METODO DE REUNION DEL MASAJEADOR");
        }

        public override void playMatch()
        {
            Console.WriteLine("METODO DE JUGAR PARTIDO DEL MASAJEADOR");
        }

        public override void travel()
        {
            Console.WriteLine("METODO DE VIAJAR DEL MASAJEADOR");
        }

        public override void workout()
        {
            Console.WriteLine("METODO DE ENTRENAR DEL MASAJEADOR");
        }

    }
}
