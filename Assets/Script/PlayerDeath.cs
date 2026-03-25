using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Transform player;
    public GameObject deathPanel;
    public GameObject endPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathPart"))
        {
            ThirdPersonController controller = player.GetComponent<ThirdPersonController>();

            controller.MoveSpeed = 0;
            controller.SprintSpeed = 0;

            deathPanel.SetActive(true);
        }
    }
    public void restrtScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int totalScenes = SceneManager.sceneCountInBuildSettings;

        if (currentSceneIndex + 1 < totalScenes)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            Debug.Log("To już ostatni level!");
            endPanel.SetActive(true);
        }
    }
}