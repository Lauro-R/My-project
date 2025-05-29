using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCaller : MonoBehaviour
{
    [SerializeField]//Script feito para controlar o acesso do Menu e de Como Jogar
    GameObject telaBacktoMenu;//permite definir um objeto da cena como tela de voltar ao Menu dentro da unity
    [SerializeField]
    GameObject telaComoJogar;//permite definir um objeto da cena como tela de como jogar dentro da unity
    // Start is called before the first frame update
    void Start()
    {
        HideAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HideAll()//esconde os outros menus
    {
        telaBacktoMenu.SetActive(false);
        telaComoJogar.SetActive(false);
    }
    public void BacktoMenu()//Volta pro menu
    {
        telaBacktoMenu.SetActive(true);
    }
    public void HowtoPlay()//Como Jogar
    {
        telaComoJogar.SetActive(true);
    }
}
