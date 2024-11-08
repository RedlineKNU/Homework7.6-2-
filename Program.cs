namespace Facade
{
    public class Power
    {
        public void TurnOn()
        {
            Console.WriteLine("Powering on the computer...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Powering off the computer...");
        }
    }

    public class OperatingSystem
    {
        public void BootUp()
        {
            Console.WriteLine("Booting up the operating system...");
        }

        public void ShutDown()
        {
            Console.WriteLine("Shutting down the operating system...");
        }
    }

    public class Applications
    {
        public void StartApps()
        {
            Console.WriteLine("Starting applications...");
        }

        public void CloseApps()
        {
            Console.WriteLine("Closing applications...");
        }
    }

    public class ComputerFacade
    {
        private Power _power;
        private OperatingSystem _os;
        private Applications _apps;

        public ComputerFacade()
        {
            _power = new Power();
            _os = new OperatingSystem();
            _apps = new Applications();
        }

        public void StartComputer()
        {
            _power.TurnOn();
            _os.BootUp();
            _apps.StartApps();
            Console.WriteLine("Computer is ready to use.");
        }

        public void ShutDownComputer()
        {
            _apps.CloseApps();
            _os.ShutDown();
            _power.TurnOff();
            Console.WriteLine("Computer is shutting down.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComputerFacade computerFacade = new ComputerFacade();

            computerFacade.StartComputer(); 
            Console.WriteLine();
            computerFacade.ShutDownComputer(); 

            Console.ReadKey();
        }
    }
}
