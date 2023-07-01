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
            _comentPlayerCore.text = "�� ������ ������ �� ������ �� ����";
            return;
        }
        if (score < (numberOfQuestions / 2))
        {
            _comentPlayerCore.text = "�� ��� ��� �� ������, �� �� ��� ����� ���";
        }
        if (score >= (numberOfQuestions / 2) && score!=numberOfQuestions)
        {
            _comentPlayerCore.text = "�� ������ ������ �� ����, �� �� ��� ��� �� ���";
        }
        if (score == numberOfQuestions)
        {
            _comentPlayerCore.text = "�� ������ ���, ������ ����� ���� ���. ��������� ������ ����� ������ �������, ���� � ��� ������� �� ��������";
        }


    }
}
