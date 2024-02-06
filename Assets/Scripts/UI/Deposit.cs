using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Deposit : MonoBehaviour
{
    [SerializeField] private GameObject selectmenu;
    [SerializeField] private GameObject DepositMenu;
    [SerializeField] private GameObject notEnough;
    [SerializeField] private TMP_InputField inputField;
    private CashManagement cash;

    private void Awake()
    {
        cash = GetComponent<CashManagement>();
    }

    public void BackSpace()
    {
        selectmenu.SetActive(true);
        DepositMenu.SetActive(false);
    }

    public void TenThouDepButton()
    {
        if(cash.haveCash >= 10000)
        {
            cash.Deposit(10000);
        }
        else
        {
            cash.NotEnoughCash();
        }
    }

    public void ThirtyThouDepButton()
    {
        if (cash.haveCash >= 30000)
        {
            cash.Deposit(30000);
        }
        else
        {
            cash.NotEnoughCash();
        }
    }

    public void FiftyThouDepButton()
    {
        if (cash.haveCash >= 50000)
        {
            cash.Deposit(50000);
        }
        else
        {
            cash.NotEnoughCash();
        }
    }

    public void OnClickDepositButton()
    {
        int _cash = 0;
        if(int.TryParse(inputField.text, out _cash))
        {
            if (cash.haveCash - _cash >= 0)
            {
                cash.haveCash -= _cash;
                cash.balanceCash += _cash;
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
