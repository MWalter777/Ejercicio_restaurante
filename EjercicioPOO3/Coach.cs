using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO3
{
    class Coach : SoccerTeam
    {
        private int idFederation;

        public Coach(int idFederation,int id, string name, string surname, int age) : base(id, name, surname, age)
        {
            this.idFederation = idFederation;
        }

        public int getIdFederation() { return idFederation; }
        public void setIdFederation(int idFederation) { this.idFederation = idFederation; }

        public override void getMeet()
        {
            Console.WriteLine("METODO DE REUNION DEL ENTRENADOR");
        }

        public override void playMatch()
        {
            Console.WriteLine("METODO DE JUGAR PARTIDO DEL ENTRENADOR");
        }

        public override void travel()
        {
            Console.WriteLine("METODO DE VIAJAR DEL ENTRENADOR");
        }

        public override void workout()
        {
            Console.WriteLine("METODO DE ENTRENAR DEL ENTRENADOR");
        }
    }
}
