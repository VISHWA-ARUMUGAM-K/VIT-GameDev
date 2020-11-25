using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPINSCRIPT : MonoBehaviour
{
    // Start is called before the first frame update
    public bool acti;
    public GameObject myobj;
    public Text Textfield;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()    
    {
        if (acti == true)
        {
            myobj.SetActive(true);
        }
        else
        {
            myobj.SetActive(false);
        }


    }
    public void SetText(string text)
    {
        Textfield.text = text;
    }
}
