using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class LastMent
{
    public static STARTSELECT lastMent()
    {
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                           보상으로 출입증을 드리겠습니다.\n" +
            "                                             언젠가는 쓸 날이 올것입니다.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n                                                  To Be Continued     ");
        Console.ReadKey();
        return STARTSELECT.SELECTTOWN;
    }
}
