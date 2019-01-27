using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panelPausa, btnMOn, btnMOff;
    public static int objetivoF = 30;
    public AudioSource audio;


    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;

        Debug.Log(SceneManager.GetActiveScene().name);

        
        
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name.Equals("Inicio"))
        {
            EstadoNiveles.scroll = true;
            audio.GetComponent<AudioManager>().reproducir(0);
        }
        else if (SceneManager.GetActiveScene().name.Equals("Intro")) {
            EstadoNiveles.scroll = false;
            audio.GetComponent<AudioManager>().reproducir(3);
        }
        else
        {
            EstadoNiveles.scroll = false;
            audio.GetComponent<AudioManager>().reproducir(4);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Application.targetFrameRate != objetivoF) {
            Application.targetFrameRate = objetivoF;
        }
    }


    public void CambiarEscena(string nombre_escena)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nombre_escena);
    }

    public void Pausar() {
        if (EstadoNiveles.musica)
        {
            btnMOn.SetActive(true);
            btnMOff.SetActive(false);
        }
        else
        {
            btnMOn.SetActive(false);
            btnMOff.SetActive(true);
        }
        Debug.Log("aqui");
        panelPausa.SetActive(true);
        Time.timeScale = 0;
        
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
        audio.GetComponent<AudioManager>().mutear(EstadoNiveles.musica);
        EstadoNiveles.musica = !EstadoNiveles.musica;
        if (EstadoNiveles.musica) {
            btnMOn.SetActive(true);
            btnMOff.SetActive(false);
        }
        else {
            btnMOn.SetActive(false);
            btnMOff.SetActive(true);
        }
        //Cambiar el muteo de la musica cuando se agregue
    }
}
