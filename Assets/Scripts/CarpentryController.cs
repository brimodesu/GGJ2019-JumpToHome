﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpentryController : MonoBehaviour
{
    public GameManager GM;
    public bool canEntry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canEntry)
        {
            if (Input.GetKeyDown("space"))
            {
                GM.CambiarEscena("Carpinteria");
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) {
            canEntry = true;
            Debug.Log("Llego a carpinteria");
        }
    }
}
