using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200001C RID: 28
	[StructLayout(2)]
	public struct AnimationHumanStream
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x0000AEE8 File Offset: 0x000090E8
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationHumanStream()
		{
			Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationHumanStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr);
			AnimationHumanStream.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, "stream");
			AnimationHumanStream.GetHumanScale_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetHumanScale_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetHumanScale_Injected");
			AnimationHumanStream.GetFootHeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetFootHeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetFootHeight_Injected");
			AnimationHumanStream.InternalResetToStancePose_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalResetToStancePose_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalResetToStancePose_Injected");
			AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalPositionFromPose_Injected");
			AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalRotationFromPose_Injected");
			AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyLocalPosition_Injected");
			AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyLocalPosition_Injected");
			AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyLocalRotation_Injected");
			AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyLocalRotation_Injected");
			AnimationHumanStream.InternalGetBodyPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyPosition_Injected");
			AnimationHumanStream.InternalSetBodyPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyPosition_Injected");
			AnimationHumanStream.InternalGetBodyRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetBodyRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetBodyRotation_Injected");
			AnimationHumanStream.InternalSetBodyRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetBodyRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetBodyRotation_Injected");
			AnimationHumanStream.GetLeftFootVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetLeftFootVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetLeftFootVelocity_Injected");
			AnimationHumanStream.GetRightFootVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.GetRightFootVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::GetRightFootVelocity_Injected");
			AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalLocalPosition_Injected");
			AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalLocalPosition_Injected");
			AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalLocalRotation_Injected");
			AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalLocalRotation_Injected");
			AnimationHumanStream.InternalGetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalPosition_Injected");
			AnimationHumanStream.InternalSetGoalPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalPosition_Injected");
			AnimationHumanStream.InternalGetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalRotation_Injected");
			AnimationHumanStream.InternalSetGoalRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalRotation_Injected");
			AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalWeightPosition_Injected");
			AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetGoalWeightRotation_Injected");
			AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalWeightPosition_Injected");
			AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetGoalWeightRotation_Injected");
			AnimationHumanStream.InternalGetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetHintPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetHintPosition_Injected");
			AnimationHumanStream.InternalSetHintPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetHintPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetHintPosition_Injected");
			AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetHintWeightPosition_Injected");
			AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalGetHintWeightPosition_Injected");
			AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtPosition_Injected");
			AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtClampWeight_Injected");
			AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtBodyWeight_Injected");
			AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtHeadWeight_Injected");
			AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSetLookAtEyesWeight_Injected");
			AnimationHumanStream.InternalSolveIK_InjectedDelegateField = IL2CPP.ResolveICall<AnimationHumanStream.InternalSolveIK_InjectedDelegate>("UnityEngine.Animations.AnimationHumanStream::InternalSolveIK_Injected");
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00003C34 File Offset: 0x00001E34
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationHumanStream>.NativeClassPtr, ref this));
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000B158 File Offset: 0x00009358
		public bool isValid
		{
			get
			{
				return this.stream != IntPtr.Zero;
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000B17C File Offset: 0x0000937C
		public void ThrowIfInvalid()
		{
			bool flag = !this.isValid;
			if (flag)
			{
				throw new InvalidOperationException("The AnimationHumanStream is invalid.");
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000B1A4 File Offset: 0x000093A4
		public float humanScale
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetHumanScale();
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000B1C4 File Offset: 0x000093C4
		public float leftFootHeight
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetFootHeight(true);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000B1E4 File Offset: 0x000093E4
		public float rightFootHeight
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetFootHeight(false);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000B204 File Offset: 0x00009404
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00003C46 File Offset: 0x00001E46
		public Vector3 bodyLocalPosition
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyLocalPosition();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyLocalPosition(value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000B224 File Offset: 0x00009424
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00003C58 File Offset: 0x00001E58
		public Quaternion bodyLocalRotation
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyLocalRotation();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyLocalRotation(value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000B244 File Offset: 0x00009444
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00003C6A File Offset: 0x00001E6A
		public Vector3 bodyPosition
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyPosition();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyPosition(value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000B264 File Offset: 0x00009464
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003C7C File Offset: 0x00001E7C
		public Quaternion bodyRotation
		{
			get
			{
				this.ThrowIfInvalid();
				return this.InternalGetBodyRotation();
			}
			set
			{
				this.ThrowIfInvalid();
				this.InternalSetBodyRotation(value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000B284 File Offset: 0x00009484
		public Vector3 leftFootVelocity
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetLeftFootVelocity();
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000B2A4 File Offset: 0x000094A4
		public Vector3 rightFootVelocity
		{
			get
			{
				this.ThrowIfInvalid();
				return this.GetRightFootVelocity();
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00003C8E File Offset: 0x00001E8E
		public void ResetToStancePose()
		{
			this.ThrowIfInvalid();
			this.InternalResetToStancePose();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000B2C4 File Offset: 0x000094C4
		public Vector3 GetGoalPositionFromPose(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalPositionFromPose(index);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000B2E4 File Offset: 0x000094E4
		public Quaternion GetGoalRotationFromPose(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalRotationFromPose(index);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000B304 File Offset: 0x00009504
		public Vector3 GetGoalLocalPosition(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalLocalPosition(index);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00003C9F File Offset: 0x00001E9F
		public void SetGoalLocalPosition(AvatarIKGoal index, Vector3 pos)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalLocalPosition(index, pos);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000B324 File Offset: 0x00009524
		public Quaternion GetGoalLocalRotation(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalLocalRotation(index);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00003CB2 File Offset: 0x00001EB2
		public void SetGoalLocalRotation(AvatarIKGoal index, Quaternion rot)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalLocalRotation(index, rot);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000B344 File Offset: 0x00009544
		public Vector3 GetGoalPosition(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalPosition(index);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00003CC5 File Offset: 0x00001EC5
		public void SetGoalPosition(AvatarIKGoal index, Vector3 pos)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalPosition(index, pos);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000B364 File Offset: 0x00009564
		public Quaternion GetGoalRotation(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalRotation(index);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public void SetGoalRotation(AvatarIKGoal index, Quaternion rot)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalRotation(index, rot);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00003CEB File Offset: 0x00001EEB
		public void SetGoalWeightPosition(AvatarIKGoal index, float value)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalWeightPosition(index, value);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00003CFE File Offset: 0x00001EFE
		public void SetGoalWeightRotation(AvatarIKGoal index, float value)
		{
			this.ThrowIfInvalid();
			this.InternalSetGoalWeightRotation(index, value);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000B384 File Offset: 0x00009584
		public float GetGoalWeightPosition(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalWeightPosition(index);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public float GetGoalWeightRotation(AvatarIKGoal index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetGoalWeightRotation(index);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000B3C4 File Offset: 0x000095C4
		public Vector3 GetHintPosition(AvatarIKHint index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetHintPosition(index);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00003D11 File Offset: 0x00001F11
		public void SetHintPosition(AvatarIKHint index, Vector3 pos)
		{
			this.ThrowIfInvalid();
			this.InternalSetHintPosition(index, pos);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003D24 File Offset: 0x00001F24
		public void SetHintWeightPosition(AvatarIKHint index, float value)
		{
			this.ThrowIfInvalid();
			this.InternalSetHintWeightPosition(index, value);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000B3E4 File Offset: 0x000095E4
		public float GetHintWeightPosition(AvatarIKHint index)
		{
			this.ThrowIfInvalid();
			return this.InternalGetHintWeightPosition(index);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00003D37 File Offset: 0x00001F37
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtPosition(lookAtPosition);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003D49 File Offset: 0x00001F49
		public void SetLookAtClampWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtClampWeight(weight);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003D5B File Offset: 0x00001F5B
		public void SetLookAtBodyWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtBodyWeight(weight);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003D6D File Offset: 0x00001F6D
		public void SetLookAtHeadWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtHeadWeight(weight);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00003D7F File Offset: 0x00001F7F
		public void SetLookAtEyesWeight(float weight)
		{
			this.ThrowIfInvalid();
			this.InternalSetLookAtEyesWeight(weight);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00003D91 File Offset: 0x00001F91
		public void SolveIK()
		{
			this.ThrowIfInvalid();
			this.InternalSolveIK();
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003DA2 File Offset: 0x00001FA2
		public float GetHumanScale()
		{
			return AnimationHumanStream.GetHumanScale_Injected(ref this);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00003DAA File Offset: 0x00001FAA
		public float GetFootHeight(bool left)
		{
			return AnimationHumanStream.GetFootHeight_Injected(ref this, left);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00003DB3 File Offset: 0x00001FB3
		public void InternalResetToStancePose()
		{
			AnimationHumanStream.InternalResetToStancePose_Injected(ref this);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000B404 File Offset: 0x00009604
		public Vector3 InternalGetGoalPositionFromPose(AvatarIKGoal index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetGoalPositionFromPose_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000B41C File Offset: 0x0000961C
		public Quaternion InternalGetGoalRotationFromPose(AvatarIKGoal index)
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetGoalRotationFromPose_Injected(ref this, index, out quaternion);
			return quaternion;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000B434 File Offset: 0x00009634
		public Vector3 InternalGetBodyLocalPosition()
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetBodyLocalPosition_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00003DBB File Offset: 0x00001FBB
		public void InternalSetBodyLocalPosition(Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyLocalPosition_Injected(ref this, ref value);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000B44C File Offset: 0x0000964C
		public Quaternion InternalGetBodyLocalRotation()
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetBodyLocalRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003DC5 File Offset: 0x00001FC5
		public void InternalSetBodyLocalRotation(Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyLocalRotation_Injected(ref this, ref value);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000B464 File Offset: 0x00009664
		public Vector3 InternalGetBodyPosition()
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetBodyPosition_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003DCF File Offset: 0x00001FCF
		public void InternalSetBodyPosition(Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyPosition_Injected(ref this, ref value);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000B47C File Offset: 0x0000967C
		public Quaternion InternalGetBodyRotation()
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetBodyRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003DD9 File Offset: 0x00001FD9
		public void InternalSetBodyRotation(Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyRotation_Injected(ref this, ref value);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000B494 File Offset: 0x00009694
		public Vector3 GetLeftFootVelocity()
		{
			Vector3 vector;
			AnimationHumanStream.GetLeftFootVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000B4AC File Offset: 0x000096AC
		public Vector3 GetRightFootVelocity()
		{
			Vector3 vector;
			AnimationHumanStream.GetRightFootVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000B4C4 File Offset: 0x000096C4
		public Vector3 InternalGetGoalLocalPosition(AvatarIKGoal index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetGoalLocalPosition_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003DE3 File Offset: 0x00001FE3
		public void InternalSetGoalLocalPosition(AvatarIKGoal index, Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalLocalPosition_Injected(ref this, index, ref pos);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000B4DC File Offset: 0x000096DC
		public Quaternion InternalGetGoalLocalRotation(AvatarIKGoal index)
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetGoalLocalRotation_Injected(ref this, index, out quaternion);
			return quaternion;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00003DEE File Offset: 0x00001FEE
		public void InternalSetGoalLocalRotation(AvatarIKGoal index, Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalLocalRotation_Injected(ref this, index, ref rot);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000B4F4 File Offset: 0x000096F4
		public Vector3 InternalGetGoalPosition(AvatarIKGoal index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetGoalPosition_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003DF9 File Offset: 0x00001FF9
		public void InternalSetGoalPosition(AvatarIKGoal index, Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalPosition_Injected(ref this, index, ref pos);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000B50C File Offset: 0x0000970C
		public Quaternion InternalGetGoalRotation(AvatarIKGoal index)
		{
			Quaternion quaternion;
			AnimationHumanStream.InternalGetGoalRotation_Injected(ref this, index, out quaternion);
			return quaternion;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003E04 File Offset: 0x00002004
		public void InternalSetGoalRotation(AvatarIKGoal index, Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalRotation_Injected(ref this, index, ref rot);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00003E0F File Offset: 0x0000200F
		public void InternalSetGoalWeightPosition(AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightPosition_Injected(ref this, index, value);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00003E19 File Offset: 0x00002019
		public void InternalSetGoalWeightRotation(AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightRotation_Injected(ref this, index, value);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00003E23 File Offset: 0x00002023
		public float InternalGetGoalWeightPosition(AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightPosition_Injected(ref this, index);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00003E2C File Offset: 0x0000202C
		public float InternalGetGoalWeightRotation(AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightRotation_Injected(ref this, index);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000B524 File Offset: 0x00009724
		public Vector3 InternalGetHintPosition(AvatarIKHint index)
		{
			Vector3 vector;
			AnimationHumanStream.InternalGetHintPosition_Injected(ref this, index, out vector);
			return vector;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00003E35 File Offset: 0x00002035
		public void InternalSetHintPosition(AvatarIKHint index, Vector3 pos)
		{
			AnimationHumanStream.InternalSetHintPosition_Injected(ref this, index, ref pos);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003E40 File Offset: 0x00002040
		public void InternalSetHintWeightPosition(AvatarIKHint index, float value)
		{
			AnimationHumanStream.InternalSetHintWeightPosition_Injected(ref this, index, value);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00003E4A File Offset: 0x0000204A
		public float InternalGetHintWeightPosition(AvatarIKHint index)
		{
			return AnimationHumanStream.InternalGetHintWeightPosition_Injected(ref this, index);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00003E53 File Offset: 0x00002053
		public void InternalSetLookAtPosition(Vector3 lookAtPosition)
		{
			AnimationHumanStream.InternalSetLookAtPosition_Injected(ref this, ref lookAtPosition);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003E5D File Offset: 0x0000205D
		public void InternalSetLookAtClampWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtClampWeight_Injected(ref this, weight);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003E66 File Offset: 0x00002066
		public void InternalSetLookAtBodyWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtBodyWeight_Injected(ref this, weight);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00003E6F File Offset: 0x0000206F
		public void InternalSetLookAtHeadWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtHeadWeight_Injected(ref this, weight);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003E78 File Offset: 0x00002078
		public void InternalSetLookAtEyesWeight(float weight)
		{
			AnimationHumanStream.InternalSetLookAtEyesWeight_Injected(ref this, weight);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00003E81 File Offset: 0x00002081
		public void InternalSolveIK()
		{
			AnimationHumanStream.InternalSolveIK_Injected(ref this);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00003E89 File Offset: 0x00002089
		public static float GetHumanScale_Injected(ref AnimationHumanStream _unity_self)
		{
			return AnimationHumanStream.GetHumanScale_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00003E96 File Offset: 0x00002096
		public static float GetFootHeight_Injected(ref AnimationHumanStream _unity_self, bool left)
		{
			return AnimationHumanStream.GetFootHeight_InjectedDelegateField(ref _unity_self, left);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00003EA4 File Offset: 0x000020A4
		public static void InternalResetToStancePose_Injected(ref AnimationHumanStream _unity_self)
		{
			AnimationHumanStream.InternalResetToStancePose_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00003EB1 File Offset: 0x000020B1
		public static void InternalGetGoalPositionFromPose_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003EC0 File Offset: 0x000020C0
		public static void InternalGetGoalRotationFromPose_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00003ECF File Offset: 0x000020CF
		public static void InternalGetBodyLocalPosition_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00003EDD File Offset: 0x000020DD
		public static void InternalSetBodyLocalPosition_Injected(ref AnimationHumanStream _unity_self, ref Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00003EEB File Offset: 0x000020EB
		public static void InternalGetBodyLocalRotation_Injected(ref AnimationHumanStream _unity_self, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00003EF9 File Offset: 0x000020F9
		public static void InternalSetBodyLocalRotation_Injected(ref AnimationHumanStream _unity_self, ref Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00003F07 File Offset: 0x00002107
		public static void InternalGetBodyPosition_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetBodyPosition_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00003F15 File Offset: 0x00002115
		public static void InternalSetBodyPosition_Injected(ref AnimationHumanStream _unity_self, ref Vector3 value)
		{
			AnimationHumanStream.InternalSetBodyPosition_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003F23 File Offset: 0x00002123
		public static void InternalGetBodyRotation_Injected(ref AnimationHumanStream _unity_self, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetBodyRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003F31 File Offset: 0x00002131
		public static void InternalSetBodyRotation_Injected(ref AnimationHumanStream _unity_self, ref Quaternion value)
		{
			AnimationHumanStream.InternalSetBodyRotation_InjectedDelegateField(ref _unity_self, ref value);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00003F3F File Offset: 0x0000213F
		public static void GetLeftFootVelocity_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.GetLeftFootVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00003F4D File Offset: 0x0000214D
		public static void GetRightFootVelocity_Injected(ref AnimationHumanStream _unity_self, out Vector3 ret)
		{
			AnimationHumanStream.GetRightFootVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00003F5B File Offset: 0x0000215B
		public static void InternalGetGoalLocalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003F6A File Offset: 0x0000216A
		public static void InternalSetGoalLocalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegateField(ref _unity_self, index, ref pos);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00003F79 File Offset: 0x00002179
		public static void InternalGetGoalLocalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00003F88 File Offset: 0x00002188
		public static void InternalSetGoalLocalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegateField(ref _unity_self, index, ref rot);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00003F97 File Offset: 0x00002197
		public static void InternalGetGoalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetGoalPosition_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00003FA6 File Offset: 0x000021A6
		public static void InternalSetGoalPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Vector3 pos)
		{
			AnimationHumanStream.InternalSetGoalPosition_InjectedDelegateField(ref _unity_self, index, ref pos);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00003FB5 File Offset: 0x000021B5
		public static void InternalGetGoalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, out Quaternion ret)
		{
			AnimationHumanStream.InternalGetGoalRotation_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003FC4 File Offset: 0x000021C4
		public static void InternalSetGoalRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, ref Quaternion rot)
		{
			AnimationHumanStream.InternalSetGoalRotation_InjectedDelegateField(ref _unity_self, index, ref rot);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00003FD3 File Offset: 0x000021D3
		public static void InternalSetGoalWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegateField(ref _unity_self, index, value);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00003FE2 File Offset: 0x000021E2
		public static void InternalSetGoalWeightRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index, float value)
		{
			AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegateField(ref _unity_self, index, value);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00003FF1 File Offset: 0x000021F1
		public static float InternalGetGoalWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003FFF File Offset: 0x000021FF
		public static float InternalGetGoalWeightRotation_Injected(ref AnimationHumanStream _unity_self, AvatarIKGoal index)
		{
			return AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000400D File Offset: 0x0000220D
		public static void InternalGetHintPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, out Vector3 ret)
		{
			AnimationHumanStream.InternalGetHintPosition_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000401C File Offset: 0x0000221C
		public static void InternalSetHintPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, ref Vector3 pos)
		{
			AnimationHumanStream.InternalSetHintPosition_InjectedDelegateField(ref _unity_self, index, ref pos);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000402B File Offset: 0x0000222B
		public static void InternalSetHintWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index, float value)
		{
			AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegateField(ref _unity_self, index, value);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000403A File Offset: 0x0000223A
		public static float InternalGetHintWeightPosition_Injected(ref AnimationHumanStream _unity_self, AvatarIKHint index)
		{
			return AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00004048 File Offset: 0x00002248
		public static void InternalSetLookAtPosition_Injected(ref AnimationHumanStream _unity_self, ref Vector3 lookAtPosition)
		{
			AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegateField(ref _unity_self, ref lookAtPosition);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00004056 File Offset: 0x00002256
		public static void InternalSetLookAtClampWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00004064 File Offset: 0x00002264
		public static void InternalSetLookAtBodyWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00004072 File Offset: 0x00002272
		public static void InternalSetLookAtHeadWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00004080 File Offset: 0x00002280
		public static void InternalSetLookAtEyesWeight_Injected(ref AnimationHumanStream _unity_self, float weight)
		{
			AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000408E File Offset: 0x0000228E
		public static void InternalSolveIK_Injected(ref AnimationHumanStream _unity_self)
		{
			AnimationHumanStream.InternalSolveIK_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x040001C0 RID: 448
		[FieldOffset(0)]
		public IntPtr stream;

		// Token: 0x040001C1 RID: 449
		private static readonly AnimationHumanStream.GetHumanScale_InjectedDelegate GetHumanScale_InjectedDelegateField;

		// Token: 0x040001C2 RID: 450
		private static readonly AnimationHumanStream.GetFootHeight_InjectedDelegate GetFootHeight_InjectedDelegateField;

		// Token: 0x040001C3 RID: 451
		private static readonly AnimationHumanStream.InternalResetToStancePose_InjectedDelegate InternalResetToStancePose_InjectedDelegateField;

		// Token: 0x040001C4 RID: 452
		private static readonly AnimationHumanStream.InternalGetGoalPositionFromPose_InjectedDelegate InternalGetGoalPositionFromPose_InjectedDelegateField;

		// Token: 0x040001C5 RID: 453
		private static readonly AnimationHumanStream.InternalGetGoalRotationFromPose_InjectedDelegate InternalGetGoalRotationFromPose_InjectedDelegateField;

		// Token: 0x040001C6 RID: 454
		private static readonly AnimationHumanStream.InternalGetBodyLocalPosition_InjectedDelegate InternalGetBodyLocalPosition_InjectedDelegateField;

		// Token: 0x040001C7 RID: 455
		private static readonly AnimationHumanStream.InternalSetBodyLocalPosition_InjectedDelegate InternalSetBodyLocalPosition_InjectedDelegateField;

		// Token: 0x040001C8 RID: 456
		private static readonly AnimationHumanStream.InternalGetBodyLocalRotation_InjectedDelegate InternalGetBodyLocalRotation_InjectedDelegateField;

		// Token: 0x040001C9 RID: 457
		private static readonly AnimationHumanStream.InternalSetBodyLocalRotation_InjectedDelegate InternalSetBodyLocalRotation_InjectedDelegateField;

		// Token: 0x040001CA RID: 458
		private static readonly AnimationHumanStream.InternalGetBodyPosition_InjectedDelegate InternalGetBodyPosition_InjectedDelegateField;

		// Token: 0x040001CB RID: 459
		private static readonly AnimationHumanStream.InternalSetBodyPosition_InjectedDelegate InternalSetBodyPosition_InjectedDelegateField;

		// Token: 0x040001CC RID: 460
		private static readonly AnimationHumanStream.InternalGetBodyRotation_InjectedDelegate InternalGetBodyRotation_InjectedDelegateField;

		// Token: 0x040001CD RID: 461
		private static readonly AnimationHumanStream.InternalSetBodyRotation_InjectedDelegate InternalSetBodyRotation_InjectedDelegateField;

		// Token: 0x040001CE RID: 462
		private static readonly AnimationHumanStream.GetLeftFootVelocity_InjectedDelegate GetLeftFootVelocity_InjectedDelegateField;

		// Token: 0x040001CF RID: 463
		private static readonly AnimationHumanStream.GetRightFootVelocity_InjectedDelegate GetRightFootVelocity_InjectedDelegateField;

		// Token: 0x040001D0 RID: 464
		private static readonly AnimationHumanStream.InternalGetGoalLocalPosition_InjectedDelegate InternalGetGoalLocalPosition_InjectedDelegateField;

		// Token: 0x040001D1 RID: 465
		private static readonly AnimationHumanStream.InternalSetGoalLocalPosition_InjectedDelegate InternalSetGoalLocalPosition_InjectedDelegateField;

		// Token: 0x040001D2 RID: 466
		private static readonly AnimationHumanStream.InternalGetGoalLocalRotation_InjectedDelegate InternalGetGoalLocalRotation_InjectedDelegateField;

		// Token: 0x040001D3 RID: 467
		private static readonly AnimationHumanStream.InternalSetGoalLocalRotation_InjectedDelegate InternalSetGoalLocalRotation_InjectedDelegateField;

		// Token: 0x040001D4 RID: 468
		private static readonly AnimationHumanStream.InternalGetGoalPosition_InjectedDelegate InternalGetGoalPosition_InjectedDelegateField;

		// Token: 0x040001D5 RID: 469
		private static readonly AnimationHumanStream.InternalSetGoalPosition_InjectedDelegate InternalSetGoalPosition_InjectedDelegateField;

		// Token: 0x040001D6 RID: 470
		private static readonly AnimationHumanStream.InternalGetGoalRotation_InjectedDelegate InternalGetGoalRotation_InjectedDelegateField;

		// Token: 0x040001D7 RID: 471
		private static readonly AnimationHumanStream.InternalSetGoalRotation_InjectedDelegate InternalSetGoalRotation_InjectedDelegateField;

		// Token: 0x040001D8 RID: 472
		private static readonly AnimationHumanStream.InternalSetGoalWeightPosition_InjectedDelegate InternalSetGoalWeightPosition_InjectedDelegateField;

		// Token: 0x040001D9 RID: 473
		private static readonly AnimationHumanStream.InternalSetGoalWeightRotation_InjectedDelegate InternalSetGoalWeightRotation_InjectedDelegateField;

		// Token: 0x040001DA RID: 474
		private static readonly AnimationHumanStream.InternalGetGoalWeightPosition_InjectedDelegate InternalGetGoalWeightPosition_InjectedDelegateField;

		// Token: 0x040001DB RID: 475
		private static readonly AnimationHumanStream.InternalGetGoalWeightRotation_InjectedDelegate InternalGetGoalWeightRotation_InjectedDelegateField;

		// Token: 0x040001DC RID: 476
		private static readonly AnimationHumanStream.InternalGetHintPosition_InjectedDelegate InternalGetHintPosition_InjectedDelegateField;

		// Token: 0x040001DD RID: 477
		private static readonly AnimationHumanStream.InternalSetHintPosition_InjectedDelegate InternalSetHintPosition_InjectedDelegateField;

		// Token: 0x040001DE RID: 478
		private static readonly AnimationHumanStream.InternalSetHintWeightPosition_InjectedDelegate InternalSetHintWeightPosition_InjectedDelegateField;

		// Token: 0x040001DF RID: 479
		private static readonly AnimationHumanStream.InternalGetHintWeightPosition_InjectedDelegate InternalGetHintWeightPosition_InjectedDelegateField;

		// Token: 0x040001E0 RID: 480
		private static readonly AnimationHumanStream.InternalSetLookAtPosition_InjectedDelegate InternalSetLookAtPosition_InjectedDelegateField;

		// Token: 0x040001E1 RID: 481
		private static readonly AnimationHumanStream.InternalSetLookAtClampWeight_InjectedDelegate InternalSetLookAtClampWeight_InjectedDelegateField;

		// Token: 0x040001E2 RID: 482
		private static readonly AnimationHumanStream.InternalSetLookAtBodyWeight_InjectedDelegate InternalSetLookAtBodyWeight_InjectedDelegateField;

		// Token: 0x040001E3 RID: 483
		private static readonly AnimationHumanStream.InternalSetLookAtHeadWeight_InjectedDelegate InternalSetLookAtHeadWeight_InjectedDelegateField;

		// Token: 0x040001E4 RID: 484
		private static readonly AnimationHumanStream.InternalSetLookAtEyesWeight_InjectedDelegate InternalSetLookAtEyesWeight_InjectedDelegateField;

		// Token: 0x040001E5 RID: 485
		private static readonly AnimationHumanStream.InternalSolveIK_InjectedDelegate InternalSolveIK_InjectedDelegateField;

		// Token: 0x0200015D RID: 349
		// (Invoke) Token: 0x060007B1 RID: 1969
		private delegate float GetHumanScale_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200015E RID: 350
		// (Invoke) Token: 0x060007B3 RID: 1971
		private delegate float GetFootHeight_InjectedDelegate(IntPtr _unity_self, bool left);

		// Token: 0x0200015F RID: 351
		// (Invoke) Token: 0x060007B5 RID: 1973
		private delegate void InternalResetToStancePose_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000160 RID: 352
		// (Invoke) Token: 0x060007B7 RID: 1975
		private delegate void InternalGetGoalPositionFromPose_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x02000161 RID: 353
		// (Invoke) Token: 0x060007B9 RID: 1977
		private delegate void InternalGetGoalRotationFromPose_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x02000162 RID: 354
		// (Invoke) Token: 0x060007BB RID: 1979
		private delegate void InternalGetBodyLocalPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000163 RID: 355
		// (Invoke) Token: 0x060007BD RID: 1981
		private delegate void InternalSetBodyLocalPosition_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x02000164 RID: 356
		// (Invoke) Token: 0x060007BF RID: 1983
		private delegate void InternalGetBodyLocalRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x060007C1 RID: 1985
		private delegate void InternalSetBodyLocalRotation_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x060007C3 RID: 1987
		private delegate void InternalGetBodyPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x060007C5 RID: 1989
		private delegate void InternalSetBodyPosition_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x060007C7 RID: 1991
		private delegate void InternalGetBodyRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x060007C9 RID: 1993
		private delegate void InternalSetBodyRotation_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x060007CB RID: 1995
		private delegate void GetLeftFootVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x060007CD RID: 1997
		private delegate void GetRightFootVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x060007CF RID: 1999
		private delegate void InternalGetGoalLocalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x060007D1 RID: 2001
		private delegate void InternalSetGoalLocalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr pos);

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x060007D3 RID: 2003
		private delegate void InternalGetGoalLocalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x060007D5 RID: 2005
		private delegate void InternalSetGoalLocalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr rot);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x060007D7 RID: 2007
		private delegate void InternalGetGoalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x060007D9 RID: 2009
		private delegate void InternalSetGoalPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr pos);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x060007DB RID: 2011
		private delegate void InternalGetGoalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, [Out] IntPtr ret);

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x060007DD RID: 2013
		private delegate void InternalSetGoalRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, IntPtr rot);

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x060007DF RID: 2015
		private delegate void InternalSetGoalWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, float value);

		// Token: 0x02000175 RID: 373
		// (Invoke) Token: 0x060007E1 RID: 2017
		private delegate void InternalSetGoalWeightRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index, float value);

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x060007E3 RID: 2019
		private delegate float InternalGetGoalWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index);

		// Token: 0x02000177 RID: 375
		// (Invoke) Token: 0x060007E5 RID: 2021
		private delegate float InternalGetGoalWeightRotation_InjectedDelegate(IntPtr _unity_self, AvatarIKGoal index);

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x060007E7 RID: 2023
		private delegate void InternalGetHintPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index, [Out] IntPtr ret);

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x060007E9 RID: 2025
		private delegate void InternalSetHintPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index, IntPtr pos);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x060007EB RID: 2027
		private delegate void InternalSetHintWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index, float value);

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x060007ED RID: 2029
		private delegate float InternalGetHintWeightPosition_InjectedDelegate(IntPtr _unity_self, AvatarIKHint index);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x060007EF RID: 2031
		private delegate void InternalSetLookAtPosition_InjectedDelegate(IntPtr _unity_self, IntPtr lookAtPosition);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x060007F1 RID: 2033
		private delegate void InternalSetLookAtClampWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x060007F3 RID: 2035
		private delegate void InternalSetLookAtBodyWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x0200017F RID: 383
		// (Invoke) Token: 0x060007F5 RID: 2037
		private delegate void InternalSetLookAtHeadWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x02000180 RID: 384
		// (Invoke) Token: 0x060007F7 RID: 2039
		private delegate void InternalSetLookAtEyesWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x02000181 RID: 385
		// (Invoke) Token: 0x060007F9 RID: 2041
		private delegate void InternalSolveIK_InjectedDelegate(IntPtr _unity_self);
	}
}
