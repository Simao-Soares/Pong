using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public  PlayerPaddle paddle;
    public Ball ball;
    private int _playerScore;
    public Text playerScoreText;

    public int _scoreLimit;

    private int _computerScore;
    public Text computerScoreText;

    public void PlayerScores(){
        _playerScore++;

        Debug.Log(_playerScore);

        if(_playerScore == _scoreLimit){
            this.paddle.Shrink();
            this.ScoreReset();
        }

        this.playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void ComputerScores(){
        _computerScore++;

        Debug.Log(_computerScore);

        if(_computerScore == _scoreLimit){
            this.paddle.Grow();
            this.ScoreReset();
        }
    
        this.computerScoreText.text = _computerScore.ToString();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void ScoreReset(){
        this._playerScore = 0;
        this._computerScore = 0;
        this.computerScoreText.text = _computerScore.ToString();
        this.playerScoreText.text = _playerScore.ToString();
    }
}
