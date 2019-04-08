using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Context context = new Context();
            //IList<AbstractExpression> list = new List<AbstractExpression>();
            //list.Add(new TerminalExpression());
            //list.Add(new NonterminalExpression());
            //list.Add(new TerminalExpression());
            //list.Add(new TerminalExpression());

            //foreach (AbstractExpression exp in list)
            //{
            //    exp.Interpret(context);
            //}

            PlayContext context = new PlayContext();

            // 音樂-上海灘
            Console.WriteLine("上海灘:");
            context.PlayText = "T 500 O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 ";
            Expression expression = null;
            try
            {
                while (context.PlayText.Length > 0)
                {
                    string str = context.PlayText.Substring(0, 1);
                    switch (str)
                    {
                        // 當首欄位是O時，則運算式實體化為音階
                        case "O":
                            expression = new Scale();
                            break;
                        // 對速度T的判斷
                        case "T":
                            expression = new Speed();
                            break;
                        // 當首字母是CDEFGAB，以及休止符P時，則實體化音符
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            expression = new Note();
                            break;
                    }
                    expression.Interpret(context);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
