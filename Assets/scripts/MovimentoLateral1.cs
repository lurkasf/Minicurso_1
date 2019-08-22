using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLateral1 : MonoBehaviour
{

    public float speed = 1.0f;
    public int direction = 1;
    public float sec = 8;


    void Start()
    {
        StartCoroutine(Example());
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + speed * direction * Time.deltaTime);
//        transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(sec);//aguarda 5 segundos
        direction = -direction;
        StartCoroutine(Example());
    }
}