using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DepositWithdrawalButton : MonoBehaviour
{ 
    [SerializeField] private GameObject selectButton;
    [SerializeField] private GameObject _deposit;
    [SerializeField] private GameObject _withdrawal;
    

    public void OnClickDepositButton()
    {
        selectButton.SetActive(false);
        _deposit.SetActive(true);
    }

    public void OnClickWithdrawalButton()
    {
        selectButton.SetActive(false );
        _withdrawal.SetActive(true);
    }
}
