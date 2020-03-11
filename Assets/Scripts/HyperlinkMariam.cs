using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hyperlink: MonoBehaviour
{
    // From the Recipes Page to Balloon Chocolate Bowl
    public void onClickToScene1()
    {
        SceneManager.LoadScene(1);
    }
}
