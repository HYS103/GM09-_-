using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difference3D : MonoBehaviour
{
    private bool isFound = false;

    public int score = 0;

    private void OnMouseDown()
    {
        if (isFound == true)
        {
            return;
        }

        isFound = true;

        score++;

        Debug.Log("Á¡¼ö : " + score);
    }
}
