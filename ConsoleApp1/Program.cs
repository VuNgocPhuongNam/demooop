/*tinh dong goi
private: chỉ được truy cập trong cùng class hoặc struct
public: có thể truy cập ở bất kỳ đâu
internal: giới hạn truy cập trong cùng một project
protected: truy cập được trong cùng class hoặc struct và các class dẫn xuất(thừa kế)
protected internal: giới hạn truy cập trong project hoặc lớp dẫn xuất*/

/*using System;

namespace ConsoleApp1
{
(C# code) tinh  ke thua tao ra lop moi ke thua cac thuoc tinh da co o lop cha
       class Vehicle  // class cha 
       {
           public string brand = "Vinfast";  
           public void honk()             
           {
               Console.WriteLine("bip, bip!");
           }
       }

       class Car : Vehicle  // class con
       {
           public string modelName = "Moning";  //con
       }

       class Program
       {
           static void Main(string[] args)
           {
               
               Car myCar = new Car();

               myCar.honk();
               Console.WriteLine(myCar.brand + " " + myCar.modelName);
           }
       }
*/    //da hinh 



/*using System;
// lớp được thừa kế từ cùng lớp cha, có cùng phương thức, nhưng mỗi lớp con sẽ có cách thực hiện riêng. Tính đa hình đảm bảo mỗi lớp sẽ có cùng chức năng nhưng lại có cách thực thi khác nhau.
namespace tinhdahinh 
{
    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override int GetArea()
        {
            return Width * Height;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 7);
            Console.WriteLine("Area: {0}", rectangle.GetArea());
            Console.ReadKey();
        }
    }
}*/

//tinh truu tuong an chi tiet trien khai chi cung cap tinh nang den nguoi dung
/*using System;

namespace ConsoleApp1
{
    interface IExportData
    {
        void Export();
    }

    class TextExport : IExportData
    {
        public void Export()
        {
            Console.WriteLine("Export data to .txt file");
        }
    }

    class CsvExport : IExportData
    {
        public void Export()
        {
            Console.WriteLine("Export data to .csv file");
        }
    }

    class Application
    {
        private readonly IExportData _exportData;

        public Application(IExportData exportData)
        {
            _exportData = exportData;
        }

        public void ExportData()
        {
            _exportData.Export();
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Application app = new Application(new TextExport());
            app.ExportData();
            Console.ReadKey();
        }
    }
}*/
