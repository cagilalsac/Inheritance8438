namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlDatabase sqldb = new SqlDatabase();
            sqldb.Update();
        }
    }

    abstract class Database // base, parent, abstract: soyut, new'lenemez, SOLID: D: Dependency Inversion
    {
        public void Add()
        {
            Console.WriteLine("Added by database");
        }

        public virtual void Update() // bu method ezilebilir aşağıdaki class'larda
        {
            Console.WriteLine("Updated by database");
        }
    }

    class SqlDatabase : Database // sub, child
    {
        public override void Update()
        {
            Console.WriteLine("Updated by Sql");
            base.Update(); // opsiyonel
        }
    }

    class OracleDatabase : Database
    {

    }
}