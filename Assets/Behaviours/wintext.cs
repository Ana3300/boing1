using UnityEngine;
using TMPro;

public class wintext : MonoBehaviour
{
    public Transform aaaa;

    void Start()
    {
        //aaaa = transform.Find("bob");
    }

    void Update()
    {
        //Transform aaaa = transform.Find("bob");
        if (aaaa.GetComponent<candy>().food >= 6 & aaaa.GetComponent<candy>().fuel >= 3)
        {
            GetComponent<TMP_Text>().enabled = true;
        }
    }
}
