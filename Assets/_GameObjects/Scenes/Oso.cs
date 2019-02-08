using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Oso : MonoBehaviour {
    public float speed;
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}
