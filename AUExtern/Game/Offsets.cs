using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUExtern
{
    internal class Offsets
    {
        /// <summary>
        /// The struct the holds localplayer, all players, and game options.
        /// </summary>
        public const string Main = "GameAssembly.dll+01D10144,5C";

        //Main
        public const string _LocalPlayer = ",10";
        public const string _GameOptions = ",14";
        public const string _AllPlayers = ",18";

        //Player 
        public const string _PlayerNameText = ",70,80";
        public const string _PlayerLightHits = ",78,28,0C";
        public const string _PlayerLightRad = ",78,1C";
        public const string NoClip = ",7C,08,20";
        public const string _PlayerShifting = ",4E";
        public const string _PlayerSpeed = ",80,30";
        public const string _PlayerGhostSpeed = ",80,34";


        //PlayerData 
        public const string _PlayerData = ",50";
        public const string _DataLevel = ",18";
        public const string _DataRoleRole = ",20,0C";
        public const string _DataIsDead = ",28";
        public const string _DataPlayerID = ",08";


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
        public const string GetUnlockedPets = "GameAssembly.dll+7B560B";
        public const string GetUnlockedHats = "GameAssembly.dll+7B550B";
        public const string GetUnlockedPlates = "GameAssembly.dll+7B559B";
        public const string GetUnlockedSkins = "GameAssembly.dll+7B567B";
        public const string GetUnlockedVisors = "GameAssembly.dll+7B56EB";

        public const string Get_ChatModeType = "GameAssembly.dll+57BE33";

        public const string Anti_Fullbright = "GameAssembly.dll+419C33";

        //Normal:je     See All Chats:jmp    74->EB
        public const string CanSeeGhostChat = "GameAssembly.dll+27FD90";


        public const string CanSeeGhosts = "GameAssembly.dll+419BA8";
    }
}
