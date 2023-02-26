using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject finish;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("End"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        }
}
