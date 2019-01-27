using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    public GameObject pensamiento;

   public Image imgFinal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pensamiento.active) {
            if (Input.GetKey(KeyCode.Space)) {
                //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
                StartCoroutine(LoadFinalImage());
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            pensamiento.SetActive(true);
            
        }
    }

    IEnumerator LoadFinalImage() {
        float duration =  60f;
        float elapsed = 0.0f;
   
        while (elapsed < duration)
        {
            imgFinal.fillAmount += .25f;
            elapsed += Time.deltaTime;
            yield return null;
        }
    }
}
