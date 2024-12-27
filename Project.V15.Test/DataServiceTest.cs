using Project.V15.Lib;
namespace Project.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ValidRows()
        {

            string path = @"C:\DataSprint5\Test.txt";
            int res = ds.Rows(path);
            Assert.AreEqual(8, res);

        }
                
        
        [TestMethod]
        public void Test()
        {
            string path = @"C:\DataSprint5\Test2.csv";
            string[,] res = { { "Budko Ivan Stepanovich", "Tyumen Zelenaya St Building 13 Apt 89", "89032345352" }, { "Budko Varvara Nikolaevna", "Tyumen Narodnaya st Bulding 20 Apt 8", "89462562536" } };
            CollectionAssert.AreEqual(res, ds.Mass(path,2,3));
            
        }

    }
}