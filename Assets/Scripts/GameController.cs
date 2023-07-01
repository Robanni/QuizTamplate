using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private QuestionData[] _questionData;

    [SerializeField] private QuestionHandler _questionHandler;

    [SerializeField] private EndGameMenuController _endGameMenuController;

    private int _numberOfQuestion = 0;
    private int _rightAnswers = 0;

    private void Start()
    {
        ChangeTheQuestion();
        
    }
    private void Update()
    {
        TryToEndTheGame();
    }

    private void TryToEndTheGame()
    {
        if(_numberOfQuestion >= _questionData.Length)
        {
            _endGameMenuController.OpenEndGamemenu();
            _endGameMenuController.ShowPlayerScroe(_rightAnswers);
            _endGameMenuController.ComentPlayerScore(_rightAnswers,_questionData.Length);
        }
    }
    private void ChangeTheQuestion()
    {
        if (_numberOfQuestion >= _questionData.Length) return;

        _questionHandler.SetButtonQuestions(_questionData[_numberOfQuestion].getWrongAnswers(),
                                            _questionData[_numberOfQuestion].getRightAnswer());

        _questionHandler.SetQuestionSprite(_questionData[_numberOfQuestion].getSprite());
    }

    public void InspectTheAnswer(string answer,GameObject button)//��������� ������������ ������ 
    {
        if (_numberOfQuestion >= _questionData.Length) return;

        Image buttonImage = button.GetComponent<Image>();

        if(answer == _questionData[_numberOfQuestion].getRightAnswer())
        {
            StartCoroutine( PlayButtonsAnimation(buttonImage, true));

            _rightAnswers++;
            
            return;
        }
        StartCoroutine( PlayButtonsAnimation(buttonImage, false));
    }
    private IEnumerator PlayButtonsAnimation(Image buttonImage,bool state)
    {
        if (state == false)
        {
            buttonImage.color = Color.red;
        }
        if(state == true)
        {
            buttonImage.color = Color.green;
            _rightAnswers++;
        }
               
        yield return new WaitForSecondsRealtime(2);

        _numberOfQuestion++;

        buttonImage.color = Color.white;

        ChangeTheQuestion();
    }
}
