using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("title");
    }
}