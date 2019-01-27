using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] Audios;
    AudioSource Reproductor;
    

    // Start is called before the first frame update
    void Awake()
    {
        Reproductor = GetComponent<AudioSource>();
    }

    //selecciona la cancion que reproducira el audio source
    public void reproducir(int cancion) {
        Reproductor.clip = Audios[cancion];
        Reproductor.Play();
    }

    public void mutear(bool valor) {
        Reproductor.mute = valor;
    }
}
