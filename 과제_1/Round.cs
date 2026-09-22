using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    private int foundCount = 0;

    public void AddCount()
    {
        foundCount++;

        Debug.Log("찾은 개수 : " + foundCount);
    }
}
