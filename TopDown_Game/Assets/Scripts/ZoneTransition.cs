using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneTransition : MonoBehaviour
{
    [SerializeField] private GameObject zoneChangePanel; 
    [SerializeField] private string SceneName; 

   

    private void Start()
    {
        zoneChangePanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SavePlayerData(collision.gameObject);
            zoneChangePanel.SetActive(true);
            Time.timeScale = 0f; 
        }
    }

    private void SavePlayerData(GameObject player)
    {
        PlayerController playerController = player.GetComponent<PlayerController>();
        if (playerController != null)
        {
            PlayerPrefs.SetInt("PlayerHealth", playerController.currentHealth);
            PlayerPrefs.SetInt("PlayerPoints", playerController.upgradePoints);
            PlayerPrefs.Save();
        }
    }

    public void OnAccept()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneName);
    }

    public void OnCancel()
    {
        Time.timeScale = 1f;
        zoneChangePanel.SetActive(false);
    }
}
