using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider.IO;
using ExcData;
using Set_Data;

namespace KartRider
{
    public class StartGameData
    {
        public static byte StartTimeAttack_SpeedType = 0;
        public static short Kart_id = 0;
        public static short FlyingPet_id = 0;
        public static uint StartTimeAttack_Track = 0;
        public static byte StartTimeAttack_StartType = 0;

        public static void Start_KartSpac()
        {
            if (GameType.StartType == 1)
            {
                StartGameData.PrKartSpec();
            }
            else if (GameType.StartType == 2)
            {
                StartGameData.PrchallengerKartSpec();
            }
            else if (GameType.StartType == 3)
            {
                if (StartGameData.StartTimeAttack_StartType == 0)
                {
                    StartGameData.PrStartTimeAttack();
                }
                else
                {
                    StartGameData.PrStartTimeAttack_QuestType();
                }
            }
            else
            {
                GameSupport.OnDisconnect();
            }
        }

        public static void PrStartTimeAttack()
        {
            using (OutPacket oPacket = new OutPacket("PrStartTimeAttack"))
            {
                oPacket.WriteByte(1);
                //------------------------------------------------------------------------KartSpac Start
                oPacket.WriteEncFloat(Kart.draftMulAccelFactor);
                oPacket.WriteEncInt(Kart.draftTick);
                oPacket.WriteEncFloat(Kart.driftBoostMulAccelFactor);
                oPacket.WriteEncInt(Kart.driftBoostTick);
                oPacket.WriteEncFloat(Kart.chargeBoostBySpeed);
                if (PlantSpec.Plant_SpeedSlotCapacity == 0)
                {
                    oPacket.WriteEncByte(Kart.SpeedSlotCapacity);
                }
                else
                {
                    oPacket.WriteEncByte(PlantSpec.Plant_SpeedSlotCapacity);
                }
                oPacket.WriteEncByte(Kart.ItemSlotCapacity);
                oPacket.WriteEncByte(Kart.SpecialSlotCapacity);
                oPacket.WriteEncByte((byte)((Kart.UseTransformBooster ? 1 : 0)));
                oPacket.WriteEncByte((byte)((Kart.motorcycleType ? 1 : 0)));
                oPacket.WriteEncFloat(Kart.Mass);
                oPacket.WriteEncFloat(Kart.AirFriction);
                oPacket.WriteEncFloat(SpeedType.DragFactor + Kart.DragFactor + FlyingPet.DragFactor + TuneSpec.Tune_DragFactor + PlantSpec.Plant_DragFactor);
                oPacket.WriteEncFloat(SpeedType.ForwardAccelForce + Kart.ForwardAccelForce + FlyingPet.ForwardAccelForce + TuneSpec.Tune_ForwardAccelForce + KartLevelSpec.KartLevel_ForwardAccelForce + PlantSpec.Plant_ForwardAccelForce);
                oPacket.WriteEncFloat(SpeedType.BackwardAccelForce + Kart.BackwardAccelForce + PlantSpec.Plant_BackwardAccelForce);
                oPacket.WriteEncFloat(SpeedType.GripBrakeForce + Kart.GripBrakeForce + PlantSpec.Plant_GripBrakeForce);
                oPacket.WriteEncFloat(SpeedType.SlipBrakeForce + Kart.SlipBrakeForce + PlantSpec.Plant_SlipBrakeForce);
                oPacket.WriteEncFloat(Kart.MaxSteerAngle);
                oPacket.WriteEncFloat(SpeedType.SteerConstraint + Kart.SteerConstraint + PlantSpec.Plant_SteerConstraint);
                oPacket.WriteEncFloat(Kart.FrontGripFactor + PlantSpec.Plant_FrontGripFactor);
                oPacket.WriteEncFloat(Kart.RearGripFactor + PlantSpec.Plant_RearGripFactor);
                oPacket.WriteEncFloat(Kart.DriftTriggerFactor);
                oPacket.WriteEncFloat(Kart.DriftTriggerTime);
                oPacket.WriteEncFloat(Kart.DriftSlipFactor + PlantSpec.Plant_DriftSlipFactor);
                oPacket.WriteEncFloat(SpeedType.DriftEscapeForce + Kart.DriftEscapeForce + FlyingPet.DriftEscapeForce + TuneSpec.Tune_DriftEscapeForce + KartLevelSpec.KartLevel_DriftEscapeForce + PlantSpec.Plant_DriftEscapeForce);
                oPacket.WriteEncFloat(SpeedType.CornerDrawFactor + Kart.CornerDrawFactor + FlyingPet.CornerDrawFactor + TuneSpec.Tune_CornerDrawFactor + KartLevelSpec.KartLevel_CornerDrawFactor + PlantSpec.Plant_CornerDrawFactor);
                oPacket.WriteEncFloat(Kart.DriftLeanFactor);
                oPacket.WriteEncFloat(Kart.SteerLeanFactor);
                if (StartGameData.StartTimeAttack_SpeedType == 4)
                {
                    oPacket.WriteEncFloat(GameType.S4_DriftMaxGauge);
                }
                else
                {
                    oPacket.WriteEncFloat(SpeedType.DriftMaxGauge + Kart.DriftMaxGauge + TuneSpec.Tune_DriftMaxGauge + PlantSpec.Plant_DriftMaxGauge);
                }
                oPacket.WriteEncFloat(Kart.NormalBoosterTime + FlyingPet.NormalBoosterTime + TuneSpec.Tune_NormalBoosterTime + PlantSpec.Plant_NormalBoosterTime);
                oPacket.WriteEncFloat(Kart.ItemBoosterTime + FlyingPet.ItemBoosterTime);
                oPacket.WriteEncFloat(Kart.TeamBoosterTime + FlyingPet.TeamBoosterTime + TuneSpec.Tune_TeamBoosterTime + PlantSpec.Plant_TeamBoosterTime);
                oPacket.WriteEncFloat(Kart.AnimalBoosterTime);
                oPacket.WriteEncFloat(Kart.SuperBoosterTime);
                oPacket.WriteEncFloat(SpeedType.TransAccelFactor + Kart.TransAccelFactor + TuneSpec.Tune_TransAccelFactor + KartLevelSpec.KartLevel_TransAccelFactor + PlantSpec.Plant_TransAccelFactor);
                oPacket.WriteEncFloat(SpeedType.BoostAccelFactor + Kart.BoostAccelFactor);
                oPacket.WriteEncFloat(Kart.StartBoosterTimeItem + KartLevelSpec.KartLevel_StartBoosterTimeItem);
                oPacket.WriteEncFloat(Kart.StartBoosterTimeSpeed + TuneSpec.Tune_StartBoosterTimeSpeed + KartLevelSpec.KartLevel_StartBoosterTimeSpeed + PlantSpec.Plant_StartBoosterTimeSpeed);
                oPacket.WriteEncFloat(SpeedType.StartForwardAccelForceItem + Kart.StartForwardAccelForceItem + FlyingPet.StartForwardAccelForceItem);
                oPacket.WriteEncFloat(SpeedType.StartForwardAccelForceSpeed + Kart.StartForwardAccelForceSpeed + FlyingPet.StartForwardAccelForceSpeed + PlantSpec.Plant_StartForwardAccelForceSpeed);
                oPacket.WriteEncFloat(Kart.DriftGaguePreservePercent);
                oPacket.WriteEncByte((byte)((Kart.UseExtendedAfterBooster ? 1 : 0)));
                oPacket.WriteEncFloat(Kart.BoostAccelFactorOnlyItem);
                oPacket.WriteEncFloat(0f);
                oPacket.WriteEncFloat(Kart.antiCollideBalance);
                //------------------------------------------------------------------------KartSpac End
                oPacket.WriteByte(0);
                oPacket.WriteInt(0);
                oPacket.WriteInt(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void PrchallengerKartSpec()
        {
            using (OutPacket oPacket = new OutPacket("PrchallengerKartSpec"))
            {
                oPacket.WriteByte(1);
                //------------------------------------------------------------------------KartSpac Start
                oPacket.WriteEncFloat(Kart.draftMulAccelFactor);
                oPacket.WriteEncInt(Kart.draftTick);
                oPacket.WriteEncFloat(Kart.driftBoostMulAccelFactor);
                oPacket.WriteEncInt(Kart.driftBoostTick);
                oPacket.WriteEncFloat(Kart.chargeBoostBySpeed);
                if (PlantSpec.Plant_SpeedSlotCapacity == 0)
                {
                    oPacket.WriteEncByte(Kart.SpeedSlotCapacity);
                }
                else
                {
                    oPacket.WriteEncByte(PlantSpec.Plant_SpeedSlotCapacity);
                }
                oPacket.WriteEncByte(Kart.ItemSlotCapacity);
                oPacket.WriteEncByte(Kart.SpecialSlotCapacity);
                oPacket.WriteEncByte((byte)((Kart.UseTransformBooster ? 1 : 0)));
                oPacket.WriteEncByte((byte)((Kart.motorcycleType ? 1 : 0)));
                oPacket.WriteEncFloat(Kart.Mass);
                oPacket.WriteEncFloat(Kart.AirFriction);
                oPacket.WriteEncFloat(SpeedType.DragFactor + Kart.DragFactor + FlyingPet.DragFactor + TuneSpec.Tune_DragFactor + PlantSpec.Plant_DragFactor);
                oPacket.WriteEncFloat(SpeedType.ForwardAccelForce + Kart.ForwardAccelForce + FlyingPet.ForwardAccelForce + TuneSpec.Tune_ForwardAccelForce + KartLevelSpec.KartLevel_ForwardAccelForce + PlantSpec.Plant_ForwardAccelForce);
                oPacket.WriteEncFloat(SpeedType.BackwardAccelForce + Kart.BackwardAccelForce + PlantSpec.Plant_BackwardAccelForce);
                oPacket.WriteEncFloat(SpeedType.GripBrakeForce + Kart.GripBrakeForce + PlantSpec.Plant_GripBrakeForce);
                oPacket.WriteEncFloat(SpeedType.SlipBrakeForce + Kart.SlipBrakeForce + PlantSpec.Plant_SlipBrakeForce);
                oPacket.WriteEncFloat(Kart.MaxSteerAngle);
                oPacket.WriteEncFloat(SpeedType.SteerConstraint + Kart.SteerConstraint + PlantSpec.Plant_SteerConstraint);
                oPacket.WriteEncFloat(Kart.FrontGripFactor + PlantSpec.Plant_FrontGripFactor);
                oPacket.WriteEncFloat(Kart.RearGripFactor + PlantSpec.Plant_RearGripFactor);
                oPacket.WriteEncFloat(Kart.DriftTriggerFactor);
                oPacket.WriteEncFloat(Kart.DriftTriggerTime);
                oPacket.WriteEncFloat(Kart.DriftSlipFactor + PlantSpec.Plant_DriftSlipFactor);
                oPacket.WriteEncFloat(SpeedType.DriftEscapeForce + Kart.DriftEscapeForce + FlyingPet.DriftEscapeForce + TuneSpec.Tune_DriftEscapeForce + KartLevelSpec.KartLevel_DriftEscapeForce + PlantSpec.Plant_DriftEscapeForce);
                oPacket.WriteEncFloat(SpeedType.CornerDrawFactor + Kart.CornerDrawFactor + FlyingPet.CornerDrawFactor + TuneSpec.Tune_CornerDrawFactor + KartLevelSpec.KartLevel_CornerDrawFactor + PlantSpec.Plant_CornerDrawFactor);
                oPacket.WriteEncFloat(Kart.DriftLeanFactor);
                oPacket.WriteEncFloat(Kart.SteerLeanFactor);
                if (StartGameData.StartTimeAttack_SpeedType == 4)
                {
                    oPacket.WriteEncFloat(GameType.S4_DriftMaxGauge);
                }
                else
                {
                    oPacket.WriteEncFloat(SpeedType.DriftMaxGauge + Kart.DriftMaxGauge + TuneSpec.Tune_DriftMaxGauge + PlantSpec.Plant_DriftMaxGauge);
                }
                oPacket.WriteEncFloat(Kart.NormalBoosterTime + FlyingPet.NormalBoosterTime + TuneSpec.Tune_NormalBoosterTime + PlantSpec.Plant_NormalBoosterTime);
                oPacket.WriteEncFloat(Kart.ItemBoosterTime + FlyingPet.ItemBoosterTime);
                oPacket.WriteEncFloat(Kart.TeamBoosterTime + FlyingPet.TeamBoosterTime + TuneSpec.Tune_TeamBoosterTime + PlantSpec.Plant_TeamBoosterTime);
                oPacket.WriteEncFloat(Kart.AnimalBoosterTime);
                oPacket.WriteEncFloat(Kart.SuperBoosterTime);
                oPacket.WriteEncFloat(SpeedType.TransAccelFactor + Kart.TransAccelFactor + TuneSpec.Tune_TransAccelFactor + KartLevelSpec.KartLevel_TransAccelFactor + PlantSpec.Plant_TransAccelFactor);
                oPacket.WriteEncFloat(SpeedType.BoostAccelFactor + Kart.BoostAccelFactor);
                oPacket.WriteEncFloat(Kart.StartBoosterTimeItem + KartLevelSpec.KartLevel_StartBoosterTimeItem);
                oPacket.WriteEncFloat(Kart.StartBoosterTimeSpeed + TuneSpec.Tune_StartBoosterTimeSpeed + KartLevelSpec.KartLevel_StartBoosterTimeSpeed + PlantSpec.Plant_StartBoosterTimeSpeed);
                oPacket.WriteEncFloat(SpeedType.StartForwardAccelForceItem + Kart.StartForwardAccelForceItem + FlyingPet.StartForwardAccelForceItem);
                oPacket.WriteEncFloat(SpeedType.StartForwardAccelForceSpeed + Kart.StartForwardAccelForceSpeed + FlyingPet.StartForwardAccelForceSpeed + PlantSpec.Plant_StartForwardAccelForceSpeed);
                oPacket.WriteEncFloat(Kart.DriftGaguePreservePercent);
                oPacket.WriteEncByte((byte)((Kart.UseExtendedAfterBooster ? 1 : 0)));
                oPacket.WriteEncFloat(Kart.BoostAccelFactorOnlyItem);
                oPacket.WriteEncFloat(0f);
                oPacket.WriteEncFloat(Kart.antiCollideBalance);
                //------------------------------------------------------------------------KartSpac End
                oPacket.WriteInt(0);
                oPacket.WriteByte(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void PrKartSpec()
        {
            using (OutPacket oPacket = new OutPacket("PrKartSpec"))
            {
                oPacket.WriteByte(1);
                //------------------------------------------------------------------------KartSpac Start
                oPacket.WriteEncFloat(Kart.draftMulAccelFactor);
                oPacket.WriteEncInt(Kart.draftTick);
                oPacket.WriteEncFloat(Kart.driftBoostMulAccelFactor);
                oPacket.WriteEncInt(Kart.driftBoostTick);
                oPacket.WriteEncFloat(Kart.chargeBoostBySpeed);
                oPacket.WriteEncByte(Kart.SpeedSlotCapacity);
                oPacket.WriteEncByte(Kart.ItemSlotCapacity);
                oPacket.WriteEncByte(Kart.SpecialSlotCapacity);
                oPacket.WriteEncByte((byte)((Kart.UseTransformBooster ? 1 : 0)));
                oPacket.WriteEncByte((byte)((Kart.motorcycleType ? 1 : 0)));
                oPacket.WriteEncFloat(Kart.Mass);
                oPacket.WriteEncFloat(Kart.AirFriction);
                oPacket.WriteEncFloat(SpeedType.DragFactor + Kart.DragFactor + FlyingPet.DragFactor);
                oPacket.WriteEncFloat(SpeedType.ForwardAccelForce + Kart.ForwardAccelForce + FlyingPet.ForwardAccelForce);
                oPacket.WriteEncFloat(SpeedType.BackwardAccelForce + Kart.BackwardAccelForce);
                oPacket.WriteEncFloat(SpeedType.GripBrakeForce + Kart.GripBrakeForce);
                oPacket.WriteEncFloat(SpeedType.SlipBrakeForce + Kart.SlipBrakeForce);
                oPacket.WriteEncFloat(Kart.MaxSteerAngle);
                oPacket.WriteEncFloat(SpeedType.SteerConstraint + Kart.SteerConstraint);
                oPacket.WriteEncFloat(Kart.FrontGripFactor);
                oPacket.WriteEncFloat(Kart.RearGripFactor);
                oPacket.WriteEncFloat(Kart.DriftTriggerFactor);
                oPacket.WriteEncFloat(Kart.DriftTriggerTime);
                oPacket.WriteEncFloat(Kart.DriftSlipFactor);
                oPacket.WriteEncFloat(SpeedType.DriftEscapeForce + Kart.DriftEscapeForce + FlyingPet.DriftEscapeForce);
                oPacket.WriteEncFloat(SpeedType.CornerDrawFactor + Kart.CornerDrawFactor + FlyingPet.CornerDrawFactor);
                oPacket.WriteEncFloat(Kart.DriftLeanFactor);
                oPacket.WriteEncFloat(Kart.SteerLeanFactor);
                if (StartGameData.StartTimeAttack_SpeedType == 4)
                {
                    oPacket.WriteEncFloat(GameType.S4_DriftMaxGauge);
                }
                else
                {
                    oPacket.WriteEncFloat(SpeedType.DriftMaxGauge + Kart.DriftMaxGauge);
                }
                oPacket.WriteEncFloat(Kart.NormalBoosterTime + FlyingPet.NormalBoosterTime);
                oPacket.WriteEncFloat(Kart.ItemBoosterTime + FlyingPet.ItemBoosterTime);
                oPacket.WriteEncFloat(Kart.TeamBoosterTime + FlyingPet.TeamBoosterTime);
                oPacket.WriteEncFloat(Kart.AnimalBoosterTime);
                oPacket.WriteEncFloat(Kart.SuperBoosterTime);
                oPacket.WriteEncFloat(SpeedType.TransAccelFactor + Kart.TransAccelFactor);
                oPacket.WriteEncFloat(SpeedType.BoostAccelFactor + Kart.BoostAccelFactor);
                oPacket.WriteEncFloat(Kart.StartBoosterTimeItem);
                oPacket.WriteEncFloat(Kart.StartBoosterTimeSpeed);
                oPacket.WriteEncFloat(SpeedType.StartForwardAccelForceItem + Kart.StartForwardAccelForceItem + FlyingPet.StartForwardAccelForceItem);
                oPacket.WriteEncFloat(SpeedType.StartForwardAccelForceSpeed + Kart.StartForwardAccelForceSpeed + FlyingPet.StartForwardAccelForceSpeed);
                oPacket.WriteEncFloat(Kart.DriftGaguePreservePercent);
                oPacket.WriteEncByte((byte)((Kart.UseExtendedAfterBooster ? 1 : 0)));
                oPacket.WriteEncFloat(Kart.BoostAccelFactorOnlyItem);
                oPacket.WriteEncFloat(0f);
                oPacket.WriteEncFloat(Kart.antiCollideBalance);
                //------------------------------------------------------------------------KartSpac End
                oPacket.WriteByte(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        public static void PrStartTimeAttack_QuestType()
        {
            using (OutPacket oPacket = new OutPacket("PrStartTimeAttack"))
            {
                oPacket.WriteByte(1);
                //------------------------------------------------------------------------KartSpac Start
                oPacket.WriteEncFloat(Kart.draftMulAccelFactor);
                oPacket.WriteEncInt(Kart.draftTick);
                oPacket.WriteEncFloat(Kart.driftBoostMulAccelFactor);
                oPacket.WriteEncInt(Kart.driftBoostTick);
                oPacket.WriteEncFloat(Kart.chargeBoostBySpeed);
                oPacket.WriteEncByte(Kart.SpeedSlotCapacity);
                oPacket.WriteEncByte(Kart.ItemSlotCapacity);
                oPacket.WriteEncByte(Kart.SpecialSlotCapacity);
                oPacket.WriteEncByte((byte)((Kart.UseTransformBooster ? 1 : 0)));
                oPacket.WriteEncByte((byte)((Kart.motorcycleType ? 1 : 0)));
                oPacket.WriteEncFloat(Kart.Mass);
                oPacket.WriteEncFloat(Kart.AirFriction);
                oPacket.WriteEncFloat(SpeedType.DragFactor + Kart.DragFactor + FlyingPet.DragFactor);
                oPacket.WriteEncFloat(SpeedType.ForwardAccelForce + Kart.ForwardAccelForce + FlyingPet.ForwardAccelForce);
                oPacket.WriteEncFloat(SpeedType.BackwardAccelForce + Kart.BackwardAccelForce);
                oPacket.WriteEncFloat(SpeedType.GripBrakeForce + Kart.GripBrakeForce);
                oPacket.WriteEncFloat(SpeedType.SlipBrakeForce + Kart.SlipBrakeForce);
                oPacket.WriteEncFloat(Kart.MaxSteerAngle);
                oPacket.WriteEncFloat(SpeedType.SteerConstraint + Kart.SteerConstraint);
                oPacket.WriteEncFloat(Kart.FrontGripFactor);
                oPacket.WriteEncFloat(Kart.RearGripFactor);
                oPacket.WriteEncFloat(Kart.DriftTriggerFactor);
                oPacket.WriteEncFloat(Kart.DriftTriggerTime);
                oPacket.WriteEncFloat(Kart.DriftSlipFactor);
                oPacket.WriteEncFloat(SpeedType.DriftEscapeForce + Kart.DriftEscapeForce + FlyingPet.DriftEscapeForce);
                oPacket.WriteEncFloat(SpeedType.CornerDrawFactor + Kart.CornerDrawFactor + FlyingPet.CornerDrawFactor);
                oPacket.WriteEncFloat(Kart.DriftLeanFactor);
                oPacket.WriteEncFloat(Kart.SteerLeanFactor);
                if (StartGameData.StartTimeAttack_SpeedType == 4)
                {
                    oPacket.WriteEncFloat(GameType.S4_DriftMaxGauge);
                }
                else
                {
                    oPacket.WriteEncFloat(SpeedType.DriftMaxGauge + Kart.DriftMaxGauge);
                }
                oPacket.WriteEncFloat(Kart.NormalBoosterTime + FlyingPet.NormalBoosterTime);
                oPacket.WriteEncFloat(Kart.ItemBoosterTime + FlyingPet.ItemBoosterTime);
                oPacket.WriteEncFloat(Kart.TeamBoosterTime + FlyingPet.TeamBoosterTime);
                oPacket.WriteEncFloat(Kart.AnimalBoosterTime);
                oPacket.WriteEncFloat(Kart.SuperBoosterTime);
                oPacket.WriteEncFloat(SpeedType.TransAccelFactor + Kart.TransAccelFactor);
                oPacket.WriteEncFloat(SpeedType.BoostAccelFactor + Kart.BoostAccelFactor);
                oPacket.WriteEncFloat(Kart.StartBoosterTimeItem);
                oPacket.WriteEncFloat(Kart.StartBoosterTimeSpeed);
                oPacket.WriteEncFloat(SpeedType.StartForwardAccelForceItem + Kart.StartForwardAccelForceItem + FlyingPet.StartForwardAccelForceItem);
                oPacket.WriteEncFloat(SpeedType.StartForwardAccelForceSpeed + Kart.StartForwardAccelForceSpeed + FlyingPet.StartForwardAccelForceSpeed);
                oPacket.WriteEncFloat(Kart.DriftGaguePreservePercent);
                oPacket.WriteEncByte((byte)((Kart.UseExtendedAfterBooster ? 1 : 0)));
                oPacket.WriteEncFloat(Kart.BoostAccelFactorOnlyItem);
                oPacket.WriteEncFloat(0f);
                oPacket.WriteEncFloat(Kart.antiCollideBalance);
                //------------------------------------------------------------------------KartSpac End
                oPacket.WriteByte(0);
                oPacket.WriteInt(0);
                oPacket.WriteInt(0);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }
    }
}