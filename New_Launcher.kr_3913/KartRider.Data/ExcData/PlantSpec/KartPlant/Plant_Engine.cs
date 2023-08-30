using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartPlant
{
	public class Plant_Engine
	{
		public static short SetPlant_Engine = 0;

		public static bool Plant_SetEngineType = false;

		public static byte PlantEngine_SpeedSlotCapacity = 0;
		public static float PlantEngine_DragFactor = 0f;
		public static float PlantEngine_ForwardAccelForce = 0f;
		public static float PlantEngine_BackwardAccelForce = 0f;
		public static float PlantEngine_GripBrakeForce = 0f;
		public static float PlantEngine_SlipBrakeForce = 0f;
		public static float PlantEngine_SteerConstraint = 0f;
		public static float PlantEngine_FrontGripFactor = 0f;
		public static float PlantEngine_RearGripFactor = 0f;
		public static float PlantEngine_DriftSlipFactor = 0f;
		public static float PlantEngine_DriftEscapeForce = 0f;
		public static float PlantEngine_CornerDrawFactor = 0f;
		public static float PlantEngine_DriftMaxGauge = 0f;
		public static float PlantEngine_NormalBoosterTime = 0f;
		public static float PlantEngine_TeamBoosterTime = 0f;
		public static float PlantEngine_TransAccelFactor = 0f;
		public static float PlantEngine_StartBoosterTimeSpeed = 0f;
		public static float PlantEngine_StartForwardAccelForceSpeed = 0f;

		public static void Plant_EngineData()
		{
			if (Plant_Engine.SetPlant_Engine == 1) //블랙 큐브
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0007f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0.0015f;
				Plant_Engine.PlantEngine_StartForwardAccelForceSpeed = 50f; //EX) 2500 x 0.02 = 50
			}
			else if (Plant_Engine.SetPlant_Engine == 2) //시크릿 코드
			{
				Plant_Engine.PlantEngine_ForwardAccelForce = 2f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0.0015f;
			}
			else if (Plant_Engine.SetPlant_Engine == 3) //표뮬러 링
			{
				Plant_Engine.PlantEngine_StartBoosterTimeSpeed = 15f;
				Plant_Engine.PlantEngine_StartForwardAccelForceSpeed = 50f;
			}
			else if (Plant_Engine.SetPlant_Engine == 4) //블랙 제어 센서
			{
				Plant_Engine.PlantEngine_StartForwardAccelForceSpeed = 100f;
			}
			else if (Plant_Engine.SetPlant_Engine == 6) //블랙 베어링
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0025f;
			}
			else if (Plant_Engine.SetPlant_Engine == 7) //화이트 베어링
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0014f;
			}
			else if (Plant_Engine.SetPlant_Engine == 8) //옐로우 제어 센서
			{
				Plant_Engine.PlantEngine_ForwardAccelForce = 1f;
				Plant_Engine.PlantEngine_StartForwardAccelForceSpeed = 50f;
			}
			else if (Plant_Engine.SetPlant_Engine == 9) //블루 제어센서
			{
				Plant_Engine.PlantEngine_ForwardAccelForce = 2f;
				Plant_Engine.PlantEngine_StartForwardAccelForceSpeed = 50f;
			}
			else if (Plant_Engine.SetPlant_Engine == 10) //그린 제어 센서
			{
				Plant_Engine.PlantEngine_ForwardAccelForce = 2f;
			}
			else if (Plant_Engine.SetPlant_Engine == 11) //퍼플 제어센서
			{
				Plant_Engine.PlantEngine_ForwardAccelForce = 2f;
			}
			else if (Plant_Engine.SetPlant_Engine == 12) //옐로우 베어링
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0007f;
				Plant_Engine.PlantEngine_ForwardAccelForce = 1f;
			}
			else if (Plant_Engine.SetPlant_Engine == 13) //블루 베어링
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0007f;
				Plant_Engine.PlantEngine_ForwardAccelForce = 1f;
			}
			else if (Plant_Engine.SetPlant_Engine == 14) //그린 베어링
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0007f;
			}
			else if (Plant_Engine.SetPlant_Engine == 15) //퍼플 베어링
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0014f;
			}
			else if (Plant_Engine.SetPlant_Engine == 16) //옐로우 쇼크
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0014f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0.0002f;
			}
			else if (Plant_Engine.SetPlant_Engine == 17) //퍼플 쇼크
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0007f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0.0004f;
			}
			else if (Plant_Engine.SetPlant_Engine == 18) //블루 쇼크
			{
				Plant_Engine.PlantEngine_ForwardAccelForce = 2f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0.0002f;
			}
			else if (Plant_Engine.SetPlant_Engine == 19) //그린 쇼크
			{
				Plant_Engine.PlantEngine_ForwardAccelForce = 1f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0.0004f;
			}
			else if (Plant_Engine.SetPlant_Engine == 20) //화이트 쇼크
			{
				Plant_Engine.PlantEngine_ForwardAccelForce = 1f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0.0006f;
			}
			else if (Plant_Engine.SetPlant_Engine == 21) //블랙 쇼크
			{
				Plant_Engine.PlantEngine_TransAccelFactor = 0.0008f;
			}
			else if (Plant_Engine.SetPlant_Engine == 22) //일렉트릭 쇼크
			{
				Plant_Engine.PlantEngine_DragFactor = -0.0012f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0.0012f;
			}
			else if (Plant_Engine.SetPlant_Engine == 23) //태고의 빛
			{
				Plant_Engine.PlantEngine_ForwardAccelForce = 1f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0.002f;
				Plant_Engine.PlantEngine_StartBoosterTimeSpeed = 30f;
			}
			else
			{
				Plant_Engine.PlantEngine_SpeedSlotCapacity = 0;
				Plant_Engine.PlantEngine_DragFactor = 0f;
				Plant_Engine.PlantEngine_ForwardAccelForce = 0f;
				Plant_Engine.PlantEngine_BackwardAccelForce = 0f;
				Plant_Engine.PlantEngine_GripBrakeForce = 0f;
				Plant_Engine.PlantEngine_SlipBrakeForce = 0f;
				Plant_Engine.PlantEngine_SteerConstraint = 0f;
				Plant_Engine.PlantEngine_FrontGripFactor = 0f;
				Plant_Engine.PlantEngine_RearGripFactor = 0f;
				Plant_Engine.PlantEngine_DriftSlipFactor = 0f;
				Plant_Engine.PlantEngine_DriftEscapeForce = 0f;
				Plant_Engine.PlantEngine_CornerDrawFactor = 0f;
				Plant_Engine.PlantEngine_DriftMaxGauge = 0f;
				Plant_Engine.PlantEngine_NormalBoosterTime = 0f;
				Plant_Engine.PlantEngine_TeamBoosterTime = 0f;
				Plant_Engine.PlantEngine_TransAccelFactor = 0f;
				Plant_Engine.PlantEngine_StartBoosterTimeSpeed = 0f;
				Plant_Engine.PlantEngine_StartForwardAccelForceSpeed = 0f;
			}
		}

		public static void RePlant_Engine()
		{
			Plant_Engine.PlantEngine_SpeedSlotCapacity = 0;
			Plant_Engine.PlantEngine_DragFactor = 0f;
			Plant_Engine.PlantEngine_ForwardAccelForce = 0f;
			Plant_Engine.PlantEngine_BackwardAccelForce = 0f;
			Plant_Engine.PlantEngine_GripBrakeForce = 0f;
			Plant_Engine.PlantEngine_SlipBrakeForce = 0f;
			Plant_Engine.PlantEngine_SteerConstraint = 0f;
			Plant_Engine.PlantEngine_FrontGripFactor = 0f;
			Plant_Engine.PlantEngine_RearGripFactor = 0f;
			Plant_Engine.PlantEngine_DriftSlipFactor = 0f;
			Plant_Engine.PlantEngine_DriftEscapeForce = 0f;
			Plant_Engine.PlantEngine_CornerDrawFactor = 0f;
			Plant_Engine.PlantEngine_DriftMaxGauge = 0f;
			Plant_Engine.PlantEngine_NormalBoosterTime = 0f;
			Plant_Engine.PlantEngine_TeamBoosterTime = 0f;
			Plant_Engine.PlantEngine_TransAccelFactor = 0f;
			Plant_Engine.PlantEngine_StartBoosterTimeSpeed = 0f;
			Plant_Engine.PlantEngine_StartForwardAccelForceSpeed = 0f;
			if (Plant_Engine.Plant_SetEngineType)
			{
				Plant_Engine.Plant_EngineData();
			}
		}
	}
}
