using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartPlant;

namespace ExcData
{
	public class PlantSpec
	{
		public static byte Plant_SpeedSlotCapacity = 0;
		public static float Plant_DragFactor = 0f;
		public static float Plant_ForwardAccelForce = 0f;
		public static float Plant_BackwardAccelForce = 0f;
		public static float Plant_GripBrakeForce = 0f;
		public static float Plant_SlipBrakeForce = 0f;
		public static float Plant_SteerConstraint = 0f;
		public static float Plant_FrontGripFactor = 0f;
		public static float Plant_RearGripFactor = 0f;
		public static float Plant_DriftSlipFactor = 0f;
		public static float Plant_DriftEscapeForce = 0f;
		public static float Plant_CornerDrawFactor = 0f;
		public static float Plant_DriftMaxGauge = 0f;
		public static float Plant_NormalBoosterTime = 0f;
		public static float Plant_TeamBoosterTime = 0f;
		public static float Plant_TransAccelFactor = 0f;
		public static float Plant_StartBoosterTimeSpeed = 0f;
		public static float Plant_StartForwardAccelForceSpeed = 0f;

		public static void Reset_PlantSpec()
		{
			PlantDataReset.PlantSpecReset();

			Plant_Engine.SetPlant_Engine = 0;
			Plant_Engine.Plant_SetEngineType = false;
			Plant_Engine.RePlant_Engine();

			Plant_Handlebar.SetPlant_Handlebar = 0;
			Plant_Handlebar.Plant_SetHandlebarType = false;
			Plant_Handlebar.RePlant_Handlebar();

			Plant_Wheel.SetPlant_Wheel = 0;
			Plant_Wheel.Plant_SetWheelType = false;
			Plant_Wheel.RePlant_Wheel();

			Plant_Kits.SetPlant_Kits = 0;
			Plant_Kits.Plant_SetKitsType = false;
			Plant_Kits.RePlant_Kits();
		}

		public static void Use_PlantSpec()
		{
			if (Plant_Engine.SetPlant_Engine == 0)
            {
				Plant_Engine.Plant_SetEngineType = false;
			}
			else
            {
				Plant_Engine.Plant_SetEngineType = true;
			}
			Plant_Engine.RePlant_Engine();

			if (Plant_Handlebar.SetPlant_Handlebar == 0)
			{
				Plant_Handlebar.Plant_SetHandlebarType = false;
			}
			else
			{
				Plant_Handlebar.Plant_SetHandlebarType = true;
			}
			Plant_Handlebar.RePlant_Handlebar();

			if (Plant_Wheel.SetPlant_Wheel == 0)
			{
				Plant_Wheel.Plant_SetWheelType = false;
			}
			else
			{
				Plant_Wheel.Plant_SetWheelType = true;
			}
			Plant_Wheel.RePlant_Wheel();

			if (Plant_Kits.SetPlant_Kits == 0)
			{
				Plant_Kits.Plant_SetKitsType = false;
			}
			else
			{
				Plant_Kits.Plant_SetKitsType = true;
			}
			Plant_Kits.RePlant_Kits();
		}
	}
}