class Program
{
    static void Main(string[] args)
    {
        /*Create a method named Sum() that will axccept any number of integer parameters and displays their sum
        Write a Main() method that demonstrates that the Sum() method works when passed 1 ,3 5 or any array of 10 integers works correctly  */


        Sum(5);
        Sum(5,10,15);
        Sum(5,10,15,20,25);

        int[] myArray ={10,20,30,40,50,60,70,80,90,100};
        Sum(myArray);


    }

    public static void Sum(params int[] myArray)
    {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum+=myArray[i];
            }
            Console.WriteLine("The sum is {0}",sum);
    }
}