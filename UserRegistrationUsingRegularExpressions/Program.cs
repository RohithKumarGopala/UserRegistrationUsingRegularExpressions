namespace UserRegistrationUsingRegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To UserRegistration Programme");

            ValidatingDetails validatingDetails = new ValidatingDetails();

            //validatingDetails.ValidatingFirstName();
            //validatingDetails.ValidatingLastName();
            //validatingDetails.ValidatingEmailaddress();
            validatingDetails.ValidatingMoblieNumber();
        }
    }
}