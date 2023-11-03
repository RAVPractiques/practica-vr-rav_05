using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
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

    void OnCollisionEnter(Collision collision)
    {
        porta.opendoor = true;
    }

    void OnCollisionExit(Collision collision)
    {
        porta.closedoor = true;
    }
}
