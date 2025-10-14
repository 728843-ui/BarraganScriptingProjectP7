using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if put.GetKeyDown(KeyCode.R))
        { 
       Getomponent<Renderer>().material = Color.red;
    }
    if (Input.GetKeyDown(KeyCode.G)
    }
        GetComponent<Renderer>().material.color = Color.green;
    }
    if (Input.GetKeyDown(KeyCode.B))
    }
        GetComponent<Renderer>().material.color = Color.blue;
