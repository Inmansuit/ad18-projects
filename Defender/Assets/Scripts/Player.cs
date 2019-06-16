using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;

    float movement = 0f;

    [SerializeField] private Text scoreText;

    private float score;

    public Text winText;

    [SerializeField] private GameObject hexagons;


    // Update is called once per frame
    void Update()
    {
        
        movement = Input.GetAxisRaw("Horizontal");
        SetScoreText();
        if (score >= 20)
        {
            winText.text = "You win!";
            StartCoroutine(WaitTwoSecondsThenLoad(0));

        }
    }


    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartCoroutine(WaitTwoSecondsThenLoad(2));

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Scoring"))
        {
            other.gameObject.SetActive(false);
            
        }
        
    }
  


    void SetScoreText()
    {
        score += Time.deltaTime;
        int intScore = (int)score;
        scoreText.text = "Score: " + intScore.ToString();
    }

    private IEnumerator WaitTwoSecondsThenLoad(int scene)
    {
        Time.timeScale = 0.2f;
        yield return new WaitForSecondsRealtime(1.9f);
        SceneManager.LoadScene(scene);
    } 


 
}