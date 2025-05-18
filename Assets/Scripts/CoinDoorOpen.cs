using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinDoorOpen : MonoBehaviour
{
    //permite que o objeto Parede seja alterado dentro desse script
    [SerializeField]
    Vector3 movVert;//Vetor para mover a Parede
    [SerializeField]
    GameObject parede;//define um objeto para ser escolhido manualmente no programa
    [SerializeField]
    int moedas = 0;//contador de moedas, resquicio de pickup
    public Vector3 newPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if(collision.gameObject.tag == "Player")//se este objeto colidir com o player:
            {
            moedas += 1;//adiciona +1 ao int moedas
            Destroy(this.gameObject);//destroi este GameObject
            parede.transform.Translate(movVert);//move a parede escolhida pelo SerializeField acima
            Debug.Log("Parede");
            }
    }
}
