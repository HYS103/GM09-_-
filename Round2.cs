using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round2 : MonoBehaviour
{
    private int score = 0;

    public void AddScore()
    {
        score++;

        Debug.Log("현재 점수 : " + score);
    }
}
