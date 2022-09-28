using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneSwitcher : MonoBehaviour
{
  public void goToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
  public void playFarmLevel()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(1);
    }
  public void playKitchenLevel()
    {
        SceneManager.LoadScene(2);
    }
  public void playXRRigTestLevel()
    {
        SceneManager.LoadScene(3);
    }
}
