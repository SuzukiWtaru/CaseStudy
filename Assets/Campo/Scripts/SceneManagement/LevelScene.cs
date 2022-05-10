using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName =  "New_Level", menuName = "Scene Data/Level")]
public class LevelScene : GameScene
{
    //Settings specific to level only
    [Header("次のシーン"), SerializeField]
    public LevelScene nextScene;
}
