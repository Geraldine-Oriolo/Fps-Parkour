﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeteccionDeCaida : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (transform.position.y < -25)
     {
        Debug.Log("Me caí");
        SceneManager.LoadScene("FPSParkour");
     }


    }
}
