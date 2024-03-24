using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class eatmushroom : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            score += 1;
            Destroy(other.gameObject);
            scoreText.text = "Score : " + score;
        }
    }

}
