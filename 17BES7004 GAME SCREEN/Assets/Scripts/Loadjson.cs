
using System;
using System.Collections.Generic;

[Serializable]
public class Loadjson
{
    public String current_points;
    public List<tasklist> tasks;

    

}
[Serializable]
public class tasklist
{
    public string title;
    public int  points;

    public bool compeleted;

}
