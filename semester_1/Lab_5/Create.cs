namespace Lab_5
{
    static class RandomPersonCreate
    {
        static Random random = new Random();
        static string[] firstNames = { "Anton", "Maksym", "Pavlo", "Kyrylo", "Dmytro", "Oleksiy", "Oleksandr", "Ivan" };
        static string[] lastNames = { "Ivanov", "Petrov", "Sydorenko", "Shevchenko", "Koval", "Kovalenko", "Tkachenko", "Bondarenko" };
        static DateTime[] dateOfBirth = { DateTime.Now, DateTime.Now.AddDays(10), DateTime.Now.AddDays(20), DateTime.Now.AddDays(30), DateTime.Now.AddDays(40) };
        public static string GetRandomName()
        {
            return firstNames[random.Next(firstNames.Length)];
        }
        public static string GetRandomLastName()
        {
            return lastNames[random.Next(lastNames.Length)];
        }
        public static DateTime GetRandomDateOfBirth()
        {
            return dateOfBirth[random.Next(dateOfBirth.Length)];
        }
        public static Person GetRandomPerson()
        {
            return new Person(GetRandomName(), GetRandomLastName(), GetRandomDateOfBirth());
        }
    }
    static class RandomDeviceCreate
    {
        static Random random = new Random();
        static string[] namesOfDevices = { "Monitor", "Keyboard", "Mouse", "Printer", "Scanner", "Microphone", "Headphones" };
        static string[] costOfDevices = { "100$", "150$", "200$", "300$", "400$", "500$", "600$" };
        static DateTime[] dateOfCreateDevices = { DateTime.Now, DateTime.Now.AddDays(10), DateTime.Now.AddDays(20), DateTime.Now.AddDays(30), DateTime.Now.AddDays(40) };
        public static string GetRandomNameOfDevice()
        {
            return namesOfDevices[random.Next(namesOfDevices.Length)];
        }
        public static string GetRandomCostOfDevice()
        {
            return costOfDevices[random.Next(costOfDevices.Length)];
        }
        public static DateTime GetRandomDateOfCreateDevices()
        {
            return dateOfCreateDevices[random.Next(dateOfCreateDevices.Length)];
        }
        public static Device GetRandomDevice()
        {
            return new Device(GetRandomNameOfDevice(), GetRandomCostOfDevice(), GetRandomDateOfCreateDevices());
        }

    }
    static class RandomComputerCreate
    {
        static Random random = new Random();
        static TypeOfWork[] typeOfWorks = { TypeOfWork.Home, TypeOfWork.Business, TypeOfWork.Server };
        public static string GetRandomIpAddress()
        {
            return $"{random.Next(1, 255)}.{random.Next(1, 255)}.{random.Next(1, 255)}.{random.Next(1, 255)}";
        }
        public static TypeOfWork GetRandomTypeOfWork()
        {
            return typeOfWorks[random.Next(typeOfWorks.Length)];
        }
        public static Computer GetRandomComputer()
        {
            Person person = RandomPersonCreate.GetRandomPerson();
            TypeOfWork typeOfWork = GetRandomTypeOfWork();
            string ipAddress = GetRandomIpAddress();
            Device[] devices = new Device[5];
            for (int i = 0; i < devices.Length; i++)
            {
                devices[i] = RandomDeviceCreate.GetRandomDevice();
            }
            return new Computer(person, typeOfWork, ipAddress, devices);
        }
    }
}
