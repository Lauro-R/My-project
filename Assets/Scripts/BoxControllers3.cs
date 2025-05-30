using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControllers3 : MonoBehaviour
{

    Rigidbody2D meuRigidbody;

    [SerializeField]//Mantem seu c�digo seguro e ainda permite altera��es pela engine
    Vector3 vetorFisica;
    [SerializeField]
    Vector3 posFinal;
    [SerializeField]
    float movSpeed;
    public bool ativado = false;
    [SerializeField]//Permite modifica��o pela ui da engine para a informa��o abaixo
    private Transform player;

    [HideInInspector] //serve para esconder uma informa��o no Unity
    public string nome;

    // Start is called before the first frame update
    void Start()
    {
        meuRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))//ativa o quadrado azul para se mover
        {
            Debug.Log("3");
            ativado = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2))//desativa os outros quadrados, 1 e 2 de se moverem quando ativado
        {
            ativado = false;
        }
            if (ativado)
            {
            FuncVelocity();
        }
        
    }
    void FuncVelocity()//recebe um vetor bidimensional, e adiciona a velocidade em tempo real dele (o quanto o jogador aperta a setinha)
    {
        float velHorizontal;
        float velVertical;

        velHorizontal = Input.GetAxis("Horizontal");//move no axis horizontal do movimento
        velVertical = Input.GetAxis("Vertical");//move no axis vertical do movimento

        meuRigidbody.velocity = new Vector2(velHorizontal, velVertical) * movSpeed;//faz com que o rigidbody desse objeto seja afetado pela movspeed * o vector2 
    }
}
