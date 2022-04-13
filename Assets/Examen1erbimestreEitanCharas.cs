using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Examen1erbimestreEitanCharas : MonoBehaviour
{
    public int producto1;
    public int producto2;
    public int producto3;

        // Start is called before the first frame update
        void Start()
    {
        if (producto1 < 1) {
            Debug.Log("Error en producto1, precio o cantidad de unidades tiene que ser mayor a 1");
        }
        if (producto2 < 1)
        {
            Debug.Log("Error en producto2, precio o cantidad de unidades tiene que ser mayor a 1");
        }
        if (producto3 < 1)
        {
            Debug.Log("Error en producto3, precio o cantidad de unidades tiene que ser mayor a 1");
        
    
           


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
