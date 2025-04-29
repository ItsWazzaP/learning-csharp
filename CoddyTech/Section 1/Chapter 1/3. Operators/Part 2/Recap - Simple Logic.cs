public class Program {
    public static void Main(string[] args) {
        bool b1 = true;
        bool b2 = true;
        bool b3 = false;
        
        bool b4 = b1 && b2 && (!b3);
        System.Console.WriteLine("b4 = " + b4);

    }
}