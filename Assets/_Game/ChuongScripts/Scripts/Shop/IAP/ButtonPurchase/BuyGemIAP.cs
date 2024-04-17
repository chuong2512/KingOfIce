using TMPro;
using UnityEngine;

namespace ChuongCustom
{
    public class BuyGemIAP : ValuePurchase
    {
        [SerializeField] private int value2;
        [SerializeField] private TextMeshProUGUI value2TMP;

        protected override void Setup()
        {
            value2TMP.SetText(value2.ToString());
        }

        protected override void OnPurchaseSuccess()
        {
            ToastManager.Instance.ShowMessageToast("Buy Success!!");
            Data.Player.Gem += value2;
            Data.Player.Coin += value;
        }
    }
}