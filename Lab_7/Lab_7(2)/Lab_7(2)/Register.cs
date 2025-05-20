namespace Lab_7_2_
{
    internal class Register
    {
        public Device[] equipment;
        public static void Print(Device[] equipment)
        {
            for (int i = 0; i < equipment.Length; i++)
            {
                Console.WriteLine(equipment[i].ToString());
            }
        }
        public static void PrintWithoutEngine(Device[] equipment)
        {
            for (int i = 0; i < equipment.Length; i++)
            {

                if (equipment[i].IsMatchEngine == false)
                {
                    Console.WriteLine(equipment[i].ToString());
                }
            }
        }
        public static void PrintElectical(Device[] equipment)
        {
            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i].IsElectric == true)
                {
                    Console.WriteLine(equipment[i].ToString());

                }
            }
        }
    }
}
