using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScore : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore = 0;
    public Text textScore;
    public GameObject gameOverScreen;
    //[ContextMenu("Increase Score")]
    void Start(){
        playerScore = 0;
    }
    public void addScore(int scoreToAdd){
        playerScore = playerScore + scoreToAdd;
        textScore.text = playerScore.ToString();
    }
    public void reStart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

}
