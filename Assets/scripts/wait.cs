using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class wait : MonoBehaviour
{
    public int RespTime;
    public string texto;
    float contador;


    void Start()
    {
        transform.GetComponent<Text>().text = texto;
        StartCoroutine(Aguarde());
        contador = RespTime;
    }

    private void Update()
    {
        
        contador = (contador - 1 * Time.deltaTime);
        transform.GetComponent<Text>().text = texto + ((int)contador+1);
    }


    IEnumerator Aguarde()
    {
        yield return new WaitForSeconds(RespTime);//aguarda
        SceneManager.LoadScene(1);
    }
}
