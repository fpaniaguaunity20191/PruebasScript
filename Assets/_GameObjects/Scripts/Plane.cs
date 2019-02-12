using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Camera[] cameras;
    public float speed;
    public float maxSpeed;
    public float angularSpeed;
    public float deltaSpeed;
    public float zAngular = 0.5f;
    private float x;
    private float y;
    private float xMouse = 0;
    private float yMouse = 0;
    private float zoomMouse = 0;
    public int zoomSpeed;
    private GameObject[] edificios;//Declaración

    private void Start()
    {
        edificios = GameObject.FindGameObjectsWithTag("Edificio");
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed);
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        //xMouse = Input.GetAxis("Mouse X");
        yMouse = yMouse + Input.GetAxis("Mouse Y");
        zoomMouse = Input.GetAxis("Mouse ScrollWheel");

        //Camera
        Camera.main.transform.Translate(Vector3.forward * speed);
        Camera.main.transform.LookAt(transform.position);
        Camera.main.fieldOfView = Camera.main.fieldOfView + zoomMouse * zoomSpeed * -1;
        //Camera.main.transform.Translate(Vector3.up * yMouse * 0.01f);
        //End camera

        transform.Rotate(y, x * angularSpeed, 0);
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, zAngular);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -zAngular);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = speed + Time.deltaTime * deltaSpeed;
            speed = Mathf.Min(speed, maxSpeed);
        }
        else if (Input.GetKey(KeyCode.LeftAlt))
        {
            speed = speed - Time.deltaTime * deltaSpeed;
            speed = Mathf.Max(speed, 0);
        }
        /*
        if (Input.GetKey(KeyCode.Alpha1))
        {
            cameras[0].gameObject.SetActive(true);
            cameras[1].gameObject.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(true);
        }
        */
        if (Input.GetButton("Fire1"))
        {
            print("PULSADO FIRE 1");
            for (int i = 0; i < edificios.Length; i++)
            {
                edificios[i].transform.localScale *= 1.01f;
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            print("PULSADO FIRE 2");
            StartCoroutine(Chiquitizar());
        }
    }
    IEnumerator Chiquitizar()
    {
        
        Vector3 initialScale = edificios[0].transform.localScale;
        for (float s = initialScale.x; s > 1; s -= 0.01f)
        {
            for (int i = 0; i < edificios.Length; i++)
            {
                edificios[i].transform.localScale = new Vector3(s, s, s);
            }
            yield return null;
        }
    }
}
