using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrir : MonoBehaviour
{
    public bool opendoor;
    public bool closedoor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (opendoor == true)
        {
            if (transform.rotation.eulerAngles.y < 90)
            {
                Move();
            }
            else
            {
                opendoor = false;
            }
        }

        if (closedoor == true)
        {
            if (transform.rotation.y >= 0)
            {
                Tanca();
            }
            else{
                closedoor = false;
            }
        }
    }

    void Move()
    {
        transform.RotateAround(new Vector3(0.5f, 0, 0), Vector3.up, 20 * Time.deltaTime);
    }

    void Tanca()
    {
        transform.RotateAround(new Vector3(0.5f, 0, 0), Vector3.up, -20 * Time.deltaTime);
    }
}
