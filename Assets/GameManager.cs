using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] int peso;
    [SerializeField] string familia;
    [SerializeField] int[] cargadores;

    int numero = 5;

    Vehiculo[] arrayCoches = new Vehiculo[10];//Array de vehículos

    List<Vehiculo> listaCoches = new List<Vehiculo>();//Lista de vehículos

    void RellenarLista()
    {
        Vehiculo v1 = new Vehiculo("Seat", 80);
        Vehiculo v2 = new Vehiculo("Fiat", 90);
        listaCoches.Add(v1);
        listaCoches.Add(v2);
    }

    void RecorrerLista()
    {
        foreach (Vehiculo coche in listaCoches)
        {
            print(coche.GetMarca());
        }
    }

    void RellenarArray()
    {
        Vehiculo v1 = new Vehiculo("Seat", 80);
        Vehiculo v2 = new Vehiculo("Fiat", 90);
        arrayCoches[0] = v1;
        arrayCoches[1] = v2;
    }
    void MostrarArray()
    {
        for (int i = 0; i < arrayCoches.Length; i++)
        {
            if (arrayCoches[i] != null)
            {
                print(arrayCoches[i].GetMarca());
            }
        }
    }



    void Start () {
        Vehiculo v1 = new Vehiculo();
        Vehiculo v2 = new Vehiculo("Skoda", 60);
        //Recorrer un array (bucle for)
        for (int i = 0; i < cargadores.Length; i++) {
            print(cargadores[i]);
        }
        RellenarArray();
        MostrarArray();
	}
	
	
}
