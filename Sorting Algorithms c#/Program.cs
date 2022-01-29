using System;


namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {

         
          
           
            StudentClass[] student = new StudentClass[50];

            student[0] = new StudentClass("james", "brown", "Sophomore", 1050, 01311993, 4);

            student[1] = new StudentClass("Betty", "Parker", "Junior", 1049, 01311993, 4);
            student[2]= new StudentClass("braine", "Lim", "Sophomore", 1048, 01311993, 4);
            student[3] = new StudentClass("Pete", "Weijand", "Freshman", 1047, 01311993, 4);
            student[4] = new StudentClass("jonathon", "Jenkins", "Junior", 1046, 01311993, 4);
            student[5] = new StudentClass("josh","Knox", "Sophomore", 1045, 01311993,4);
            student[6] = new StudentClass("sheff","Mip", "Freshman", 1044, 01311993,4);
            student[7] = new StudentClass("linux", "Sap", "Sophomore", 1043, 01311993, 4);
            student[8] = new StudentClass("baker", "Cale", "Junior", 1042, 01311993, 4);
            student[9] = new StudentClass("marge", "Green", "Sophomore", 1041, 01311993, 4);
            student[10] = new StudentClass("Philip", "Gucci", "Freshman", 1039, 01311993, 4);
            student[11] = new StudentClass("Phil", "Gregerson", "Sophomore", 1039, 01311993, 4);
            student[12] = new StudentClass("Jasmine", "Mac", "Junior", 1049, 01311993, 4);
            student[13] = new StudentClass("Kim", "West", "Sophomore", 1048, 01311993, 4);
            student[14] = new StudentClass("Mike", "Jones", "Junior", 1047, 01311993, 4);
            student[15] = new StudentClass("Robert", "Kelly", "Junior", 1046, 01311993, 4);
            student[16] = new StudentClass("Odell", "Beckham", "Freshman", 1045, 01311993, 4);
            student[17] = new StudentClass("Stephan", "Curry", "Senior", 1044, 01311993, 4);
            student[18] = new StudentClass("Geoff", "Baley", "Junior", 1043, 01311993, 4);
            student[19] = new StudentClass("Haan", "Solo", "Freshman", 1042, 01311993, 4);
            student[20] = new StudentClass("Homer", "Simpson", "Junior", 1041, 01311993, 4);
            student[21] = new StudentClass("David", "Granston", "Freshman", 1039, 01311993, 4);
            student[22] = new StudentClass("Zandree", "Stone", "Freshman", 1048, 01311993, 4);
            student[23] = new StudentClass("Xavier", "Xman", "Junior", 1047, 01311993, 4);
            student[24] = new StudentClass("Yolanda", "Stevens", "Sophomore", 1046, 01311993, 4);
            student[25] = new StudentClass("Jamal", "Smith", "Freshman", 1045, 01311993, 4);
            student[26] = new StudentClass("Barmoder", "Stinnks", "Sophomore", 1044, 01311993, 4);
            student[27] = new StudentClass("Cranker", "Moap", "Junior", 1043, 01311993, 4);
            student[28] = new StudentClass("Baker", "Caleb", "Freshman", 1042, 01311993, 4);
            student[29] = new StudentClass("Luuk", "Salamander", "Junior", 1041, 01311993, 4);
            student[30] = new StudentClass("Jesus", "Martinez", "senior", 1050, 01311993, 4);
            student[31] = new StudentClass("betty", "Starter", "Freshman", 1049, 01311993, 4);
            student[32] = new StudentClass("Sara", "Ngyuen", "Senior", 1048, 01311993, 4);
            student[33] = new StudentClass("pete", "weijand", "Junior", 1047, 01311993, 4);
            student[34] = new StudentClass("jonathon", "jenkins", "Junior", 1046, 01311993, 4);
            student[35] = new StudentClass("Enmci", "Sipr", "Sophomore", 1045, 01311993, 4);
            student[36] = new StudentClass("sheff", "Mipper", "Senior", 1044, 01311993, 4);
            student[37] = new StudentClass("Hander", "Kisap", "Sophomore", 1043, 01311993, 4);
            student[38] = new StudentClass("baker", "cale", "Junior", 1042, 01311993, 4);
            student[39] = new StudentClass("Dave", "Jappel", "Senior", 1041, 01311993, 4);
            student[40] = new StudentClass("London", "Tokyo", "Junior", 1050, 01311993, 4);
            student[41] = new StudentClass("bett", "parker", "Junior", 1049, 01311993, 4);
            student[42] = new StudentClass("Snowden", "Falls", "Freshman", 1048, 01311993, 4);
            student[43] = new StudentClass("Orion", "Windex", "Freshman", 1047, 01311993, 4);
            student[44] = new StudentClass("Ben", "Dullpero", "Freshman", 1046, 01311993, 4);
            student[45] = new StudentClass("Jeffery", "Pesos", "Freshman", 1045, 01311993, 4);
            student[46] = new StudentClass("Nealon", "Tusk", "Senior", 1044, 01311993, 4);
            student[47] = new StudentClass("Bill", "Fence", "Freshman", 1043, 01311993, 4);
            student[48] = new StudentClass("Naviv", "Rozouski", "Freshman", 1042, 01311993, 4);
            student[49] = new StudentClass("Mary", "Jollip", "Senior", 1041, 01311993, 4);
            

            

            //Puts last names into a separate array
           
            string[] lastName = new string[student.Length];
            int i = 0;
            for (i = 0; i < lastName.Length; i++)
            {
                lastName[i] = student[i].getLastName();

            }
            

            //Pull the student ID from the array 
            int[] studentID = new int[student.Length];
            int high = studentID.Length - 1;

            for ( i = 0; i < studentID.Length; i++)
            {
                studentID[i] = student[i].getstudentId();
            }
           

            // User Menu
            UserMenu(studentID, lastName, high);
          

        }
        // Print string array 
        private static void print(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+"\n");
            }
        }
        //Print int array
       
        private static void print(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void UserMenu(int [] arr, string[] array, int num)
        {
            
            Console.WriteLine("Student DataBase\n");
            Console.WriteLine("1. Sort by Name");
            Console.WriteLine("2. Sort by Student ID");
            Console.WriteLine("3. Exit");
            int userInput = InputValidationForInt();


            switch (userInput)
            {
                case 1://Last Name
                    Console.WriteLine("Which sorting algorithm would you like to use? \n");
                    Console.WriteLine("1. Quick Sort");
                    Console.WriteLine("2. Merge Sort");
                    Console.WriteLine("3. EXIT");
                    userInput = InputValidationForInt();
                    if (userInput == 1)
                    {
                        Mergersorter.Merge(array);
                        print(array);

                    }
/*
                    if (userInput == 2 )
                    {
                        Mergersorter.Merge(array);
                        print(array);

                    }
*/
                    if (userInput == 2)
                    {
                        bubbleSort.sort(array);

                    }

                        break;
                case 2://Sort by student ID
                    Console.WriteLine("Which sorting algorithm would you like to use? \n");
                    Console.WriteLine("1. Quick Sort");
                    Console.WriteLine("2. Merge Sort");
                    userInput = InputValidationForInt();
                    if (userInput == 1)
                    {
                        quicksort.quickSort(arr, 0, num);
                        print(arr);

                    }

                    if (userInput == 2)
                    {
                        MergesorterInt.MergesortInt(arr);
                        print(arr);

                    }
                    
                    break;

                case 3:
                    Console.WriteLine("Exit");
                    break;


            }

            

        }
        //Standard user input validation method
        public static int InputValidationForInt()
        {
            int userInt;
            while (!int.TryParse(Console.ReadLine(), out userInt))
            {
                Console.WriteLine("Please enter a number to select an option");
            }

            return userInt;
        }


        

       
     

  

    }

    }



