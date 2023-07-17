using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextGame_Script_Manager1 : MonoBehaviour
{

    public int staminaValue, companionstaminaValue, floorValue, hero, comp;
    public TextMeshProUGUI staminaTextValue, companionTextValue, floorTextValue, storyTextValue;
    public string story;
    public GameObject Status;
    public GameObject ImageIn;
    public GameObject ImageOut;
    public GameObject StartingScreen;
    public GameObject Floor5_Choices;
    public GameObject Floor5;
    public GameObject Floor4_Choices;
    public GameObject Floor4;
    public GameObject Floor3_Choices;
    public GameObject Floor3;
    public GameObject Floor2_Choices;
    public GameObject Floor2;
    public GameObject Floor1_Choices;
    public GameObject Floor1;
    // Start is called before the first frame update
    void Start()
    {
        staminaValue = 4;
        companionstaminaValue = 4;
        floorValue = 5;
        story = "You wake up in deep in a dungeon after falling down 5 floors down and it seems that a monster cushioned your fall which kept you alive, you see two ways forward, the left side has light at the end and the right side is dark, left and right where do you go";

    }

    // Update is called once per frame
    void Update()
    {
        staminaTextValue.text = staminaValue.ToString();
        companionTextValue.text = companionstaminaValue.ToString();
        floorTextValue.text = floorValue.ToString();
        storyTextValue.text = story;
    }
    public void StartGame()
    {
        StartingScreen.SetActive(false);
    }
    public void Gototheright()
    {
        story = "You go to the right you see a staircase and climbed it, \n\non the next floor you encounter a girl do you save her or leave her behind? She offers to help you escape the dungeon";
        floorValue--;
        Floor5_Choices.SetActive(false);
        Floor5.SetActive(false);
    }
    public void Gototheleft()
    {
        story = "You go to the left, You go into the light and get attacked by a monster that lures enemies using light, You fight the monster and won but you are now slightly tired";
        story = "";
        story = "(Pay attention to detail as the start of the story said you fell 3 floors down and it is impossible for you to see light down here) ";
        staminaValue--;
        if (staminaValue == 0)
        {
            story = "Bad Ending: You got attacked by a monster and died due to exhaustion";
            Floor5_Choices.SetActive(false);
            Floor5.SetActive(false);
            Floor4_Choices.SetActive(false);
            Floor4.SetActive(false);
            Floor3_Choices.SetActive(false);
            Floor3.SetActive(false);
            Floor2_Choices.SetActive(false);
            Floor2.SetActive(false);
            Floor1_Choices.SetActive(false);
            Floor1.SetActive(false);
            return;
        }
    }

    public void Leave()
    {
        story = "You can't afford to bring a possible deadweight but you rescue her, patch her up and leave her some food and water to survive on her own and you tell her to wait for you to clear the dungeon alone \nShe thanks you for the supplies and tells you to be careful with a solemn look \nYou move up alone \nYou encounter a lady telling you there's treasures on the right";
        Floor4_Choices.SetActive(false);
        Floor4.SetActive(false);
        floorValue--;
    }
    public void Save()
    {
        story = "You save her, patch her up and gave her some of your supplies to heal up and you tell her that you will be leaving together once she is ready to leave however she only eats and drinks the rations then stands up and tells you she's ready \nShe looks better than before and you move up together \nYou encounter a lady telling you there's treasures on the right your companion tells you its dangerous";
        Floor4_Choices.SetActive(false);
        Floor4.SetActive(false);
        floorValue--;
        comp++;
    }
    public void Ignore()
    {
        if (comp == 1)
        {
            story = "you and your companion ignored the lady and go to the left and while climbing the stairs your companion says it was a good idea since she saw skulls and bones at the end of the right hallway \non the next floor you encounter a monster which you cannot avoid you fight it and defeat it but since your companion had your back you didn't lose stamina you both decide to rest on the next floor";
            floorValue--;
            Floor3_Choices.SetActive(false);
            Floor3.SetActive(false);
            if (staminaValue == 0)
            {
                story = "Bad Ending: You got attacked by a monster and died due to exhaustion";
                Floor5_Choices.SetActive(false);
                Floor5.SetActive(false);
                Floor4_Choices.SetActive(false);
                Floor4.SetActive(false);
                Floor3_Choices.SetActive(false);
                Floor3.SetActive(false);
                Floor2_Choices.SetActive(false);
                Floor2.SetActive(false);
                Floor1_Choices.SetActive(false);
                Floor1.SetActive(false);
                return;
            }
        }
        else
        {
            story = "You ignore the lady and you see a hole on the wall where you saw the right side filled with skulls and bones of humans, you walk towards the stairs \non the next floor you encounter a monster which you cannot avoid you fight it and defeat it losing 1 stamina you decide to rest on the next floor gaining stamina";
            floorValue--;
            Floor3_Choices.SetActive(false);
            Floor3.SetActive(false);
            if (staminaValue == 0)
            {
                story = "Bad Ending: You got attacked by a monster and died due to exhaustion";
                Floor5_Choices.SetActive(false);
                Floor5.SetActive(false);
                Floor4_Choices.SetActive(false);
                Floor4.SetActive(false);
                Floor3_Choices.SetActive(false);
                Floor3.SetActive(false);
                Floor2_Choices.SetActive(false);
                Floor2.SetActive(false);
                Floor1_Choices.SetActive(false);
                Floor1.SetActive(false);
                return;
            }
        }
    }
    public void GoRight()
    {
        if (comp == 1)
        {
            story = "You and your companion go to the right and encounter a big monster you beat it together and losing 1 stamina together, you go back to confront the lady and she wasn't there anymore \non the next floor you encounter a monster which you cannot avoid you fight it and defeat it but since your companion had your back you didn't lose stamina you decide to rest on the next floor gaining stamina";
            floorValue--;
            Floor3_Choices.SetActive(false);
            Floor3.SetActive(false);
            if (staminaValue == 0)
            {
                story = "Bad Ending: You got attacked by a monster and died due to exhaustion";
                Floor5_Choices.SetActive(false);
                Floor5.SetActive(false);
                Floor4_Choices.SetActive(false);
                Floor4.SetActive(false);
                Floor3_Choices.SetActive(false);
                Floor3.SetActive(false);
                Floor2_Choices.SetActive(false);
                Floor2.SetActive(false);
                Floor1_Choices.SetActive(false);
                Floor1.SetActive(false);
                return;
            }
        }
        else
        {
            story = "You go to the right alone and encounter a monster and fought it, you lost 2 stamina and you go back to confront the lady and she wasn't there anymore \non the next floor you encounter a monster which you cannot avoid you fight it and defeat it losing 1 stamina(Losing a total of 3), you decide to rest on the next floor gaining stamina";
            staminaValue -= 2;
            floorValue--;
            Floor3_Choices.SetActive(false);
            Floor3.SetActive(false);
            if (staminaValue == 0)
            {
                story = "Bad Ending: You got attacked by a monster and died due to exhaustion";
                Floor5_Choices.SetActive(false);
                Floor5.SetActive(false);
                Floor4_Choices.SetActive(false);
                Floor4.SetActive(false);
                Floor3_Choices.SetActive(false);
                Floor3.SetActive(false);
                Floor2_Choices.SetActive(false);
                Floor2.SetActive(false);
                Floor1_Choices.SetActive(false);
                Floor1.SetActive(false);
                return;
            }
        }
    }
    public void restmore()
    {
        if (comp == 1)
        {
            story = "You both rest more and gain 1 more stamina and you are ready for the boss fight \nyou encounter the boss and both lose 3 stamina";
            companionstaminaValue++;
            staminaValue++;
            hero++;
            companionstaminaValue -= 3;
            staminaValue -= 3;
            floorValue--;
            Floor2.SetActive(false);
            Floor2_Choices.SetActive (false);
            if (staminaValue == 0)
            {
                story = "Rescued Ending: You got attacked by a monster and got exhausted but your companion managed to save you and drag you outside and into her town and help you recover";
                Floor5_Choices.SetActive(false);
                Floor5.SetActive(false);
                Floor4_Choices.SetActive(false);
                Floor4.SetActive(false);
                Floor3_Choices.SetActive(false);
                Floor3.SetActive(false);
                Floor2_Choices.SetActive(false);
                Floor2.SetActive(false);
                Floor1_Choices.SetActive(false);
                Floor1.SetActive(false);
                ImageIn.SetActive(false);
                Floor1_Choices.SetActive(false);
                Floor1.SetActive(false);
                Status.SetActive(false);
            }
        }
        else
        {
            story = "you rest more and gain one more stamina \nyou encounter the boss and lose 3 stamina";
            staminaValue++;
            floorValue--;
            Floor2.SetActive(false);
            Floor2_Choices.SetActive(false);
            if (staminaValue == 0)
            {
                story = "Bad Ending: You got attacked by a monster and died due to exhaustion";
                Floor5_Choices.SetActive(false);
                Floor5.SetActive(false);
                Floor4_Choices.SetActive(false);
                Floor4.SetActive(false);
                Floor3_Choices.SetActive(false);
                Floor3.SetActive(false);
                Floor2_Choices.SetActive(false);
                Floor2.SetActive(false);
                Floor1_Choices.SetActive(false);
                Floor1.SetActive(false);
                return;
            }
        }
    }
    public void moveforward()
    {
        story = "you are eager to leave the dungeon and leave early \nyou encounter the boss and lose 3 stamina";
        staminaValue -= 3;
        floorValue--;
        Floor2.SetActive(false);
        Floor2_Choices.SetActive(false);
        if (staminaValue == 0)
        {
            story = "Bad Ending: You got attacked by a monster and died due to exhaustion";
            Floor5_Choices.SetActive(false);
            Floor5.SetActive(false);
            Floor4_Choices.SetActive(false);
            Floor4.SetActive(false);
            Floor3_Choices.SetActive(false);
            Floor3.SetActive(false);
            Floor2_Choices.SetActive(false);
            Floor2.SetActive(false);
            Floor1_Choices.SetActive(false);
            Floor1.SetActive(false);
            return;
        }
    }
    public void openDoor()
    {
        if (comp == 1)
        {
            if (hero == 1)
            {
               story = "Best Ending: you finally got out of the dungeon with your companion \nyou told her she can go home since her town is nearby and is thankful for you and invites you to her house to live with her and adventure with her \n seeing no disadvantage in going with her you agree and the story after is for another time ";
                ImageIn.SetActive(false);
                Floor1_Choices.SetActive(false);
                Floor1.SetActive(false);
                Status.SetActive(false);
            }
            else 
            {
                story = "Normal Ending: You finally got out of the dungeon with your companion \nyou told her she can go home since her town is nearby and is thankful for you and leaves \nyou are left to walk home from a distant town";
                ImageIn.SetActive(false);
                Floor1_Choices.SetActive(false);
                Floor1.SetActive(false);
                Status.SetActive(false);
            }
        }
        else
        {
            story = "Normal Ending: You finally got out of the dungeon and you remembered about the girl you left behind and went back for her \n you found her sleeping in a corner and carried her home behind your back \n you sleep in an inn and the next day she thanks you and wants you to help her with tasks around the town since you are strong what happens next is for another story";
            ImageIn.SetActive(false);
            Floor1_Choices.SetActive(false);
            Floor1.SetActive(false);
            Status.SetActive(false);
        }
    }



}
