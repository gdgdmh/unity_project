using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleTask : MonoBehaviour
{
    private Mhl.Input.Touch.ISingleTouchActionable touchAction;

    // Start is called before the first frame update
    void Start()
    {
        touchAction = new Mhl.Input.Touch.SingleTouchActionEditor();
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Assertions.Assert.IsNotNull(touchAction);
        touchAction.Update();
        if (touchAction.IsTouchEnded())
        {
            // 画面のどこかをタッチした
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
    }
}
