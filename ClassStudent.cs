using System;

namespace Chapter_14_Definng_classes
{
    public  class Student
    {
        //no 1 & 5;
        public string Name {get; set;}
        public string Course {get; set;}
        public  string Email {get; set;}
        public string PhoneNumber {get; set;}
        public Universitty Universitty {get; set;}
        public Subjects Subjects {get; set;
        public static int Count {get; set;}


        // n0 2
        public Student (string name, string course, string email, string phonenumber, Universitty universitty, Subjects subjects)
        {
            Name = name;
            Course = course;
            Email = email;
            PhoneNumber = phonenumber;
            Universitty = universitty;
            Subjects = subjects;

        }

        public Student(string name,string phoneNumber) 
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public Student (string course,Universitty universitty,string email)
        {
            Course = course;
             Universitty = universitty;
            Email = email;
        }


        //no 3
        public  Student ()
        {
             Count++;
        }


       // No 4

       public void PrintStudentInfo(Student s1)
       {
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Course);
            Console.WriteLine(s1.Universitty);
            Console.WriteLine(s1.Email);
            Console.WriteLine(s1.PhoneNumber);
       }

          //no 6

            Student ps2 = new Student("ade","Horticulture","4kerty@gmail.com","09098787890",Universitty.fuunaab,Subjects.phy101);  
            Student ps3 = new Student ("ade","090987876");
            Student ps4 = new Student("Computer science",Universitty.lasu,"MayD@gmail.com");
            
            //no 7

            public static void StudentTest()
            {
                Student st = new Student();
                st.Name = "wasiu";
                st.PhoneNumber = "09098786546";
                st.Course = "Horticuture";
                st.Email = "HSD!@mail.com";
                st.Universitty = Universitty.unilag;
                st.Subjects = Subjects.math202;

                Console.WriteLine($"your name is {st.Name} your course {st.Course} your email is {st.Email} your university is {st.Universitty} and your subject is {st.Subjects}");
            }

           // no 8,9,10,11,112,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27
            // CLasses Created;

    }
}