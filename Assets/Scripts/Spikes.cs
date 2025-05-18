using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)//Quando um objeto entra em colisão com o objeto que possui esse script
    {
        if (collision.gameObject.tag == "Player")//se o player colidir com este objeto
        {
            Animator player_anim = collision.gameObject.GetComponent<Animator>();//deixa a player_anim acessar a animação do player quando colide com um game object
            player_anim.SetBool("IsDestroyed",true);//ativa a booleana da animação de morte do Player
            Destroy(collision.gameObject, 0.5f);//destroi o que colidiu com ele, neste caso o player
        }
    }
}