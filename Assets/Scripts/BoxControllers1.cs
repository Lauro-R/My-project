using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControllers1 : MonoBehaviour
{

    Rigidbody2D meuRigidbody;

    [SerializeField]//Mantem seu c�digo seguro e ainda permite altera��es pela engine
    Vector3 vetorFisica;
    [SerializeField]
    Vector3 posFinal;
    [SerializeField]
    float movSpeed;
    public bool ativado = false;

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
            if (Input.GetKeyDown(KeyCode.Alpha1))//ativa o quadrado vermelho para se mover
            {
                Debug.Log("1");
                ativado = true;
                
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3))//desativa os outros cubos quando o bot�o acima (Alpha1) � apertado utilizando a booleana abaixo.
            {
                ativado = false;
            }
        if (ativado)
        {
            FuncMovePosition();//chama a fun��o move position para mover os objetos.
        }
    }
    void FuncMovePosition()//move o objeto baseado no transform pelo Move Position
    {
        Vector3 posFinal = this.transform.position + vetorFisica;
        meuRigidbody.MovePosition(posFinal);
    }
}