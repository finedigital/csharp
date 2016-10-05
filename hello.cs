
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static string DoSomething(bool s)
{
    if(s)
    {
    Console.BackgroundColor = ConsoleColor.White;
    Console.Foregroundcolor = ConsoleColor.Red;
    return DateTime.Now.AddDays(-1).ToString();

    }
    else
    {
        return DateTime.Now.ToString;
    }

}



