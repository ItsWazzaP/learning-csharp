public class Program {
    public static void Main(string[] args) {
        // Initialize variables
        bool isSunny = true;
        double windSpeed = 5.4;
        int temperature = 23;
        int solarPanelOutput = 9;
        bool isCloudy = false;
        
        // The complete logical expression
        bool result = isSunny && (windSpeed < 10) && (solarPanelOutput < 15) && (temperature > 20 || isCloudy);
        
        // Don't delete the lines below
        System.Console.WriteLine("Checking conditions for solar energy production...");
        System.Console.WriteLine("1. Is it sunny? " + isSunny);
        System.Console.WriteLine("2. Is wind speed safe? " + (windSpeed < 10));
        System.Console.WriteLine("3. Can panels produce more? " + (solarPanelOutput < 15));
        System.Console.WriteLine("4. Is temperature good OR no clouds? " + (temperature > 20 || !isCloudy));
        System.Console.WriteLine("\nFinal result - Good day for solar energy production: " + result);
    }
}