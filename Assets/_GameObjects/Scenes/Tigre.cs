using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Oso))]
public class Tigre : MonoBehaviour {
    [Header("Ataque")]
    public int potencia;
    public int cargador;
    [Header("Defensa")]
    public int escudo;
    public int duracion;
    public int vida;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
