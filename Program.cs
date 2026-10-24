namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.
        while(true)
        {
            System.Console.WriteLine("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400 == 0 || year % 100 != 0) && year % 4 == 0 )
            {
               System.Console.WriteLine("good");     
            } 
        }
    }
}