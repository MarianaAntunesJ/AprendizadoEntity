namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LivroContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}