using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycastere : MonoBehaviour
{
    [SerializeField]
    float distancia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            VerificarRaycastDown();
        }
    }
    void VerificarRaycastDown()
    {
        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, transform.right, distancia);
        
        if (hit.collider.gameObject.tag == "Enemy")
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
            Gizmos.DrawLine(transform.position, transform.position + (transform.right * distancia));
            //Gizmos.DrawWireSphere(transform.position, distancia);
        }
    }
}
