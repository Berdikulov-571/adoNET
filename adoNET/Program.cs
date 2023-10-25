using System.Data.SqlClient;

namespace adoNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataContextAdoNet.DeleteById(5);
            //DataContextAdoNet.Create(5, "MuhammadAbdulloh", "Komilov");
            //DataContextAdoNet.GetById(1);
            //DataContextAdoNet.Update(5,"Alisher","Alimatov");
            List<User> users = DataContextAdoNet.GetUsers();

            foreach (User i in users)
            {
                Console.WriteLine($"{i.firstName} {i.lastName}");
            }
        }
    }
}