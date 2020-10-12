using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class Player : SoccerTeam
    {
        private int dorsal;
        private string demarcation;

        public Player(int id, string name, string surname, int age, int dorsal, string demarcation) : base(id, name, surname, age)
        {
            this.dorsal = dorsal;
            this.demarcation = demarcation;
        }

        public int getDorsal() { return dorsal; }
        public void setDorsal(int dorsal) { this.dorsal = dorsal; }
        public string getDemarcation() { return demarcation; }
        public void setDemarcation(string demarcation) { this.demarcation = demarcation; }


        public void interview()
        {
            Console.WriteLine("ENTREVISTA A JUGADOR");
        }

        public override void getMeet()
        {
            Console.WriteLine("METODO DE REUNION DEL JUGADOR");
        }

        public override void playMatch()
        {
            Console.WriteLine("METODO DE JUGAR PARTIDO DEL JUGADOR");
        }

        public override void travel()
        {
            Console.WriteLine("METODO DE VIAJAR DEL JUGADOR");
        }

        public override void workout()
        {
            Console.WriteLine("METODO DE ENTRENAR DEL JUGADOR");
        }

    }
}
