using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisica2 : MonoBehaviour
{

    Rigidbody2D myRigidbody;

    [SerializeField]//Mantem seu código seguro e ainda permite alterações pela engine
    Vector3 vectorPhysics;
    Vector3 posFinal;
    [SerializeField]
    float moveSpeed;

    float velHorizontal;
    float velVertical;

    [HideInInspector] //serve para esconder uma informação no Unity
    public string nome;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))//quando J apertado, função move position é ativada
        {
            FuncMovePosition();
        }
        if (Input.GetKeyDown(KeyCode.B))//quando B apertado, função addforce é ativada
        {
            FuncAddForce();
        }
        if (Input.GetKeyDown(KeyCode.Y))//quando Y apertado, função FuncVelocity é ativada
        { 
            FuncVelocity();
        }
    }
    void FuncMovePosition()
    {
        Vector3 posFinal = this.transform.position + vectorPhysics;
        myRigidbody.MovePosition(posFinal);
    }
    void FuncAddForce()
    {
        myRigidbody.AddForce(vectorPhysics);
    }
    void FuncVelocity()
    {

        velHorizontal = Input.GetAxis("Horizontal");
        velVertical = Input.GetAxis("Vertical");

        myRigidbody.velocity = new Vector2(velHorizontal, velVertical) * moveSpeed;
    }
}
