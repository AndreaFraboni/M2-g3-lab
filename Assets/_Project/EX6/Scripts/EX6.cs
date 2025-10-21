using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX6 : MonoBehaviour
{
    [SerializeField] int Numero1;
    [SerializeField] int Numero2;

    int valorealto;

    // Start is called before the first frame update
    void Start()
    {
        if (Numero1>Numero2)
        {
            valorealto = Numero1;
        }
        if (Numero2>valorealto)
        {
            valorealto = Numero2;
        }

        Debug.Log("Il numero più alto è = " + valorealto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
