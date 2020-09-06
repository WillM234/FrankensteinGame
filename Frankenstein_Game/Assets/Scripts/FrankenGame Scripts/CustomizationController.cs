using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CustomizationController : MonoBehaviour
{
    #region Game Objects
    [Header("Game Objects")]
    public Sprite Character1, Character2, Character3;
    private SpriteRenderer TopRenderer,BottomRenderer;
    private GameObject TopPlayer, BottomPlayer;
    #endregion
    #region Menu Objects
    [Header("Menu Objects")]
    public Slider SpriteSelector, BlueSlider, RedSlider, GreenSlider, AlphaSlider;
    private float BlueValue, RedValue, GreenValue, AlphaValue;
    private Color PlayerColor;
    #endregion
    private void Awake()
    {
    TopPlayer = GameObject.Find("TopPlayer"); BottomPlayer = GameObject.Find("BottomPlayer");
    TopRenderer = TopPlayer.GetComponent<SpriteRenderer>();
    BottomRenderer = BottomPlayer.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
    PlayerColor = new Color(RedValue, GreenValue, BlueValue, AlphaValue);
    TopRenderer.color = PlayerColor; BottomRenderer.color = PlayerColor;
    }
    public void BlueChanger()
    {
    BlueValue = BlueSlider.value;
    }
    public void RedChanger()
    {
    RedValue = RedSlider.value;
    }
    public void GreenChanger()
    {
    GreenValue = GreenSlider.value;
    }
    public void AlphaChanger()
    {
    AlphaValue = AlphaSlider.value;
    }
    public void ShapeChanger()
    {
    if(SpriteSelector.value == 1)
        {
            TopRenderer.sprite = Character1;
            BottomRenderer.sprite = Character1;
        }
    if (SpriteSelector.value == 2)
        {
            TopRenderer.sprite = Character2;
            BottomRenderer.sprite = Character2;
        }
    if (SpriteSelector.value == 3)
        {
            TopRenderer.sprite = Character3;
            BottomRenderer.sprite = Character3;
        }
    }
}
