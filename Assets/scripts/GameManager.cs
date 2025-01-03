using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public ball ball;

    public paddle PlayerPaddle;
    public paddle ComputerPaddle;

    public Text PlayerScoreText;

    public Text ComputerScoreText;

    private int _playerScore;

    private int _computerScore;

    public void PlayerScore()
    {
        _playerScore++;
        this.PlayerScoreText.text = _playerScore.ToString();
        ResetRound();
    }
    public void ComputerScore()
    {
        _computerScore++;
        this.ComputerScoreText.text = _computerScore.ToString();
        ResetRound();
       
    }
    private void ResetRound()
    {
        this.PlayerPaddle.ResetPosition();
        this.ComputerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}




