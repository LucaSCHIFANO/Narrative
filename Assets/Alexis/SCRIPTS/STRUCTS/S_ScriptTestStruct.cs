using UnityEngine;
using System;
[Serializable]
public struct S_ScriptTestStruct
{
    [TextArea]
    public string phrase;

    public int scoreFriend;
    public int path;
    public int step;

    public S_ScriptTestStruct(string txt, int pathId, int friend, int stepId) : this()
    {
        this.phrase = txt;
        this.path = pathId;
        this.step = stepId;
        this.scoreFriend = friend;
    }
}
