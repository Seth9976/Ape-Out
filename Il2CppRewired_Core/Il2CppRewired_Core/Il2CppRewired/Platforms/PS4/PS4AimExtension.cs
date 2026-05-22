using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x0200018F RID: 399
	public sealed class PS4AimExtension : PS4ControllerExtension
	{
		// Token: 0x06002922 RID: 10530 RVA: 0x000CFC1C File Offset: 0x000CDE1C
		// Note: this type is marked as 'beforefieldinit'.
		static PS4AimExtension()
		{
			Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "PS4AimExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr);
			PS4AimExtension.NativeMethodInfoPtr_get_Source_Private_get_IPS4AimExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673273);
			PS4AimExtension.NativeMethodInfoPtr__ctor_Internal_Void_IPS4AimExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673274);
			PS4AimExtension.NativeMethodInfoPtr__ctor_Private_Void_PS4AimExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673275);
			PS4AimExtension.NativeMethodInfoPtr_GetVibration_Public_Single_PS4AimMotorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673276);
			PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4AimMotorType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673277);
			PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4AimMotorType_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673278);
			PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4AimMotorType_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673279);
			PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673280);
			PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673281);
			PS4AimExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673282);
			PS4AimExtension.NativeMethodInfoPtr_xrnxHrueTVMIZLTLNjrQvmcjdSR_Private_Static_Int32_PS4AimMotorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr, 100673283);
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x000CFD28 File Offset: 0x000CDF28
		public new unsafe IPS4AimExtensionSource Source
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309495, XrefRangeEnd = 309501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr_get_Source_Private_get_IPS4AimExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPS4AimExtensionSource>(intPtr3) : null;
			}
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000CFD68 File Offset: 0x000CDF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309501, XrefRangeEnd = 309502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PS4AimExtension(IPS4AimExtensionSource source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr__ctor_Internal_Void_IPS4AimExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000CFDB4 File Offset: 0x000CDFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309502, XrefRangeEnd = 309503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PS4AimExtension(PS4AimExtension source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4AimExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr__ctor_Private_Void_PS4AimExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000CFE00 File Offset: 0x000CE000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309503, XrefRangeEnd = 309510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVibration(PS4AimMotorType motor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr_GetVibration_Public_Single_PS4AimMotorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000CFE4C File Offset: 0x000CE04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309510, XrefRangeEnd = 309511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(PS4AimMotorType motor, float motorLevel)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4AimMotorType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000CFE98 File Offset: 0x000CE098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309511, XrefRangeEnd = 309512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(PS4AimMotorType motor, float motorLevel, bool stopOtherMotors)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4AimMotorType_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000CFEF4 File Offset: 0x000CE0F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309520, RefRangeEnd = 309522, XrefRangeStart = 309512, XrefRangeEnd = 309520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(PS4AimMotorType motor, float motorLevel, float duration, bool stopOtherMotors)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4AimMotorType_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000CFF5C File Offset: 0x000CE15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309522, XrefRangeEnd = 309531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(float strongMotorLevel, float weakMotorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref strongMotorLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weakMotorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000CFFA8 File Offset: 0x000CE1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309531, XrefRangeEnd = 309540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(float strongMotorLevel, float weakMotorLevel, float strongMotorDuration, float weakMotorDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref strongMotorLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weakMotorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strongMotorDuration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weakMotorDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000D0010 File Offset: 0x000CE210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309540, XrefRangeEnd = 309544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension dLAxRoWNebGZzafOZSROBGeqqVrC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000D0050 File Offset: 0x000CE250
		[CallerCount(0)]
		public unsafe static int xrnxHrueTVMIZLTLNjrQvmcjdSR(PS4AimMotorType A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4AimExtension.NativeMethodInfoPtr_xrnxHrueTVMIZLTLNjrQvmcjdSR_Private_Static_Int32_PS4AimMotorType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x0000FB73 File Offset: 0x0000DD73
		public PS4AimExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Private_get_IPS4AimExtensionSource_0;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IPS4AimExtensionSource_0;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_PS4AimExtension_0;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Single_PS4AimMotorType_0;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_PS4AimMotorType_Single_0;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_PS4AimMotorType_Single_Boolean_0;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_PS4AimMotorType_Single_Single_Boolean_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_0;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr_xrnxHrueTVMIZLTLNjrQvmcjdSR_Private_Static_Int32_PS4AimMotorType_0;
	}
}
