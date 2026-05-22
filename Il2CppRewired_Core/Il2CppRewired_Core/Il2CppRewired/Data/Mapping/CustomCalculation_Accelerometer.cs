using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppRewired.Utils.Classes.Data;

namespace Il2CppRewired.Data.Mapping
{
	// Token: 0x020000A4 RID: 164
	[Serializable]
	public sealed class CustomCalculation_Accelerometer : CustomCalculation
	{
		// Token: 0x06001453 RID: 5203 RVA: 0x00079334 File Offset: 0x00077534
		// Note: this type is marked as 'beforefieldinit'.
		static CustomCalculation_Accelerometer()
		{
			Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data.Mapping", "CustomCalculation_Accelerometer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr);
			CustomCalculation_Accelerometer.NativeFieldInfoPtr__calculationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr, "_calculationType");
			CustomCalculation_Accelerometer.NativeFieldInfoPtr__inputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr, "_inputType");
			CustomCalculation_Accelerometer.NativeFieldInfoPtr__outputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr, "_outputType");
			CustomCalculation_Accelerometer.NativeMethodInfoPtr_get_ResultType_Internal_Virtual_get_DataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr, 100666735);
			CustomCalculation_Accelerometer.NativeMethodInfoPtr_FGmlJUhppNOoAsicdMOGvcmcvyK_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr, 100666736);
			CustomCalculation_Accelerometer.NativeMethodInfoPtr_eAjPwbDthJoQYSfiGcmSvoFcHec_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr, 100666737);
			CustomCalculation_Accelerometer.NativeMethodInfoPtr_OipyiXlbKAzXufsaMokuxzGyQPo_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr, 100666738);
			CustomCalculation_Accelerometer.NativeMethodInfoPtr_clMzEIzKxSjgDLpKTLfkdSlFWxA_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr, 100666739);
			CustomCalculation_Accelerometer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr, 100666740);
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x00079418 File Offset: 0x00077618
		public unsafe override TypeWrapper.DataType ResultType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_Accelerometer.NativeMethodInfoPtr_get_ResultType_Internal_Virtual_get_DataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00079454 File Offset: 0x00077654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265346, XrefRangeEnd = 265355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool FGmlJUhppNOoAsicdMOGvcmcvyK()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_Accelerometer.NativeMethodInfoPtr_FGmlJUhppNOoAsicdMOGvcmcvyK_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00079490 File Offset: 0x00077690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265367, RefRangeEnd = 265368, XrefRangeStart = 265355, XrefRangeEnd = 265367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float eAjPwbDthJoQYSfiGcmSvoFcHec()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_Accelerometer.NativeMethodInfoPtr_eAjPwbDthJoQYSfiGcmSvoFcHec_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x000794CC File Offset: 0x000776CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265381, RefRangeEnd = 265382, XrefRangeStart = 265368, XrefRangeEnd = 265381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float OipyiXlbKAzXufsaMokuxzGyQPo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_Accelerometer.NativeMethodInfoPtr_OipyiXlbKAzXufsaMokuxzGyQPo_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00079508 File Offset: 0x00077708
		[CallerCount(0)]
		public unsafe float clMzEIzKxSjgDLpKTLfkdSlFWxA(float A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_Accelerometer.NativeMethodInfoPtr_clMzEIzKxSjgDLpKTLfkdSlFWxA_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00079554 File Offset: 0x00077754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomCalculation_Accelerometer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomCalculation_Accelerometer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomCalculation_Accelerometer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00008D71 File Offset: 0x00006F71
		public CustomCalculation_Accelerometer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x00079590 File Offset: 0x00077790
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x00008D7A File Offset: 0x00006F7A
		public unsafe CustomCalculation_Accelerometer.CalculationType _calculationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomCalculation_Accelerometer.NativeFieldInfoPtr__calculationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomCalculation_Accelerometer.NativeFieldInfoPtr__calculationType)) = value;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x000795B8 File Offset: 0x000777B8
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x00008D95 File Offset: 0x00006F95
		public unsafe CustomCalculation_Accelerometer.InputType _inputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomCalculation_Accelerometer.NativeFieldInfoPtr__inputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomCalculation_Accelerometer.NativeFieldInfoPtr__inputType)) = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x000795E0 File Offset: 0x000777E0
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x00008DB0 File Offset: 0x00006FB0
		public unsafe CustomCalculation_Accelerometer.OutputType _outputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomCalculation_Accelerometer.NativeFieldInfoPtr__outputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomCalculation_Accelerometer.NativeFieldInfoPtr__outputType)) = value;
			}
		}

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeFieldInfoPtr__calculationType;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeFieldInfoPtr__inputType;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeFieldInfoPtr__outputType;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultType_Internal_Virtual_get_DataType_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_FGmlJUhppNOoAsicdMOGvcmcvyK_Internal_Virtual_Boolean_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_eAjPwbDthJoQYSfiGcmSvoFcHec_Private_Single_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_OipyiXlbKAzXufsaMokuxzGyQPo_Private_Single_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_clMzEIzKxSjgDLpKTLfkdSlFWxA_Private_Single_Single_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002CE RID: 718
		[OriginalName("Rewired_Core.dll", "", "CalculationType")]
		public enum CalculationType
		{
			// Token: 0x0400339A RID: 13210
			Pitch,
			// Token: 0x0400339B RID: 13211
			Roll
		}

		// Token: 0x020002CF RID: 719
		[OriginalName("Rewired_Core.dll", "", "OutputType")]
		public enum OutputType
		{
			// Token: 0x0400339D RID: 13213
			Axis,
			// Token: 0x0400339E RID: 13214
			Angle
		}

		// Token: 0x020002D0 RID: 720
		[OriginalName("Rewired_Core.dll", "", "InputType")]
		public enum InputType
		{
			// Token: 0x040033A0 RID: 13216
			Acceleration,
			// Token: 0x040033A1 RID: 13217
			UserAcceleration,
			// Token: 0x040033A2 RID: 13218
			Gravity
		}
	}
}
