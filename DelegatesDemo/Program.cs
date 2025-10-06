public delegate void Print(string msg);

class Program {
    static void Main() {
        Print printer = Console.WriteLine;
        printer("Hello from a delegate!");
    }
}
