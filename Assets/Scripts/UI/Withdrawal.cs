using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Withdrawal : MonoBehaviour
{
    [SerializeField] private GameObject selectmenu;
    [SerializeField] private GameObject WithdrawalMenu;
    [SerializeField] private TMP_InputField inputField;
    private CashManagement cash;

    private void Awake()
    {
        cash = GetComponent<CashManagement>();
    }

    public void BackSpace()
    {
        selectmenu.SetActive(true);
        WithdrawalMenu.SetActive(false);
    }

    public void TenThouWithButton()
    {
        if (cash.balanceCash >= 10000)
        {
            cash.Withdrawal(10000);
        }
        else
        {
            cash.NotEnoughCash();
        }
    }

    public void ThirtyThouWithButton()
    {
        if (cash.balanceCash >= 30000)
        {
            cash.Withdrawal(30000);
        }
        else
        {
            cash.NotEnoughCash();
        }
    }

    public void FiftyThouWithButton()
    {
        if (cash.balanceCash >= 50000)
        {
            cash.Withdrawal(50000);
        }
        else
        {
            cash.NotEnoughCash();
        }
    }

    public void OnClickWithdrawalButton()
    {
        int _cash = 0;
        if (int.TryParse(inputField.text, out _cash))
        {
            if (cash.balanceCash - _cash >= 0)
            {
                cash.haveCash += _cash;
                cash.balanceCash -= _cash;
            }
            else
            {
                cash.NotEnoughCash();
            }
        }

        else
        {
            return;
        }
    }
}
