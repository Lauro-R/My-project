using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica : MonoBehaviour
{

    Rigidbody2D myRigidbody;

    [SerializeField]//Mantem seu c�digo seguro e ainda permite altera��es pela engine
    Vector3 vectorPhysics;
    Vector3 posFinal;
    [SerializeField]
    float moveSpeed;

    Animator myAnimator;

    float velHorizontal;
    float velVertical;

    [HideInInspector] //serve para esconder uma informa��o no Unity
    public string nome;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();//componente de anima��o para o player ter anima��es
        myRigidbody = GetComponent<Rigidbody2D>();//componente de RigidBody para as intera��es do Player
    }

    // Update is called once per frame
    void Update()
    {
        FuncVelocity();//Fun��o que faz o player poder se mexer.
        Animation();//ativa a anima��o do player.
    }
    /*void FuncMovePosition()
    {
        Vector3 posFinal = this.transform.position + vectorPhysics;
        myRigidbody.MovePosition(posFinal);// apenas um resquicio de codigo para n�o perder estas fun��es de referencia
    }
    void FuncAddForce()
        {
            myRigidbody.AddForce(vectorPhysics);
        }*/
    void Animation()
    {
        myAnimator.SetFloat("velY", velVertical);//ambos modificam a anima��o baseada no eixo de movimenta��o do player
        myAnimator.SetFloat("velX", velHorizontal);
    }
    void FuncVelocity()
    {
        
        velHorizontal = Input.GetAxis("Horizontal");//detecta o axis horizontal do input do player no input de movimenta��o
        velVertical = Input.GetAxis("Vertical");//detecta o axis vertical do input do player no input de movimenta��o

        myRigidbody.velocity = new Vector2(velHorizontal, velVertical) * moveSpeed;
    }
}
