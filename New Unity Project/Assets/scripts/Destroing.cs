﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroing : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Update()
    {

       
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Destroy(gameObject, 1);
        }
        
    }
}
