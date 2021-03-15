using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roullettecontroller : MonoBehaviour
{ 
    float rotspeed = 0;
  
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.rotspeed = 10.0f;
        }
        if (Input.GetMouseButton(1))
        {
            this.rotspeed = 0f;
        }
        transform.Rotate(0, 0, this.rotspeed);
        this.rotspeed *= 0.978f;
    }
}
