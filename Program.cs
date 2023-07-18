using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment9
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string username,email,password;
                Console.WriteLine("Enter User Name");
                username = (Console.ReadLine());
                Console.WriteLine(username.GetType());
                Console.WriteLine("Enter Email ");
                email = Console.ReadLine();
                Console.WriteLine("Enter Password");
                password = Console.ReadLine();
                if (username.Length<6 )
                {
                    throw new CustomException("The Username Should have minimum six Characters");
                }
                else if (password.Length < 8)
                {
                    Console.WriteLine("The Password Must have Minimum 8 characters");
                }
                else if(username.Length>=6 && password.Length>=8)
                {
                    Console.WriteLine("Registration Successfull");
                    Console.WriteLine($"Username: {username} \n Email: {email} \n Password: {password}");
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.WriteLine("*** Thank You ***");
                Console.ReadKey();
            }
        }
    }
}
