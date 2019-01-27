using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }


    public void CambiarEscena(string nombre_escena)
    {
        SceneManager.LoadScene(nombre_escena);
    }
    
    public void pausa() {
        Time.timeScale = 0;
    }
    public void CambiarEstadoPanel(GameObject panel) {
        panel.SetActive(!panel.activeInHierarchy);
   }
}
