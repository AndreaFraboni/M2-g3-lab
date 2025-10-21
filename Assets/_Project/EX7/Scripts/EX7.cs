using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX7 : MonoBehaviour
{
    [SerializeField] int Numero1;
    [SerializeField] int Numero2;

    int valorebasso;

    // Start is called before the first frame update
    void Start()
    {
        if (Numero1 < Numero2)
        {
            valorebasso = Numero1;
        }
        if (Numero2 < valorebasso)
        {
            valorebasso = Numero2;
        }

        Debug.Log("Il numero più basso è = " + valorebasso);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
