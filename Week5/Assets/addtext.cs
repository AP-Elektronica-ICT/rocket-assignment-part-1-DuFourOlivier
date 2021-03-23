using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addtext : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textElement;
    public string textvalue;
    
    void Start()
    {
        textElement.text = textvalue + disappear.mCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = textvalue + disappear.mCount.ToString();
    }

}
