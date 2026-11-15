using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class candy : MonoBehaviour
{
    public int fuel = 0;
    public int food = 0;
    private move speed;
    public int powerDur;
    public Image nyoom;
    public Image boing;
    //public AudioClip clip;
    AudioSource audioSource;
    //public Transform unu;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        var collider = GetComponent<Collider>();
        collider.sharedMaterial.bounciness = 0.6f;
        speed = GetComponent<move>();
        //audio.clip = clip;
        //unu = transform.Find("1");
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "candyFuel")
        {
            fuel++;
            Destroy(other.gameObject);
            audioSource.Play();
            //Invoke("checkWin", 0);
        }
        if (other.gameObject.tag == "candyFood")
        {
            food++;
            Destroy(other.gameObject);
            audioSource.Play();
            //Invoke("checkWin", 0);
        }
        if (other.gameObject.tag == "candyPower")
        {
            if(Random.Range(0, 2) == 1)
            {
                speed.vitezaStDr = 240;
                nyoom.enabled = true;
                Invoke("slow", powerDur);
            }
            else
            {
                var collider = GetComponent<Collider>();
                collider.sharedMaterial.bounciness = 1f;
                boing.enabled = true;
                Invoke("stopBounce", powerDur);
            }
            Destroy(other.gameObject);
            audioSource.Play();
        }
    }

    //void checkWin()
    //{
    //    if(fuel >= 0 && food >= 1)
    //    {
    //        unu.GetComponent<Text>().enabled = true;
    //    }
    //}
    void slow()
    {
        speed.vitezaStDr = 30;
        nyoom.enabled = false;
    }

    void stopBounce()
    {
        boing.enabled = false;
        var collider = GetComponent<Collider>();
        collider.sharedMaterial.bounciness = 0.6f;
    }
}
