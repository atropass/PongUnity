using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle PlayerPaddle;
    public Paddle ComputerPaddle;
    private int _playerScore = 0;
    private int _computerScore = 0;
    public Text ComputerScoreText;
    public Text PlayerScoreText;

    public void PlayerScoreTexts(){
        _playerScore++;
        this.PlayerScoreText.text = _playerScore.ToString();
        ResetGame();
    }
    public void ComputerScores(){
        _computerScore++;
        this.ComputerScoreText.text = _computerScore.ToString();
        ResetGame();
    } 
    private void ResetGame(){
        this.ComputerPaddle.ResetPosition();
        this.PlayerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}

