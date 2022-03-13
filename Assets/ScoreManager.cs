using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreCalculator(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log("score:" + score);
        if (score == 100)
        {
            Debug.Log("you won the Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            score = 0;
        }
    }
}
