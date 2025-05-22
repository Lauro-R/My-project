using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControllers2 : MonoBehaviour
{

    Rigidbody2D meuRigidbody;

    [SerializeField]//Mantem seu código seguro e ainda permite alterações pela engine
    Vector3 vetorFisica;
    [SerializeField]
    Vector3 posFinal;
    [SerializeField]
    float movSpeed;
    public bool ativado = false;

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
            if (Input.GetKeyDown(KeyCode.Alpha2))//ativa o quadrado verde para se mover
            {
                Debug.Log("2");
                ativado = true;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))//desativa os outros quadrados, 1  3 e 4 de se moverem quando ativado
        {
                ativado = false;
            }
            if (ativado)
        {
            FuncAddForce();//chama a função add force
        }
    }
    void FuncAddForce()//empurra o objeto em uma direção
    {
        meuRigidbody.AddForce(vetorFisica);
    }
}
