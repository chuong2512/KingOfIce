using TMPro;
using UnityEngine;

namespace ChuongCustom
{
    public abstract class ValuePurchase : ButtonPurchase
    {
        [SerializeField] private TextMeshProUGUI price;
        [SerializeField] private TextMeshProUGUI valueTMP;
        [SerializeField] protected int value;

        protected override void SetupPurchaseData(IAPData iapData)
        {
            price.SetText(iapData.price);
            valueTMP.SetText(value.ToString());
        }
    }
}