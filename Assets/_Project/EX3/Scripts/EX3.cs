using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX3 : MonoBehaviour
{

    [SerializeField] int Numero;

    int restodivisione;

    // Start is called before the first frame update
    void Start()
    {
        restodivisione = Numero % 2;

        if (restodivisione == 0)
        {
            Debug.Log("Il numero = " + Numero + " è PARI !!!!");
        }
        else
        {
            Debug.Log("Il numero= " + Numero + " è DISPARI !!!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
