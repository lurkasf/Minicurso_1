using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Sair();
        }
    }*/

    public void Play(int Cena)
    {
        SceneManager.LoadScene(Cena);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
