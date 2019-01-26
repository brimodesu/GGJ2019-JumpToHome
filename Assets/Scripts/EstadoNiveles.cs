using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoNiveles : MonoBehaviour
{
    public static bool[] NivelesResueltos;

    public static void Resolver(int nivel) {
        NivelesResueltos[nivel] = true;
    }

    public static bool estadoNivel(int nivel) {
        return NivelesResueltos[nivel];
    }

    public static bool Resueltos() {
        foreach (bool nivel in NivelesResueltos){
            if (!nivel) {
                return false;
            }
        }
        return true;
    }
}
