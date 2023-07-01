using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;

public class EndGameMenuController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _playerScore;
    [SerializeField] private TextMeshProUGUI _comentPlayerCore;
    public void OpenEndGamemenu() 
    {
        gameObject.SetActive(true);
        Yandex.DeathAdv();
    }

    public void RestartLevel()
    {
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex);
    }
    public void StartNextLevel()
    {
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex+1);
    } 

    public void ShowPlayerScroe(int score)
    {
        _playerScore.text = "Score: " + score;
    }
    public void ComentPlayerScore(int score, int numberOfQuestions)
    {
        if(score == 0)
        {
            _comentPlayerCore.text = "Ты вообще ничего не знаешь об игре";
            return;
        }
        if (score < (numberOfQuestions / 2))
        {
            _comentPlayerCore.text = "Ты уже что то знаешь, но ты все равно нуб";
        }
        if (score >= (numberOfQuestions / 2) && score!=numberOfQuestions)
        {
            _comentPlayerCore.text = "Ты многое знаешь об игре, но ты все еще не про";
        }
        if (score == numberOfQuestions)
        {
            _comentPlayerCore.text = "Ты знаешь все, можешь звать себя про. Попытайся пройти более сложнй уровень, если и эта вершина не покарена";
        }


    }
}
