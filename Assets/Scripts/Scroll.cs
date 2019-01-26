using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public Transform[] fondos;
    public float[] velocidades;
    public float smoothing = 1f;

    private Transform camara;
    private Vector3 posCamPrev;

    private void Awake()
    {
        camara = Camera.main.transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        posCamPrev = camara.position;
        velocidades = new float[fondos.Length];
        for (int i = 0; i < fondos.Length; i++) {
            velocidades[i] = fondos[i].position.z * -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < fondos.Length; i++) {
            float parallax = (posCamPrev.x - camara.position.x) * velocidades[i];
            float objetivo = fondos[i].position.x + parallax;
        }
    }
}
