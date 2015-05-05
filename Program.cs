
    class Program
    {
        static void Main(string[] args)
        {
            var create = new GenExcel();
            // Создаем эксельку
            create.CreatePackage("lol.xlsx");

        }
    }
