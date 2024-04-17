using UnityEngine;
using UnityEngine.UI;

namespace ChuongCustom
{
    public abstract class ButtonPurchase : MonoBehaviour
    {
        [SerializeField, IAPKey] private string _productID;
        [SerializeField] private Button buttonClick;
        
        private void Awake()
        {
            Init();
        }

        private void OnEnable()
        {
            Setup();
        }

        protected virtual void Init()
        {
            SetupPurchaseData(IAPDataManager.GetData(_productID));
            buttonClick.onClick.AddListener(OnClick);
        }

        protected virtual void OnClick()
        {
            IAPManager.OnPurchaseSuccess = OnPurchaseSuccess;
            IAPManager.Instance.BuyProductID(_productID);
        }
        
        protected abstract void Setup();

        protected abstract void SetupPurchaseData(IAPData iapData);

        protected abstract void OnPurchaseSuccess();
    }
}