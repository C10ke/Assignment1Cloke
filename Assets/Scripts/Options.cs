using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void CheatSheetLV1 ()
    {
        SceneManager.LoadScene("Level01CheatSheet");
    }

}