using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryManager : MonoBehaviour
{  ///NOTA: Script hecho por Sony. Cuando uso 'Dummy_' quiere decir que es algo creado para PRUEBAS. 
   ///Es correcto borrarlo, pero usadlo como referencia
   ///*En este caso utilicé ints como ejemplos, pero dependiendo de como indexemos los OBJETOS, tendremos que cambiar el tipo de lista y dato
   /// *Suponemos que el int = 0 equivale a la falta de un objeto.
   /// 
    public int[] dummy_inventory = new int[0];

    private void Start()
    {
        dummy_inventory = AddItem(dummy_inventory, 2);

        dummy_inventory = LoseItem(dummy_inventory, 2);
    }

    public void AddItem(int ObjectToAdd)
    {
        dummy_inventory = AddItem(dummy_inventory, ObjectToAdd);
    }

    public int[] AddItem(int[] List, int ObjectToAdd)//El tipo de función debe coincidir con el tipo de lista. El tipo de ObjetoToAdd ha de coincidir con la clase de objeto que usemos para instanciar cada item del juego
    {
        int[] NewList = new int[List.Length + 1];//Creamos una nueva lista con un slot más
        for (int i = 0; i < List.Length; i++)//Buscamos los datos de todos los slots que tiene nuestra lista antigua...
        {
            NewList[i] = List[i];// E igualamos cada uno de los slots a nuestra lista antigua. 'El slot i, es igual al slot i de la otra lista, le sumamos uno a i', el slot  i nuevo es igual al slot i nuevo de la lista, le añadimos 1 y asi....
        }


        NewList[List.Length] = ObjectToAdd;//Al ultimo slow de la nueva lista le añadimos el objeto nuevo.
        return NewList;
    }

    int[] LoseItem(int[] List, int ObjectToLose)//El tipo de función debe coincidir con el tipo de lista. El tipo de ObjetoToAdd ha de coincidir con la clase de objeto que usemos para instanciar cada item del juego
    {
        for (int i = 0; i < List.Length; i++)//Bucle para repasar todos los elmentos de la listas, comparandolos con el objeto/valor del objeto deseado (ObjectToLose)
        {
            if (List[i] == ObjectToLose) //En el caso de que el ObjetoToLose se encuentre.
            {
                List[i] = 0;//****Si la lista tiene objetos que puedan tener valor null, cambiar esto por null

                if (List.Length - 1 == i) //¿Es el indice el último elemento de la lista?
                {
                    int slotsloss = 1;//Creamos un valor que será la cantidad de slots que quitaremos despues. El valor por defecto es uno, ya que ES el ultimo elemento de la lista
                    while(slotsloss < List.Length)//Mientras que la cantidad de slots que vamos a quitar sea menos que la cantidad de slots en la lista....
                    {
                        int index = List.Length - 1 - slotsloss;//Creamos un int que es igual a la cantidad total de slots de la lista menos los slot que vamos a perder (El objetivo es asignarlo a la cantidad de slots que tendrá la lista al final
                        if (List[index] == 0)//****Si la lista tiene objetos que puedan tener valor null, cambiar esto por null
                            slotsloss++;
                        else
                            break;
                    }

                    int[] NewList = new int[List.Length - slotsloss];
                    for (int j = 0; j < NewList.Length; j++)
                    {
                        NewList[j] = List[j];
                    }

                    return NewList;
                    //List = NewList;
                }

                break;
            }
        }
        return List;
    }
}
