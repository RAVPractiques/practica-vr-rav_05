using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger: MonoBehaviour
{
    
    public abrir porta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        porta.opendoor = true;
    }

    void OnTriggerExit(Collider other)
    {
        porta.closedoor = true;
    }
}

