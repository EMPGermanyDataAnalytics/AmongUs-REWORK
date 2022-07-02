using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace AUExtern
{
    internal class Game
    {
        Mem mem
        {
            get
            {
                return Mem.m;
            }
        }
    }
    public class HatManager
    {
        public static FUNCTION getPets = new FUNCTION(Offsets.GetUnlockedPets,2);
        public static FUNCTION getHats = new FUNCTION(Offsets.GetUnlockedHats, 2);
        public static FUNCTION getPlates = new FUNCTION(Offsets.GetUnlockedPlates, 2);
        public static FUNCTION getSkins = new FUNCTION(Offsets.GetUnlockedSkins, 2);
        public static FUNCTION getVisors = new FUNCTION(Offsets.GetUnlockedVisors, 2);
    }

    public class SaveManager
    {
        public static FUNCTION Get_ChatModeType = new FUNCTION(Offsets.Get_ChatModeType, 2);
        public static int Level
        {
            get
            {
               return Mem.m.ReadInt(Offsets._GlobalLevel);
            }
            set
            {
                Mem.m.WriteMemory(Offsets._GlobalLevel,"int",value.ToString());
            }
        }
    }

    public class Vector2
    {
        public float x;
        public float y;
        public Vector2(float x, float y) 
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x:{x.ToString()} y:{y.ToString()}";
        }
    }


    public class PlayerControl
    {
        public static PlayerControl localPlayer
        {
            get
            {
                return new PlayerControl(Offsets.Main + Offsets._LocalPlayer);
            }
        }
        public static List<PlayerControl> allPlayerControls
        {
            get
            {
                List<PlayerControl> list = new List<PlayerControl>();
                int count = Mem.m.ReadInt(Offsets.Main + Offsets._AllPlayers + Offsets._ListCount);

                for (int i = 0; i < count; i++)
                {
                    string offset = Convert.ToString(0x10 + (0x4 * i), 16);
                    list.Add(new PlayerControl(Offsets.Main + Offsets._AllPlayers + Offsets._ListItems + "," + offset));
                }
                return list;
            }
        }


        public static Vector2 localPosition
        {
            get
            {
                float x = Mem.m.ReadFloat(Offsets.localPosX);
                float y = Mem.m.ReadFloat(Offsets.localPosY);
                return new Vector2(x, y);
            }
            set
            {
                Mem.m.WriteMemory(Offsets.localPosX,"float",value.x.ToString());
                Mem.m.WriteMemory(Offsets.localPosY, "float", value.y.ToString());
            }
        }


        public static FUNCTION AntiFullbright = new FUNCTION(Offsets.Anti_Fullbright,5);
        public static FUNCTION SeeGhosts = new FUNCTION(Offsets.CanSeeGhosts,5);
        //public static FUNCTION SeeGhostChat = new FUNCTION(Offsets.CanSeeGhostChat, 5);

        public string address;
        public string nickname
        {
            get
            {
                int length = 2 * Mem.m.ReadInt(address + Offsets._PlayerNameText + Offsets._TextLength);
                return Mem.m.ReadString(address + Offsets._PlayerNameText + Offsets._TextString,length:length, stringEncoding: Encoding.Unicode);
            }
            set
            {
                Mem.m.WriteMemory(address + Offsets._PlayerNameText + Offsets._TextString,"string",value.ToString(),value.Length,stringEncoding:Encoding.Unicode);
                Mem.m.WriteMemory(address + Offsets._PlayerNameText + Offsets._TextLength,"int",value.Length.ToString());
            }
        }

        public Vector2 position
        {
            get
            {
                float x = Mem.m.ReadFloat(address + Offsets._PlayerPosVecX);
                float y = Mem.m.ReadFloat(address + Offsets._PlayerPosVecY);
                return new Vector2(x,y);
            }
        }



        public bool Host
        {
            get
            {
                if(Mem.m.ReadInt(address + Offsets._PlayerData + Offsets._DataPlayerID) == 0)
                {
                    return true;
                }
                return false;
            }
        }
        public bool IsDead
        {
            get
            {
                int dead = Mem.m.ReadInt(address + Offsets._PlayerData + Offsets._DataIsDead);
                switch (dead)
                {
                    case 0: { return false; }
                    case 1: { return true; }
                }
                return false;
            }
        }
        public float Speed
        {
            get
            {
                if (this.IsDead)
                {
                    return Mem.m.ReadFloat(address + Offsets._PlayerGhostSpeed);
                }
                return Mem.m.ReadFloat(address + Offsets._PlayerSpeed);
            }
            set
            {
                if (this.IsDead)
                {
                    Mem.m.WriteMemory(address + Offsets._PlayerGhostSpeed,"float",value.ToString());
                }
                else
                {
                    Mem.m.WriteMemory(address + Offsets._PlayerSpeed, "float", value.ToString());
                }
            }
        }
        public bool ShapeShifting
        {
            get
            {
                if(Mem.m.ReadInt(address + Offsets._PlayerShifting) == 1)
                {
                    return true;
                }
                return false;
            }
        }
        public int Level
        {
            get
            {
                return Mem.m.ReadInt(address + Offsets._PlayerData + Offsets._DataLevel);
            }
            set
            {
                Mem.m.WriteMemory(address + Offsets._PlayerData + Offsets._DataLevel,"int",value.ToString());
            }
        }
        public string role
        {
            get
            {
                int roleint = Mem.m.ReadInt(address+Offsets._PlayerData+Offsets._DataRoleRole);
                return Enum.GetNames(typeof(ROLE))[roleint];
            }
        }

        public ROLE RawRole
        {
            get
            {
                int roleint = Mem.m.ReadInt(address + Offsets._PlayerData + Offsets._DataRoleRole);
                return (ROLE)Enum.GetValues(typeof(ROLE)).GetValue(roleint);
            }
        }
        public float LightRadius
        {
            set
            {
                Mem.m.WriteMemory(address + Offsets._PlayerLightRad, "float", value.ToString());
            }
            get
            {
                return Mem.m.ReadFloat(address + Offsets._PlayerLightRad);
            }
        }
        public int LightHits
        {
            set
            {
                Mem.m.WriteMemory(address + Offsets._PlayerLightHits,"int",value.ToString());
            }
            get
            {
                return Mem.m.ReadInt(address + Offsets._PlayerLightHits);
            }
        }
        public void ToggleNoclip(bool value)
        {
            if (value){
                Mem.m.WriteMemory(address + Offsets.NoClip, "int", "0");
            }else{
                Mem.m.WriteMemory(address + Offsets.NoClip, "int", "257");
            }
            

        }
        public void ToggleFB(bool value)
        {
            if (value){
                //On
                AntiFullbright.NOP();
                LightHits = 0;
                LightRadius = 40;
            }else{
                //Off
                //AntiFullbright.Revert(); REMOVED DUE TO ISSUES WITH REFLECTION
                LightHits = 100;
                LightRadius = 5;
            }
        }

        public void ResetSpeed()
        {

           PlayerControl.localPlayer.Speed = Mem.m.ReadFloat(Offsets.Main + Offsets._GameOptions + Offsets.G_PlayerSpeedMod);
        }
        public PlayerControl(string address)
        {
            this.address = address;
        }
    }

    public enum ROLE
    {
        Crewmate,
        Imposter,
        Scientist,
        Engineer,
        Guardian_Angel,
        Shapeshifter
    }

    public class FUNCTION
    {
        public string address;
        private int length;
        private byte[] oldBytes;
        public bool nop_d = false;

        public byte[] hack = null;

        /// <summary>
        /// Replaces (length) bytes starting at (address) with 0x90 (NOP).
        /// </summary>
        public void NOP()
        {
            if (nop_d == false)
            {
                byte[] temp = new byte[length];
                for (int i = 0; i < length; i++)
                {
                    temp[i] = 0x90;
                }
                Mem.m.WriteBytes(address, temp);
                nop_d = true;
            }
        }


        public void SetHack()
        {
            if(hack != null)
            {
                WriteBytes(hack);
            }
        }

        public void WriteBytes(byte[] bytes)
        {
            for(int i = 0; i < length; i++)
            {
                if(!(i > bytes.Length))
                {
                    Mem.m.WriteMemory(address,"byte",bytes[i].ToString("X"));
                }
                else
                {
                    Mem.m.WriteMemory(address, "byte","90");
                }
            }
        }

        /// <summary>
        /// Reverts to original bytes.
        /// </summary>
        public void Revert()
        {
            if (nop_d == true)
            {
                Mem.m.WriteBytes(address, oldBytes);
                nop_d = false;
            }
        }

        /// <summary>
        /// Various tools for external functions.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="length"></param>
        public FUNCTION(string code,int length,byte[] hack = null)
        {
            this.address = code;
            this.length = length;
            oldBytes = Mem.m.ReadBytes(code,length);
            if(hack != null)
            {
                this.hack = hack;
            }
        }
    }


    public class ASM_Compiler_x86
    {
        public static byte[] Compile(string opcode, IntPtr start, IntPtr end)
        {
            List<byte> bytes = new List<byte>();
            string[] ops = opcode.Split(' ');
            foreach(string op in ops)
            {
               bytes.Add((byte)Enum.Parse(typeof(Opcodes),op,true));
            }
            byte[] jmpBytes;
            if (start != IntPtr.Zero && end != IntPtr.Zero)
            {
                jmpBytes = GetJmpBytes(start,end,ops.Count() / 2);
                bytes.AddRange(jmpBytes);
            }

            return bytes.ToArray();
        }



        public static byte[] GetJmpBytes(IntPtr start,IntPtr end,int jmpLength = 0x5)
        {
            IntPtr realStart = start + jmpLength;
            string bytes_to_jump_in_hex = (end.ToInt32() - start.ToInt32()).ToString("X");
            return to_byteArray(bytes_to_jump_in_hex);
        }


        public static byte[] to_byteArray(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < hex.Length; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public enum Opcodes
        {
            call = 0xE8,
            jmp = 0xE9,
            jb = 0x72,
            je = 0x74,
            mov = 0x8B,
            add = 0x03,
            cmp = 0x3B,
            xor = 0x33,
            ret = 0xC3,
            test = 0x8,
            sub = 0x2B
        }
    }
}
