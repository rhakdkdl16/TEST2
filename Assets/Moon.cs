using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    float x = 30;
    float  z = 0;
     
    [SerializeField] GameObject earth;
    private void Update()
    {
             
     
     
       
        transform.position = new Vector3(x,0,z);

    }

    void b()
    {
        for(int i = 0;  i <= 30; )
       {
            i++;
            x -= 1f;
            z += 1f;
       }

    }
    void a()
    {
         for(int i = 0; i <= 30;)
       {
           i++;
           x += 1f;
           z -= 1f;
       }
    }
}
