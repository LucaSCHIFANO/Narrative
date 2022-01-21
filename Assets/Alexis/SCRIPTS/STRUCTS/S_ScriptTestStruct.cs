using UnityEngine;
using System;
[Serializable]
public struct S_ScriptTestStruct
{
    public string phrase;
    public int scoreFriend;
    public int scoreLove;


    public S_ScriptTestStruct(string txt, int love, int friend) : this()
    {
        this.phrase = txt;
        this.scoreLove = love;
        this.scoreFriend = friend;
    }
}
