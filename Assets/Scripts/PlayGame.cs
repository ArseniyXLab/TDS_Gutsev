using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void PlayGameButton(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
