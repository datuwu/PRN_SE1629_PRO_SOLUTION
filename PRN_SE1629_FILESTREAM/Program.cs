using System;
using System.IO;
using System.Text;

namespace Prn.FileStreamDemo;

public class Program
{
    public static void Main()
    {
        string msg = "Dang dau het ca dau day nay";

        using FileStream fileStream = File.Open("data.dat",
            FileMode.Create);
        byte[] msgByte
            = Encoding.UTF8.GetBytes(msg);

        //write msgByte to file data.dat
        fileStream.Write(msgByte, 0, msgByte.Length);
        fileStream.Position = 0;
    }
}