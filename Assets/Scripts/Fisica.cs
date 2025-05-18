using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour
{

    Rigidbody2D myRigidbody;

    [SerializeField]//Mantem seu código seguro e ainda permite alterações pela engine
    Vector3 vectorPhysics;
    Vector3 posFinal;
    [SerializeField]
    float moveSpeed;

    Animator myAnimator;

    float velHorizontal;
    float velVertical;

    [HideInInspector] //serve para esconder uma informação no Unity
    public string nome;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();//componente de animação para o player ter animações
        myRigidbody = GetComponent<Rigidbody2D>();//componente de RigidBody para as interações do Player
    }

    // Update is called once per frame
    void Update()
    {
        FuncVelocity();//Função que faz o player poder se mexer.
        Animation();//ativa a animação do player.
    }
    /*void FuncMovePosition()
    {
        Vector3 posFinal = this.transform.position + vectorPhysics;
        myRigidbody.MovePosition(posFinal);// apenas um resquicio de codigo para não perder estas funções de referencia
    }
    void FuncAddForce()
        {
            myRigidbody.AddForce(vectorPhysics);
        }*/
    void Animation()
    {
        myAnimator.SetFloat("velY", velVertical);//ambos modificam a animação baseada no eixo de movimentação do player
        myAnimator.SetFloat("velX", velHorizontal);
    }
    void FuncVelocity()
    {
        
        velHorizontal = Input.GetAxis("Horizontal");//detecta o axis horizontal do input do player no input de movimentação
        velVertical = Input.GetAxis("Vertical");//detecta o axis vertical do input do player no input de movimentação

        myRigidbody.velocity = new Vector2(velHorizontal, velVertical) * moveSpeed;
    }
}
