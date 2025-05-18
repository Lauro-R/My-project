using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resetter : MonoBehaviour
{
    public void ResetOnClick()
    {
        SceneManager.LoadScene("SampleScene");//chama a cena SampleScene quando pressiona o Botão reset
    }
}
