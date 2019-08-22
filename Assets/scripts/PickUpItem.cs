using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour {

    int count;
    public int MaxItens = 3;
    public GameObject WinText;
    public AudioClip Pick;
    AudioSource Sons;

    public Text CountText;
    // Use this for initialization
    void Start() {
        count = 0;
        CountText.text = "Items: ";
        Sons = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
            Sons.clip = Pick;
            Sons.Play();
        }
    }

    void setCountText()
    {
        CountText.text = "Items: " + count.ToString();
        if (count >= MaxItens)
        {
            WinText.SetActive(true);
            //CountText.text = "You win!";
            StartCoroutine("lol");
        }
    }

    IEnumerator lol()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
