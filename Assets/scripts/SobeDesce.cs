using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SobeDesce : MonoBehaviour {

    public float speed = 1.0f;
    public int direction = 1;
    public float sec = 8;

    void Start () {
        StartCoroutine(Exampler());
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x , transform.position.y + speed * direction * Time.deltaTime, transform.position.z);
        //        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
    }

    IEnumerator Exampler()
    {
        yield return new WaitForSeconds(sec);//aguarda 5 segundos
        direction = -direction;
        StartCoroutine(Exampler());
    }
}
