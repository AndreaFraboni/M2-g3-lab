using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class EX4 : MonoBehaviour
{
    [SerializeField] int Numero;

    int startnumber;
    int secondnumber;
    int thirdnumber;

    // Start is called before the first frame update
    void Start()
    {
        startnumber = Numero;
        Debug.Log("Start number = " + startnumber);

        secondnumber = startnumber + 1;
        thirdnumber = startnumber + 2;

        Debug.Log("Second number = " + secondnumber);
        Debug.Log("Third number = " + thirdnumber);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
