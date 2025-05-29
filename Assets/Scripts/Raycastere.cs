using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycastere : MonoBehaviour
{
    [SerializeField]
    float distancia;
    [SerializeField]
    GameObject VisualRaycast;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))//apertar o K ativa o raycast
        {
            VerificarRaycastDown();
        }
    }
    void VerificarRaycastDown()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, transform.right, distancia);//verifica se o raycast encostou em algo
        
        if (hit.collider.gameObject.tag == "Enemy")//se o raycast colidir com a tag, ela é destruida
        {
            Destroy(hit.collider.gameObject);
            Debug.Log(hit.collider.gameObject.name);
        }
    }
    private void OnDrawGizmos()
    {
        if (Input.GetKey(KeyCode.K))
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + (transform.right * distancia));//desenha a linha do raycaster para a direita multiplicado pela distancia colocada dentro da unity
            //Gizmos.DrawWireSphere(transform.position, distancia);
        }
    }
}
