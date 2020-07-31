using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticMng{

    private static StaticMng _instance;
    public static StaticMng Instance
    {
        get
        {
            if (_instance == null)
                _instance = new StaticMng();
            return _instance;
        }
        set
        {
            _instance = value;
        }
    }

    public string _UserId;
    public string _UserPW;

    public string _IpAdress = "104.198.127.225";
    public string _PlayStoreAdress = "https://play.google.com/store/apps/details?id=jhj.WellPlayer.Busking";
    public string _DBIDPW = ";Database=BuskingServer;UserId=root;Password=Jsysb0p5pN1k6wI7;";
    public string _AppVersion = "6";
    public string _UserName;
    public string _NowWantScene;
    public int _Infinity_FastValue;

    //Music
    public float _NowStageMusicPlayTime;
    public float _MusicTimeLineWidth = 710.0f;
    public float _SkillIconInterval = 100.0f;

    public int _NowInfinityBgNumber;

    //Ingame
    public bool _TowerSet_Drag;
    public bool _GameMode_Infinity;
    public int _MonsterCount;
    public int[] _InfinityGameTowerLevel = {1,1,1,1 };

    public bool _CanPlay;//ForPause
    public bool _Tutorialing;
    public bool _LowUI_Down;
    public bool _StartGame;
    public bool _PauseGame;
    public int _PlayerLife;
    public int _InfinityGameScore;
    public int _InfinityScoreIdentity;

    //Tower
    public int _GuitarTowerLevel;
    public int _DrumTowerLevel;
    public int _BassTowerLevel;
    public int _KeyBoardTowerLevel;

    public int _GuitarTowerRank;
    public int _DrumTowerRank;
    public int _BassTowerRank;
    public int _KeyBoardTowerRank;

    public int _TowerMaximumLevel = 10;

    //Public
    public int _Gold;
    public int _Gem;
    public int _Player_MaxExp = 4;
    public int _Player_NowExp;
    public int _Player_Level;
    public float _Option_Volume;
    public bool _Option_Volume_Bool;

    public int _Stage_Chapter;
    public int _Stage_Sector;

    public int _UnLock_Chapter;
    public int[] _UnLock_Sector = new int[4];

    public int _MaximumChapter = 4;
    public int[] _MaximumSector = { 10, 10, 10, 10 };
    public int[,] _StagePeakCount = new int[4, 10];
    public int[] _NeedPassPeakCount = {25,28,30 };

    //Shop
    public int[] _GoldShop_Price = { 10, 50, 100, 500 };
    public int[] _GoldShop_Reward = { 10000, 50000, 100000, 500000  };

    //Achievement
    public int _MaxAchievementCount = 11;
    public List<string> _Achive_Name = new List<string>();
    public List<string> _Achive_Explanation = new List<string>();
    public List<int> _Achive_NowValue = new List<int>();
    public List<int> _Achive_MaxValue = new List<int>();
    public List<int> _Achive_ClearCheck = new List<int>();
    public List<int> _Achive_Reward = new List<int>();
    public List<string> _Achive_RewardInfo = new List<string>();
}
