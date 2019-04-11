using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_27._12._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Муратжан";
            int age = 30;
            string street = "Молдагулова 19";
            String str = new string(new char[] { 'a', 'b', 'c' });
            string splittedText = name.Insert(3, "fdghh");
            Console.WriteLine(splittedText);
            string text = "Здравствуйте, " + name + ", вы выглядите очень молодо, предполагаю вам лет " + age +
                ", я вчера видел на улице " + street + " человека, очень похожего на вас , может это были вы?";
            Console.WriteLine(text);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Здравствуйте, ");
            stringBuilder.Append(name);
            stringBuilder.Append(", вы выглядите очень молодо, предполагаю вам лет ");
            stringBuilder.Append(age);
            stringBuilder.Append(", я вчера видел на улице ");
            stringBuilder.Append(street);
            stringBuilder.Append(" человека, очень похожего на вас , может это были вы?");
            text = stringBuilder.ToString();
            text = string.Format("Приветствую {0} возраст {1} адрес {2}.", name, age, street);
            text = $"Приветствую {name} возраст {age} адрес{street}.";
            string path = @"C:\Windows\Logs\DISM";
            Console.ReadLine();
        }
    }
}
