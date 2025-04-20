using System;
using System.Text;
namespace Lab1_1;

class bai1
{
    static void Main(string[] args)
    {
        //Bai 1:
        //Config Console Output được Tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;
        //1. Khai báo biến
        string ten;
        int tuoi;
        //2. Nhập giá trị
        Console.WriteLine("Nhập tên và tuổi của bạn :");
        Console.Write("- Tên: ");
        ten = (Console.ReadLine());
        Console.Write("- Tuổi: ");
        tuoi = int.Parse(Console.ReadLine());
        //3. Hiển thị kết quả 
        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");


        //Bai 2: 
        //1. Khai báo biến
        int chieudai, chieurong;
        //2. Nhập giá trị
        Console.WriteLine("Nhập chiều dài và chiều rộng: ");
        Console.Write("Chiều dài: ");
        chieudai = int.Parse(Console.ReadLine());
        Console.Write("Chiều rộng: ");
        chieurong = int.Parse(Console.ReadLine());
        //3.TÍnh diện tích 
        int dientich = chieudai * chieurong;
        //4. hiển thị kết quả
        Console.WriteLine($"Diện tích của hình chữ nhật là: {dientich}");


        //Bai 3:
    }
}

