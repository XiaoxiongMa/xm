﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScripts : MonoBehaviour

{    
    // Start is called before the first frame update
    void Start()
    {
        // print(message:"hi");
	    // print(message:"welcome to World");
        // int a = 5;
        //int b = ++a;
        //print(message:("b={0}", b));

        int a = 10;
        int b = a--;
        print(message: ("b={0},a={1}", b,a));

        int a = 10;
        int b = ++a;
        print(message: ("b={0}", b));

        int a = 10;
        int b = a--;
        print(message: ("b={0},a={1}", b, a));

        int c = 10;
        int d = c % 3;
        print(message: ("d={0}", d));
        
        int max=(a > c ? a : c)
        print(message: ("a={0},c={1} max={2}", a, c, max));

        int e = 20;
        e -= 5;//e = e-5;
        print(message: ("e={0}", e));

        bool bequal = ((a != c)||(c! =d));
        print(message: (bequal));
        print(message: (!bequal));
        
        person prl = new person(30."zhangsan");
        person pr2 = new person(40."lisi");
        
        print(message:(prl.age));
        print(message:(prl._name));
        print(message:(pr2.age));
        print(message:(pr2._name));
        
        
        
    }

    
   
}
    
    
        public class person
            {
                public int age = 20;
                private string _name;
                
                public Person()
                {
                    this.age = 20;
                    this._name = "human";
                }
            
            
            }
            
         
         
         
        