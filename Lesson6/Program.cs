using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileSystem1
            //string[] filePaths = Directory.GetFiles(@"C:\Program Files (x86)\Skype", "*s.exe", SearchOption.AllDirectories);
            //for (int i = 0; i < filePaths.Length; i++)
            //{
            //    Console.WriteLine(filePaths[i]);
            //}

            //DirectoryInfo info = new DirectoryInfo(@"C:\Program Files (x86)\Skype");
            //if (info.Exists)
            //{
            //    FileInfo[] files = info.GetFiles("*", SearchOption.AllDirectories);
            //    for (int i = 0; i < files.Length; i++)
            //    {
            //        Console.WriteLine(files[i].Length);
            //        Console.WriteLine(files[i].Name);
            //        Console.WriteLine(files[i].Extension);

            //    }
            //} 
            #endregion

            #region FileSystem2
            //FileInfo file1 = new FileInfo(@"C:\Lesson6\1.txt");
            //FileInfo file2 = new FileInfo(@"C:\Lesson6\Test\2.txt");

            //file1.Create();

            //if (file2.Directory.Exists)
            //{
            //    file2.Create();
            //}
            //else
            //{
            //    file2.Directory.Create();
            //    file2.Create();
            //}

            //string path = @"C:\Lesson6\Test\1\2\3\4\5\2.txt";
            //Console.WriteLine(Path.GetFileName(path));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            //Console.WriteLine(Path.GetDirectoryName(path));

            //string dir = @"C:\Lesson6";
            //string temp = "temp_24";
            //string filename = "name.txt";

            //path = Path.Combine(dir, temp, filename); 
            #endregion

            Point p1 = new Point(10, 15, "Первая>точка");
            //p1.Print();

            //SavePoint(p1);

            //ReadPoint();
            //XmlSerialization(p1);
            p1 = XmlDeserialization();
            p1.Print();

        }

        static Point XmlDeserialization()
        {
            FileStream stream = new FileStream("point.xml", FileMode.Open, FileAccess.Read);
            Point p = new Point();
            XmlSerializer serializer = new XmlSerializer(p.GetType());
            p = (Point)serializer.Deserialize(stream);
            stream.Close();
            return p;
        }

        static void XmlSerialization(Point p)
        {
            FileStream stream = new FileStream("point.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(p.GetType());
            serializer.Serialize(stream, p);
            stream.Close();
        }

        private static void ReadPoint()
        {
            FileStream stream = new FileStream("point.txt", FileMode.Open, FileAccess.Read);
            Point p;
            using (StreamReader reader = new StreamReader(stream))
            {
                int x = int.Parse(reader.ReadLine());
                int y = int.Parse(reader.ReadLine());
                string label = reader.ReadLine();
                p = new Point(x, y, label);
                reader.Close();
            }
            p.Print();
        }

        private static void SavePoint(Point p1)
        {
            FileStream stream = new FileStream("point.txt", FileMode.Create, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine(p1.x);
                writer.WriteLine(p1.y);
                writer.WriteLine(p1.label);
                writer.Close();
            }
        }
    }

    [Serializable]
    public class Point
    {
        public int x;
        public int y;
        public string label;
        public Point(int x, int y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }

        public Point()
        {   }

        public void Print()
        {
            Console.WriteLine("X = {0}\nY = {1}\nLabel: {2}", x, y, label);
        }
    }
}
