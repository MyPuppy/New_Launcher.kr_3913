using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartPlant;
using KartRider;

namespace ExcData
{
    public class PlantCheck
    {
        public static void TimeAttack_PlantCheck()
        {
            PlantSpec.Plant_SpeedSlotCapacity = Plant_Kits.PlantKits_SpeedSlotCapacity;
            PlantSpec.Plant_DragFactor = Plant_Engine.PlantEngine_DragFactor + Plant_Handlebar.PlantHandlebar_DragFactor + Plant_Wheel.PlantWheel_DragFactor + Plant_Kits.PlantKits_DragFactor + Plant_Kits.PlantKits_DragFactor;
            PlantSpec.Plant_ForwardAccelForce = Plant_Engine.PlantEngine_ForwardAccelForce + Plant_Handlebar.PlantHandlebar_ForwardAccelForce + Plant_Wheel.PlantWheel_ForwardAccelForce + Plant_Kits.PlantKits_ForwardAccelForce;
            PlantSpec.Plant_BackwardAccelForce = Plant_Engine.PlantEngine_BackwardAccelForce + Plant_Handlebar.PlantHandlebar_BackwardAccelForce + Plant_Wheel.PlantWheel_BackwardAccelForce + Plant_Kits.PlantKits_BackwardAccelForce;
            PlantSpec.Plant_GripBrakeForce = Plant_Engine.PlantEngine_GripBrakeForce + Plant_Handlebar.PlantHandlebar_GripBrakeForce + Plant_Wheel.PlantWheel_GripBrakeForce + Plant_Kits.PlantKits_GripBrakeForce;
            PlantSpec.Plant_SlipBrakeForce = Plant_Engine.PlantEngine_SlipBrakeForce + Plant_Handlebar.PlantHandlebar_SlipBrakeForce + Plant_Wheel.PlantWheel_SlipBrakeForce + Plant_Kits.PlantKits_SlipBrakeForce;
            PlantSpec.Plant_SteerConstraint = Plant_Engine.PlantEngine_SteerConstraint + Plant_Handlebar.PlantHandlebar_SteerConstraint + Plant_Wheel.PlantWheel_SteerConstraint + Plant_Kits.PlantKits_SteerConstraint;
            PlantSpec.Plant_FrontGripFactor = Plant_Engine.PlantEngine_FrontGripFactor + Plant_Handlebar.PlantHandlebar_FrontGripFactor + Plant_Wheel.PlantWheel_FrontGripFactor + Plant_Kits.PlantKits_FrontGripFactor;
            PlantSpec.Plant_RearGripFactor = Plant_Engine.PlantEngine_RearGripFactor + Plant_Handlebar.PlantHandlebar_RearGripFactor + Plant_Wheel.PlantWheel_RearGripFactor + Plant_Kits.PlantKits_RearGripFactor;
            PlantSpec.Plant_DriftSlipFactor = Plant_Engine.PlantEngine_DriftSlipFactor + Plant_Handlebar.PlantHandlebar_DriftSlipFactor + Plant_Wheel.PlantWheel_DriftSlipFactor + Plant_Kits.PlantKits_DriftSlipFactor;
            PlantSpec.Plant_DriftEscapeForce = Plant_Engine.PlantEngine_DriftEscapeForce + Plant_Handlebar.PlantHandlebar_DriftEscapeForce + Plant_Wheel.PlantWheel_DriftEscapeForce + Plant_Kits.PlantKits_DriftEscapeForce;
            PlantSpec.Plant_CornerDrawFactor = Plant_Engine.PlantEngine_CornerDrawFactor + Plant_Handlebar.PlantHandlebar_CornerDrawFactor + Plant_Wheel.PlantWheel_CornerDrawFactor + Plant_Kits.PlantKits_CornerDrawFactor;
            PlantSpec.Plant_DriftMaxGauge = Plant_Engine.PlantEngine_DriftMaxGauge + Plant_Handlebar.PlantHandlebar_DriftMaxGauge + Plant_Wheel.PlantWheel_DriftMaxGauge + Plant_Kits.PlantKits_DriftMaxGauge;
            PlantSpec.Plant_NormalBoosterTime = Plant_Engine.PlantEngine_NormalBoosterTime + Plant_Handlebar.PlantHandlebar_NormalBoosterTime + Plant_Wheel.PlantWheel_NormalBoosterTime + Plant_Kits.PlantKits_NormalBoosterTime;
            PlantSpec.Plant_TeamBoosterTime = Plant_Engine.PlantEngine_TeamBoosterTime + Plant_Handlebar.PlantHandlebar_TeamBoosterTime + Plant_Wheel.PlantWheel_TeamBoosterTime + Plant_Kits.PlantKits_TeamBoosterTime;
            PlantSpec.Plant_TransAccelFactor = Plant_Engine.PlantEngine_TransAccelFactor + Plant_Handlebar.PlantHandlebar_TransAccelFactor + Plant_Wheel.PlantWheel_TransAccelFactor + Plant_Kits.PlantKits_TransAccelFactor;
            PlantSpec.Plant_StartBoosterTimeSpeed = Plant_Engine.PlantEngine_StartBoosterTimeSpeed + Plant_Handlebar.PlantHandlebar_StartBoosterTimeSpeed + Plant_Wheel.PlantWheel_StartBoosterTimeSpeed + Plant_Kits.PlantKits_StartBoosterTimeSpeed;
            PlantSpec.Plant_StartForwardAccelForceSpeed = Plant_Engine.PlantEngine_StartForwardAccelForceSpeed + Plant_Handlebar.PlantHandlebar_StartForwardAccelForceSpeed + Plant_Wheel.PlantWheel_StartForwardAccelForceSpeed + Plant_Kits.PlantKits_StartForwardAccelForceSpeed;

            SpeedType.SpeedTypeData();
        }
    }
}