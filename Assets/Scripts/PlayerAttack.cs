using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    GameObject bomb;
    [SerializeField]
    float forcaTiro = 10;
    [SerializeField]
    Transform posTiro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Animator player_anim = GetComponent<Animator>();//deixa a player_anim acessar a animação do player
            player_anim.SetBool("IsAttacking", true);//ativa a booleana da animação de atirar do Player
            CriarBomba();
        }
    }
    void CriarBomba()
    {
        GameObject bombaTemp;
        bombaTemp = Instantiate(bomb, posTiro.transform.position, this.transform.rotation);//Unstancia a prefab da bomba
        bombaTemp.GetComponent<Rigidbody2D>().velocity = new Vector2(forcaTiro, 0);//modifica a velocidade da bomba saindo do player.
    }
    void PlayerStoppedAttacking()
    {
        Animator player_anim = GetComponent<Animator>();//deixa a player_anim acessar a animação do player
        player_anim.SetBool("IsAttacking", false);//desliga a booleana após o uso na timeline do Animator.
    }
}
