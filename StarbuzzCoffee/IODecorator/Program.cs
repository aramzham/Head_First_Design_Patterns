using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = default(int);
            using (var stream = new FileStream(@"E:\test.txt", FileMode.Open))
            using (StreamReader sr = new LowerCaseInputStreamReader(stream))
            {
                while ((c = sr.Read()) >= 0)
                {
                    Console.Write((char)c);
                }
            }

            Console.ReadLine();
        }
    }

    public class LowerCaseInputStreamReader : StreamReader
    {
        public LowerCaseInputStreamReader(Stream stream) : base(stream)
        {
        }

        public override int Read()
        {
            var c = base.Read();
            return c == -1 ? c : char.ToLower((char)c);
        }

        public override int Read(char[] b, int index, int count) 
        {
            var result = base.Read(b, index, count);
            for (int i = index; i < index + result; i++)
            {
                b[i] = char.ToLower(b[i]);
            }

            return result;
        }
    }
}
