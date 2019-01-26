using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public int velocidad = 10;
    public Object pasto;

    private MeshRenderer renderer;
    Rigidbody2D cuerpo;

    public Transform CharacterBody;

    public bool direccion;

    void Awake()
    {       

    }

    void Start()
    {
        direccion = true;
        cuerpo = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);
        Flip(horizontal);
    }

    private void HandleMovement(float horizontal) {
        Vector2 movimiento = Vector2.zero;
        movimiento.x = horizontal;
        cuerpo.velocity = Vector2.Lerp(cuerpo.velocity, movimiento, 1);
    }
    private void Flip(float horizontal) {
        if (horizontal > 0 && !direccion || horizontal < 0 && direccion) {
            direccion = !direccion;
            Vector3 scale = CharacterBody.localScale;
            scale.x *= -1;
            CharacterBody.localScale = scale;
        }
    }
}
