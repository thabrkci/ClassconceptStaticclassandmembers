using System.Data;
using System.Runtime.InteropServices;

namespace Sınıf_Kavramı_Static_Sınıf_ve_Üyeler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*******Static Sınıf Ve Üyeler********");
        Console.WriteLine("Çalışan Sayısı:    {0}", Calisan.Calisansayisi);
        Calisan calisan = new Calisan("Taha","BÖREKCİ","IK");
        Console.WriteLine("Çalışan Sayısı:    {0}", Calisan.Calisansayisi);
        Calisan işçi = new Calisan("Taha","BÖREKCİ","DEPARTMANT");
        Console.WriteLine("Çalışan Sayısı:    {0}", Calisan.Calisansayisi);
        

    }






}




    class Calisan
    {

      private static int calisansayisi;

      public static int Calisansayisi { get => calisansayisi;}

      private string Name;
      private string Surname;
      private string Department;
      static Calisan(){
        calisansayisi = 0;

      }

     public Calisan(string name, string surname, string department)
    { 
     this.Name = name;
     this.Surname = surname;
     this.Department = department;
     calisansayisi ++;
         
    }



    }
    
      


    



    
