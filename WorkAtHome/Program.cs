using System;

namespace WorkAtHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1.Test
            //Car car = new Car(100, 50)
            //{
            //    Model = "M5",
            //    Brand = "BMW",
            //    Milage = 100000
            //};

            //Console.WriteLine(car.CurrentCapacity);
            #endregion

            #region Task2.Test
            Student[] students = new Student[0];
            string option;
            do
            {
                Console.WriteLine("1.Butun telebelere bax \n2.Telebeler uzre axtaris et \n3.Telebe elave et \n0.Menudan cixis et");
                Console.WriteLine("Emeliyat secin : ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        if (students.Length == 0)
                        {
                            Console.WriteLine("Hal hazirda qeydiyyatdan kecen telebe yoxdur");
                        }
                        else
                        {
                            for (int i = 0; i < students.Length; i++)
                            {
                                Console.WriteLine($"FullName : {students[i].FullName}\nGroupNo : {students[i].GroupNo}");
                            }
                        }

                        break;
                    case "2":
                        Console.WriteLine("Axtarmaq istediyiniz deyeri daxil edin :");
                        string getValue = Console.ReadLine();
                        if (students.Length == 0)
                        {
                            Console.WriteLine("Hal hazirda qeydiyyatdan kecen telebe yoxdur");
                        }
                        else
                        {
                            int count = 0;
                            for (int i = 0; i < students.Length; i++)
                            {
                                if (students[i].FullName.Contains(getValue) || students[i].GroupNo.Contains(getValue))
                                {
                                    Console.WriteLine($"FullName : {students[i].FullName} \nGroupNo : {students[i].GroupNo}");
                                    count++;
                                }

                            }
                            if (count == 0)
                            {

                                Console.WriteLine("Daxil etdiyiniz deyerle elaqeli melumat yoxdur");

                            }
                        }

                        break;
                    case "3":
                        string fullName;
                        bool isOk = true;
                        do
                        {
                            if (isOk == false)
                            {
                                Console.WriteLine("Zehmet olmasa adinizin ve soyadinizin bas herflerini boyuk yazin");

                            }
                            Console.Write("Telebenin ad ve soyadini daxil edin : ");
                            fullName = Console.ReadLine();
                            isOk = false;

                        } while (MakeCorrectFullName(fullName) == false);
                        bool isOk2 = true;
                        string groupNo;
                        do
                        {
                            if (isOk2 == false)
                            {
                                Console.WriteLine("Qrup nomresi boyuk herfle baslamali ve reqemle davam etmelidir.Uzunlugu 4 olmalidir");
                            }
                            Console.Write("Telebenin qrup nomresini daxil edin : ");
                            groupNo = Console.ReadLine();
                            isOk2 = false;
                        } while (MakeCorrectGroupName(groupNo) == false);

                        Student student = new Student()
                        {
                            FullName = fullName,
                            GroupNo = groupNo
                        };

                        Array.Resize(ref students, students.Length + 1);
                        for (int i = 0; i < students.Length; i++)
                        {

                            students[students.Length - 1] = student;
                        }
                        break;


                    case "0":
                        Console.WriteLine("Cixmaq istediyinizden eminsiniz ? \nBeli\nXeyr");
                        var exitOrContinue = Console.ReadLine();
                        option = exitOrContinue;
                        break;

                    default:
                        Console.WriteLine("Zehmet olmasa duzgun secim edin");
                        break;

                }

            } while (option != "Beli");
            #endregion
        }
        static bool MakeCorrectGroupName(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            if (str.Length < 5)
            {
                if (!char.IsUpper(str[0]))
                {
                    return false;
                }
                for (int i = 1; i < str.Length; i++)
                {
                    if (!char.IsDigit(str[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool MakeCorrectFullName(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            else
            {
                var nameAndSurname = str.Split(' ');
                var noSpaceNameAndSurname = new string[0];
                int j = 0;
                for (int i = 0; i < nameAndSurname.Length; i++)
                {
                    if (nameAndSurname[i] != "")
                    {
                        Array.Resize(ref noSpaceNameAndSurname, noSpaceNameAndSurname.Length + 1);
                        noSpaceNameAndSurname[j] = nameAndSurname[i];
                        j++;
                    }
                }
                // FullName 3 addanda ibaret ola biler deye bele verdim
                if (noSpaceNameAndSurname.Length <= 3)
                {
                    int count = 0;
                    for (int i = 0; i < noSpaceNameAndSurname.Length; i++)
                    {
                        if (MakeName(noSpaceNameAndSurname[i]))
                        {
                            count++;
                        }
                    }
                    if (noSpaceNameAndSurname.Length == count)
                    {
                        return true;
                    }


                    return false;

                }
                return false;
            }


        }

        static bool MakeName(string str)
        {
            if (!char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsLower(str[i]))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
