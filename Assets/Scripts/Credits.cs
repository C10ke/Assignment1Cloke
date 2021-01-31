using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
     public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void BackToMenu ()
    {
        SceneManager.LoadScene("Menu");
    }
    public void CheatSheetLV1()
    {
        SceneManager.LoadScene("Level01CheatSheet");
    }
    public void CheatSheetLV2()
    {
        SceneManager.LoadScene("Level02CheatSheet");
    }

    public void CheatSheetLV3()
    {
        SceneManager.LoadScene("Level03CheatSheet");
    }

}
