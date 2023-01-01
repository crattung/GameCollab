using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_light : MonoBehaviour
{

    public GameObject Light;
    public bool L = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lightup()
    {
        Light.SetActive(!L);
        L = !L;

    }
}
