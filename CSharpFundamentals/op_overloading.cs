using System;

public class Oper
{
        private int _no;

        public int No
        {
                get
                {
                        return _no;
                }
                set
                {
                        _no = value;
                }
        }


        public static Oper operator + (Oper op1, Oper op2)
        {
                Oper result = new Oper();

                result.No = op1.No + op2.No;

                return result;
        }


        //Uncomment the following while executing this code.--------
    /*
        public static void Main()
        {
                Oper result = null;
                Oper op1 = new Oper();
                op1.No = 10;

                Oper op2 = new Oper();
                op2.No = 20;


                result = op1 + op2;
                Console.WriteLine(result.No.ToString());
        }
*/
}
