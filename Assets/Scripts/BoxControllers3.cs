using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControllers3 : MonoBehaviour
{

    Rigidbody2D meuRigidbody;

    [SerializeField]//Mantem seu código seguro e ainda permite alterações pela engine
    Vector3 vetorFisica;
    [SerializeField]
    Vector3 posFinal;
    [SerializeField]
    float movSpeed;
    public bool ativado = false;
    [SerializeField]//Permite modificação pela ui da engine para a informação abaixo
    private Transform player;

    [HideInInspector] //serve para esconder uma informação no Unity
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
            transform.position = player.transform.position + new Vector3(5, 1, 5);//Faz com que o objeto que utiliza esse script siga o player
        }
        
    }
    void FuncVelocity()//recebe um vetor bidimensional, e adiciona a velocidade em tempo real dele (o quanto o jogador aperta a setinha)
    {
        float velHorizontal;
        float velVertical;

        velHorizontal = Input.GetAxis("Horizontal");
        velVertical = Input.GetAxis("Vertical");

        meuRigidbody.velocity = new Vector2(velHorizontal, velVertical) * movSpeed;
    }
}
