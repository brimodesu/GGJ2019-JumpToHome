using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public int velocidad = 5;
    private SpriteRenderer spriteRenderer;
    public Object pasto;
    private MeshRenderer renderer;
    Rigidbody2D cuerpo;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
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

        bool flipSprite = (spriteRenderer.flipX ? (movimiento.x > 0.01f) : (movimiento.x < 0.01f));
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        cuerpo.velocity = Vector2.Lerp(cuerpo.velocity, movimiento, 1);

    }
}
