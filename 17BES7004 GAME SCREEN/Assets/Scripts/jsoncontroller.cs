using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jsoncontroller : MonoBehaviour
{
    
    public string jsonURL;
    
    void Start()
    {
        StartCoroutine(getdata());
    }
    private void processjsondata(string _url)
    {
        Loadjson jsndata = JsonUtility.FromJson<Loadjson>(_url);
        Debug.Log(jsndata.current_points);
        Debug.Log(jsndata.tasks);

        foreach(tasklist x in jsndata.tasks)
        {
            Debug.Log(x.title);
            Debug.Log(x.points);
            Debug.Log(x.compeleted);
        }
    }

    IEnumerator getdata()
    {
        Debug.Log("processing dta,please wait");

        WWW _www = new WWW(jsonURL);
        yield return _www;
        if (_www.error == null)
        {
            processjsondata(_www.text);
        }
        else
        {
            Debug.Log("oopps somethings went  wrong");
        }

    }
    // Update is called once per frame

}
