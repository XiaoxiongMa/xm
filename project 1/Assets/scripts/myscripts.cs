using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScripts : MonoBehaviour

{    
    // Start is called before the first frame update
    void Start()
    {
        print(message:"hi");
		print(message:"welcome to World");
        int a = 5;
        int b = ++a;
        print(message:("b={0}", b));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
