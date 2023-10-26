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


            //DataContextAdoNet.GetByGeneric("StudyCenterDB","userTable","where userId = 5;");

            DataContextAdoNet.Insert("StudyCenterDB","Persons", "('Bahriddin','Abdusalomov',17,1),('Temurbek','Abdurashidov',17,2)");
        }
    }
}