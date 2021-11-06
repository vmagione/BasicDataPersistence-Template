using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level01Manager : MonoBehaviour
{
     public Text TextPlayerName;

    void Start()
    {
        TextPlayerName.text = GameManager.Instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
