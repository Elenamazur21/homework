using System;
using System.Net.NetworkInformation;

namespace Lesson3
{
    public class Neurologist : Doctor

    {

        public Neurologist(string name, int age, int exper, string spec) : base(name, age, exper, spec)

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
        //Чтобы не выводить в консоль булевое значение (true/false), можно было создать общий enum Status для статусов:
        //public enum Status
        //{
        //    Ill,
        //    Healthy
        //}
//        присвоить свойству Status тип данных Status:
//public Status Status { get; set}

//        и в методах проверять статус через enum:
//if (patient.Status.CompareTo(Status.Ill){...}
//    или if ((int) patient.Status == (int) Status.Ill) { ...}

//    Если нужно показать в консоли имя члена enum (Ill,
//    Healthy), а не его значение, то воспользуйтесь методом GetName().



    }
}


