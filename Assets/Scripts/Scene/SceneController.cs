using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController inst;
    private void Awake()
    {
        inst = this;
        DontDestroyOnLoad(this);
    }
    public void ChangeScene(string name)
    {
        ChangeScene((object)name);
    }
    public void ChangeScene(int index)
    {
        ChangeScene((object)index);
    }
    private void ChangeScene(object obj)
    {
        if (obj.GetType() == typeof(int))
            SceneManager.LoadScene((int)obj);
        else
            SceneManager.LoadScene((string)obj);
    }
}
