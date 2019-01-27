using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panelPausa;

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

    public void Pausar() {
        Time.timeScale = 0;
        panelPausa.SetActive(true);
        //Detener la musica cuando se agregue
    }
    public void CambiarEstadoPanel(GameObject panel) {
        panel.SetActive(!panel.activeInHierarchy);
    }

    public void Iniciar(){
        Time.timeScale = 1;
        panelPausa.SetActive(false);
    }

    public void Musica() {
        EstadoNiveles.musica = !EstadoNiveles.musica;
        //Cambiar el muteo de la musica cuando se agregue
    }
}
