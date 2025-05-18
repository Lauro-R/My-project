using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptionsExit : MonoBehaviour
{
    [SerializeField]
    GameObject telaMenu;//permite definir um objeto como a tela de menu dentro da unity
    [SerializeField]
    GameObject telaOptions;//permite definir um objeto como a tela de Options dentro da unity
    [SerializeField]
    GameObject telaQuit;//permite definir um objeto da cena como tela de quit dentro da unity

    private void Start()
    {
        HideAll();//chama a função
        ShowMenu();//chama a função
    }
    public void NewGameStart()
    {
        Debug.Log("Game Started");
        SceneManager.LoadScene("SampleScene");//Inicia o Jogo.
        //Posso colocar também " SceneManager.LoadScene(1); devido a ordem de cenas listado no Build Settings
    }
    public void OptionsSettings()
    {
        Debug.Log("Options Menu Opened");//Essa função abre o menu de Opções
        
    }
    /*Também pode ser feito dessa forma:
    public void ShowTela(int numTela)
    {
        HIdeAll();
        Telas telaEscolhida = (Telas)numTela;
        switch (telaEscolhida)
        {
            case 1:
            telaMenu.SetActive(true);
            break;

            case 2:
            telaOption.SetActive(true);
            break;
        }
    }
    ou um Enumerator:
    public enum Telas { Menu = 1, Options = 2}
    mudando cada case para "case Telas.Menu*:" dentro do switch
    * (o Telas.Menu sendo especifico para cada tela, como Telas.Options, etc)

    */
    public void HideAll()//esconde os outros menus
    {
        telaMenu.SetActive(false);
        telaOptions.SetActive(false);
        telaQuit.SetActive(false);
    }
    public void ShowMenu()//Função para mostrar o menu
    {
        //HideAll(); pode ser incluso aqui, ou dentro do botão  na hora de chamar a opção on click
        telaMenu.SetActive(true);
    }
    public void ShowOptions()//Função para mostrar o options
    {
        //HideAll(); pode ser incluso aqui, ou dentro do botão  na hora de chamar a opção on click
        telaOptions.SetActive(true);
    }
    public void ExitGameFunc()//essa função fecha o jogo.
    {
        Debug.Log("Bye Bye");
        //HideAll(); pode ser incluso aqui, ou dentro do botão  na hora de chamar a opção on click
        telaQuit.SetActive(true);
    }
    public void QuittingGame()
    {
        Application.Quit();//sai do aplicativo.
    }
}
