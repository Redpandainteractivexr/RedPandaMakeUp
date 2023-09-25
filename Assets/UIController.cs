using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public GameObject LipStickPanel,ShadowFilterPanel,BlusherPanel;
    public Button ButtonLipStickButton,BlusherButton,ShadowFilterButton;
    private void Awake()
    {
        ButtonLipStickButton.onClick.AddListener(() => OpenLipStickPanel());
        BlusherButton.onClick.AddListener(() => OpenBlusherPanel());
        ShadowFilterButton.onClick.AddListener(() => OpenShadowFilterPanel());
    }
    // Start is called before the first frame update

    public void OpenLipStickPanel()
    {
        LipStickPanel.SetActive(true);
        ShadowFilterPanel.SetActive(false);
        BlusherPanel.SetActive(false);
    }
    public void OpenShadowFilterPanel()
    {
        LipStickPanel.SetActive(false);
        ShadowFilterPanel.SetActive(true);
        BlusherPanel.SetActive(false);
    }
    public void OpenBlusherPanel()
    {
        LipStickPanel.SetActive(false);
        ShadowFilterPanel.SetActive(false);
        BlusherPanel.SetActive(true);
    }

}
