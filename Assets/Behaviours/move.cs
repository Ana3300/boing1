using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public float vitezaSalt = 100;
    public float vitezaStDr = 200;
    private bool grounded;
    private Rigidbody rb;
    public Vector3 startPos;
    private pian mort;
    public Text textRef;

    void Start()
    {
        textRef = GetComponent<Text>();
        rb = GetComponent<Rigidbody>();
        rb.mass = 10;
        startPos.Set(rb.position.x, rb.position.y, rb.position.z);
        mort = GetComponent<pian>();
    }

    void Update()
    {
        //textRef.text = 23f.ToString();
        // susu
        if (Keyboard.current.wKey.isPressed && grounded == true && mort.isAlive == true && GetComponent<exitLevel>().done == false)
        {
            rb.AddForce(transform.up * vitezaSalt);
        }
        // steanga
        if (Keyboard.current.aKey.isPressed && mort.isAlive == true && GetComponent<exitLevel>().done == false)
        {
            rb.AddForce(-transform.right * vitezaStDr);
        }
        // draeptea
        if (Keyboard.current.dKey.isPressed && mort.isAlive == true && GetComponent<exitLevel>().done == false)
        {
            rb.AddForce(transform.right * vitezaStDr);
        }
    }
    // coliziuned
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Finish")
        {
            grounded = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Finish")
        {
            grounded = false;
        }
    }
}
