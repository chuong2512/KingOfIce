using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using UnityEngine;

public class ContinueBtn : AButton
{
    protected override void OnClickButton()
    {
        if (Data.Player.Gem >= 1)
        {
            Data.Player.Gem -= 1;
            ToastManager.Instance.ShowMessageToast("Buy Success!!");
            Manager.InGame.Continue();
            ScreenManager.Instance.Back();
        }
        else
        {
            ToastManager.Instance.ShowMessageToast("Not enough heart !!!");
        }
    }

    protected override void OnStart()
    {
    }
}