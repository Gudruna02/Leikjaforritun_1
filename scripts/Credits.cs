using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    //hætta
    public void Quit()
    {
        Application.Quit();
    }
    //Spila aftur
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene"); // birtist game scene-ið
    }
}
