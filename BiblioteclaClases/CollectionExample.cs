using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteclaClases
{
    public class CollectionExample
    {
        public static void SortedListCollection()
        {
            //definir el tamaño de la lista
            Console.Write("Cuantos elementos agregara a la lista");
            var elements = Convert.ToInt32(Console.ReadLine());

            //declara arrays vacios
            object[] key = new object[elements];
            object[] value = new object[elements];

            //declarar la lista
            SortedList<object, object> srtList = new SortedList<object, object>();
            int i = 0;

            while (i < elements)
            {
                Console.WriteLine("Escriba el elemento a agregar {0}", i);

                //llenar los arrays
                Console.Write("Key: ");
                key[i] = Console.ReadLine();
                Console.Write("Value: ");
                value[i] = Console.ReadLine();

                //lenar la lista
                srtList.Add(key[i], value[i]);

                i++;
            }

            //mostrar elementos en la lista
            Console.WriteLine("****ELEMENTOS EN LA LISTA****");
            foreach (KeyValuePair<object, object> element in srtList)
            {
                Console.WriteLine("{o}: {1}", element.Key, element.Value);
            }
        }
   
    }
}
