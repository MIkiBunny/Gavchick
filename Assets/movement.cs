using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D pl;
    int wholeNumber = 16;
    float decimalNumber = 4.54f;
    string text = "AAAAAAAA";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 4f, 0);
        }
        if (Input.GetKeyDown("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(4f, 0, 0);
        }
        if (Input.GetKeyDown("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-4f, 0, 0);
        }
    }
}
