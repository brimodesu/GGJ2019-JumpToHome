using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public int velocidad = 5;
    public Object pasto;
    private MeshRenderer renderer;
    Rigidbody2D cuerpo;

    void Awake()
    {
       
        
    }

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = Vector2.zero;

       float horizontal = Input.GetAxis("Horizontal");
        movimiento.x = horizontal;

       

        cuerpo.velocity = Vector2.Lerp(cuerpo.velocity, movimiento, 1);

    }
}
