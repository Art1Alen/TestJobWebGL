using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TMP_Text RecordText;
    [SerializeField] private GameObject _panelResult;

    public Button ButtonResult;

    private void Start() 
    {
        int lastRunScore = PlayerPrefs.GetInt("lastRunScore");
        int recordScore = PlayerPrefs.GetInt("recordScore");

        if(lastRunScore > lastRunScore)
        {
            recordScore = lastRunScore;
            PlayerPrefs.SetInt("recordScore", recordScore);
            RecordText.text = recordScore.ToString();
        }
        else
        {
            RecordText.text = recordScore.ToString();
        }
        Button button = ButtonResult.GetComponent<Button>();
		button.onClick.AddListener(TaskOnClick);
    }
    
    public void PlayGame()
    {
       SceneManager.LoadScene(1);
    }

    public void TaskOnClick()
    {
		_panelResult.SetActive(true);
    }
}
