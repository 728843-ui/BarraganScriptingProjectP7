using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesFunctions : MonoBehaviour
{
    //Creating an integer variable
    int myInt = 6;
   
    // Start is called before the first frame update
    void Start()
    {
        //running my int variable thru the function
        myInt = MultiplyByTwo(myInt);
        
        //displaying the results on console
        Debug.Log (myInt);
    }

    // Update is called once per frame
    
        int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
