using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Danmaku : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnParticleCollision(GameObject collision)//quando colidir com a particula
    {
        Debug.Log(collision.name);
        if (collision.transform.tag == "Player")// Destruirá a tag player se ele esbarrar na particula.
        {
            Animator player_anim = collision.gameObject.GetComponent<Animator>();//deixa a player_anim acessar a animação do player quando colide com um game object
            player_anim.SetBool("IsDestroyed", true);//ativa a booleana da animação de morte do Player
            Destroy(collision.gameObject, 0.5f);//destroi o que colidiu com ele, neste caso o player
        }
    }
}
