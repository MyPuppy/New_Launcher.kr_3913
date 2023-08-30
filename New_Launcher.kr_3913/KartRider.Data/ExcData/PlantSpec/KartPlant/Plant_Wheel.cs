using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartPlant
{
	public class Plant_Wheel
	{
		public static short SetPlant_Wheel = 0;

		public static bool Plant_SetWheelType = false;

		public static byte PlantWheel_SpeedSlotCapacity = 0;
		public static float PlantWheel_DragFactor = 0f;
		public static float PlantWheel_ForwardAccelForce = 0f;
		public static float PlantWheel_BackwardAccelForce = 0f;
		public static float PlantWheel_GripBrakeForce = 0f;
		public static float PlantWheel_SlipBrakeForce = 0f;
		public static float PlantWheel_SteerConstraint = 0f;
		public static float PlantWheel_FrontGripFactor = 0f;
		public static float PlantWheel_RearGripFactor = 0f;
		public static float PlantWheel_DriftSlipFactor = 0f;
		public static float PlantWheel_DriftEscapeForce = 0f;
		public static float PlantWheel_CornerDrawFactor = 0f;
		public static float PlantWheel_DriftMaxGauge = 0f;
		public static float PlantWheel_NormalBoosterTime = 0f;
		public static float PlantWheel_TeamBoosterTime = 0f;
		public static float PlantWheel_TransAccelFactor = 0f;
		public static float PlantWheel_StartBoosterTimeSpeed = 0f;
		public static float PlantWheel_StartForwardAccelForceSpeed = 0f;

		public static void Plant_WheelData()
		{
			if (Plant_Wheel.SetPlant_Wheel == 1) //카보 블레이드
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = 70f;
				Plant_Wheel.PlantWheel_DriftMaxGauge = -40f;
				Plant_Wheel.PlantWheel_CornerDrawFactor = 0.001f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 2) //닥터R 파이어 디스크
			{
				Plant_Wheel.PlantWheel_SlipBrakeForce = -192f;
				Plant_Wheel.PlantWheel_DriftMaxGauge = -60f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 3) //크로스 워커
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = 70f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 4) //블랙 디스크 휠
			{
				Plant_Wheel.PlantWheel_DriftMaxGauge = -60f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 5) //화이트 디스크 휠
			{
				Plant_Wheel.PlantWheel_DriftMaxGauge = -40f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 6) //블랙 오프로드 휠
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = 50f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 7) //화이트 오프로드 휠
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = 30f;
				Plant_Wheel.PlantWheel_CornerDrawFactor = 0.0005f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 8) //옐로우 디스크 휠
			{
				Plant_Wheel.PlantWheel_DriftMaxGauge = -40f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 9) //블루 디스크 휠
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = -20f;
				Plant_Wheel.PlantWheel_DriftMaxGauge = -60f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 10) //퍼플 디스크 휠
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = -60f;
				Plant_Wheel.PlantWheel_DriftMaxGauge = -100f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 11) //그린 디스크 휠
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = -40f;
				Plant_Wheel.PlantWheel_DriftMaxGauge = -80f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 12) //옐로우 오프로드 휠
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = 10f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 13) //블루 오프로드 휠
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = 30f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 15) //퍼플 오프로드 휠
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = 70f;
				Plant_Wheel.PlantWheel_DriftMaxGauge = 60f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 16) //옐로우 프레임
			{
				Plant_Wheel.PlantWheel_CornerDrawFactor = 0.0005f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 17) //퍼플 프레임
			{
				Plant_Wheel.PlantWheel_DragFactor = -0.0007f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 18) //블루 프레임
			{
				Plant_Wheel.PlantWheel_DriftMaxGauge = -40f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 20) //화이트 프레임
			{
				Plant_Wheel.PlantWheel_DriftMaxGauge = -30f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 22) //어스퀘이크
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = 30f;
			}
			else if (Plant_Wheel.SetPlant_Wheel == 23) //와일드 서클
			{
				Plant_Wheel.PlantWheel_DriftEscapeForce = 90f;
				Plant_Wheel.PlantWheel_CornerDrawFactor = 0.0005f;
			}
			else
			{
				Plant_Wheel.PlantWheel_SpeedSlotCapacity = 0;
				Plant_Wheel.PlantWheel_DragFactor = 0f;
				Plant_Wheel.PlantWheel_ForwardAccelForce = 0f;
				Plant_Wheel.PlantWheel_BackwardAccelForce = 0f;
				Plant_Wheel.PlantWheel_GripBrakeForce = 0f;
				Plant_Wheel.PlantWheel_SlipBrakeForce = 0f;
				Plant_Wheel.PlantWheel_SteerConstraint = 0f;
				Plant_Wheel.PlantWheel_FrontGripFactor = 0f;
				Plant_Wheel.PlantWheel_RearGripFactor = 0f;
				Plant_Wheel.PlantWheel_DriftSlipFactor = 0f;
				Plant_Wheel.PlantWheel_DriftEscapeForce = 0f;
				Plant_Wheel.PlantWheel_CornerDrawFactor = 0f;
				Plant_Wheel.PlantWheel_DriftMaxGauge = 0f;
				Plant_Wheel.PlantWheel_NormalBoosterTime = 0f;
				Plant_Wheel.PlantWheel_TeamBoosterTime = 0f;
				Plant_Wheel.PlantWheel_TransAccelFactor = 0f;
				Plant_Wheel.PlantWheel_StartBoosterTimeSpeed = 0f;
				Plant_Wheel.PlantWheel_StartForwardAccelForceSpeed = 0f;
			}
		}

		public static void RePlant_Wheel()
		{
			Plant_Wheel.PlantWheel_SpeedSlotCapacity = 0;
			Plant_Wheel.PlantWheel_DragFactor = 0f;
			Plant_Wheel.PlantWheel_ForwardAccelForce = 0f;
			Plant_Wheel.PlantWheel_BackwardAccelForce = 0f;
			Plant_Wheel.PlantWheel_GripBrakeForce = 0f;
			Plant_Wheel.PlantWheel_SlipBrakeForce = 0f;
			Plant_Wheel.PlantWheel_SteerConstraint = 0f;
			Plant_Wheel.PlantWheel_FrontGripFactor = 0f;
			Plant_Wheel.PlantWheel_RearGripFactor = 0f;
			Plant_Wheel.PlantWheel_DriftSlipFactor = 0f;
			Plant_Wheel.PlantWheel_DriftEscapeForce = 0f;
			Plant_Wheel.PlantWheel_CornerDrawFactor = 0f;
			Plant_Wheel.PlantWheel_DriftMaxGauge = 0f;
			Plant_Wheel.PlantWheel_NormalBoosterTime = 0f;
			Plant_Wheel.PlantWheel_TeamBoosterTime = 0f;
			Plant_Wheel.PlantWheel_TransAccelFactor = 0f;
			Plant_Wheel.PlantWheel_StartBoosterTimeSpeed = 0f;
			Plant_Wheel.PlantWheel_StartForwardAccelForceSpeed = 0f;
			if (Plant_Wheel.Plant_SetWheelType)
			{
				Plant_Wheel.Plant_WheelData();
			}
		}
	}
}
