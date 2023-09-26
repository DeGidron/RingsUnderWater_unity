using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public GameManager gameManager;
    public int cupIndex;

    private void OnEnable()
    {
        GetComponent<Button>().onClick.AddListener(buttonClicked);
    }

    void Update()
    {
        
    }

    public void buttonClicked()
    {
        gameManager.cupClicked = this.GetComponent<Button>();
        gameManager.cupClickedNum = transform.GetSiblingIndex();
    }
}
