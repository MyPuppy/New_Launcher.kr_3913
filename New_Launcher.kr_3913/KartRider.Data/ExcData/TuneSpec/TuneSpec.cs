using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider;
using Set_Data;

namespace ExcData
{
    public class TuneSpec
    {
        public static float Tune_DragFactor = 0f;
        public static float Tune_ForwardAccelForce = 0f;
        public static float Tune_DriftEscapeForce = 0f;
        public static float Tune_CornerDrawFactor = 0f;
        public static float Tune_DriftMaxGauge = 0f;
        public static float Tune_NormalBoosterTime = 0f;
        public static float Tune_TeamBoosterTime = 0f;
        public static float Tune_TransAccelFactor = 0f;
        public static float Tune_StartBoosterTimeSpeed = 0f;

        public static void Reset_TuneSpec()
        {
            TuneSpec.Tune_DragFactor = 0f;
            TuneSpec.Tune_ForwardAccelForce = 0f;
            TuneSpec.Tune_DriftEscapeForce = 0f;
            TuneSpec.Tune_CornerDrawFactor = 0f;
            TuneSpec.Tune_DriftMaxGauge = 0f;
            TuneSpec.Tune_NormalBoosterTime = 0f;
            TuneSpec.Tune_TeamBoosterTime = 0f;
            TuneSpec.Tune_TransAccelFactor = 0f;
            TuneSpec.Tune_StartBoosterTimeSpeed = 0f;
        }

