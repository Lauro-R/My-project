using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Follow_player : MonoBehaviour
{
    [SerializeField]//Permite modificação pela ui da engine para a informação abaixo
    private Transform player;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 1, -5);//Faz com que o objeto que utiliza esse script siga o player
    }
}