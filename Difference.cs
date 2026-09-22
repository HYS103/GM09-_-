using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difference : MonoBehaviour
{
    private bool isFound = false;

    public Round round;

    private void OnMouseDown()
    {
        if (isFound == true)
        {
            return;
        }

        isFound = true;

        Debug.Log("Ã£À½");

        round.AddCount();
    }
}

