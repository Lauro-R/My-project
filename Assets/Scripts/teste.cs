using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour
{
    public Vector3 moverVertical;
    public Vector3 moverHorizontal;
    public Vector3 Rotato;
    public Vector3 scale_mod;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(moverVertical);//Move verticalmente no eixo + com W
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-moverVertical);// Move Verticalmente no eixo - com S
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moverHorizontal);// Move Horizontalmente no eixo - com A
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moverHorizontal);// Move Horizontalmente no eixo + com D
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-Rotato);// Rotaciona no eixo Z- com Q
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Rotato);// Rotaciona no eixo Z+ com E
        }
        if (Input.GetKey(KeyCode.N))//Diminui a escala do quadrado
        {
            if (transform.localScale.x > 0.3)//limita a escala pra não inverter o cubo
            {
                transform.localScale -= scale_mod;
            }
        }
        if (Input.GetKey(KeyCode.M))//Aumenta a escala do quadrado
        {
            transform.localScale += scale_mod;
            }
        }
    }
