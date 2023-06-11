using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonObserver : MonoBehaviour
{
    [SerializeField] private List<ButtonStatus> _buttonStatuses;
    [SerializeField] private GameController _gameController;
    private void Start()
    {
        for(int i = 0; i < _buttonStatuses.Count; i++)
        {
            _buttonStatuses[i].answerIsGiven += SendStatusToGameController;
        }
    }
    private void SendStatusToGameController(string answer, GameObject senderButton)
    {
        _gameController.InspectTheAnswer(answer, senderButton);
    }
}
