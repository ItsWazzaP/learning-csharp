public class Program {
    public static void Main(string[] args) {
        int a = 15;
        int b = 10;
        
        // Don't change below this line
        int c = 0;
        if (a >= b && !(b < 10))
        {
            c = 2;
        }
        
        c += 1;
        System.Console.WriteLine("c = " + c);
    }
}