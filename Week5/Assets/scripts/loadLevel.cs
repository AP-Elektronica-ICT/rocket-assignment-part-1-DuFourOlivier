using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public string mlevelToLoad;
  public void LoadLevel()
    {
        disappear.mCount = 0;
        SceneManager.LoadScene(mlevelToLoad);
    }
}
