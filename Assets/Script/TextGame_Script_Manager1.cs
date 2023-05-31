using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextGame_Script_Manager1 : MonoBehaviour
{

    public int staminaValue, companionstaminaValue, rationValue, floorValue;
    public TextMeshProUGUI staminaTextValue, companionTextValue, RationTextValue, floorTextValue, storyTextValue;
    public string story;
    public GameObject Floor10_Choices;
    // Start is called before the first frame update
    void Start()
    {
        staminaValue = 5;
        companionstaminaValue = 5;
        rationValue = 3;
        floorValue = 10;
        story = "You wake up in deep in a dungeon after falling down 10 floors down and it seems that a monster cushioned your fall which kept you alive you see two ways but you lost 2 rations in the process, left and right where do you go";
    }

    // Update is called once per frame
    void Update()
    {
        staminaTextValue.text = staminaValue.ToString();
        companionTextValue.text = companionstaminaValue.ToString();
        RationTextValue.text = rationValue.ToString();
        floorTextValue.text = floorValue.ToString();
        storyTextValue.text = story;
    }
    public void Gototheright()
    {
        story = "You go to the right, You only see stairs, You climbed the staircase, Nothing Happens";
        floorValue--;
        Floor10_Choices.SetActive(false);
    }
    public void Gototheleft()
    {
        story = "You go to the left, You go into the light and get attacked by a monster that lures enemies using light, You fight the monster and won but you are now slightly tired";
        story = "";
        story = "(Pay attention to detail as the start of the story said you fell 3 floors down and it is impossible for you to see light down here) ";
        staminaValue--;
    }
}
