using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pian : MonoBehaviour
{
    private move pos;
    private Transform alive;
    private Transform dead;
    public bool isAlive;
    public Image suffer;
    AudioSource audioSource;

    void Start()
    {
        pos = GetComponent<move>();
        alive = transform.Find("unnamed_0");
        dead = transform.Find("ddeaad_0");
        isAlive = true;
        //suffer = transform.Find("suffering");
        suffer.enabled = false;
        audioSource = dead.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "pain" && isAlive == true)
        {
            isAlive = false;
            suffer.enabled = true;
            Invoke("respawn", 2);
            alive.GetComponent<SpriteRenderer> ().enabled = false;
            dead.GetComponent<SpriteRenderer> ().enabled = true;
            audioSource.Play();
        }
    }

    void respawn()
    {
        isAlive = true;
        suffer.enabled = false;
        gameObject.transform.position = pos.startPos;
        alive.GetComponent<SpriteRenderer> ().enabled = true;
        dead.GetComponent<SpriteRenderer> ().enabled = false;
    }
}
