using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CashManagement : MonoBehaviour
{
    public int haveCash;
    public int balanceCash;
    public TMP_Text _haveCash;
    public TMP_Text _balanceCash;
    public static CashManagement instance;
    public GameObject notEnough;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        haveCash = 100000;
        balanceCash = 50000;
    }

    private void Update()
    {
        _haveCash.text = haveCash.ToString();
        _balanceCash.text = balanceCash.ToString();
    }

    public void Deposit(int amount)
    {
        haveCash -= amount;
        balanceCash += amount;
    }

    public void Withdrawal(int amount)
    {
        haveCash += amount;
        balanceCash -= amount;
    }

    public void NotEnoughCash()
    {
        notEnough.SetActive(true);
    }

}
