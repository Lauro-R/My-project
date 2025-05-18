using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {//acessando o transform e posição do player, guardado dentro do Vector2 dentro de PlayerPrefs, o float guarda o valor do player
        Player.transform.position = new Vector2(PlayerPrefs.GetFloat("player_xPos"), PlayerPrefs.GetFloat("player_yPos"));
    }
    public void SavePosition()
    {
        PlayerPrefs.SetFloat("player_xPos", Player.transform.position.x);//guarda o float x do jogador
        PlayerPrefs.SetFloat("player_yPos", Player.transform.position.y);//guarda o float y do jogador
        PlayerPrefs.Save();//Salva os valores dentro do Registro
    }
    public void ClearData()
    {
        PlayerPrefs.DeleteAll();
    }
}
