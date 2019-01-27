using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionLampara : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            SceneManager.LoadScene(1);   
        }
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Piso") {
            GetComponent<Rigidbody2D>().gravityScale = 0f;
            GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
}
