using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo {
    private string marca;
    protected string modelo;
    public int potencia;
    int consumo;
    /// <summary>
    /// Constructor vacio
    /// </summary>
    public Vehiculo() {
        this.marca = "NISU";
        this.modelo = "NISU";
        this.potencia = -1;
        this.consumo = 0;
    }
    /// <summary>
    /// Constructor con parámetros
    /// </summary>
    /// <param name="_marca"></param>
    /// <param name="_potencia"></param>
    public Vehiculo(string _marca, int _potencia) {
        this.marca = _marca;
        this.potencia = _potencia;
    }
	public void SetMarca(string _marca) {
        this.marca = _marca;
    }
    public string GetMarca() {
        return this.marca;
    }
    public void ArrancarMotor() {
        //Hace cosas
    }
    public float GetConsumoMedio() {
        //Calcula el consumo medio
        return 0;
    }
    public float CalcularDuractionTrayecto(string origen, string destino) {
        //Hago el calculo
        return 0;
    }
    public void IncrementarVelocidad(int cv) {
        //Hacemos lo que sea
    }
}
