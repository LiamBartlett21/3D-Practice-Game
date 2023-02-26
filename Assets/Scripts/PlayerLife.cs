using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] List<GameObject> checkpoint;
    [SerializeField] GameObject player;
    [SerializeField] Vector3 vector;
    [SerializeField] private AudioSource deathNoise;
    [SerializeField] float border;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(player.transform.position.y < border)
        {
            Respawn();
            deathNoise.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            deathNoise.Play();
            Respawn();
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter(Collider other)
    {
        vector = player.transform.position;
        Destroy(other.gameObject);
    }

    private void Respawn()
    {
        player.transform.position = vector;
    }
}
