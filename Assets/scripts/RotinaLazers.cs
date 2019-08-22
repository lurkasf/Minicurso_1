using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotinaLazers : MonoBehaviour {

    public float time;
    public GameObject luzes;

	void Start () {
        StartCoroutine(Lazers());
    }

    IEnumerator Lazers()
    {
        yield return new WaitForSeconds(time);//aguarda
        luzes.SetActive(false);
        transform.GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(time);//aguarda
        luzes.SetActive(true);
        transform.GetComponent<Collider>().enabled = true;
        StartCoroutine(Lazers());
    }

}
