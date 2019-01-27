using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoNiveles
{

    private static bool[] NivelesResueltos;
    public static bool musica = true, scroll = false;

    //Hay que instanciar el numero de niveles que tendrá el juego
    public static void numeroNiveles(int niveles) {
        NivelesResueltos = new bool[niveles];
    }

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
