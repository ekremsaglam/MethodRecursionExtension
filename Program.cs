using System;

namespace methodRecursion_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //3^4
            int result = 1;
            for (int i =1 ; i<5 ; i++){
                result *=3;

            }
            Console.WriteLine(result);

            Islemler nesne = new Islemler();
            int sonuc = nesne.Expo(2,4);
            Console.WriteLine(sonuc);

            string ifade = "Ekrem Sağlam benim adım";
            bool sonuc2 = ifade.checkSpaces();
            Console.WriteLine(sonuc);

            if(sonuc2){
                Console.WriteLine(ifade.removeWhiteSpaces());
            }
            Console.WriteLine(ifade.makeUpperCase());
            Console.WriteLine(ifade.makeLowerCase());


        }//main end


    }//class Program end

    public class Islemler{
        public int Expo(int sayi, int us){
            if (us<2){
                return sayi;
            }
            int result = 1;
            result = Expo(sayi,us-1)*sayi;
            return result;
        }
    }//class Islemler end

    public static class Extension{
        public static bool checkSpaces(this string param){
            return param.Contains(" ");
        }

        public static string removeWhiteSpaces(this string param){
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }
        public static string makeUpperCase(this string param){
            return param.ToUpper();
        }
        public static string makeLowerCase(this string param){
            return param.ToLower();
        }
        
    }
}
