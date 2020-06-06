using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class FilePicker
    {
        public string FirstFilePath;
        public string SecondFilePath;
        public FilePicker(string filePath1, string filePath2)
        {
            FirstFilePath = filePath1;
            SecondFilePath = filePath2;
        }
        public void PickBiggerNums(int number)
        {
            List<int> selected = new List<int>();
            BinaryReader reader = new BinaryReader(new FileStream(FirstFilePath, FileMode.OpenOrCreate));
            int currentElement;
            while(reader.BaseStream.Position != reader.BaseStream.Length)
            {
                currentElement = reader.ReadInt32();
                if(currentElement >= number)
                {
                    selected.Add(currentElement);
                }
            }
            reader.Close();
            reader = new BinaryReader(new FileStream(SecondFilePath, FileMode.OpenOrCreate));
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                currentElement = reader.ReadInt32();
                if (currentElement >= number)
                {
                    selected.Add(currentElement);
                }
            }
            reader.Close();
            BinaryWriter writer = new BinaryWriter(new FileStream("output.txt", FileMode.OpenOrCreate));
            foreach(int num in selected)
            {
                Console.WriteLine(num);
                writer.Write(num);
            }
            writer.Close();
        }
    }
}
