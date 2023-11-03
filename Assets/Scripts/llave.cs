using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour
{
    public abrir porta;
    public string Clau = "Llave";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag(Clau)){
            porta.opendoor = true;
        }
    }
    public void OnCollisionExit(Collision other){
        if(other.gameObject.CompareTag(Clau)){
            porta.closedoor = true;
        }
    }
    

    
}
