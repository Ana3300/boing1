using UnityEngine;
using TMPro;

public class FINAL : MonoBehaviour
{
    public Transform aaaa;

    void Start()
    {
        //aaaa = transform.Find("bob");
    }

    void Update()
    {
        //Transform aaaa = transform.Find("bob");
        if (aaaa.GetComponent<exitLevel>().done == true)
        {
            GetComponent<TMP_Text>().enabled = true;
        }
    }
}
