// Вид 1

// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1(); - тут закоментировано то что должно работать

// Вид 2

// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// Method2(msg: "Текст сообщения", count: 4); тут закоментировано то что должно работать

// Вид 3
//  int Method3()
//  {
//     return DateTime.Now.Year;
//  }
//  int year = Method3();
//  Console.WriteLine(year);

// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i < count)
//     {
//         result = result+text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

string Method5(int count, string text)
 {
     
     string result = string.Empty;
     for( int i=0; i < count; i++)
         {
        result = result+text;
              }
     return result;
 }
 string res = Method5(10, "z");
 Console.WriteLine(res);