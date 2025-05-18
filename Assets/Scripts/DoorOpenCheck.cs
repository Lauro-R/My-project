using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenCheck : MonoBehaviour
{
    [SerializeField]
    Vector3 moverVertical;
    [SerializeField]
    GameObject parede1;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)//o player entrar neste trigger:
    {
        if (collision.gameObject.tag == "Player")//se o player colidir com este objeto
        {
            parede1.transform.Translate(moverVertical);//mover a parede vertical no valor definido pelo serializefield acima
        }
    }
}
