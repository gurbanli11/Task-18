//namespace HomeWork16._04
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
           //Cat cat = (Cat)animal;
            //Cat cat = animal is Cat;
            //if (cat!=null)
            //{
            //    cat.Risofkalanmaq();
            //}
            //if (animal is Cat cat)
            //{
            //    cat.Risofkalanmaq();
            //}
            //else if (animal is Eagle)
            //{
            //    Eagle eagle = (Eagle)animal;
            //    eagle.Hunt();
            //}
            //else if (animal is Shark)
            //{
            //    Shark shark = (Shark)animal;
            //    shark.Swim();
            //}

            //Boxing -> Value type-ni referance type-a chevirmek
            //string txt = 5.ToString();
            //Unboxing -> Referance type-ni value type-a chevirmek
            //int num = Convert.ToInt32(txt);


//            Person anar = new();
//            {
//                Name = "Anar";
//                Surname = "Gasimzade";
//                Age = 20;
//            }
//            Person orxan = new();
//            {
//                Name = "Orxan";
//                Surname = "Gurbanli";
//                Age = 20;
//            }
//            Console.WriteLine(anar > orxan);
//        }


//        class Person
//        {
//            public string Name { get; set; }
//            public string Surname { get; set; }
//            public string Age { get; set; }
//        }
//        public static bool operator>(Person left,Person right)
//        {
//            return left.Age > right.Age;
//        }
//        public static bool operator <(Person left, Person right)
//        {
//            return left.Age < right.Age;
//        }
//        public static bool operator =(Person left, Person right)
//        {
//            return left.Age != right.Age;
//        }
//        public static bool operator !=(Person left, Person right)
//        {
//            return left.Age == right.Age;
//        }
//    }
//}