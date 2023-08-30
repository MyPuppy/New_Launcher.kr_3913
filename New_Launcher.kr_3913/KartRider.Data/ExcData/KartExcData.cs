using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider;
using KartRider.IO;
using RiderData;

namespace ExcData
{
    public static class KartExcData
    {
        public static void Kart_ExcData()
        {
            int TuneCount = NewRider.Kart_Old_Cut;
            int PlantCount = NewRider.Kart_Old_Cut;
            int KartLevelCount = NewRider.Kart_Old_Cut;
            short KartSN = LauncherSystem.KartOld_SN;

            if (Program.UseKartTune)
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteInt(TuneCount);
                    for (short i = 1; i <= NewRider.MaxKart; i++)
                    {
                        if (i <= 25 || i == 27 || i == 29 || i == 45 || i == 54 || i == 59 ||
                            i == 63 || i == 70 || i == 82 || i == 95 || i == 101 || i == 103 || i == 111 || i == 114 || i == 117 || i == 210 || i == 219 || i == 220 || i == 232 || i == 265 || i == 285 ||
                            i == 292 || i == 302 || i == 311 || i == 326 || i == 357 || i == 358 || i == 361 || i == 371 || i == 378 || i == 382 || i == 420 || i == 429 || i == 433 || i == 436 || i == 437 ||
                            i == 439 || i == 453 || i == 458 || i == 459 || i == 464 || i == 473 || i == 481 || i == 484 || i == 501 || i == 510 || i == 517 || i == 531 || i == 543 || i == 550 || i == 559 ||
                            i == 564 || i == 566 || i == 574 || i == 596 || i == 597 || i == 602 || i == 604 || i == 606 || i == 608 || i == 611 || i == 619 || i == 620 || i == 624 || i == 627 || i == 628 ||
                            i == 629 || i == 630 || i == 631 || i == 632 || i == 633 || i == 636 || i == 637 || i == 638 || i == 639 || i == 643 || i == 644 || i == 645 || i == 646 || i == 647 || i == 648 ||
                            i == 649 || i == 650 || i == 654 || i == 655 || i == 656 || i == 660 || i == 661 || i == 662 || i == 663 || i == 664 || i == 666 || i == 667 || i == 668 || i == 669 || i == 670 ||
                            i == 671 || i == 677 || i == 678 || i == 679 || i == 680 || i == 681 || i == 682 || i == 683 || i == 684 || i == 686 || i == 688 || i == 689 || i == 700 || i == 701 || i == 702 ||
                            i == 703 || i == 704 || i == 705 || i == 706 || i == 707 || i == 708 || i == 709 || i == 712 || i == 718 || i == 719 || i == 720 || i == 737 || i == 738 || i == 739 || i == 740 ||
                            i == 741 || i == 742 || i == 750 || i == 751 || i == 757 || i == 764 || i == 769 || i == 770 || i == 771 || i == 772 || i == 773 || i == 774 || i == 775 || i == 776 || i == 780 ||
                            i == 787 || i == 788 || i == 794 || i == 795 || i == 796 || i == 797 || i == 800 || i == 801 || i == 805 || i == 806 || i == 808 || i == 811 || i == 813 || i == 824 || i == 827 ||
                            i == 828 || i == 829 || i == 830 || i == 832 || i == 833 || i == 835 || i == 837 || i == 838 || i == 839 || i == 840 || i == 841 || i == 843 || i == 844 || i == 845 || i == 846 ||
                            i == 847 || i == 849 || i == 850 || i == 851 || i == 852 || i == 853 || i == 854 || i == 855 || i == 856 || i == 857 || i == 858 || i == 859 || i == 861 || i == 863 || i == 864 ||
                            i == 865 || i == 866 || i == 867 || i == 868 || i == 869 || i == 872 || i == 873 || i == 874 || i == 875 || i == 877 || i == 878 || i == 879 || i == 880 || i == 882 || i == 883 ||
                            i == 884 || i == 885 || i == 887 || i == 888 || i == 889 || i == 890 || i == 891 || i == 894 || i == 896 || i == 900 || i == 901 || i == 902 || i == 905 || i == 906 || i == 907 ||
                            i == 914 || i == 915 || i == 916 || i == 917 || i == 918 || i == 919 || i == 921 || i == 922 || i == 927 || i == 930 || i == 931 || i == 932 || i == 935 || i == 937 || i == 939 ||
                            i == 940 || i == 941 || i == 942 || i == 943 || i == 944 || i == 946 || i == 947 || i == 948 || i == 949 || i == 950 || i == 951 || i == 954 || i == 955 || i == 956 || i == 961 ||
                            i == 962 || i == 963 || i == 967 || i == 971 || i == 977 || i == 998 || i == 999 || i == 1003 || i == 1004 || i == 1005 || i == 1006 || i == 1007 || i == 1008 || i == 1009 || i == 1010 ||
                            i == 1013 || i == 1014 || i == 1015 || i == 1017)
                        {
                            oPacket.WriteShort(3);
                            oPacket.WriteShort(i);
                            oPacket.WriteShort(KartSN);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            if (i == 628 || i == 631 || i == 637 || i == 645 || i == 648 || i == 655 || i == 667 || i == 669 || i == 677 || i == 680 || i == 688 || i == 708 || i == 712 || i == 741 || i == 775 || i == 634 || i == 672 || i == 710 || i == 778)//Type S
                            {
                                if (i == 655)
                                {
                                    oPacket.WriteShort(601);//스피드전 스타트 부스터 지속 시간 증가 +1
                                    oPacket.WriteShort(0);
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 677)
                                {
                                    oPacket.WriteShort(701);//스피드전에서 변신 부스터 가속도 증가 +1
                                    oPacket.WriteShort(601);//스피드전 스타트 부스터 지속 시간 증가 +1
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 628)
                                {
                                    oPacket.WriteShort(702);//스피드전에서 변신 부스터 가속도 증가 +2
                                    oPacket.WriteShort(602);//스피드전 스타트 부스터 지속 시간 증가 +2
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 637 || i == 667 || i == 688 || i == 708 || i == 775)
                                {
                                    oPacket.WriteShort(703);//스피드전에서 변신 부스터 가속도 증가 +3
                                    oPacket.WriteShort(603);//스피드전 스타트 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 634 || i == 672 || i == 710 || i == 778)//PC방 전용
                                {
                                    oPacket.WriteShort(703);//스피드전에서 변신 부스터 가속도 증가 +3
                                    oPacket.WriteShort(602);//스피드전 스타트 부스터 지속 시간 증가 +2
                                    oPacket.WriteShort(101);//최고 속도 증가 +1
                                }
                                else if (i == 631 || i == 645 || i == 648 || i == 669 || i == 680 || i == 712 || i == 741)
                                {
                                    oPacket.WriteShort(703);//스피드전에서 변신 부스터 가속도 증가 +3
                                    oPacket.WriteShort(603);//스피드전 스타트 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(102);//최고 속도 증가 +2
                                }
                            }
                            else if (i == 633 || i == 647 || i == 650 || i == 671 || i == 681 || i == 719 || i == 742 || i == 787) //Type H
                            {
                                oPacket.WriteShort(603);//스피드전 스타트 부스터 지속 시간 증가 +3
                                oPacket.WriteShort(903);//드리프트 탈출력 증가 +3
                                oPacket.WriteShort(702);//스피드전에서 변신 부스터 가속도 증가 +2
                            }
                            else if (i == 700 || i == 701 || i == 702 || i == 703 || i == 704 || i == 750 || i == 751 || i == 788)//Type C
                            {
                                oPacket.WriteShort(903);//드리프트 탈출력 증가 +3
                                oPacket.WriteShort(702);//스피드전에서 변신 부스터 가속도 증가 +2
                                oPacket.WriteShort(602);//스피드전 스타트 부스터 지속 시간 증가 +2
                            }
                            else if (i == 629 || i == 632 || i == 638 || i == 646 || i == 649 || i == 656 || i == 668 || i == 670 || i == 678 || i == 679 || i == 689 || i == 705 || i == 709 || i == 718 || i == 740 || i == 776 || i == 635 || i == 673 || i == 711 || i == 779) //Type B
                            {
                                if (i == 656)
                                {
                                    oPacket.WriteShort(801);//스피드전에서 드리프트 게이지 충전량 +1
                                    oPacket.WriteShort(0);
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 678)
                                {
                                    oPacket.WriteShort(501);//스피드전에서 부스터 지속 시간 증가 +1
                                    oPacket.WriteShort(801);//스피드전에서 드리프트 게이지 충전량 +1
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 629)
                                {
                                    oPacket.WriteShort(502);//스피드전에서 부스터 지속 시간 증가 +2
                                    oPacket.WriteShort(802);//스피드전에서 드리프트 게이지 충전량 +2
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 638 || i == 668 || i == 689 || i == 705 || i == 709 || i == 776)
                                {
                                    oPacket.WriteShort(503);//스피드전에서 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(803);//스피드전에서 드리프트 게이지 충전량 +3
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 635 || i == 673 || i == 711 || i == 779)//PC방 전용
                                {
                                    oPacket.WriteShort(503);//스피드전에서 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(802);//스피드전에서 드리프트 게이지 충전량 +2
                                    oPacket.WriteShort(701);//스피드전에서 변신 부스터 가속도 증가 +1
                                }
                                else if (i == 632 || i == 646 || i == 649 || i == 670 || i == 679 || i == 718 || i == 740)
                                {
                                    oPacket.WriteShort(503);//스피드전에서 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(803);//스피드전에서 드리프트 게이지 충전량 +3
                                    oPacket.WriteShort(702);//스피드전에서 변신 부스터 가속도 증가 +2
                                }
                            }
                            else if (i <= 70 || i == 232 || i == 464) //Type A-3
                            {
                                oPacket.WriteShort(503);//스피드전에서 부스터 지속 시간 증가 +3
                                oPacket.WriteShort(803);//스피드전에서 드리프트 게이지 충전량 +3
                                oPacket.WriteShort(203);//가속도 증가 +3
                            }
                            else if (i == 82 || i == 95 || i == 101 || i == 103 || i == 111 || i == 114 || i == 117 || i == 210 || i == 219 || i == 220 || i == 265 || i == 285 || i == 292 || i == 358 || i == 420 || i == 501) //Type A-2
                            {
                                oPacket.WriteShort(503);//스피드전에서 부스터 지속 시간 증가 +3
                                oPacket.WriteShort(703);//스피드전에서 변신 부스터 가속도 증가 +3
                                oPacket.WriteShort(903);//드리프트 탈출력 증가 +3
                            }
                            else //Type A-1
                            {
                                oPacket.WriteShort(603);//스피드전 스타트 부스터 지속 시간 증가 +3
                                oPacket.WriteShort(703);//스피드전에서 변신 부스터 가속도 증가 +3
                                oPacket.WriteShort(903);//드리프트 탈출력 증가 +3
                            }
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                        }
                    }
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
            else
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteInt(47);
                    for (short i = 1; i <= NewRider.MaxKart; i++)
                    {
                        if (i == 628 || i == 629 || i == 631 || i == 632 || i == 633 || i == 637 || i == 638 || i == 645 || i == 646 || i == 647 ||
                            i == 648 || i == 649 || i == 650 || i == 655 || i == 656 || i == 667 || i == 668 || i == 669 || i == 670 || i == 671 ||
                            i == 677 || i == 678 || i == 679 || i == 680 || i == 681 || i == 688 || i == 689 || i == 700 || i == 701 || i == 702 ||
                            i == 703 || i == 704 || i == 705 || i == 708 || i == 709 || i == 712 || i == 718 || i == 719 || i == 740 || i == 741 || 
                            i == 742 || i == 750 || i == 751 || i == 775 || i == 776 || i == 787 || i == 788)
                        {
                            oPacket.WriteShort(3);
                            oPacket.WriteShort(i);
                            oPacket.WriteShort(KartSN);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            if (i == 628 || i == 631 || i == 637 || i == 645 || i == 648 || i == 655 || i == 667 || i == 669 || i == 677 || i == 680 || i == 688 || i == 708 || i == 712 || i == 741 || i == 775 || i == 634 || i == 672 || i == 710 || i == 778)//Type S
                            {
                                if (i == 655)
                                {
                                    oPacket.WriteShort(601);//스피드전 스타트 부스터 지속 시간 증가 +1
                                    oPacket.WriteShort(0);
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 677)
                                {
                                    oPacket.WriteShort(701);//스피드전에서 변신 부스터 가속도 증가 +1
                                    oPacket.WriteShort(601);//스피드전 스타트 부스터 지속 시간 증가 +1
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 628)
                                {
                                    oPacket.WriteShort(702);//스피드전에서 변신 부스터 가속도 증가 +2
                                    oPacket.WriteShort(602);//스피드전 스타트 부스터 지속 시간 증가 +2
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 637 || i == 667 || i == 688 || i == 708 || i == 775)
                                {
                                    oPacket.WriteShort(703);//스피드전에서 변신 부스터 가속도 증가 +3
                                    oPacket.WriteShort(603);//스피드전 스타트 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 634 || i == 672 || i == 710 || i == 778)//PC방 전용
                                {
                                    oPacket.WriteShort(703);//스피드전에서 변신 부스터 가속도 증가 +3
                                    oPacket.WriteShort(602);//스피드전 스타트 부스터 지속 시간 증가 +2
                                    oPacket.WriteShort(101);//최고 속도 증가 +1
                                }
                                else if (i == 631 || i == 645 || i == 648 || i == 669 || i == 680 || i == 712 || i == 741)
                                {
                                    oPacket.WriteShort(703);//스피드전에서 변신 부스터 가속도 증가 +3
                                    oPacket.WriteShort(603);//스피드전 스타트 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(102);//최고 속도 증가 +2
                                }
                            }
                            else if (i == 633 || i == 647 || i == 650 || i == 671 || i == 681 || i == 719 || i == 742 || i == 787) //Type H
                            {
                                oPacket.WriteShort(603);//스피드전 스타트 부스터 지속 시간 증가 +3
                                oPacket.WriteShort(903);//드리프트 탈출력 증가 +3
                                oPacket.WriteShort(702);//스피드전에서 변신 부스터 가속도 증가 +2
                            }
                            else if (i == 700 || i == 701 || i == 702 || i == 703 || i == 704 || i == 750 || i == 751 || i == 788)//Type C
                            {
                                oPacket.WriteShort(903);//드리프트 탈출력 증가 +3
                                oPacket.WriteShort(702);//스피드전에서 변신 부스터 가속도 증가 +2
                                oPacket.WriteShort(602);//스피드전 스타트 부스터 지속 시간 증가 +2
                            }
                            else if (i == 629 || i == 632 || i == 638 || i == 646 || i == 649 || i == 656 || i == 668 || i == 670 || i == 678 || i == 679 || i == 689 || i == 705 || i == 709 || i == 718 || i == 740 || i == 776 || i == 635 || i == 673 || i == 711 || i == 779) //Type B
                            {
                                if (i == 656)
                                {
                                    oPacket.WriteShort(801);//스피드전에서 드리프트 게이지 충전량 +1
                                    oPacket.WriteShort(0);
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 678)
                                {
                                    oPacket.WriteShort(501);//스피드전에서 부스터 지속 시간 증가 +1
                                    oPacket.WriteShort(801);//스피드전에서 드리프트 게이지 충전량 +1
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 629)
                                {
                                    oPacket.WriteShort(502);//스피드전에서 부스터 지속 시간 증가 +2
                                    oPacket.WriteShort(802);//스피드전에서 드리프트 게이지 충전량 +2
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 638 || i == 668 || i == 689 || i == 705 || i == 709 || i == 776)
                                {
                                    oPacket.WriteShort(503);//스피드전에서 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(803);//스피드전에서 드리프트 게이지 충전량 +3
                                    oPacket.WriteShort(0);
                                }
                                else if (i == 635 || i == 673 || i == 711 || i == 779)//PC방 전용
                                {
                                    oPacket.WriteShort(503);//스피드전에서 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(802);//스피드전에서 드리프트 게이지 충전량 +2
                                    oPacket.WriteShort(701);//스피드전에서 변신 부스터 가속도 증가 +1
                                }
                                else if (i == 632 || i == 646 || i == 649 || i == 670 || i == 679 || i == 718 || i == 740)
                                {
                                    oPacket.WriteShort(503);//스피드전에서 부스터 지속 시간 증가 +3
                                    oPacket.WriteShort(803);//스피드전에서 드리프트 게이지 충전량 +3
                                    oPacket.WriteShort(702);//스피드전에서 변신 부스터 가속도 증가 +2
                                }
                            }
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(0);
                        }
                    }
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
            if (Program.UseKartPlant)
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(1);
                    oPacket.WriteByte(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(PlantCount);
                    for (short i = 1; i <= NewRider.MaxKart; i++)
                    {
                        if (i <= 25 || i == 27 || i == 29 || i == 45 || i == 54 || i == 59 ||
                            i == 63 || i == 70 || i == 82 || i == 95 || i == 101 || i == 103 || i == 111 || i == 114 || i == 117 || i == 210 || i == 219 || i == 220 || i == 232 || i == 265 || i == 285 ||
                            i == 292 || i == 302 || i == 311 || i == 326 || i == 357 || i == 358 || i == 361 || i == 371 || i == 378 || i == 382 || i == 420 || i == 429 || i == 433 || i == 436 || i == 437 ||
                            i == 439 || i == 453 || i == 458 || i == 459 || i == 464 || i == 473 || i == 481 || i == 484 || i == 501 || i == 510 || i == 517 || i == 531 || i == 543 || i == 550 || i == 559 ||
                            i == 564 || i == 566 || i == 574 || i == 596 || i == 597 || i == 602 || i == 604 || i == 606 || i == 608 || i == 611 || i == 619 || i == 620 || i == 624 || i == 627 || i == 628 ||
                            i == 629 || i == 630 || i == 631 || i == 632 || i == 633 || i == 636 || i == 637 || i == 638 || i == 639 || i == 643 || i == 644 || i == 645 || i == 646 || i == 647 || i == 648 ||
                            i == 649 || i == 650 || i == 654 || i == 655 || i == 656 || i == 660 || i == 661 || i == 662 || i == 663 || i == 664 || i == 666 || i == 667 || i == 668 || i == 669 || i == 670 ||
                            i == 671 || i == 677 || i == 678 || i == 679 || i == 680 || i == 681 || i == 682 || i == 683 || i == 684 || i == 686 || i == 688 || i == 689 || i == 700 || i == 701 || i == 702 ||
                            i == 703 || i == 704 || i == 705 || i == 706 || i == 707 || i == 708 || i == 709 || i == 712 || i == 718 || i == 719 || i == 720 || i == 737 || i == 738 || i == 739 || i == 740 ||
                            i == 741 || i == 742 || i == 750 || i == 751 || i == 757 || i == 764 || i == 769 || i == 770 || i == 771 || i == 772 || i == 773 || i == 774 || i == 775 || i == 776 || i == 780 ||
                            i == 787 || i == 788 || i == 794 || i == 795 || i == 796 || i == 797 || i == 800 || i == 801 || i == 805 || i == 806 || i == 808 || i == 811 || i == 813 || i == 824 || i == 827 ||
                            i == 828 || i == 829 || i == 830 || i == 832 || i == 833 || i == 835 || i == 837 || i == 838 || i == 839 || i == 840 || i == 841 || i == 843 || i == 844 || i == 845 || i == 846 ||
                            i == 847 || i == 849 || i == 850 || i == 851 || i == 852 || i == 853 || i == 854 || i == 855 || i == 856 || i == 857 || i == 858 || i == 859 || i == 861 || i == 863 || i == 864 ||
                            i == 865 || i == 866 || i == 867 || i == 868 || i == 869 || i == 872 || i == 873 || i == 874 || i == 875 || i == 877 || i == 878 || i == 879 || i == 880 || i == 882 || i == 883 ||
                            i == 884 || i == 885 || i == 887 || i == 888 || i == 889 || i == 890 || i == 891 || i == 894 || i == 896 || i == 900 || i == 901 || i == 902 || i == 905 || i == 906 || i == 907 ||
                            i == 914 || i == 915 || i == 916 || i == 917 || i == 918 || i == 919 || i == 921 || i == 922 || i == 927 || i == 930 || i == 931 || i == 932 || i == 935 || i == 937 || i == 939 ||
                            i == 940 || i == 941 || i == 942 || i == 943 || i == 944 || i == 946 || i == 947 || i == 948 || i == 949 || i == 950 || i == 951 || i == 954 || i == 955 || i == 956 || i == 961 ||
                            i == 962 || i == 963 || i == 967 || i == 971 || i == 977 || i == 998 || i == 999 || i == 1003 || i == 1004 || i == 1005 || i == 1006 || i == 1007 || i == 1008 || i == 1009 || i == 1010 ||
                            i == 1013 || i == 1014 || i == 1015 || i == 1017)
                        {
                            oPacket.WriteShort(i);
                            oPacket.WriteShort(KartSN);
                            oPacket.WriteInt(4);
                            oPacket.WriteShort(43);
                            oPacket.WriteShort(23);
                            oPacket.WriteShort(44);
                            oPacket.WriteShort(2);
                            oPacket.WriteShort(45);
                            oPacket.WriteShort(23);
                            oPacket.WriteShort(46);
                            oPacket.WriteShort(1);
                        }
                    }
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
            if (Program.UseKartLevel)
            {
                using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
                {
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(0);
                    oPacket.WriteByte(1);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(KartLevelCount);
                    for (short i = 1; i <= NewRider.MaxKart; i++)
                    {
                        if (i <= 25 || i == 27 || i == 29 || i == 45 || i == 54 || i == 59 ||
                            i == 63 || i == 70 || i == 82 || i == 95 || i == 101 || i == 103 || i == 111 || i == 114 || i == 117 || i == 210 || i == 219 || i == 220 || i == 232 || i == 265 || i == 285 ||
                            i == 292 || i == 302 || i == 311 || i == 326 || i == 357 || i == 358 || i == 361 || i == 371 || i == 378 || i == 382 || i == 420 || i == 429 || i == 433 || i == 436 || i == 437 ||
                            i == 439 || i == 453 || i == 458 || i == 459 || i == 464 || i == 473 || i == 481 || i == 484 || i == 501 || i == 510 || i == 517 || i == 531 || i == 543 || i == 550 || i == 559 ||
                            i == 564 || i == 566 || i == 574 || i == 596 || i == 597 || i == 602 || i == 604 || i == 606 || i == 608 || i == 611 || i == 619 || i == 620 || i == 624 || i == 627 || i == 628 ||
                            i == 629 || i == 630 || i == 631 || i == 632 || i == 633 || i == 636 || i == 637 || i == 638 || i == 639 || i == 643 || i == 644 || i == 645 || i == 646 || i == 647 || i == 648 ||
                            i == 649 || i == 650 || i == 654 || i == 655 || i == 656 || i == 660 || i == 661 || i == 662 || i == 663 || i == 664 || i == 666 || i == 667 || i == 668 || i == 669 || i == 670 ||
                            i == 671 || i == 677 || i == 678 || i == 679 || i == 680 || i == 681 || i == 682 || i == 683 || i == 684 || i == 686 || i == 688 || i == 689 || i == 700 || i == 701 || i == 702 ||
                            i == 703 || i == 704 || i == 705 || i == 706 || i == 707 || i == 708 || i == 709 || i == 712 || i == 718 || i == 719 || i == 720 || i == 737 || i == 738 || i == 739 || i == 740 ||
                            i == 741 || i == 742 || i == 750 || i == 751 || i == 757 || i == 764 || i == 769 || i == 770 || i == 771 || i == 772 || i == 773 || i == 774 || i == 775 || i == 776 || i == 780 ||
                            i == 787 || i == 788 || i == 794 || i == 795 || i == 796 || i == 797 || i == 800 || i == 801 || i == 805 || i == 806 || i == 808 || i == 811 || i == 813 || i == 824 || i == 827 ||
                            i == 828 || i == 829 || i == 830 || i == 832 || i == 833 || i == 835 || i == 837 || i == 838 || i == 839 || i == 840 || i == 841 || i == 843 || i == 844 || i == 845 || i == 846 ||
                            i == 847 || i == 849 || i == 850 || i == 851 || i == 852 || i == 853 || i == 854 || i == 855 || i == 856 || i == 857 || i == 858 || i == 859 || i == 861 || i == 863 || i == 864 ||
                            i == 865 || i == 866 || i == 867 || i == 868 || i == 869 || i == 872 || i == 873 || i == 874 || i == 875 || i == 877 || i == 878 || i == 879 || i == 880 || i == 882 || i == 883 ||
                            i == 884 || i == 885 || i == 887 || i == 888 || i == 889 || i == 890 || i == 891 || i == 894 || i == 896 || i == 900 || i == 901 || i == 902 || i == 905 || i == 906 || i == 907 ||
                            i == 914 || i == 915 || i == 916 || i == 917 || i == 918 || i == 919 || i == 921 || i == 922 || i == 927 || i == 930 || i == 931 || i == 932 || i == 935 || i == 937 || i == 939 ||
                            i == 940 || i == 941 || i == 942 || i == 943 || i == 944 || i == 946 || i == 947 || i == 948 || i == 949 || i == 950 || i == 951 || i == 954 || i == 955 || i == 956 || i == 961 ||
                            i == 962 || i == 963 || i == 967 || i == 971 || i == 977 || i == 998 || i == 999 || i == 1003 || i == 1004 || i == 1005 || i == 1006 || i == 1007 || i == 1008 || i == 1009 || i == 1010 ||
                            i == 1013 || i == 1014 || i == 1015 || i == 1017)
                        {
                            oPacket.WriteShort(i);
                            oPacket.WriteShort(KartSN);
                            oPacket.WriteShort(5);
                            oPacket.WriteShort(0);
                            oPacket.WriteShort(10);
                            oPacket.WriteShort(5);
                            oPacket.WriteShort(10);
                            oPacket.WriteShort(10);
                            if (i <= 292 || i == 358 || i == 420 || i == 464 || i == 501 || i == 837 || i == 838 || i == 843 || i == 845 || i == 847 ||
                                i == 853 || i == 856 || i == 863 || i == 873 || i == 880)
                            {
                                oPacket.WriteShort(0);
                            }
                            else
                            {
                                oPacket.WriteShort(6); //코팅
                            }
                        }
                    }
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
        }
    }
}