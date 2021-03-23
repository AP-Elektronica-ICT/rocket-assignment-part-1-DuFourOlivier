using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelUp : MonoBehaviour
{
    // Start is called before the first frame update
    public string mlevelToLoad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(mlevelToLoad);
    }
}
