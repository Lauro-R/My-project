using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombProjectile : MonoBehaviour
{
    float tempoVida = 2f;
    float contador = 0;
    
    void Update()
    {
        contador += Time.deltaTime;
        if (contador >= tempoVida)//cria um contador para fazer a bombinha expirar ap�s o tempo estipulado nos floats acima.
        {
            Destroy(this.gameObject);//destroi a bombinha
        }
    }
}
