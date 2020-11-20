using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public GameObject endGameText;
    public GameObject scoreText;
    public static int score;

    void OnTriggerEnter(Collider other)
    {
        score += 1;
        scoreText.GetComponent<Text>().text = "Score: " + score;
        Destroy(gameObject);

        if(score == 30)
        {
            endGameText.SetActive(true);
        }
    }

}
