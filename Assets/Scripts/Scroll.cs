﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float velocidad = 5f;
    private MeshRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        int direccion = 0;
        if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                direccion = -1;
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                direccion = 1;
            }
            renderer.material.mainTextureOffset += new Vector2(Time.deltaTime *velocidad *  -direccion * 0.2f, 0);
        }

    }

}
