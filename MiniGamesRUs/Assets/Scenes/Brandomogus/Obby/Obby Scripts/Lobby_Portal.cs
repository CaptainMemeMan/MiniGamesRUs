using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyPortal : MonoBehaviour
{
    public Material obbyPortalMaterial; // Reference to the Obby Portal's material
    public Color portalColor = Color.green; // Color to change to
    public Color emissionColor = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        if (obbyPortalMaterial == null)
        {
            Debug.LogError("Obby Portal Material is not assigned in the inspector.");
        }
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
            // Change the obby portal's material color
            if (obbyPortalMaterial != null)
            {
                obbyPortalMaterial.color = emissionColor;
            }

            // Load the "main map" scene
            SceneManager.LoadScene("main map");
        }
    }
}
