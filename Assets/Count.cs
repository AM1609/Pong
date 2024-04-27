using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Count : MonoBehaviour
{
    public GameObject ball;
    public Text Score;
    private int bat_1_score = 0;
    private int bat_2_score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x >= 9f)
        {
            bat_1_score++;
        }
        if (ball.transform.position.x <= -9f)
        {
            bat_2_score++;
        }
        Score.text = bat_1_score.ToString() + " - " + bat_2_score.ToString();
    }
}
