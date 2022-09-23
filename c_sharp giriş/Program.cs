

//https://app.patika.dev/canselbktas
class Program
{
    public static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Please enter your name: ");
        string name=Console.ReadLine();
        Console.WriteLine("Hello "+name);
        */

        byte b=5;          //1 byte 
        sbyte c=5;        //1 byte

        short s=5;        //2 byte
        ushort us=5;     //2 byte 

        Int16 i16=2;     //2 byte
        int i=2;         //4 byte
        Int32 i32=2;     //4 byte
        Int16 i64=2;     //8 byte

        uint ui=2;    //4 byte
        long l=4;     //8 byte
        ulong ul=4;   //8 byte

        //Reel sayılar 
        float f=5;     //4 byte
        double d=5;    //8 byte
        decimal de=5;  //16 byte


      char ch='a';            //2 byte
      string str="zikriye";   //sınırsız

      bool b1= true;
      bool b2= false;

      DateTime dt= DateTime.Now;

      Console.WriteLine(dt);


      object o1="x";
      object o2='y';
      object o3=4;
      object o5=4.5;


      //string ifadeler 

      string str1=string.Empty;
      str1="zikriye ürkmez";
      string ad="zikriye";
      string soyad="ürkmez";
      string tamIsım=ad+" "+soyad;

       //integer tanımlama şekilleri

       int integer1=5;
       int integer2=3;
       int integer3=integer1*integer2;


       //boolean
       bool bool1=10<2;

       //değişken dönüşümleri
       string str20="20";
       int Int20=20;

       string yeniDeger=str20+Int20.ToString();
       Console.WriteLine(yeniDeger); // cıktı: 2020
       
       int int21=Int20+ Convert.ToInt32(str20);
        Console.WriteLine(int21);  // cıktı: 40
      
       int int12= Int20 + int.Parse(str20);
        Console.WriteLine(int12);  // cıktı: 40

       
       //datetime
       string datetime=DateTime.Now.ToString("dd.mm.yyyy");
       Console.WriteLine(datetime);





    }
}
