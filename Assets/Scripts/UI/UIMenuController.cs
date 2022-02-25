using UnityEngine;
using UnityEngine.UI;

public class UIMenuController : MonoBehaviour
{
    [SerializeField] private Button playBtn;
    private void Awake()
    {
        playBtn.onClick.AddListener(delegate
        {
            SceneController.inst.ChangeScene("MainScene");
        });
    }
}
