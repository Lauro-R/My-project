using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControllers4 : MonoBehaviour
{
public bool ativado = false;
[SerializeField]//permite modificar o valor dentro da engine da Unity
Vector3 novarota;
[SerializeField]
float valorEscalaN;
[SerializeField]
float valorEscalaS;
[HideInInspector] //serve para esconder uma informação no Unity
public string nome;

// Start is called before the first frame update
void Start()
{
    
}

// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown(KeyCode.Alpha4))//ativa o quadrado amarelo para se mover
    {
        Debug.Log("4");
            ativado = true;
            transform.Rotate(novarota);//rotaciona o cubo 4 amarelo quando ativado
            transform.localScale *= valorEscalaN;//aumenta a escala do cubo 4 quando ativado
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3))//desativa os outros quadrados, 1 e 2 e 3 de se moverem quando ativado
        {
            ativado = false;
        }
    }
    }
