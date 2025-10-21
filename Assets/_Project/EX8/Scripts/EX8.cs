using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX8 : MonoBehaviour
{

    [SerializeField] int voto;

    string votoamericano;

    // Start is called before the first frame update
    void Start()
    {

        if (voto >= 0 && voto <= 4)
        {
            votoamericano = "F";
        }
        if (voto == 5)
        {
            votoamericano = "E";
        }
        if (voto == 6)
        {
            votoamericano = "C";
        }     
        if (voto >= 7 && voto <= 8)
        {
            votoamericano = "B";
        }
        if (voto == 9)
        {
            votoamericano = "A";
        }
        if (voto == 10)
        {
            votoamericano = "A+";
        }

        Debug.Log("Il voto in numero : " + voto + " corrisponde al voto americano : " + votoamericano);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
