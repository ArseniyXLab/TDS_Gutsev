using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiayerCount : MonoBehaviour
{
    Text text;
    [SerializeField] public static int Deth = 1;
    public GameObject LosePanel;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = Deth.ToString();

        if (Deth == 0)
        {
            LosePanel.SetActive(true);
        }
    }
}
