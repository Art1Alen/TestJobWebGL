using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class Score : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] public TMP_Text _scoreText;

   
    private void Update()
    {
        _scoreText.text = ((int)(_player.position.z / 2)).ToString();
    }
    
}
