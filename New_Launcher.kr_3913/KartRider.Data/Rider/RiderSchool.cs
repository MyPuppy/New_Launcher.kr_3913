using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;
using KartRider;
using ExcData;

namespace RiderData
{
    public static class RiderSchool
    {
        public static void PrStartRiderSchool()
        {
            if (GameType.RiderSchoolType == 186 || GameType.RiderSchoolType == 239 || GameType.RiderSchoolType == 112 || GameType.RiderSchoolType == 255 || GameType.RiderSchoolType == 32 || GameType.RiderSchoolType == 172 || GameType.RiderSchoolType == 127 || GameType.RiderSchoolType == 245 || GameType.RiderSchoolType == 212)
            {
                RiderSchool.PrStartRiderSchool_Speed();
            }
            else if (GameType.RiderSchoolType == 124 || GameType.RiderSchoolType == 137 || GameType.RiderSchoolType == 22 || GameType.RiderSchoolType == 176 || GameType.RiderSchoolType == 181 || GameType.RiderSchoolType == 189 || GameType.RiderSchoolType == 162 || GameType.RiderSchoolType == 87 || GameType.RiderSchoolType == 65)
            {
                RiderSchool.PrStartRiderSchool_Item();
            }
            else
            {
                GameSupport.OnDisconnect();
            }
        }

        public static void PrStartRiderSchool_Speed()
        {
            using (OutPacket oPacket = new OutPacket("PrStartRiderSchool"))
            {
                oPacket.WriteByte(1);
                oPacket.WriteEncFloat(1.15f);
                oPacket.WriteEncInt(2000);
                oPacket.WriteEncFloat(1.15f);
                oPacket.WriteEncInt(500);
                oPacket.WriteEncFloat(300f);
                oPacket.WriteEncByte(2);
                oPacket.WriteEncByte(2);
                oPacket.WriteEncByte(1);
                oPacket.WriteEncByte((byte)((true ? 1 : 0)));
                oPacket.WriteEncByte((byte)((false ? 1 : 0)));
                oPacket.WriteEncFloat(100f);
                oPacket.WriteEncFloat(3f);
                oPacket.WriteEncFloat(0.6735001f);
                oPacket.WriteEncFloat(2296f);
                oPacket.WriteEncFloat(1825f);
                oPacket.WriteEncFloat(2070f);
                oPacket.WriteEncFloat(1415f);
                oPacket.WriteEncFloat(10f);
                oPacket.WriteEncFloat(24.95f);
                oPacket.WriteEncFloat(5f);
                oPacket.WriteEncFloat(5f);
                oPacket.WriteEncFloat(0.2f);
                oPacket.WriteEncFloat(0.2f);
                oPacket.WriteEncFloat(0.2f);
                oPacket.WriteEncFloat(4075f);
                oPacket.WriteEncFloat(0.244f);
                oPacket.WriteEncFloat(0.065f);
                oPacket.WriteEncFloat(0.01f);
                oPacket.WriteEncFloat(3820f);
                oPacket.WriteEncFloat(2890f);
                oPacket.WriteEncFloat(3000f);
                oPacket.WriteEncFloat(4290f);
                oPacket.WriteEncFloat(4000f);
                oPacket.WriteEncFloat(3500f);
                oPacket.WriteEncFloat(1.8375f);
                oPacket.WriteEncFloat(1.494f);
                oPacket.WriteEncFloat(1000f);
                oPacket.WriteEncFloat(1500f);
                oPacket.WriteEncFloat(2296f);
                oPacket.WriteEncFloat(3635f);
                oPacket.WriteEncFloat(0.5f);
                oPacket.WriteEncByte((byte)((false ? 1 : 0)));
                oPacket.WriteEncFloat(1.5f);
                oPacket.WriteEncFloat(0f);
                oPacket.WriteEncFloat(1f);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void PrStartRiderSchool_Item()
        {
            using (OutPacket oPacket = new OutPacket("PrStartRiderSchool"))
            {
                oPacket.WriteByte(1);
                oPacket.WriteEncFloat(1.15f);
                oPacket.WriteEncInt(2000);
                oPacket.WriteEncFloat(1.15f);
                oPacket.WriteEncInt(500);
                oPacket.WriteEncFloat(300f);
                oPacket.WriteEncByte(2);
                oPacket.WriteEncByte(2);
                oPacket.WriteEncByte(2);
                oPacket.WriteEncByte((byte)((true ? 1 : 0)));
                oPacket.WriteEncByte((byte)((false ? 1 : 0)));
                oPacket.WriteEncFloat(100f);
                oPacket.WriteEncFloat(3f);
                oPacket.WriteEncFloat(0.6735f);
                oPacket.WriteEncFloat(2295f);
                oPacket.WriteEncFloat(1825f);
                oPacket.WriteEncFloat(2070f);
                oPacket.WriteEncFloat(1415f);
                oPacket.WriteEncFloat(10f);
                oPacket.WriteEncFloat(24.95f);
                oPacket.WriteEncFloat(5f);
                oPacket.WriteEncFloat(5f);
                oPacket.WriteEncFloat(0.2f);
                oPacket.WriteEncFloat(0.2f);
                oPacket.WriteEncFloat(0.2f);
                oPacket.WriteEncFloat(4000f);
                oPacket.WriteEncFloat(0.244f);
                oPacket.WriteEncFloat(0.065f);
                oPacket.WriteEncFloat(0.01f);
                oPacket.WriteEncFloat(4300f);
                oPacket.WriteEncFloat(3000f);
                oPacket.WriteEncFloat(3000f);
                oPacket.WriteEncFloat(4500f);
                oPacket.WriteEncFloat(4000f);
                oPacket.WriteEncFloat(3500f);
                oPacket.WriteEncFloat(1.7755f);
                oPacket.WriteEncFloat(1.494f);
                oPacket.WriteEncFloat(1400f);
                oPacket.WriteEncFloat(1000f);
                oPacket.WriteEncFloat(3635f);
                oPacket.WriteEncFloat(2295f);
                oPacket.WriteEncFloat(0.5f);
                oPacket.WriteEncByte((byte)((false ? 1 : 0)));
                oPacket.WriteEncFloat(1.5f);
                oPacket.WriteEncFloat(0f);
                oPacket.WriteEncFloat(1f);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }
    }
}