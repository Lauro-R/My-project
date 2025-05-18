using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    [SerializeField]//Mantem seu código seguro e ainda permite alterações pela engine
    Vector3 vectorPhysics;
    public string cole;
    [SerializeField] int speed;

    private void OnCollisionEnter2D(Collision2D collision)//serve para checar quando o objeto que tiver esse script e aparecer no Debug Log.
    {
        Debug.Log(collision.gameObject.name);
        }

    private void OnCollisionExit2D(Collision2D collision)//serve para checar quando o objeto sai do que colidiu e imprime no debug log.
    {
        Debug.Log("Saiu do " + collision.gameObject.name);
    }

    private void OnCollisionStay2D(Collision2D collision)//serve para checar quando o objeto fica onde colidiu e imprime no debug log.
    {
        Debug.Log("xxxx " + collision.gameObject.name);
    }
}
