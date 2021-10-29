using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RecolteObjets : MonoBehaviour
{
    public static RecolteObjets instance;
    public TextMeshProUGUI text;
    int score;
    public PlayerLife playerObjects;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void ChangeScore(int nbObject)
    {
        score += nbObject;
        text.text = score.ToString();

    }
}
