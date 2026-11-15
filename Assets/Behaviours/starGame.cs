using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void controls()
    {
        SceneManager.LoadScene("controls");
    }
}