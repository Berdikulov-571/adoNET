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
            DataContextAdoNet.GetAll();
        }
    }
}