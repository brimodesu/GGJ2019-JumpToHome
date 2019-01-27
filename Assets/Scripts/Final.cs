using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject pensamiento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pensamiento.active) {
            if (Input.GetKey(KeyCode.Space)) {
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            pensamiento.SetActive(true);
        }
    }
}
