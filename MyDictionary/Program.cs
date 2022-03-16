using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> cities = new Dictionary<int, string>();
            cities.Add(2, "Adıyaman");
            cities.Add(23, "Elazığ");
            cities.Add(35, "İzmir");
            Console.WriteLine(cities.Count);
            Dictionary<int, string>.ValueCollection degerListesi = cities.Values;
            foreach (var item in degerListesi)
            {
                Console.WriteLine(item);
            }

            MyDictionary<int,string> myCities = new MyDictionary<int,string>();
            myCities.Add(2, "Adıyaman");
            myCities.Add(6, "Ankara");
            Console.WriteLine(myCities.Count);

            Console.ReadLine();
        }

  
    }
}
