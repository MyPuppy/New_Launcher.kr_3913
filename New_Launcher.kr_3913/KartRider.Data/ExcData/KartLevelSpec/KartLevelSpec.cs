using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider;
using Set_Data;

namespace ExcData
{
    public class KartLevelSpec
    {
        public static float KartLevel_ForwardAccelForce = 0f;
        public static float KartLevel_CornerDrawFactor = 0f;
        public static float KartLevel_DriftEscapeForce = 0f;
        public static float KartLevel_StartBoosterTimeItem = 0f;
        public static float KartLevel_StartBoosterTimeSpeed = 0f;
        public static float KartLevel_TransAccelFactor = 0f;

        public static void Reset_KartLevelSpec()
        {
            KartLevelSpec.KartLevel_ForwardAccelForce = 0f;
            KartLevelSpec.KartLevel_CornerDrawFactor = 0f;
            KartLevelSpec.KartLevel_DriftEscapeForce = 0f;
            KartLevelSpec.KartLevel_StartBoosterTimeItem = 0f;
            KartLevelSpec.KartLevel_StartBoosterTimeSpeed = 0f;
            KartLevelSpec.KartLevel_TransAccelFactor = 0f;
        }

        public static void Use_KartLevelSpec()
        {
            KartLevelSpec.KartLevel_ForwardAccelForce = 0f;
            KartLevelSpec.KartLevel_CornerDrawFactor = 0f;
            KartLevelSpec.KartLevel_DriftEscapeForce = 0f;
            KartLevelSpec.KartLevel_StartBoosterTimeItem = 0f;
            KartLevelSpec.KartLevel_StartBoosterTimeSpeed = 0f;
            KartLevelSpec.KartLevel_TransAccelFactor = 0f;
            if (SetRiderItem.Set_KartSN == LauncherSystem.KartOld_SN)
            {
                if (Program.UseKartLevel)
                {
                    KartLevelSpec.KartLevel_ForwardAccelForce = 1.5f;
                    KartLevelSpec.KartLevel_CornerDrawFactor = 0.0005f;
                    KartLevelSpec.KartLevel_DriftEscapeForce = 50f;
                    KartLevelSpec.KartLevel_StartBoosterTimeItem = 100f;
                    KartLevelSpec.KartLevel_StartBoosterTimeSpeed = 100f;
                    KartLevelSpec.KartLevel_TransAccelFactor = 0.005f;
                }
            }
        }
    }
}