using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = Database;



namespace AUExtern
{
    internal class Offsets
    {
        /// <summary>
        /// The struct the holds localplayer, all players, and game options.
        /// </summary>
        public const string Main = "GameAssembly.dll+01D1C5E0,5C";

        //Main
        public const string _LocalPlayer = ",10";
        public const string _GameOptions = ",14";
        public const string _AllPlayers = ",18";


        //SaveController
        public const string _GlobalLevel = "GameAssembly.dll+01DFB67C,50,F78";

        //Player 
        public const string _PlayerNameText = D.PlayerControl.cosmetics + D.CosmeticsLayer.nameText + D.TMPText.mtext;
        public const string _PlayerLightHits = D.PlayerControl.myLight + D.LightSource.hits + D.ArrayList.size;
        public const string _PlayerLightRad = D.PlayerControl.myLight + D.LightSource.LightRadius;
        public const string NoClip = D.PlayerControl.Collider + ",8,20";
        public const string _PlayerShifting = D.PlayerControl.shapeshifting;
        public const string _PlayerSpeed = D.PlayerControl.MyPhysics + D.PlayerPhysics.Speed;
        public const string _PlayerGhostSpeed = D.PlayerControl.MyPhysics + D.PlayerPhysics.GhostSpeed;



        //PlayerData 
        public const string _PlayerData = D.PlayerControl.cachedData;
        public const string _DataLevel = D.PlayerInfo.PlayerLevel;
        public const string _DataRoleRole = D.PlayerInfo.Role + D.RoleBehaviour.Role;
        public const string _DataIsDead = D.PlayerInfo.IsDead;
        public const string _DataPlayerID = D.PlayerInfo.PlayerId;


        //GameOptions
        public const string G_PlayerSpeedMod = ",08";
        public const string G_KillDistance = ",0C";
        public const string G_Killcooldown = ",10";
        public const string G_numCommonTasks = ",14";
        public const string G_numLongTasks = ",18";
        public const string G_numShortTasks = ",1C";
        public const string G_numImposters = ",20";
        public const string G_isDefault = ",24";
        public const string G_MaxPlayers = ",28";
        public const string G_MapID = ",30";
        public const string G_numEmergencyMeetings = ",34";
        public const string G_EmergencyCooldown = ",38";
        public const string G_ghostsDoTasks = ",3C";
        public const string G_DiscusstionTime = ",40";
        public const string G_VoteTime = ",44";
        public const string G_CrewLightMod = ",48";
        public const string G_ImpLightMod = ",4C";
        public const string G_ConfirmImposter = ",50";
        public const string G_VisualTasks = ",51";
        public const string G_AnonymousVotes = ",52";
        public const string G_TaskBarMode = ",54";
        public const string G_gameType = ",5C";
        //GameOptions => RoleOptions
        public const string G_ShifterLeaveSkin = ",58,8";
        public const string G_ShifterCooldown = ",58,0C";
        public const string G_ShifterDuration = ",58,10";
        public const string G_ScientistCooldown = ",58,14";
        public const string G_ScientistBatteryCharge = ",58,18";
        public const string G_GaurdianAngelCooldown = ",58,1C";
        public const string G_ImpostersCanSeeProtect = ",58,20";
        public const string G_ProtectionDuration = ",58,24";
        public const string G_EngineerCooldown = ",5828";
        public const string G_EngineerVentMaxTime = ",58,2C";
 



        //Text
        public const string _TextLength = ",8";
        public const string _TextString = ",C";



        //ListStuff
        public const string _ListItems = ",8";
        public const string _ListCount = ",C";


        //Function Pointers
        public const string GetUnlockedPets = "GameAssembly.dll+57386B";//
        public const string GetUnlockedHats = "GameAssembly.dll+57376B";//UPDATE
        public const string GetUnlockedPlates = "GameAssembly.dll+5737FB";//
        public const string GetUnlockedSkins = "GameAssembly.dll+5738DB";//
        public const string GetUnlockedVisors = "GameAssembly.dll+57394B";//


        //SaveManager.get_ChatModeType
        public const string Get_ChatModeType = "GameAssembly.dll+7C9253";//


        public const string Anti_Fullbright = "GameAssembly.dll+5D5773";//

        //Normal:je     See All Chats:jmp    74->EB
        public const string CanSeeGhostChat = "N/A";

        //PlayerControl.set_Visible
        public const string CanSeeGhosts = "GameAssembly.dll+5DD268";//
    }
}
