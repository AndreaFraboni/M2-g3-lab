using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
   [SerializeField] int numero1;
   [SerializeField] int numero2;
   [SerializeField] int numero3;
   [SerializeField] int numero4;
   

  
    // Start is called before the first frame update
    void Start()
    {   
        
        int somma;
        int moltiplicazione;
        int media;
        
        Debug.Log("[numero1] = " + numero1 + " [numero2] = " + numero2 + " [numero3] = " + numero3 + " [numero4] = " + numero4);

        somma = (numero1 + numero2 + numero3 + numero4);

        Debug.Log("Somma = " + somma);

        moltiplicazione = (numero1 * numero2 * numero3 * numero4);

        Debug.Log("Moltiplicazione = " + moltiplicazione);

        media = ((numero1 + numero2 + numero3 + numero4) / 4);

        Debug.Log("Media = " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
