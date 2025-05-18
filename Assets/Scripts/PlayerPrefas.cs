using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefas : MonoBehaviour
{
    [SerializeField]
    InputField textoNome;

    public string nomeVar;
    public float xp;
    public int level;

    public void Salvar()
    {
        nomeVar = textoNome.text;
        PlayerPrefs.SetString("Nome Player", nomeVar);
        PlayerPrefs.SetInt("Level Player", level);
        PlayerPrefs.SetFloat("XP Player", xp);
        PlayerPrefs.Save();
    }

    // Start is called before the first frame update
    void Start()
    {
        nomeVar = PlayerPrefs.GetString("Nome Player");
        PlayerPrefs.GetInt("Level Player");
        PlayerPrefs.GetFloat("XP Player");
        textoNome.text = nomeVar;
    }

    /*public void CleanData()
    {
        PlayerPrefs.DeleteKey("Nome Player");
        PlayerPrefs.DeleteAll();
    }*/
    // Update is called once per frame
    void Update()
    {
        
    }
}
