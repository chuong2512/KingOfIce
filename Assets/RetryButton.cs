using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : AButton
{
    // Start is called before the first frame update
    void Start()
    {
    }

    protected override void OnClickButton()
    {
        ScoreManager.Score = 0;
        SceneManager.LoadScene("");
    }

    protected override void OnStart()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}