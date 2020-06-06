using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter writer = new BinaryWriter(new FileStream("binary1.txt", FileMode.OpenOrCreate));
            writer.Write(230);
            writer.Write(130);
            writer.Write(50);
            writer.Close();
            writer = new BinaryWriter(new FileStream("binary2.txt", FileMode.OpenOrCreate));
            writer.Write(20);
            writer.Write(250);
            writer.Write(20);
            writer.Write(50);
            writer.Close();
            FilePicker picker = new FilePicker("binary1.txt", "binary2.txt");
            picker.PickBiggerNums(123);
            Console.ReadKey();
        }
    }
}
