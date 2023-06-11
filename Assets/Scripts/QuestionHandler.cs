using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionHandler : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> _answerButtons;
    [SerializeField] private GameObject _questionSprite;

    
    public void SetButtonQuestions(string[] wrongAnswers, string rightAnswer)
    {
        int positionOfRightAnswer = Random.Range(0, 4);//������ ����������� ������ 
        _answerButtons[positionOfRightAnswer].text = rightAnswer;

        int i,j;//���������� �����
        for (i = 0, j =0; i < _answerButtons.Count; i++, j++)
        {
            if (i == positionOfRightAnswer) { j--; continue; } //���� ������ ���������, �� �������� �� ��� �� �������� ������

            _answerButtons[i].text = wrongAnswers[j];
        }
        
    }

    public void SetQuestionSprite(Sprite sprite)
    {
        _questionSprite.GetComponent<Image>().sprite = sprite;//��������� �����������
    }
}
