using UnityEngine;
using TMPro;

public class starttext : MonoBehaviour
{
    //public Transform aaaa;

    void Start()
    {
        Invoke("hide", 5);
    }

    void hide()
    {
        GetComponent<TMP_Text>().enabled = false;
    }
}
