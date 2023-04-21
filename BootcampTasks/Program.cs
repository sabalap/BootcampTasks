namespace BootcampTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task N1 
            try
            {
                int attemptsNumber = 5;
                while (attemptsNumber > 0)
                {
                    Console.WriteLine("Please enter the name");
                    string enteredname = Console.ReadLine();

                    Console.WriteLine("Please enter the passsword");
                    string enteredPassword = Console.ReadLine();

                    if (UserCredentialsValidity(enteredname, enteredPassword))
                    {
                        Console.WriteLine("Success, Your Credentials are correct!");
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        attemptsNumber--;
                        Console.WriteLine($"Incorrect Credentials, You have {attemptsNumber} attempts left");
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("");
            }


            // ***********************************


            // Task N2
            try
            {
                Console.WriteLine("Enter the number to convert");

                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Binary of the given number is");

                Console.WriteLine(ConvertNumberToBinary(number));
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("");
            }


            // ***********************************

            // Task N3
            // პირველი ხერხით გავაკეთე კონსოლიდან შემოტანით.
            try
            {
                Console.WriteLine("Calculate Area");

                Console.WriteLine("Please Enter the length");
                int lengthForArea = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter the width");
                int widthForArea = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Calculate Area result");
                Console.WriteLine(CalculateArea(lengthForArea, widthForArea));
                Console.WriteLine("");

                Console.WriteLine("Calculate Volume");

                Console.WriteLine("Please Enter the length");
                int lengthForVolume = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter the width");
                int widthForVolume = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter the height");
                int heightForVolume = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Calculate Volume result");
                Console.WriteLine(CalculateVolume(lengthForVolume, widthForVolume,heightForVolume));
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("");
            }

            // მეორე ხერხით ხელით გავუწერე არგუმენტები.
            try
            {
                Console.WriteLine("Calculate Area");

                Console.WriteLine("When length is 5 and width is 5,Calculate Area result");
                Console.WriteLine(CalculateArea(5, 5));
                Console.WriteLine("");

                Console.WriteLine("Calculate Volume");

                Console.WriteLine("When length is 5, width is 5 and height is 5, Calculate Volume result");
                Console.WriteLine(CalculateVolume(5,5,5));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("");
            }

        }



        // return bool based on console credentials
        static bool UserCredentialsValidity(string name, string password)
        {
            string myName = "saba555";
            string myPassword = "paroli123";

            return name == myName && password == myPassword;
        } 


        // Convert Number To Binary
        static string ConvertNumberToBinary(int number) => Convert.ToString(number, 2);


        // Calculate area
        static int CalculateArea(int length, int width) => length * width;

        // Calculate Volume
        static int CalculateVolume(int length, int width, int height) => length * width * height;
    }
}