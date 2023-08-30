using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcData
{
    public class PlantDataReset
    {
        public static void PlantSpecReset()
		{
			PlantSpec.Plant_SpeedSlotCapacity = 0;
			PlantSpec.Plant_DragFactor = 0f;
			PlantSpec.Plant_ForwardAccelForce = 0f;
			PlantSpec.Plant_BackwardAccelForce = 0f;
			PlantSpec.Plant_GripBrakeForce = 0f;
			PlantSpec.Plant_SlipBrakeForce = 0f;
			PlantSpec.Plant_SteerConstraint = 0f;
			PlantSpec.Plant_FrontGripFactor = 0f;
			PlantSpec.Plant_RearGripFactor = 0f;
			PlantSpec.Plant_DriftSlipFactor = 0f;
			PlantSpec.Plant_DriftEscapeForce = 0f;
			PlantSpec.Plant_CornerDrawFactor = 0f;
			PlantSpec.Plant_DriftMaxGauge = 0f;
			PlantSpec.Plant_NormalBoosterTime = 0f;
			PlantSpec.Plant_TeamBoosterTime = 0f;
			PlantSpec.Plant_TransAccelFactor = 0f;
			PlantSpec.Plant_StartBoosterTimeSpeed = 0f;
			PlantSpec.Plant_StartForwardAccelForceSpeed = 0f;
		}
    }
}