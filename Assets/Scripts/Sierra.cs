using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sierra : MonoBehaviour
{
    public float velocidad = 10f;
    public GameObject mesa, explosion, cadena;
    Animator animadorCadena;
    bool giro = true;

    // Start is called before the first frame update
    void Start()
    {
        animadorCadena = cadena.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (giro) {
            transform.Rotate(Vector3.forward, Time.deltaTime * -velocidad);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tronco") {
            Destroy(collision.gameObject);
            explosion.SetActive(true);
            animadorCadena.SetBool("Caida", true);
            Destroy(mesa);
            giro = false;
            GetComponent<Collider2D>().isTrigger = true;
            collision.gameObject.GetComponent<Collider2D>().isTrigger = true;
          
        }
        
        
    }
}
