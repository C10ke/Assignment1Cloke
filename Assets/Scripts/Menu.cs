using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowCredits ()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadLevel_01()
    {
        SceneManager.LoadScene("Level01");    
    }

    public void LoadLevel_02()
    {
        SceneManager.LoadScene("Level02");    
    }

    public void LoadLevel_03 ()
    {
        SceneManager.LoadScene("Level03");
    }

    public void LoadOptions ()
    {
        SceneManager.LoadScene("Options");
    }



    /* If time create options for:
     *      player speed modes - 
     *          fridge fresh(slower): sticks to the ground, more control, less slippery
     *          room temperature(normal): glides on the ground, normal control, normal slippery
     *          pre-heated skillet(faster): slides on the ground, less control, more slippery
     *      difficulty - more obstacles 
     *      bumpers - to keep players from falling off aka bowling style bumpers
     * 
     * 
     */
}
