using System.Reflection.Metadata.Ecma335;

internal class Program {
    private static void Main(string[] args) {
        calc1();
        //calc2();
    }
    private static void calc2() {
        Stack<double> stack = new();
        string entry = string.Empty;
        string answer = string.Empty;
        Console.Write("Enter RPN Statement: ");
        answer = Console.ReadLine();
        string[] operands = answer.Split(",");
        foreach (var op in operands) {
            double n;
            bool isNumber =double.TryParse(op, out n);
            if (isNumber) {
                stack.Push(n);
                continue;
            }
            double n1 = stack.Pop();
            double n2 = stack.Pop();
            double result = op switch {
                "+" => n2 + n1,
                "-" => n2 - n1,
                "*" => n2 * n1,
                "/" => n2 / n1,
                "^" => Math.Pow(n1, n2),
            };
            Console.WriteLine(result);
            stack.Push(result);
        }
    }
    private static void calc1() {
        Stack<int> stack = new();
        string entry = string.Empty;
        string answer = string.Empty;
        do {
            int n1;
            int n2;
            if (answer.ToLower() == "c") {
                stack.Clear();
            }
            switch (answer) {
                case "+":
                n1 = stack.Pop();
                n2 = stack.Pop();
                Console.WriteLine(n1 + n2);
                stack.Push(n1 + n2);
                break;
                case "-":
                n1 = stack.Pop();
                n2 = stack.Pop();
                Console.WriteLine(n2 - n1);
                stack.Push(n2 - n1);
                break;
                case "*":
                n1 = stack.Pop();
                n2 = stack.Pop();
                Console.WriteLine(n1 * n2);
                stack.Push(n1 * n2);
                break;
                case "/":
                n1 = stack.Pop();
                n2 = stack.Pop();
                Console.WriteLine(n2 / n1);
                stack.Push(n2 / n1);
                break;
                case "%":
                n1 = stack.Pop();
                n2 = stack.Pop();
                Console.WriteLine(n2 % n1);
                stack.Push(n2 % n1);
                break;
                default:
                int n = Convert.ToInt32(answer);
                stack.Push(n);
                break;
            }
            Console.Write("Enter number, operator, or x to quit: ");
            answer = Console.ReadLine();
        } while (answer.ToLower() != "x");
    }
    private static void calc3() {
        Stack<double> stack = new();
        string entry = Console.ReadLine();
        string[] ansP = entry.Split();
        foreach (var X in ansP) {

        }
    }
}
