using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class YourScore : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private void OnEnable()
    {
        _text = GetComponent<TextMeshProUGUI>();
        Show(0);
    }

    private void Show(int value)
    {
        Data.Player.HighScore = value;
        _text.text = ScoreManager.Score.ToString();
    }
}