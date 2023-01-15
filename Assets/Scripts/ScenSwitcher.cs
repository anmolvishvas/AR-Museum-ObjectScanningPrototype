using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenSwitcher : MonoBehaviour
{
    public void TailInfo()
    {
        SceneManager.LoadScene("TailInfoScene");
    }
    public void GeneralInfo()
    {
        SceneManager.LoadScene("GeneralInfoScene");
    }
    public void OriginInfo()
    {
        SceneManager.LoadScene("OriginInfoScene");
    }
    public void ViewSkeleton()
    {
        SceneManager.LoadScene("ViewSkeletonScene");
    }
    public void HornsInfo()
    {
        SceneManager.LoadScene("HornsInfoScene");
    }
    public void Back()
    {
        SceneManager.LoadScene("MainScene");
    }
}
