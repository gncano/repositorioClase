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
            zoneChangePanel.SetActive(true);
            Time.timeScale = 0f; 
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
