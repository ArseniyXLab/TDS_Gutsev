using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    Text text;
    [SerializeField] public static int enemys;
    public GameObject WinPanel;

    void Start()
    {
        text = GetComponent<Text>();  
    }

     void Update()
    {
        text.text = enemys.ToString();

        if (enemys == 9)
        {
            WinPanel.SetActive(true);
        }
    }

   
}
