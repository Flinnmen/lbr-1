using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
<<<<<<< Updated upstream
{
    
    public void test()
    {
        SceneManager.LoadScene("scheikundeMain");
=======
{   
    public LoaderScriptMM scriptLoad;

    public void loadMainMenu()
    {
        scriptLoad.LoadAnimation("MainMenu");
>>>>>>> Stashed changes
    }

    void loadMainMenu()
    {
<<<<<<< Updated upstream
        
=======
        scriptLoad.LoadAnimation("levelselect");
>>>>>>> Stashed changes
    }

    void loadLevelselect()
    {
<<<<<<< Updated upstream
        SceneManager.LoadScene("levelselect");
=======
        scriptLoad.LoadAnimation("scheikundeMain");
>>>>>>> Stashed changes
    }

    void loadLevel1()
    {
<<<<<<< Updated upstream
        
=======
        scriptLoad.LoadAnimation("bossScheikunde");
>>>>>>> Stashed changes
    }

    void loadLevel2()
    {
        
    }

    void loadSettings()
    {
        SceneManager.LoadScene("settings");
    }

    void loadCredits()
    {
        SceneManager.LoadScene("credits");
    }

    public void quitGame()
    {
        Application.Quit();
    }


}
