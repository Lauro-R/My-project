using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resolutions : MonoBehaviour
{
    [SerializeField]
    Dropdown dropResolucoes;//deixa adereçar o dropdown escolhido
    [SerializeField]
    Toggle fullScreen;

    public List<string> nomesResolucoes;//cria uma lista publica

    Resolution[] resolucoesPCPlayer;//cria uma array para guardar as resoluções

    private void Start()
    {
        nomesResolucoes = new List<string>();//nomesResolucoes = new List<string>();  adiciona nomesResolucoes na lista
        GetResolutions();
        PreencherResolucoes();
    }

    public void CliqueiTelaCheia(bool valor)//cria uma função com uma booleana pra usar o toggle pra ativar a tela cheia
    {
        Debug.Log("valor do toggle é " + valor);
        Screen.fullScreen = valor;//coloca a tela em fullscreen baseado no valor da booleana criada nessa função
    }
    void PreencherResolucoes()//pegar a resolução que o usuario tem e salva numa lista
    {
        resolucoesPCPlayer = Screen.resolutions;//adiciona as possiveis resoluções do player automaticamente e salva no Array
        for (int i = 0; i < resolucoesPCPlayer.Length; i++)//cria um for que vai parsear as resoluções e colocar na lista
        {
            nomesResolucoes.Add(resolucoesPCPlayer[i].ToString());//converte o valor adicionado a lista para string
        }
        dropResolucoes.AddOptions(nomesResolucoes);//adiciona valores no dropdown
    }
    public void AplicarResolucao(int indice)
    {
        Debug.Log("Opcao escolhida" + indice);
        Debug.Log($"Width: {resolucoesPCPlayer[indice].width} Height {resolucoesPCPlayer[indice].height}");//imprime o valor do set resolution
        Screen.SetResolution(resolucoesPCPlayer[indice].width,  //para ficar mais facil de ler
                             resolucoesPCPlayer[indice].height,
                             fullScreen.isOn);
    }

    void GetResolutions()
    {
        
        dropResolucoes.AddOptions(nomesResolucoes);//adiciona valores no dropdown
    }
}
