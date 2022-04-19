using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEscape : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKey("escape"))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
    }
}
