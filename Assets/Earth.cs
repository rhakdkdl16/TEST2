using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    private void Update() {
        float value = Mathf.PingPong(Time.time, 10);

            GetComponent<Renderer>().material.SetFloat("_TexValue",value);
          
    }
}
