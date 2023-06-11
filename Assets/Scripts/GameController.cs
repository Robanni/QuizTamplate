using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private QuestionData[] _questionData;

    [SerializeField] private QuestionHandler _questionHandler;

    private int _numberOfQuestion = 0;

    private void Start()
    {
        ChangeTheQuestion();
    }

    private void ChangeTheQuestion()
    {
        if (_numberOfQuestion > _questionData.Length) return;
        _questionHandler.SetButtonQuestions(_questionData[_numberOfQuestion].getWrongAnswers(),
                                            _questionData[_numberOfQuestion].getRightAnswer());

        _questionHandler.SetQuestionSprite(_questionData[_numberOfQuestion].getSprite());
    }

    public void InspectTheAnswer(string answer,GameObject button)//Проверяет правильность ответа 
    {
        if(answer == _questionData[_numberOfQuestion].getRightAnswer())
        {
            Debug.Log("answer is corrct");

            _numberOfQuestion++;
            
            ChangeTheQuestion();

            return;
        }
        Debug.Log("answer is wrong");
    }
}
