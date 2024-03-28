using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{


    public void CarregarJogao()
    {
        SceneManager.LoadScene("Jogao");
    }
     public void CarregarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
  
    public void Sair()
    {
        Application.Quit();
    }
}