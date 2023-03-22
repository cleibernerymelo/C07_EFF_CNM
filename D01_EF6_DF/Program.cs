using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D01_EF6_DF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Declarar o contexto de bd (instanciar DbContext)
            Console.WriteLine("Entity framework");

            var db = new NorthwindEntities(); //Aceder: connectionstring + dbsets
            #endregion

            #region 2. Usar o contexto de bd
            using (db)
            {
                #region New Region (1)
                Region region1= new Region();
                Region region2 = new Region();
                Region region3 = new Region();

                region1.RegionID = 5; // não é identity
                region1.RegionDescription = "Norte";

                region2.RegionID = 6; // não é identity
                region2.RegionDescription = "Centro";

                region3.RegionID = 7; // não é identity
                region3.RegionDescription = "Sul";



                db.Region.Add(region1); // Adicionar o novo registo à tabela em memoria (dbset)
                db.Region.Add(region2);
                db.Region.Add(region3);

                int countRows = db.SaveChanges(); // Gravar o registo anterior na bd 

                Console.WriteLine($"New region saved. {countRows}\n");

                 var queryRegion = db.Region.Select(r => r).OrderBy(r => r.RegionID);

                foreach (var item in queryRegion)
                {
                    Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");
                  
                }

                #endregion

                #region New Territory at region (n)
                Territories territories1 = new Territories();
                Territories territories2 = new Territories();
                Territories territories3 = new Territories();

                territories1.TerritoryID = "00001";
                territories1.TerritoryDescription = "Espinto";
                territories1.RegionID = 5;

                territories2.TerritoryID = "00002";
                territories2.TerritoryDescription = "Leiria";
                territories2.RegionID = 6;

                territories3.TerritoryID = "00003";
                territories3.TerritoryDescription = "Beja";
                territories3.RegionID = 7;

                db.Territories.Add(territories1);
                db.Territories.Add(territories2);
                db.Territories.Add(territories3);

                int countTerritories = db.SaveChanges();
                Console.WriteLine($"New territories saved. {countTerritories}\n");

                var queryTerritory = db.Territories.Select(t => t).OrderByDescending(t => t.TerritoryID);

                //foreach (var item in queryRegion)
                //{
                //    Console.WriteLine($"{item.RegionID} - {item.RegionDescription}");

                //}

                queryTerritory.ToList().ForEach(t => Console.WriteLine($"{t.TerritoryID}: {t.RegionID} - {t.TerritoryDescription}"));
                #endregion

                #region Adicionar employee
                //Todo CNM: Inserir um empregado com os vossos dados, um novo territories.

                //Employees employees = new Employees();
                //EmployeeTerritories employeeTerritories = new EmployeeTerritories();

                //employees.EmployeeID = 1;
                //employees.FirstName = "Cleiber";
                //employees.LastName = "Melo";
                //employeeTerritories.TerritoryID = "00002";

                //db.Employees.Add( employees );
                //int countEmployees = db.SaveChanges();  
                #endregion
                Utility.TerminateConsole();
            }
            #endregion
        }
    }
}
