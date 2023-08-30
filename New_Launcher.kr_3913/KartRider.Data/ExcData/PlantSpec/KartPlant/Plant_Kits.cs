using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartPlant
{
	public class Plant_Kits
	{
		public static short SetPlant_Kits = 0;

		public static bool Plant_SetKitsType = false;

		public static byte PlantKits_SpeedSlotCapacity = 0;
		public static float PlantKits_DragFactor = 0f;
		public static float PlantKits_ForwardAccelForce = 0f;
		public static float PlantKits_BackwardAccelForce = 0f;
		public static float PlantKits_GripBrakeForce = 0f;
		public static float PlantKits_SlipBrakeForce = 0f;
		public static float PlantKits_SteerConstraint = 0f;
		public static float PlantKits_FrontGripFactor = 0f;
		public static float PlantKits_RearGripFactor = 0f;
		public static float PlantKits_DriftSlipFactor = 0f;
		public static float PlantKits_DriftEscapeForce = 0f;
		public static float PlantKits_CornerDrawFactor = 0f;
		public static float PlantKits_DriftMaxGauge = 0f;
		public static float PlantKits_NormalBoosterTime = 0f;
		public static float PlantKits_TeamBoosterTime = 0f;
		public static float PlantKits_TransAccelFactor = 0f;
		public static float PlantKits_StartBoosterTimeSpeed = 0f;
		public static float PlantKits_StartForwardAccelForceSpeed = 0f;

		public static void Plant_KitsData()
		{
			if (Plant_Kits.SetPlant_Kits == 1) //골든 로제타 킷
			{
				Plant_Kits.PlantKits_DriftMaxGauge = -80f;
				Plant_Kits.PlantKits_NormalBoosterTime = 120f;
			}
			else if (Plant_Kits.SetPlant_Kits == 2) //에어 프레셔
			{
				Plant_Kits.PlantKits_ForwardAccelForce = 2f;
				Plant_Kits.PlantKits_DriftSlipFactor = -0.03f;
			}
			else if (Plant_Kits.SetPlant_Kits == 5) //레이지 펌프
			{
				Plant_Kits.PlantKits_NormalBoosterTime = 80f;
				Plant_Kits.PlantKits_TeamBoosterTime = 70f;
				Plant_Kits.PlantKits_StartForwardAccelForceSpeed = 50f;
			}
			else if (Plant_Kits.SetPlant_Kits == 6) //레드 레이븐 램프
			{
				Plant_Kits.PlantKits_NormalBoosterTime = 60f;
			}
			else if (Plant_Kits.SetPlant_Kits == 7) //블랙 니트로
			{
				Plant_Kits.PlantKits_StartBoosterTimeSpeed = 105f;
			}
			else if (Plant_Kits.SetPlant_Kits == 12) //화이트 펌프
			{
				Plant_Kits.PlantKits_SpeedSlotCapacity = 3;
			}
			else if (Plant_Kits.SetPlant_Kits == 15) //옐로우 니트로
			{
				Plant_Kits.PlantKits_GripBrakeForce = 10f;
			}
			else if (Plant_Kits.SetPlant_Kits == 16) //블루 니트로
			{
				Plant_Kits.PlantKits_SlipBrakeForce = 10f;
			}
			else if (Plant_Kits.SetPlant_Kits == 23) //옐로우 펌프
			{
				Plant_Kits.PlantKits_NormalBoosterTime = 60f;
			}
			else if (Plant_Kits.SetPlant_Kits == 24) //블루 펌프
			{
				Plant_Kits.PlantKits_TeamBoosterTime = 60f;
			}
			else if (Plant_Kits.SetPlant_Kits == 25) //그린 펌프
			{
				Plant_Kits.PlantKits_NormalBoosterTime = 90f;
				Plant_Kits.PlantKits_TeamBoosterTime = -30f;
			}
			else if (Plant_Kits.SetPlant_Kits == 26) //퍼플 펌프
			{
				Plant_Kits.PlantKits_NormalBoosterTime = -30f;
				Plant_Kits.PlantKits_TeamBoosterTime = 90f;
			}
			else
			{
				Plant_Kits.PlantKits_SpeedSlotCapacity = 0;
				Plant_Kits.PlantKits_DragFactor = 0f;
				Plant_Kits.PlantKits_ForwardAccelForce = 0f;
				Plant_Kits.PlantKits_BackwardAccelForce = 0f;
				Plant_Kits.PlantKits_GripBrakeForce = 0f;
				Plant_Kits.PlantKits_SlipBrakeForce = 0f;
				Plant_Kits.PlantKits_SteerConstraint = 0f;
				Plant_Kits.PlantKits_FrontGripFactor = 0f;
				Plant_Kits.PlantKits_RearGripFactor = 0f;
				Plant_Kits.PlantKits_DriftSlipFactor = 0f;
				Plant_Kits.PlantKits_DriftEscapeForce = 0f;
				Plant_Kits.PlantKits_CornerDrawFactor = 0f;
				Plant_Kits.PlantKits_DriftMaxGauge = 0f;
				Plant_Kits.PlantKits_NormalBoosterTime = 0f;
				Plant_Kits.PlantKits_TeamBoosterTime = 0f;
				Plant_Kits.PlantKits_TransAccelFactor = 0f;
				Plant_Kits.PlantKits_StartBoosterTimeSpeed = 0f;
				Plant_Kits.PlantKits_StartForwardAccelForceSpeed = 0f;
			}
		}

		public static void RePlant_Kits()
		{
			Plant_Kits.PlantKits_SpeedSlotCapacity = 0;
			Plant_Kits.PlantKits_DragFactor = 0f;
			Plant_Kits.PlantKits_ForwardAccelForce = 0f;
			Plant_Kits.PlantKits_BackwardAccelForce = 0f;
			Plant_Kits.PlantKits_GripBrakeForce = 0f;
			Plant_Kits.PlantKits_SlipBrakeForce = 0f;
			Plant_Kits.PlantKits_SteerConstraint = 0f;
			Plant_Kits.PlantKits_FrontGripFactor = 0f;
			Plant_Kits.PlantKits_RearGripFactor = 0f;
			Plant_Kits.PlantKits_DriftSlipFactor = 0f;
			Plant_Kits.PlantKits_DriftEscapeForce = 0f;
			Plant_Kits.PlantKits_CornerDrawFactor = 0f;
			Plant_Kits.PlantKits_DriftMaxGauge = 0f;
			Plant_Kits.PlantKits_NormalBoosterTime = 0f;
			Plant_Kits.PlantKits_TeamBoosterTime = 0f;
			Plant_Kits.PlantKits_TransAccelFactor = 0f;
			Plant_Kits.PlantKits_StartBoosterTimeSpeed = 0f;
			Plant_Kits.PlantKits_StartForwardAccelForceSpeed = 0f;
			if (Plant_Kits.Plant_SetKitsType)
			{
				Plant_Kits.Plant_KitsData();
			}
		}
	}
}