using StarterAssets;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Transform player;
    public GameObject deathPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathPart"))
        {
            player.GetComponent<ThirdPersonController>().MoveSpeed = 0;
            player.GetComponent<ThirdPersonController>().SprintSpeed = 0;
            deathPanel.SetActive(true);
        }
    }
    public void restrtScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
