using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(FastProto_Counter))]
public class FastProto_Score : MonoBehaviour
{
    public TextMeshProUGUI _score;
    public FastProto_Counter _currentScore;

    public void DisplayScore()
    {
        _score.text = _currentScore._currentValue.ToString();
    }

}
