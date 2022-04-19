using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody _rigidbody;
    
    [SerializeField] private GameObject _panelGameOver;
    [SerializeField] private GameObject _panelFinish;
    [SerializeField] private Score _scoreScript;

    private void Start ()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        _rigidbody.AddForce (movement * speed);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Finish"))
        {
            _panelFinish.SetActive (true);
            int lastRunScore = int.Parse(_scoreScript._scoreText.text.ToString());   
            PlayerPrefs.SetInt("lastRunScore", lastRunScore);      
            Time.timeScale = 0; 
        }
          if(other.gameObject.CompareTag ("GameOver"))
        {
           _panelGameOver.SetActive(true);
            int lastRunScore = int.Parse(_scoreScript._scoreText.text.ToString());   
            PlayerPrefs.SetInt("lastRunScore", lastRunScore);   
           Time.timeScale = 0;
        }    
    }

}