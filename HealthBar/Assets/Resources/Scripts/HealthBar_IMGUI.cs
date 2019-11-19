using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_IMGUI : MonoBehaviour
{
    // 最大血量
    public float MaxValue = 10.0f;
    // 当前血量
    public float CurValue;
    private float LerpValue;
    // 只是为了方便
    public Slider healthSlider;
    private void Start()
    {
        // 默认最大血量是10.0，可以调整
        MaxValue = 10.0f;
        // 初始血量为1.0
        CurValue = 1.0f;
        LerpValue = 1.0f;
    }
    void OnGUI()
    {
        GUI.HorizontalScrollbar(new Rect(25, 25, 300, 50), 0.0f, CurValue, 0.0f, MaxValue);

        if (GUI.Button(new Rect(45, 90, 50, 30), "加血"))
        {
            LerpValue += 1.0f;
            if(LerpValue > 10.0f)
            {
                LerpValue = 10.0f;
            }
        }
        if (GUI.Button(new Rect(225, 90, 50, 30), "减血"))
        {
            LerpValue -= 1.0f;
            if (LerpValue < 0.0f)
            {
                LerpValue = 0.0f;
            }
        }
        CurValue = Mathf.Lerp(CurValue, LerpValue, 0.05f);
        healthSlider.value = CurValue;

    }
}
