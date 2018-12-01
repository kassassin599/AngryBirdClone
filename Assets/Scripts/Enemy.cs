using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

    public float health = 4f;

    public static int EnemiesAlive = 0;

    private void Start()
    {
        EnemiesAlive++;
    }

    private void OnCollisionEnter2D(Collision2D colInfo)
    {
        if (colInfo.relativeVelocity.magnitude>health)
        {
            Die();
        }
    }

    void Die()
    {
        EnemiesAlive--;
        if (EnemiesAlive<=0)
        {
            Debug.Log("SceneManager.LoadScene(0);");
        }

        Destroy(gameObject);
    }
}
