using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Vida : MonoBehaviour {
    #region funções 
    public void MudaCor(Color cor, GameObject painel)
    {

        painel.GetComponent<Image>().color = cor;

    }

    public void AtualizaVida()
    {
        if(vida < 4)
        {
            MudaCor(new Vector4(1.0f, 0.2f, 0.3f, transp + 0.8f), painel);
            vida4.SetActive(false);
        }
        if(vida < 3)
        {
            MudaCor(new Vector4(1.0f, 0.1f, 0.2f, transp + 0.9f), painel);
            vida3.SetActive(false);
        }
        if(vida < 2)
        {
            MudaCor(new Vector4(1.0f, 0.0f, 0.0f, transp + 10f), painel);
            vida2.SetActive(false);
        }
        if(vida < 1)
        {
            vida1.SetActive(true);
            vida2.SetActive(true);
            vida3.SetActive(true);
            vida4.SetActive(true);
            vida = 4;
            SceneManager.LoadScene(2);
        }
    }

    public void PerdeVida(int quantas)
    {
        vida= vida-quantas;
    }
    #endregion

    #region variaveis
    public int vida;
    public GameObject painel;
    float transp = 0;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
    public GameObject vida4;
    public GameObject LastCheckpoint;
    public GameObject checkie;
    public int CheckTime;
    #endregion

    void Start () {
        vida = 4;
        
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("checkpoint"))
        {
            StartCoroutine(("CheckpointNotification"));
            LastCheckpoint = other.gameObject;
        }
        if (other.gameObject.tag == ("buraco"))
        {
            //StartCoroutine("CaiInfinito");
            transform.position = LastCheckpoint.transform.position;
        }
        if (other.gameObject.tag == ("corte"))
        {
            PerdeVida(1);
        }
        if (other.gameObject.tag == ("eletrico"))
        {
            PerdeVida(2);
        }

        AtualizaVida();
    }

    IEnumerator CheckpointNotification()
    {
        checkie.SetActive(true);
        yield return new WaitForSeconds(CheckTime);//aguarda
        checkie.SetActive(false);
    }
    /*IEnumerator CaiInfinito()
    {
        Time.timeScale = 0.6f;
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 0.3f;
        yield return new WaitForSeconds(0.2f);
        transform.position = LastCheckpoint.transform.position;
        Time.timeScale = 1;

    }*/
    
}
