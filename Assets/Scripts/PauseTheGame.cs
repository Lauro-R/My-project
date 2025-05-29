using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTheGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
    void PauseGame()//pausará o jogo
    {
        if(Time.timeScale ==0)//faz um if para poder pausar e despausar o jogo
        {
            Time.timeScale = 1;
        }
        else//se estiver despausado, pausa
        {
            Time.timeScale = 0;
        }
        Debug.Log("Função de Pausar");

    }
}
