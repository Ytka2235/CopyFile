using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Последовательное копирование");
        Timer timer = new Timer();
        timer.Start();
        string src1 = @"C:\Users\admin_0\Desktop\file1.txt";
        string dest1 = @"C:\Users\admin_0\Desktop\cory1.txt";
        File.Copy(src1, dest1);
        string src2 = @"C:\Users\admin_0\Desktop\file2.txt";
        string dest2 = @"C:\Users\admin_0\Desktop\cory2.txt";
        File.Copy(src2, dest2);
        timer.Stop();
        Console.WriteLine("Паралельное копирование");
        Thread th = new Thread(Copy);
        timer.Start();
        th.Start();
        string src = @"C:\Users\admin_0\Desktop\file1.txt";
        string dest = @"C:\Users\admin_0\Desktop\cory3.txt";
        File.Copy(src, dest);
        timer.Stop();

    }


    public static void Copy()
    {
        string src = @"C:\Users\admin_0\Desktop\file2.txt";
        string dest = @"C:\Users\admin_0\Desktop\cory4.txt";
        File.Copy(src, dest);
    }
}