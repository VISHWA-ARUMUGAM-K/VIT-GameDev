using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    [SerializeField]
    private Text text1;
    public void SetText(string text)
    {
        text1.text = text;
    }

}
