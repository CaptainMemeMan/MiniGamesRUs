using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserDeathsceneshortcut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collission)
    {
        if (collission.CompareTag("Player"))
        {
            SceneManager.LoadScene("EasyObby2");
        }
    }
}
