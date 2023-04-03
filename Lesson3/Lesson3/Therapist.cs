using System;
namespace Lesson3
{
	public class Therapist : Doctor

	{
        public Therapist (string name, int age, int exper, string spec) : base(name, age, exper, spec)
        {
        }

        public override void Cure(Patient patient)
        {
            if (patient.Status == true)
            {
                Console.WriteLine("Ты здоров,иди домой");

            }
            else
            {
                patient.Status = true;
                Console.WriteLine("Ура,чудесная сила исцеления!");
            }
        }

    //        Если переменная булева, то в If можно не прописывать ее сравнение со значением.
    //Т.е.если условие проходит, при значении Satus true, то: if (patient.Status){ ...}.
    //Если при значении false, то if (!patient.Status){...}.

    }

}

