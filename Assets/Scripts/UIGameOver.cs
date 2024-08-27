using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    
    void Start()
    {
        scoreText.text = "YOU SCORED : \n" + ScoreKeeper.Instance.GetScore().ToString("000000000");
    }
}
