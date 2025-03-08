using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyPortal : MonoBehaviour
{
    public Material obbyPortalMaterial; // Reference to the Obby Portal's material
    public Color portalColor = Color.green; // Color to change to

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // This function will be triggered when the player enters the lobby portal
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
           
            // Change the obby portal color to green
            if (obbyPortalMaterial != null)
            {
                obbyPortalMaterial.color = portalColor;
            }

            SceneManager.LoadScene("main map");
        }
    }
}