        public static void Use_TuneSpec()
        {
            TuneSpec.Tune_DragFactor = 0f;
            TuneSpec.Tune_ForwardAccelForce = 0f;
            TuneSpec.Tune_DriftEscapeForce = 0f;
            TuneSpec.Tune_CornerDrawFactor = 0f;
            TuneSpec.Tune_DriftMaxGauge = 0f;
            TuneSpec.Tune_NormalBoosterTime = 0f;
            TuneSpec.Tune_TeamBoosterTime = 0f;
            TuneSpec.Tune_TransAccelFactor = 0f;
            TuneSpec.Tune_StartBoosterTimeSpeed = 0f;
            if (SetRiderItem.Set_Kart == 628 || SetRiderItem.Set_Kart == 631 || SetRiderItem.Set_Kart == 637 || SetRiderItem.Set_Kart == 645 || SetRiderItem.Set_Kart == 648 || SetRiderItem.Set_Kart == 655 || SetRiderItem.Set_Kart == 667 || SetRiderItem.Set_Kart == 669 || SetRiderItem.Set_Kart == 677 || SetRiderItem.Set_Kart == 680 || SetRiderItem.Set_Kart == 688 || SetRiderItem.Set_Kart == 708 || SetRiderItem.Set_Kart == 712 || SetRiderItem.Set_Kart == 741 || SetRiderItem.Set_Kart == 775 || SetRiderItem.Set_Kart == 634 || SetRiderItem.Set_Kart == 672 || SetRiderItem.Set_Kart == 710 || SetRiderItem.Set_Kart == 778)//Type S
            {
                if (SetRiderItem.Set_Kart == 655)
                {
                    TuneSpec.Tune_StartBoosterTimeSpeed = 150f;//스피드전 스타트 부스터 지속 시간 증가 +1
                }
                else if (SetRiderItem.Set_Kart == 677)
                {
                    TuneSpec.Tune_TransAccelFactor = 0.003f;//스피드전에서 변신 부스터 가속도 증가 +1
                    TuneSpec.Tune_StartBoosterTimeSpeed = 150f;//스피드전 스타트 부스터 지속 시간 증가 +1
                }
                else if (SetRiderItem.Set_Kart == 628)
                {
                    TuneSpec.Tune_TransAccelFactor = 0.007f;//스피드전에서 변신 부스터 가속도 증가 +2
                    TuneSpec.Tune_StartBoosterTimeSpeed = 300f;//스피드전 스타트 부스터 지속 시간 증가 +2
                }
                else if (SetRiderItem.Set_Kart == 637 || SetRiderItem.Set_Kart == 667 || SetRiderItem.Set_Kart == 688 || SetRiderItem.Set_Kart == 708 || SetRiderItem.Set_Kart == 775)
                {
                    TuneSpec.Tune_TransAccelFactor = 0.01f;//스피드전에서 변신 부스터 가속도 증가 +3
                    TuneSpec.Tune_StartBoosterTimeSpeed = 700f;//스피드전 스타트 부스터 지속 시간 증가 +3
                }
                else if (SetRiderItem.Set_Kart == 634 || SetRiderItem.Set_Kart == 672 || SetRiderItem.Set_Kart == 710 || SetRiderItem.Set_Kart == 778)//PC방 전용
                {
                    TuneSpec.Tune_TransAccelFactor = 0.01f;//스피드전에서 변신 부스터 가속도 증가 +3
                    TuneSpec.Tune_StartBoosterTimeSpeed = 300f;//스피드전 스타트 부스터 지속 시간 증가 +2
                    TuneSpec.Tune_DragFactor = -0.0008f;//최고 속도 증가 +1
                }
                else if (SetRiderItem.Set_Kart == 631 || SetRiderItem.Set_Kart == 645 || SetRiderItem.Set_Kart == 648 || SetRiderItem.Set_Kart == 669 || SetRiderItem.Set_Kart == 680 || SetRiderItem.Set_Kart == 712 || SetRiderItem.Set_Kart == 741)
                {
                    TuneSpec.Tune_TransAccelFactor = 0.01f;//스피드전에서 변신 부스터 가속도 증가 +3
                    TuneSpec.Tune_StartBoosterTimeSpeed = 700f;//스피드전 스타트 부스터 지속 시간 증가 +3
                    TuneSpec.Tune_DragFactor = -0.0015f;//최고 속도 증가 +2
                }
            }
            else if (SetRiderItem.Set_Kart == 633 || SetRiderItem.Set_Kart == 647 || SetRiderItem.Set_Kart == 650 || SetRiderItem.Set_Kart == 671 || SetRiderItem.Set_Kart == 681 || SetRiderItem.Set_Kart == 719 || SetRiderItem.Set_Kart == 742 || SetRiderItem.Set_Kart == 787) //Type H
            {
                TuneSpec.Tune_StartBoosterTimeSpeed = 700f;//스피드전 스타트 부스터 지속 시간 증가 +3
                TuneSpec.Tune_DriftEscapeForce = 120f;//드리프트 탈출력 증가 +3
                TuneSpec.Tune_TransAccelFactor = 0.007f;//스피드전에서 변신 부스터 가속도 증가 +2
            }
            else if (SetRiderItem.Set_Kart == 700 || SetRiderItem.Set_Kart == 701 || SetRiderItem.Set_Kart == 702 || SetRiderItem.Set_Kart == 703 || SetRiderItem.Set_Kart == 704 || SetRiderItem.Set_Kart == 750 || SetRiderItem.Set_Kart == 751 || SetRiderItem.Set_Kart == 788)//Type C
            {
                TuneSpec.Tune_DriftEscapeForce = 120f;//드리프트 탈출력 증가 +3
                TuneSpec.Tune_TransAccelFactor = 0.007f;//스피드전에서 변신 부스터 가속도 증가 +2
                TuneSpec.Tune_StartBoosterTimeSpeed = 300f;//스피드전 스타트 부스터 지속 시간 증가 +2
            }
            else if (SetRiderItem.Set_Kart == 629 || SetRiderItem.Set_Kart == 632 || SetRiderItem.Set_Kart == 638 || SetRiderItem.Set_Kart == 646 || SetRiderItem.Set_Kart == 649 || SetRiderItem.Set_Kart == 656 || SetRiderItem.Set_Kart == 668 || SetRiderItem.Set_Kart == 670 || SetRiderItem.Set_Kart == 678 || SetRiderItem.Set_Kart == 679 || SetRiderItem.Set_Kart == 689 || SetRiderItem.Set_Kart == 705 || SetRiderItem.Set_Kart == 709 || SetRiderItem.Set_Kart == 718 || SetRiderItem.Set_Kart == 740 || SetRiderItem.Set_Kart == 776 || SetRiderItem.Set_Kart == 635 || SetRiderItem.Set_Kart == 673 || SetRiderItem.Set_Kart == 711 || SetRiderItem.Set_Kart == 779) //Type B
            {
                if (SetRiderItem.Set_Kart == 656)
                {
                    TuneSpec.Tune_DriftMaxGauge = -50f;//스피드전에서 드리프트 게이지 충전량 +1
                }
                else if (SetRiderItem.Set_Kart == 678)
                {
                    TuneSpec.Tune_NormalBoosterTime = 50f;//스피드전에서 부스터 지속 시간 증가 +1
                    TuneSpec.Tune_DriftMaxGauge = -50f;//스피드전에서 드리프트 게이지 충전량 +1
                }
                else if (SetRiderItem.Set_Kart == 629)
                {
                    TuneSpec.Tune_NormalBoosterTime = 100f;//스피드전에서 부스터 지속 시간 증가 +2
                    TuneSpec.Tune_DriftMaxGauge = -80f;//스피드전에서 드리프트 게이지 충전량 +2
                }
                else if (SetRiderItem.Set_Kart == 638 || SetRiderItem.Set_Kart == 668 || SetRiderItem.Set_Kart == 689 || SetRiderItem.Set_Kart == 705 || SetRiderItem.Set_Kart == 709 || SetRiderItem.Set_Kart == 776)
                {
                    TuneSpec.Tune_NormalBoosterTime = 150f;//스피드전에서 부스터 지속 시간 증가 +3
                    TuneSpec.Tune_DriftMaxGauge = -120f;//스피드전에서 드리프트 게이지 충전량 +3
                }
                else if (SetRiderItem.Set_Kart == 635 || SetRiderItem.Set_Kart == 673 || SetRiderItem.Set_Kart == 711 || SetRiderItem.Set_Kart == 779)//PC방 전용
                {
                    TuneSpec.Tune_NormalBoosterTime = 150f;//스피드전에서 부스터 지속 시간 증가 +3
                    TuneSpec.Tune_DriftMaxGauge = -80f;//스피드전에서 드리프트 게이지 충전량 +2
                    TuneSpec.Tune_TransAccelFactor = 0.003f;//스피드전에서 변신 부스터 가속도 증가 +1
                }
                else if (SetRiderItem.Set_Kart == 632 || SetRiderItem.Set_Kart == 646 || SetRiderItem.Set_Kart == 649 || SetRiderItem.Set_Kart == 670 || SetRiderItem.Set_Kart == 679 || SetRiderItem.Set_Kart == 718 || SetRiderItem.Set_Kart == 740)
                {
                    TuneSpec.Tune_NormalBoosterTime = 150f;//스피드전에서 부스터 지속 시간 증가 +3
                    TuneSpec.Tune_DriftMaxGauge = -120f;//스피드전에서 드리프트 게이지 충전량 +3
                    TuneSpec.Tune_TransAccelFactor = 0.007f;//스피드전에서 변신 부스터 가속도 증가 +2
                }
            }
            else
            {
                if (SetRiderItem.Set_KartSN == LauncherSystem.KartOld_SN)
                {
                    if (Program.UseKartTune)
                    {
                        if (SetRiderItem.Set_Kart <= 70 || SetRiderItem.Set_Kart == 232 || SetRiderItem.Set_Kart == 464) //Type A-3
                        {
                            TuneSpec.Tune_NormalBoosterTime = 150f;//스피드전에서 부스터 지속 시간 증가 +3
                            TuneSpec.Tune_DriftMaxGauge = -120f;//스피드전에서 드리프트 게이지 충전량 +3
                            TuneSpec.Tune_ForwardAccelForce = 3f;//가속도 증가 +3
                        }
                        else if (SetRiderItem.Set_Kart == 82 || SetRiderItem.Set_Kart == 95 || SetRiderItem.Set_Kart == 101 || SetRiderItem.Set_Kart == 103 || SetRiderItem.Set_Kart == 111 || SetRiderItem.Set_Kart == 114 || SetRiderItem.Set_Kart == 117 || SetRiderItem.Set_Kart == 210 || SetRiderItem.Set_Kart == 219 || SetRiderItem.Set_Kart == 220 || SetRiderItem.Set_Kart == 265 || SetRiderItem.Set_Kart == 285 || SetRiderItem.Set_Kart == 292 || SetRiderItem.Set_Kart == 358 || SetRiderItem.Set_Kart == 420 || SetRiderItem.Set_Kart == 501) //Type A-2
                        {
                            TuneSpec.Tune_NormalBoosterTime = 150f;//스피드전에서 부스터 지속 시간 증가 +3
                            TuneSpec.Tune_TransAccelFactor = 0.01f;//스피드전에서 변신 부스터 가속도 증가 +3
                            TuneSpec.Tune_DriftEscapeForce = 120f;//드리프트 탈출력 증가 +3
                        }
                        else //Type A-1
                        {
                            TuneSpec.Tune_StartBoosterTimeSpeed = 700f;//스피드전 스타트 부스터 지속 시간 증가 +3
                            TuneSpec.Tune_TransAccelFactor = 0.01f;//스피드전에서 변신 부스터 가속도 증가 +3
                            TuneSpec.Tune_DriftEscapeForce = 120f;//드리프트 탈출력 증가 +3
                        }
                    }
                }
            }
        }
    }
}