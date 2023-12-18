using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ContadorMonedaC : MonoBehaviour
{
    //public TMP_Text ContadorMonedas;
    public float Monedas = 1f;
    //public TMP_Text frase;
    public GameObject Personaje;

    // Start is called before the first frame update
    void Start()
    {
        //ContadorMonedas.text = "0";
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Moneda"))
        {
            Debug.Log("+1");
            Monedas++;
            //ContadorMonedas.text = Monedas.ToString();
            
        }
    }
}