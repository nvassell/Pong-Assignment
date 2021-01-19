using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    public void Player1Scored()
    {
        ResetPosition();
    }

    public void Player2Scored()
    {
        ResetPosition();
    }

    public void ResetPosition()
    {
        ball.GetComponent<ball>().Reset();
        player1Paddle.GetComponent<paddle>().Reset();
        player2Paddle.GetComponent<paddle>().Reset();
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

}
