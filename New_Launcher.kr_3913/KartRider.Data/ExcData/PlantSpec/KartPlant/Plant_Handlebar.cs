using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartPlant
{
	public class Plant_Handlebar
	{
		public static short SetPlant_Handlebar = 0;

		public static bool Plant_SetHandlebarType = false;

		public static byte PlantHandlebar_SpeedSlotCapacity = 0;
		public static float PlantHandlebar_DragFactor = 0f;
		public static float PlantHandlebar_ForwardAccelForce = 0f;
		public static float PlantHandlebar_BackwardAccelForce = 0f;
		public static float PlantHandlebar_GripBrakeForce = 0f;
		public static float PlantHandlebar_SlipBrakeForce = 0f;
		public static float PlantHandlebar_SteerConstraint = 0f;
		public static float PlantHandlebar_FrontGripFactor = 0f;
		public static float PlantHandlebar_RearGripFactor = 0f;
		public static float PlantHandlebar_DriftSlipFactor = 0f;
		public static float PlantHandlebar_DriftEscapeForce = 0f;
		public static float PlantHandlebar_CornerDrawFactor = 0f;
		public static float PlantHandlebar_DriftMaxGauge = 0f;
		public static float PlantHandlebar_NormalBoosterTime = 0f;
		public static float PlantHandlebar_TeamBoosterTime = 0f;
		public static float PlantHandlebar_TransAccelFactor = 0f;
		public static float PlantHandlebar_StartBoosterTimeSpeed = 0f;
		public static float PlantHandlebar_StartForwardAccelForceSpeed = 0f;

		public static void Plant_HandlebarData()
		{
			if (Plant_Handlebar.SetPlant_Handlebar == 1) //바이킹 배틀
			{
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = -40f;
				Plant_Handlebar.PlantHandlebar_SlipBrakeForce = -40f;
				Plant_Handlebar.PlantHandlebar_FrontGripFactor = 0.2f;
				Plant_Handlebar.PlantHandlebar_RearGripFactor = 0.2f;
				Plant_Handlebar.PlantHandlebar_CornerDrawFactor = 0.0005f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 2) //엑스 스트림
			{
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = -12f;
				Plant_Handlebar.PlantHandlebar_FrontGripFactor = 0.3f;
				Plant_Handlebar.PlantHandlebar_RearGripFactor = 0.3f;
				Plant_Handlebar.PlantHandlebar_CornerDrawFactor = 0.001f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 3) //샤프 라이너
			{
				Plant_Handlebar.PlantHandlebar_SlipBrakeForce = -10f;
				Plant_Handlebar.PlantHandlebar_FrontGripFactor = 0.2f;
				Plant_Handlebar.PlantHandlebar_RearGripFactor = 0.2f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 4) //퍼펙트 블랙 핸들
			{
				Plant_Handlebar.PlantHandlebar_FrontGripFactor = 0.1f;
				Plant_Handlebar.PlantHandlebar_RearGripFactor = 0.1f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 5) //퍼펙트 화이트 핸들
			{
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = -20f;
				Plant_Handlebar.PlantHandlebar_FrontGripFactor = 0.05f;
				Plant_Handlebar.PlantHandlebar_RearGripFactor = 0.05f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 6) //다크 크로스
			{
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = -20f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 7) //홀리 커브
			{
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = -15f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 8) //옐로우 레이싱 핸들
			{
				Plant_Handlebar.PlantHandlebar_SteerConstraint = 0.2f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 9) //블루 레이싱 핸들
			{
				Plant_Handlebar.PlantHandlebar_SteerConstraint = 0.4f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 10) //그린 레이싱 핸들
			{
				Plant_Handlebar.PlantHandlebar_SteerConstraint = 0.8f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 11) //퍼플 레이싱 핸들
			{
				Plant_Handlebar.PlantHandlebar_SteerConstraint = -0.4f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 12) //옐로우 십자형 핸들
			{
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = -5f;
				Plant_Handlebar.PlantHandlebar_SlipBrakeForce = -8f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 13) //블루 십자형 핸들
			{
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = -7f;
				Plant_Handlebar.PlantHandlebar_SlipBrakeForce = -6f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 14) //그린 십자형 핸들
			{
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = -9f;
				Plant_Handlebar.PlantHandlebar_SlipBrakeForce = -4f;
			}
			else if (Plant_Handlebar.SetPlant_Handlebar == 15) //퍼플 십자형 핸들
			{
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = -11f;
				Plant_Handlebar.PlantHandlebar_SlipBrakeForce = -2f;
			}
			else
			{
				Plant_Handlebar.PlantHandlebar_SpeedSlotCapacity = 0;
				Plant_Handlebar.PlantHandlebar_DragFactor = 0f;
				Plant_Handlebar.PlantHandlebar_ForwardAccelForce = 0f;
				Plant_Handlebar.PlantHandlebar_BackwardAccelForce = 0f;
				Plant_Handlebar.PlantHandlebar_GripBrakeForce = 0f;
				Plant_Handlebar.PlantHandlebar_SlipBrakeForce = 0f;
				Plant_Handlebar.PlantHandlebar_SteerConstraint = 0f;
				Plant_Handlebar.PlantHandlebar_FrontGripFactor = 0f;
				Plant_Handlebar.PlantHandlebar_RearGripFactor = 0f;
				Plant_Handlebar.PlantHandlebar_DriftSlipFactor = 0f;
				Plant_Handlebar.PlantHandlebar_DriftEscapeForce = 0f;
				Plant_Handlebar.PlantHandlebar_CornerDrawFactor = 0f;
				Plant_Handlebar.PlantHandlebar_DriftMaxGauge = 0f;
				Plant_Handlebar.PlantHandlebar_NormalBoosterTime = 0f;
				Plant_Handlebar.PlantHandlebar_TeamBoosterTime = 0f;
				Plant_Handlebar.PlantHandlebar_TransAccelFactor = 0f;
				Plant_Handlebar.PlantHandlebar_StartBoosterTimeSpeed = 0f;
				Plant_Handlebar.PlantHandlebar_StartForwardAccelForceSpeed = 0f;
			}
		}

		public static void RePlant_Handlebar()
		{
			Plant_Handlebar.PlantHandlebar_SpeedSlotCapacity = 0;
			Plant_Handlebar.PlantHandlebar_DragFactor = 0f;
			Plant_Handlebar.PlantHandlebar_ForwardAccelForce = 0f;
			Plant_Handlebar.PlantHandlebar_BackwardAccelForce = 0f;
			Plant_Handlebar.PlantHandlebar_GripBrakeForce = 0f;
			Plant_Handlebar.PlantHandlebar_SlipBrakeForce = 0f;
			Plant_Handlebar.PlantHandlebar_SteerConstraint = 0f;
			Plant_Handlebar.PlantHandlebar_FrontGripFactor = 0f;
			Plant_Handlebar.PlantHandlebar_RearGripFactor = 0f;
			Plant_Handlebar.PlantHandlebar_DriftSlipFactor = 0f;
			Plant_Handlebar.PlantHandlebar_DriftEscapeForce = 0f;
			Plant_Handlebar.PlantHandlebar_CornerDrawFactor = 0f;
			Plant_Handlebar.PlantHandlebar_DriftMaxGauge = 0f;
			Plant_Handlebar.PlantHandlebar_NormalBoosterTime = 0f;
			Plant_Handlebar.PlantHandlebar_TeamBoosterTime = 0f;
			Plant_Handlebar.PlantHandlebar_TransAccelFactor = 0f;
			Plant_Handlebar.PlantHandlebar_StartBoosterTimeSpeed = 0f;
			Plant_Handlebar.PlantHandlebar_StartForwardAccelForceSpeed = 0f;
			if (Plant_Handlebar.Plant_SetHandlebarType)
			{
				Plant_Handlebar.Plant_HandlebarData();
			}
		}
	}
}
