using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    TMP_Text tmp;
    Bank bank;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TMP_Text>();
        bank = FindObjectOfType<Bank>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = "Gold:" + bank.CurrentBalance.ToString();
    }
}
