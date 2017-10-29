using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Modeles;

namespace ConsoleTraining
{
    class Program
    {
        private Training Entrainement { get; set; }
        private Seance Se { get; set; }

        private Program()
        {
            ExerciseX Ex = new ExerciseX { Name = "Curl", Reps = 12, Sets = 4, Rest = 90 };
            Ex.Muscles.Add(Muscle.Biceps);
            Se = new Seance { Ex, Ex };
            Se.Nom = "Bra";
            Entrainement = new Training { Se, Se };

            Console.Write(Entrainement.First().First().Muscles.First());
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
