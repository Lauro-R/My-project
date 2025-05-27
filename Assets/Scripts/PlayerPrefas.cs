using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefas : MonoBehaviour
{
    [SerializeField]
    InputField textoNome;//permite associar uma zona de input com a variavel pela Unity

    public string nomeVar;
    public float xp;
    public int level;

    public void Salvar()//função para salvar informações no registro
    {
        nomeVar = textoNome.text;
        PlayerPrefs.SetString("Nome Player", nomeVar);
        PlayerPrefs.SetInt("Level Player", level);
        PlayerPrefs.SetFloat("XP Player", xp);
        PlayerPrefs.Save();//Salva essas informações no registro do computador
    }

    // Start is called before the first frame update
    void Start()
    {
        nomeVar = PlayerPrefs.GetString("Nome Player");
        PlayerPrefs.GetInt("Level Player");
        PlayerPrefs.GetFloat("XP Player");
        textoNome.text = nomeVar;//deixa você aplicar o texto do nome do jogador ao playerprefs
    }

    /*public void CleanData()//limpa o registro assim que ativa
    {
        PlayerPrefs.DeleteKey("Nome Player");
        PlayerPrefs.DeleteAll();
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
