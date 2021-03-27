using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_health : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textElement;

    void Start()
    {
        textElement.text = "Health: " + Health.HP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = "Health: " + Health.HP.ToString();
    }

}
