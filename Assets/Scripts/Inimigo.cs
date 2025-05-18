using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    float vel = 0.01f;//velocidade que o inimigo vai se mexer
    float tempoMudar;
    [SerializeField]
    GameObject tiro;//define o projetil do inimigo
    // Start is called before the first frame update
    void Start()
    {
        tempoMudar = Random.Range(2f, 0.5f);
        StartCoroutine(Atirando());//chama a corotina de atirar
        StartCoroutine(MudarDir(tempoMudar));//chama a corotina de mudar de direção
    }
    private void Update()
    {
        transform.Translate(new Vector3(vel, 0, 0));//atualiza a posição do Inimigo
    }
    IEnumerator Atirando()//Cria-se uma Co rotina para o inimigo continuar atirando
    {
        yield return new WaitForSeconds(2);//faz o inimigo atirar nesse tempo, e todo enumerator precisa retornar alguma coisa
        GameObject bombaTemp;
        bombaTemp = Instantiate(tiro, this.transform.position, this.transform.rotation);//Unstancia a prefab da bomba
        bombaTemp.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);//modifica a velocidade da bomba saindo do inimigo
    }
    IEnumerator MudarDir(float tempo)
    {
        yield return new WaitForSeconds(tempo);//retorna o mudar direção após esse tempo
        vel *= -1;
        tempoMudar = Random.Range(2f, 0.5f);
        StartCoroutine(MudarDir(tempoMudar));//chama a corotina novamente
    }
}
