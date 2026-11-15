using UnityEngine;
using UnityEngine.SceneManagement;

public class exitLevel : MonoBehaviour
{
    private candy ghmjhgf;
    public int neededFood = 6;
    public int neededFuel = 3;
    public int endWait = 7;
    public Transform closer;
    public Transform opener;
    public Transform self;
    public Transform rocket;
    public bool done = false;

    void Start()
    {
        ghmjhgf = GetComponent<candy>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Finish" && ghmjhgf.food >= neededFood && ghmjhgf.fuel >= neededFuel)
        {
            Invoke("back", endWait);
            Destroy(opener.gameObject);
            Destroy(self.gameObject);
            closer.GetComponent<SpriteRenderer>().enabled = true;
            //rocket.GetComponent<FINAL>().Invoke("Cutscene", 2);
            done = true;
        }
    }

    void back()
    {
        SceneManager.LoadScene("title");
    }
}
