using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PauseTheGame : MonoBehaviour
{
    [SerializeField]
    GameObject telaPause;
    // Start is called before the first frame update
    void Start()
    {
        HidePauseMenu();//faz com que o menu de pausa venha desligado
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();//chama a função pausegame

        }
    }
    void PauseGame()//pausará o jogo
    {
        if(Time.timeScale ==0)//faz um if para poder pausar e despausar o jogo
        {
            Time.timeScale = 1;
            HidePauseMenu();
        }
        else//se estiver despausado, pausa
        {
            Time.timeScale = 0;
            MenuPauseOpen();
        }
        Debug.Log("Função de Pausar");
    }
    void MenuPauseOpen()
    {
        telaPause.SetActive(true);//liga o menu de pause
    }
    void HidePauseMenu()//esconde o menu novamente
    {
        telaPause.SetActive(false);
    }
}
