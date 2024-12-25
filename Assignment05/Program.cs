using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Assignment05
{
    internal class Program
    {

        #region Two Functions of Q1

        //public static void PassValueParaByValue(int a)
        //{
        //    a=a + 1;
        //    Console.WriteLine(a);
        //}

        //public static void PassValueParaByReference(ref int a)
        //{
        //    a = a + 1;
        //    Console.WriteLine($"Value in the function  : {a}");
        //}

        #endregion

        #region Two functions of Q2


        //public  static void PassReferenceParaByValue(int[] arr)

        //{
        //    Console.WriteLine("Array during function run : ");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] += 1;
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        //#endregion


        //public static void PassReferenceParaByReference(ref int[] arr)

        //{

        //    Console.WriteLine("Array during function run : ");
        //    arr = new int[] {10,20,30,40,50 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
       
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        #endregion

        #region Function of Q3
        //public static void SumAndSub(int x, int y, out int Sum , out int sub )
        //{
        //   Sum = x + y;
        //   sub = x - y;
        //}
        #endregion

        #region Function of Q4

        //public static void SumOfIndividualDigits(int a)
        //{
        //    int container = 0;
        //    int sum = 0;
        //    while (a > 0)
        //    {
        //        container = a % 10;
        //        sum += container;
        //        a = a / 10;

        //    }
        //    Console.WriteLine(sum);
        //}
        #endregion

        #region function of Q5

        //public static void Isprime(int x)
        //{

        //    for (int i = 2; i < x; i++)
        //    {
        //        if (x % i == 0)
        //        {
        //            Console.WriteLine($"This number is not prime : {x}");
        //            break;
        //        }

        //        else
        //        {
        //            Console.WriteLine($"This number is  prime : {x}");
        //            break;
        //        }
        //    }

        //}
        #endregion

        #region function of Q6 

        //public static void MinMaxArray(ref int[] arr ,  ref int maxNum, ref int minNum )
        //{
        //    int swap = 0;  
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i+1; j < arr.Length ; j++)
        //            if (arr[i] > arr[j])// 8>5
        //            {
        //                swap = arr[j];// 5
        //                arr[j] = arr[i];//8
        //                arr[i] = swap;//5

        //            }

        //    }
        //    minNum = arr[0];
        //    maxNum = arr[arr.Length-1];
        //    //return ;
        //}
        #endregion

        #region Function of Q7

        //public static int FactorialNumber(ref int x)
        //{

        //    for (int i = x-1 ; i >=1; i--)
        //    {
        //        x = x * i;

        //    }
        //    return x;
        //}

        #endregion

        #region Function of Q8

        //public static void ChangeChar(ref string changeName, string changeLetter,int pos)
        //{
        //    changeName = changeName.Remove(pos, 1);
        //    changeName= changeName.Insert(pos, changeLetter.ToString());    
        //}
        #endregion
        public static void Main()
        {




            #region Q1 

            // passing  value type parameters :

            // 1- passing by value : means take a copy from the original value and pass it to the variable in the function
            //                       and varaiable of the function create a place int the stack for this copy and store it in
            //                       and any modifcation or calculations on this copy doesn't mean that the original value
            //                       will be affected or changed

            // example on passing by value:

            //Console.WriteLine("Enter the number:");
            //int x;
            //int.TryParse(Console.ReadLine(), out x);    
            //PassValueParaByValue(x);
            //Console.WriteLine("value of x after function run is done : ");
            //Console.WriteLine(x);


            //2- passing by reference : means that the place of the value of the original variable in the stack is passed to the variable
            //                          of the function so the varaible of the function doesn't create a place in the stack for
            //                          the value , it acts during the run of the function as the original variable of this value
            //                          and can modify and do calculations that will affect the original value in the original variable
            //                          after the function run

            // example on passing by reference:

            //Console.WriteLine("Enter the number:");
            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //PassValueParaByReference(ref x);
            //Console.WriteLine("value of x after function run is done : ");
            //Console.WriteLine(x);

            #endregion

            #region Q2

            // passing Reference value type parameters :

            // 1- passing by value : means that a copy of the address of the original variable will passed to the variable of
            //                       the function , So the variable of te function have the address that points to value stored
            //                       in the heap and can modify and do calculations on the value directly during the function run
            //                       and after run of function is done the changed value will remain and will be in the original variable
            //                       but if during the function run the varaible of function create new object with new address
            //                       and make modifications and calculations on it , the new address will not stored in the original
            //                       vairable and the value of the original variable will not change , as in the variable of the function
            //                       now is pointing now towards a new object with new value


            // example on passing by value  :


            //Console.WriteLine("Enter the array :");
            //int[] x = new int[5];
            //for (int i = 0; i < x.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out x[i]);
            //}
            //PassReferenceParaByValue(x);
            //Console.WriteLine("value of array x after function run is done : ");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}


            // 2- passing by reference : means that  place of the value of the original variable is passed to the variable of the 
            //                           function so during the function running its variable takes place of original variable
            //                           
            //                           in the debug table and in the stack frame and carry directly the address of the value
            //                           that points to value in the heap  can modify and do calculations on the value directly 
            //                           during the function run and after run of function done the modified value remains in the
            //                           original varaible
            //                           And if during the function , a new object with new address is created in the varaible
            //                           of the function , it will be stored insatead of the old address of the original variable
            //                           so the value in the heap that old address points to it will return to unreachacble object
            //                           because  after the function run is done , the original variable will be carrying
            //                           new address that points towards a new value un the heap

            // example :

            //Console.WriteLine("Enter the array :");
            //int[] x = new int[5];
            //for (int i = 0; i < x.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out x[i]);
            //}
            //PassReferenceParaByReference(ref x);
            //Console.WriteLine("value of array x after function run is done : ");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}



            #endregion

            #region Q3 

            //int a;
            //int y;
            //Console.WriteLine("Enter first integer : ");
            //int.TryParse(Console.ReadLine(), out a);
            //Console.WriteLine("Enter Second integer : ");
            //int.TryParse(Console.ReadLine(), out y);    
            //int summation;
            //int subtraction;
            //SumAndSub(a, y, out summation, out subtraction);
            //Console.WriteLine($"Summation is : {summation}");
            //Console.WriteLine($"Subtraction  is : {subtraction}");

            #endregion

            #region Q4


            //Console.WriteLine("Enter the number : ");
            //int x;
            //int.TryParse(Console.ReadLine(), out x);
            //SumOfIndividualDigits(x);



            #endregion

            #region Q5

            //Console.WriteLine("Enter the number : ");
            //int a;

            //int.TryParse(Console.ReadLine(), out a);
            //Isprime(a);



            #endregion

            #region Q6

            //Console.WriteLine("Enter numbers of the array : ");
            //int[] x = new int[5];
            //int maxValue, minValue;
            //maxValue = 0;
            //minValue = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out x[i]);
            //}
            //MinMaxArray(ref x,ref maxValue, ref minValue);
            //Console.WriteLine("Array after sorting ");
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i]);    
            //}

            //Console.WriteLine($"Minimum value is : {minValue}");
            //Console.WriteLine($"Maximum value is : {maxValue}");


            #endregion

            #region Q7

            //Console.WriteLine("enter the number : ");
            //int a;
            //int factorialNum;
            //int.TryParse(Console.ReadLine(), out a);
            //factorialNum = FactorialNumber(ref a);
            //Console.WriteLine($"factorial number is : {factorialNum}");

            #endregion

            #region Q8

            //string name;
            //string letter;
            //int index;

            //Console.WriteLine("Enetr the string : ");
            //name = Console.ReadLine();
            //Console.WriteLine("Enter the letter : ");
            //letter = Console.ReadLine();
            //Console.WriteLine("Enter the index : ");
            //int.TryParse(Console.ReadLine(), out index);

            //ChangeChar(ref name,  letter,index);

            //Console.WriteLine(name);

            #endregion


        }
    }
}
