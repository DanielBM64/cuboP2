using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MovimientoPj : MonoBehaviour
{
    public GameObject Personaje;
    public Rigidbody rigidBodyEsfera;
    public float movimientoX;
    public float movimientoZ;
    public float velocidad;
    public float Tiempo = 0f;
    public float fuerza = 100f;
    public bool quiereSaltar = false;
    public bool puedeSaltar = false;
    public GameObject Suelo;
    private Vector3 escala;
    // Start is called before the first frame update
    void Start()
    {
        rigidBodyEsfera = GetComponent<Rigidbody>();
        velocidad = 5f;
        Tiempo = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento de personaje
        movimientoX = Input.GetAxis("Horizontal");
        movimientoZ = Input.GetAxis("Vertical");

        rigidBodyEsfera.velocity = new Vector3(movimientoX * velocidad, rigidBodyEsfera.velocity.y, movimientoZ * velocidad);

        if (Input.GetButton("Jump"))
        {
            quiereSaltar = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Coger Moneda
        if (collision.gameObject.CompareTag("Moneda"))
        {
            Destroy(collision.gameObject);
            escala = new Vector3(1f, +1f, +1f);
        }
    }
    void FixedUpdate()
    {
            if (quiereSaltar == true)
            {
                rigidBodyEsfera.AddForce(transform.up * fuerza);
                quiereSaltar = false;
                //Apply a force to this Rigidbody in direction of this GameObjects up axis
            }
    }
    
}