using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float velocidad = 10f;
    Rigidbody2D cuerpo;

    public Transform CharacterBody;
    public Animator CharacterAnimator;


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
        movimiento.x = horizontal * velocidad;
        
        cuerpo.velocity = Vector2.Lerp(cuerpo.velocity, movimiento, 1);

        //Debug.Log(cuerpo.velocity.x);
        CharacterAnimator.SetFloat("Movimiento", Mathf.Abs(cuerpo.velocity.x));
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
