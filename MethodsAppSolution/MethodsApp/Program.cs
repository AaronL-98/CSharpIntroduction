namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--MethodCalls--
            //var result = DoThis(10, "Sad");
            //var result2 = DoThis(25);
            //var pizza1 = OrderPizza(true, false);
            //var pizza2 = OrderPizza(true, pineapple: false); //  Named argument
            //var pizza3 = OrderPizza(false, true, note: "GlutenFree");


            //--Tuples--
            //(string, string, int) myTuple = ("Joe", "McCann", 23);
            //Console.WriteLine(myTuple);
            //Console.WriteLine(myTuple.Item2);
            //var weight = ConvertPoundsToStones(146);
            //Console.WriteLine(weight);



        }
        public static int DoThis(int x, string y = "happy")
        {
            Console.WriteLine($"I'm feeling {y}");
            return x * x;
        }
        public static string OrderPizza( bool mushrooms, bool pineapple, bool chicken = false, bool peppers = false, string note = "")
        {
            var pizza = $"{note} Pizza with tomato sauce, cheese, ";
            if (pineapple) pizza += "pineapple, ";
            if (mushrooms) pizza += "mushrooms, ";
            if (chicken) pizza += "chicken, ";
            if (peppers) pizza += "peppers, ";
            if (chicken) pizza += "anchovies, ";
            return pizza;
        }
        public static (int stones, int pounds) ConvertPoundsToStones(int pounds)
        {
            const int poundsInAStone = 14;
            var st = pounds / poundsInAStone;
            var lbs = pounds % poundsInAStone;
            return (st, lbs);
        }
    }

}