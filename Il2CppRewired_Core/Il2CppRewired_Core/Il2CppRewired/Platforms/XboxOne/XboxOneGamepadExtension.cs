using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppSystem;

namespace Il2CppRewired.Platforms.XboxOne
{
	// Token: 0x02000218 RID: 536
	public sealed class XboxOneGamepadExtension : Controller.Extension
	{
		// Token: 0x0600371E RID: 14110 RVA: 0x001103A4 File Offset: 0x0010E5A4
		// Note: this type is marked as 'beforefieldinit'.
		static XboxOneGamepadExtension()
		{
			Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.XboxOne", "XboxOneGamepadExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr);
			XboxOneGamepadExtension.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, "biBJftmjAXeWoBqMpeqfZEjZwtg");
			XboxOneGamepadExtension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, "KGQsYBfjblOxfiUZWLkipVdVFYP");
			XboxOneGamepadExtension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676897);
			XboxOneGamepadExtension.NativeMethodInfoPtr_get_xboxOneUserId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676898);
			XboxOneGamepadExtension.NativeMethodInfoPtr_get_xboxOneJoystickId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676899);
			XboxOneGamepadExtension.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_IXboxOneInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676900);
			XboxOneGamepadExtension.NativeMethodInfoPtr__ctor_Private_Void_XboxOneGamepadExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676901);
			XboxOneGamepadExtension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676902);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676903);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676904);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676905);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676906);
			XboxOneGamepadExtension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676907);
			XboxOneGamepadExtension.NativeMethodInfoPtr_GetVibration_Public_Single_XboxOneGamepadMotorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676908);
			XboxOneGamepadExtension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676909);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676910);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676911);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676912);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676913);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676914);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676915);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676916);
			XboxOneGamepadExtension.NativeMethodInfoPtr_PulseVibrateMotor_Public_Void_XboxOneGamepadMotorType_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676917);
			XboxOneGamepadExtension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676918);
			XboxOneGamepadExtension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676919);
			XboxOneGamepadExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676920);
			XboxOneGamepadExtension.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676921);
			XboxOneGamepadExtension.NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_XboxOneGamepadMotorType_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676922);
			XboxOneGamepadExtension.NativeMethodInfoPtr_cihueHuoaShkAFuAWObpeswAnEF_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, 100676923);
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x00110618 File Offset: 0x0010E818
		public unsafe Joystick joystick
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347397, XrefRangeEnd = 347399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Joystick>(intPtr3) : null;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x00110658 File Offset: 0x0010E858
		public unsafe int xboxOneUserId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347399, XrefRangeEnd = 347413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_get_xboxOneUserId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x00110694 File Offset: 0x0010E894
		public unsafe ulong xboxOneJoystickId
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 347424, RefRangeEnd = 347428, XrefRangeStart = 347413, XrefRangeEnd = 347424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_get_xboxOneJoystickId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x001106D0 File Offset: 0x0010E8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347445, RefRangeEnd = 347446, XrefRangeStart = 347428, XrefRangeEnd = 347445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneGamepadExtension(bool supportsVibration, IXboxOneInputSource xboxOneInputSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref supportsVibration;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xboxOneInputSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_IXboxOneInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0011072C File Offset: 0x0010E92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347446, XrefRangeEnd = 347454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneGamepadExtension(XboxOneGamepadExtension source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr__ctor_Private_Void_XboxOneGamepadExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06003724 RID: 14116 RVA: 0x00110778 File Offset: 0x0010E978
		public unsafe int vibrationMotorCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347454, XrefRangeEnd = 347458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x001107B4 File Offset: 0x0010E9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347458, XrefRangeEnd = 347459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(int motorIndex, float motorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x00110800 File Offset: 0x0010EA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347459, XrefRangeEnd = 347460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(int motorIndex, float motorLevel, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x0011085C File Offset: 0x0010EA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347460, XrefRangeEnd = 347461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x001108B8 File Offset: 0x0010EAB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 347472, RefRangeEnd = 347477, XrefRangeStart = 347461, XrefRangeEnd = 347472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00110920 File Offset: 0x0010EB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347477, XrefRangeEnd = 347481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVibration(int motorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motorIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x0011096C File Offset: 0x0010EB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347481, XrefRangeEnd = 347485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVibration(XboxOneGamepadMotorType motor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_GetVibration_Public_Single_XboxOneGamepadMotorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x001109B8 File Offset: 0x0010EBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347485, XrefRangeEnd = 347492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x001109EC File Offset: 0x0010EBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347492, XrefRangeEnd = 347493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(XboxOneGamepadMotorType motor, float motorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00110A38 File Offset: 0x0010EC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347493, XrefRangeEnd = 347494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00110A94 File Offset: 0x0010EC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347494, XrefRangeEnd = 347495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00110AF0 File Offset: 0x0010ECF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 347508, RefRangeEnd = 347512, XrefRangeStart = 347495, XrefRangeEnd = 347508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00110B58 File Offset: 0x0010ED58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347512, XrefRangeEnd = 347513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftMotorLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00110BA4 File Offset: 0x0010EDA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347521, RefRangeEnd = 347522, XrefRangeStart = 347513, XrefRangeEnd = 347521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(float leftMotorLevel, float rightMotorLevel, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftMotorLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00110C00 File Offset: 0x0010EE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347522, XrefRangeEnd = 347535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftTriggerLevel, float rightTriggerLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftMotorLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftTriggerLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightTriggerLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00110C68 File Offset: 0x0010EE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347535, XrefRangeEnd = 347544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PulseVibrateMotor(XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_PulseVibrateMotor_Public_Void_XboxOneGamepadMotorType_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00110CD0 File Offset: 0x0010EED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347544, XrefRangeEnd = 347551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x00110D10 File Offset: 0x0010EF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347551, XrefRangeEnd = 347555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SouFSqCHNLMbAzpFusEqgKLXdOQA(IControllerExtensionSource A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00110D54 File Offset: 0x0010EF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347555, XrefRangeEnd = 347565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension dLAxRoWNebGZzafOZSROBGeqqVrC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00110D94 File Offset: 0x0010EF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BicogWPgevrFZwICbwpkHBEuTLD()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x00110DC8 File Offset: 0x0010EFC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347569, RefRangeEnd = 347571, XrefRangeStart = 347565, XrefRangeEnd = 347569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void mVQYCbUBHoFNvrjgeeLvwddRTuC(XboxOneGamepadMotorType A_1, float A_2, float A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_XboxOneGamepadMotorType_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00110E24 File Offset: 0x0010F024
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 347575, RefRangeEnd = 347579, XrefRangeStart = 347571, XrefRangeEnd = 347575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cihueHuoaShkAFuAWObpeswAnEF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.NativeMethodInfoPtr_cihueHuoaShkAFuAWObpeswAnEF_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00013006 File Offset: 0x00011206
		public XboxOneGamepadExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x00110E58 File Offset: 0x0010F058
		// (set) Token: 0x0600373C RID: 14140 RVA: 0x0001300F File Offset: 0x0001120F
		public unsafe XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV biBJftmjAXeWoBqMpeqfZEjZwtg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x00110E88 File Offset: 0x0010F088
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x0001302E File Offset: 0x0001122E
		public unsafe Il2CppReferenceArray<TimerAbs> KGQsYBfjblOxfiUZWLkipVdVFYP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TimerAbs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeFieldInfoPtr_biBJftmjAXeWoBqMpeqfZEjZwtg;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeFieldInfoPtr_KGQsYBfjblOxfiUZWLkipVdVFYP;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeMethodInfoPtr_get_joystick_Private_get_Joystick_0;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeMethodInfoPtr_get_xboxOneUserId_Public_get_Int32_0;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeMethodInfoPtr_get_xboxOneJoystickId_Public_get_UInt64_0;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_IXboxOneInputSource_0;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_XboxOneGamepadExtension_0;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Single_XboxOneGamepadMotorType_0;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_0;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_Single_0;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_Boolean_0;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_XboxOneGamepadMotorType_Single_Single_Boolean_0;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_0;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Boolean_0;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeMethodInfoPtr_PulseVibrateMotor_Public_Void_XboxOneGamepadMotorType_Single_Single_Single_0;

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeMethodInfoPtr_SouFSqCHNLMbAzpFusEqgKLXdOQA_Internal_Virtual_Void_IControllerExtensionSource_0;

		// Token: 0x04002EBC RID: 11964
		private static readonly IntPtr NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0;

		// Token: 0x04002EBD RID: 11965
		private static readonly IntPtr NativeMethodInfoPtr_BicogWPgevrFZwICbwpkHBEuTLD_Private_Void_0;

		// Token: 0x04002EBE RID: 11966
		private static readonly IntPtr NativeMethodInfoPtr_mVQYCbUBHoFNvrjgeeLvwddRTuC_Private_Void_XboxOneGamepadMotorType_Single_Single_0;

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeMethodInfoPtr_cihueHuoaShkAFuAWObpeswAnEF_Private_Void_0;

		// Token: 0x020004B7 RID: 1207
		public class toHnXcNTXvzxGjRxuLGbKhurfDV : Object
		{
			// Token: 0x0600521A RID: 21018 RVA: 0x00175564 File Offset: 0x00173764
			// Note: this type is marked as 'beforefieldinit'.
			static toHnXcNTXvzxGjRxuLGbKhurfDV()
			{
				Il2CppClassPointerStore<XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XboxOneGamepadExtension>.NativeClassPtr, "toHnXcNTXvzxGjRxuLGbKhurfDV");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV>.NativeClassPtr);
				XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV>.NativeClassPtr, "IrPGdvpUHdQviBLkVmFelgVaPvu");
				XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_sOeRJHQKAQnepmUjBUGXTSDZNSy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV>.NativeClassPtr, "sOeRJHQKAQnepmUjBUGXTSDZNSy");
				XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_UEfwSjDXbDTFEVFvDYvxcOgEocj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV>.NativeClassPtr, "UEfwSjDXbDTFEVFvDYvxcOgEocj");
				XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV>.NativeClassPtr, "NHHSBHSGBsgbYzoafsilROcNHRd");
				XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeMethodInfoPtr__ctor_Public_Void_Boolean_IXboxOneInputSource_AkPWZxJICqXISLazpKqWsMZEWa_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV>.NativeClassPtr, 100676924);
			}

			// Token: 0x0600521B RID: 21019 RVA: 0x001755F4 File Offset: 0x001737F4
			[CallerCount(0)]
			public unsafe toHnXcNTXvzxGjRxuLGbKhurfDV(bool supportsVibration, IXboxOneInputSource xboxOneInputSource, AkPWZxJICqXISLazpKqWsMZEWa vibrationData)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref supportsVibration;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xboxOneInputSource);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibrationData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeMethodInfoPtr__ctor_Public_Void_Boolean_IXboxOneInputSource_AkPWZxJICqXISLazpKqWsMZEWa_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600521C RID: 21020 RVA: 0x0001D915 File Offset: 0x0001BB15
			public toHnXcNTXvzxGjRxuLGbKhurfDV(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001929 RID: 6441
			// (get) Token: 0x0600521D RID: 21021 RVA: 0x0017565C File Offset: 0x0017385C
			// (set) Token: 0x0600521E RID: 21022 RVA: 0x0001D91E File Offset: 0x0001BB1E
			public unsafe static int IrPGdvpUHdQviBLkVmFelgVaPvu
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu, (void*)(&value));
				}
			}

			// Token: 0x1700192A RID: 6442
			// (get) Token: 0x0600521F RID: 21023 RVA: 0x00175678 File Offset: 0x00173878
			// (set) Token: 0x06005220 RID: 21024 RVA: 0x0001D92C File Offset: 0x0001BB2C
			public unsafe AkPWZxJICqXISLazpKqWsMZEWa sOeRJHQKAQnepmUjBUGXTSDZNSy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_sOeRJHQKAQnepmUjBUGXTSDZNSy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_sOeRJHQKAQnepmUjBUGXTSDZNSy)) = value;
				}
			}

			// Token: 0x1700192B RID: 6443
			// (get) Token: 0x06005221 RID: 21025 RVA: 0x001756A0 File Offset: 0x001738A0
			// (set) Token: 0x06005222 RID: 21026 RVA: 0x0001D947 File Offset: 0x0001BB47
			public unsafe IXboxOneInputSource UEfwSjDXbDTFEVFvDYvxcOgEocj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_UEfwSjDXbDTFEVFvDYvxcOgEocj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXboxOneInputSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_UEfwSjDXbDTFEVFvDYvxcOgEocj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700192C RID: 6444
			// (get) Token: 0x06005223 RID: 21027 RVA: 0x001756D0 File Offset: 0x001738D0
			// (set) Token: 0x06005224 RID: 21028 RVA: 0x0001D966 File Offset: 0x0001BB66
			public unsafe bool NHHSBHSGBsgbYzoafsilROcNHRd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneGamepadExtension.toHnXcNTXvzxGjRxuLGbKhurfDV.NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd)) = value;
				}
			}

			// Token: 0x040044F7 RID: 17655
			private static readonly IntPtr NativeFieldInfoPtr_IrPGdvpUHdQviBLkVmFelgVaPvu;

			// Token: 0x040044F8 RID: 17656
			private static readonly IntPtr NativeFieldInfoPtr_sOeRJHQKAQnepmUjBUGXTSDZNSy;

			// Token: 0x040044F9 RID: 17657
			private static readonly IntPtr NativeFieldInfoPtr_UEfwSjDXbDTFEVFvDYvxcOgEocj;

			// Token: 0x040044FA RID: 17658
			private static readonly IntPtr NativeFieldInfoPtr_NHHSBHSGBsgbYzoafsilROcNHRd;

			// Token: 0x040044FB RID: 17659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_IXboxOneInputSource_AkPWZxJICqXISLazpKqWsMZEWa_0;
		}
	}
}
