using System;
using System.Runtime.InteropServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Platforms.Custom;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Platforms.XboxOne
{
	// Token: 0x0200021B RID: 539
	public sealed class XboxOneInputSource : CustomInputSource
	{
		// Token: 0x06003742 RID: 14146 RVA: 0x00110F88 File Offset: 0x0010F188
		// Note: this type is marked as 'beforefieldinit'.
		static XboxOneInputSource()
		{
			Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.XboxOne", "XboxOneInputSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr);
			XboxOneInputSource.NativeFieldInfoPtr_rwLKlnboiVVqiJjKDVwwbtycKvb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, "rwLKlnboiVVqiJjKDVwwbtycKvb");
			XboxOneInputSource.NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, "hvGDCWectQgzwVNffhRCeUEVaDyy");
			XboxOneInputSource.NativeFieldInfoPtr_YocRkGPwRCgBgVGuexKsjmOTKMm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, "YocRkGPwRCgBgVGuexKsjmOTKMm");
			XboxOneInputSource.NativeFieldInfoPtr_hygDekdrFWbdIimxgpcVgySytKYK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, "hygDekdrFWbdIimxgpcVgySytKYK");
			XboxOneInputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, "OGPdMfJpwRsSVAGxJGrPBlthhPYj");
			XboxOneInputSource.NativeMethodInfoPtr_get_isReady_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676926);
			XboxOneInputSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676927);
			XboxOneInputSource.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676928);
			XboxOneInputSource.NativeMethodInfoPtr_hfVeUtpbibgvZULHsEsTzxBjvGg_Private_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676929);
			XboxOneInputSource.NativeMethodInfoPtr_FaTHakbExGXZhmLYkRZyaHdjCpFi_Private_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676930);
			XboxOneInputSource.NativeMethodInfoPtr_csawBjIKkeLalgODUcDoBzpeWjsw_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676931);
			XboxOneInputSource.NativeMethodInfoPtr_FlQHudwkMImLKdcThGiNFesRcEdJ_Private_Boolean_UInt32_Boolean_byref_BadConnectionReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676932);
			XboxOneInputSource.NativeMethodInfoPtr_LqRGtEKjBinySbRrHMwUsjNysCEb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676933);
			XboxOneInputSource.NativeMethodInfoPtr_GetXboxOneUserIdFromUnityJoystick_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676934);
			XboxOneInputSource.NativeMethodInfoPtr_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_XboxOneGamepadMotorType_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676935);
			XboxOneInputSource.NativeMethodInfoPtr_SetXboxOneVibration_Public_Virtual_Final_New_Boolean_UInt64_AkPWZxJICqXISLazpKqWsMZEWa_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676936);
			XboxOneInputSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676937);
			XboxOneInputSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676938);
			XboxOneInputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, 100676939);
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06003743 RID: 14147 RVA: 0x00111134 File Offset: 0x0010F334
		public unsafe override bool isReady
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_get_isReady_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00111170 File Offset: 0x0010F370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347728, XrefRangeEnd = 347760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XboxOneInputSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x001111AC File Offset: 0x0010F3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347760, XrefRangeEnd = 347774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_Update_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x001111E0 File Offset: 0x0010F3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347774, XrefRangeEnd = 347785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void hfVeUtpbibgvZULHsEsTzxBjvGg(uint A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_hfVeUtpbibgvZULHsEsTzxBjvGg_Private_Void_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0011122C File Offset: 0x0010F42C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347799, RefRangeEnd = 347801, XrefRangeStart = 347785, XrefRangeEnd = 347799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaTHakbExGXZhmLYkRZyaHdjCpFi(uint A_1, bool A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_FaTHakbExGXZhmLYkRZyaHdjCpFi_Private_Void_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x00111278 File Offset: 0x0010F478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347814, RefRangeEnd = 347815, XrefRangeStart = 347801, XrefRangeEnd = 347814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void csawBjIKkeLalgODUcDoBzpeWjsw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_csawBjIKkeLalgODUcDoBzpeWjsw_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x001112AC File Offset: 0x0010F4AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 347840, RefRangeEnd = 347843, XrefRangeStart = 347815, XrefRangeEnd = 347840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FlQHudwkMImLKdcThGiNFesRcEdJ(uint A_1, bool A_2, out XboxOneInputSource.BadConnectionReason A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_FlQHudwkMImLKdcThGiNFesRcEdJ_Private_Boolean_UInt32_Boolean_byref_BadConnectionReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00111314 File Offset: 0x0010F514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347843, XrefRangeEnd = 347846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LqRGtEKjBinySbRrHMwUsjNysCEb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_LqRGtEKjBinySbRrHMwUsjNysCEb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00111348 File Offset: 0x0010F548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347846, XrefRangeEnd = 347853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unityJoystickId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_GetXboxOneUserIdFromUnityJoystick_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x00111394 File Offset: 0x0010F594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347853, XrefRangeEnd = 347860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxOneJoystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_XboxOneGamepadMotorType_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x0011140C File Offset: 0x0010F60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347860, XrefRangeEnd = 347867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetXboxOneVibration(ulong xboxOneJoystickId, AkPWZxJICqXISLazpKqWsMZEWa vibration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xboxOneJoystickId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_SetXboxOneVibration_Public_Virtual_Final_New_Boolean_UInt64_AkPWZxJICqXISLazpKqWsMZEWa_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00111464 File Offset: 0x0010F664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347867, XrefRangeEnd = 347875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00111498 File Offset: 0x0010F698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x001114CC File Offset: 0x0010F6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347875, XrefRangeEnd = 347887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x0001305F File Offset: 0x0001125F
		public XboxOneInputSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x0011150C File Offset: 0x0010F70C
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x00013068 File Offset: 0x00011268
		public unsafe static int rwLKlnboiVVqiJjKDVwwbtycKvb
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.NativeFieldInfoPtr_rwLKlnboiVVqiJjKDVwwbtycKvb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.NativeFieldInfoPtr_rwLKlnboiVVqiJjKDVwwbtycKvb, (void*)(&value));
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x00111528 File Offset: 0x0010F728
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x00013076 File Offset: 0x00011276
		public unsafe bool hvGDCWectQgzwVNffhRCeUEVaDyy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy)) = value;
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x00111550 File Offset: 0x0010F750
		// (set) Token: 0x06003757 RID: 14167 RVA: 0x00013091 File Offset: 0x00011291
		public unsafe bool YocRkGPwRCgBgVGuexKsjmOTKMm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.NativeFieldInfoPtr_YocRkGPwRCgBgVGuexKsjmOTKMm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.NativeFieldInfoPtr_YocRkGPwRCgBgVGuexKsjmOTKMm)) = value;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x00111578 File Offset: 0x0010F778
		// (set) Token: 0x06003759 RID: 14169 RVA: 0x000130AC File Offset: 0x000112AC
		public unsafe Queue<XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn> hygDekdrFWbdIimxgpcVgySytKYK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.NativeFieldInfoPtr_hygDekdrFWbdIimxgpcVgySytKYK);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.NativeFieldInfoPtr_hygDekdrFWbdIimxgpcVgySytKYK), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x0600375A RID: 14170 RVA: 0x001115A8 File Offset: 0x0010F7A8
		// (set) Token: 0x0600375B RID: 14171 RVA: 0x000130CB File Offset: 0x000112CB
		public new unsafe bool OGPdMfJpwRsSVAGxJGrPBlthhPYj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj)) = value;
			}
		}

		// Token: 0x04002ED0 RID: 11984
		private static readonly IntPtr NativeFieldInfoPtr_rwLKlnboiVVqiJjKDVwwbtycKvb;

		// Token: 0x04002ED1 RID: 11985
		private static readonly IntPtr NativeFieldInfoPtr_hvGDCWectQgzwVNffhRCeUEVaDyy;

		// Token: 0x04002ED2 RID: 11986
		private static readonly IntPtr NativeFieldInfoPtr_YocRkGPwRCgBgVGuexKsjmOTKMm;

		// Token: 0x04002ED3 RID: 11987
		private static readonly IntPtr NativeFieldInfoPtr_hygDekdrFWbdIimxgpcVgySytKYK;

		// Token: 0x04002ED4 RID: 11988
		private static readonly IntPtr NativeFieldInfoPtr_OGPdMfJpwRsSVAGxJGrPBlthhPYj;

		// Token: 0x04002ED5 RID: 11989
		private static readonly IntPtr NativeMethodInfoPtr_get_isReady_Public_Virtual_get_Boolean_0;

		// Token: 0x04002ED6 RID: 11990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002ED7 RID: 11991
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04002ED8 RID: 11992
		private static readonly IntPtr NativeMethodInfoPtr_hfVeUtpbibgvZULHsEsTzxBjvGg_Private_Void_UInt32_Boolean_0;

		// Token: 0x04002ED9 RID: 11993
		private static readonly IntPtr NativeMethodInfoPtr_FaTHakbExGXZhmLYkRZyaHdjCpFi_Private_Void_UInt32_Boolean_0;

		// Token: 0x04002EDA RID: 11994
		private static readonly IntPtr NativeMethodInfoPtr_csawBjIKkeLalgODUcDoBzpeWjsw_Private_Void_0;

		// Token: 0x04002EDB RID: 11995
		private static readonly IntPtr NativeMethodInfoPtr_FlQHudwkMImLKdcThGiNFesRcEdJ_Private_Boolean_UInt32_Boolean_byref_BadConnectionReason_0;

		// Token: 0x04002EDC RID: 11996
		private static readonly IntPtr NativeMethodInfoPtr_LqRGtEKjBinySbRrHMwUsjNysCEb_Private_Void_0;

		// Token: 0x04002EDD RID: 11997
		private static readonly IntPtr NativeMethodInfoPtr_GetXboxOneUserIdFromUnityJoystick_Public_Virtual_Final_New_Int32_Int32_0;

		// Token: 0x04002EDE RID: 11998
		private static readonly IntPtr NativeMethodInfoPtr_PulseVibrateMotor_Public_Virtual_Final_New_Void_UInt64_XboxOneGamepadMotorType_Single_Single_Single_0;

		// Token: 0x04002EDF RID: 11999
		private static readonly IntPtr NativeMethodInfoPtr_SetXboxOneVibration_Public_Virtual_Final_New_Boolean_UInt64_AkPWZxJICqXISLazpKqWsMZEWa_0;

		// Token: 0x04002EE0 RID: 12000
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x04002EE1 RID: 12001
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002EE2 RID: 12002
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x020004B8 RID: 1208
		[OriginalName("Rewired_Core.dll", "", "BadConnectionReason")]
		public enum BadConnectionReason
		{
			// Token: 0x040044FD RID: 17661
			None,
			// Token: 0x040044FE RID: 17662
			GamepadNotActive,
			// Token: 0x040044FF RID: 17663
			InvalidName
		}

		// Token: 0x020004B9 RID: 1209
		[StructLayout(2)]
		public struct KiDnNKkggnqplXNAFpIRbwoRnpn
		{
			// Token: 0x06005225 RID: 21029 RVA: 0x001756F8 File Offset: 0x001738F8
			// Note: this type is marked as 'beforefieldinit'.
			static KiDnNKkggnqplXNAFpIRbwoRnpn()
			{
				Il2CppClassPointerStore<XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, "KiDnNKkggnqplXNAFpIRbwoRnpn");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn>.NativeClassPtr);
				XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn.NativeFieldInfoPtr_NKKIiEtjRRtgKoOJNFGytWjMnCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn>.NativeClassPtr, "NKKIiEtjRRtgKoOJNFGytWjMnCH");
				XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn.NativeFieldInfoPtr_yTzzPhfLZCazqhcGXAvjzwLakZX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn>.NativeClassPtr, "yTzzPhfLZCazqhcGXAvjzwLakZX");
				XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn>.NativeClassPtr, 100676940);
			}

			// Token: 0x06005226 RID: 21030 RVA: 0x00175760 File Offset: 0x00173960
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76853, RefRangeEnd = 76855, XrefRangeStart = 76853, XrefRangeEnd = 76855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KiDnNKkggnqplXNAFpIRbwoRnpn(uint unityJoystickId, uint connectedFrame)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref unityJoystickId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectedFrame;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005227 RID: 21031 RVA: 0x0001D981 File Offset: 0x0001BB81
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XboxOneInputSource.KiDnNKkggnqplXNAFpIRbwoRnpn>.NativeClassPtr, ref this));
			}

			// Token: 0x04004500 RID: 17664
			private static readonly IntPtr NativeFieldInfoPtr_NKKIiEtjRRtgKoOJNFGytWjMnCH;

			// Token: 0x04004501 RID: 17665
			private static readonly IntPtr NativeFieldInfoPtr_yTzzPhfLZCazqhcGXAvjzwLakZX;

			// Token: 0x04004502 RID: 17666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

			// Token: 0x04004503 RID: 17667
			[FieldOffset(0)]
			public uint NKKIiEtjRRtgKoOJNFGytWjMnCH;

			// Token: 0x04004504 RID: 17668
			[FieldOffset(4)]
			public uint yTzzPhfLZCazqhcGXAvjzwLakZX;
		}

		// Token: 0x020004BA RID: 1210
		public class qfOBCcGWMycYuffyzFFTjAyUSdn : CustomInputSource.Joystick
		{
			// Token: 0x06005228 RID: 21032 RVA: 0x001757A0 File Offset: 0x001739A0
			// Note: this type is marked as 'beforefieldinit'.
			static qfOBCcGWMycYuffyzFFTjAyUSdn()
			{
				Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XboxOneInputSource>.NativeClassPtr, "qfOBCcGWMycYuffyzFFTjAyUSdn");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr);
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_wuJGhDkBlVgWLDdNjgUhulfhZzxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "wuJGhDkBlVgWLDdNjgUhulfhZzxt");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "AHoQaCqgIOGogOpDnwRoZuWfUKU");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_HSxEDSKBTmvIKgTlxldgopnkErK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "HSxEDSKBTmvIKgTlxldgopnkErK");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_syzaEenEjIyTeckEVIqCeWgKmZnn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "syzaEenEjIyTeckEVIqCeWgKmZnn");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_BqIXwAIuRaghwJnUbBOnbysLqYGh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "BqIXwAIuRaghwJnUbBOnbysLqYGh");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_sXIJXDyWIdGIAFsknTKXWJFpnbT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "sXIJXDyWIdGIAFsknTKXWJFpnbT");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_ZqzjaQxGaTXQUDMcHBiVJTdcANf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "ZqzjaQxGaTXQUDMcHBiVJTdcANf");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_OJcDjkbVbtDSDndemXQPqyUzgXj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "OJcDjkbVbtDSDndemXQPqyUzgXj");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_zvYFkOheBTfswITMRACCxVIeoOY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "zvYFkOheBTfswITMRACCxVIeoOY");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_JotiUbjvsDltxIyExabmeBEOIou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "JotiUbjvsDltxIyExabmeBEOIou");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_qAqXwlHNMreMssPkDHEWkKeimpz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "qAqXwlHNMreMssPkDHEWkKeimpz");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_ETGMzVIrFroPyqiMRskBgQhkhTbJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "ETGMzVIrFroPyqiMRskBgQhkhTbJ");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_aRfarStljqLRqdMSlFbVHEXEtyH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "aRfarStljqLRqdMSlFbVHEXEtyH");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_LhQCGqaUnvOIjKMfbJRcckFUqnPR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "LhQCGqaUnvOIjKMfbJRcckFUqnPR");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_UKCJjJMjTPKceQGRJDATJJOYGdqU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "UKCJjJMjTPKceQGRJDATJJOYGdqU");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_kVDSSrShTwGQQEtcRiBOwYozTle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "kVDSSrShTwGQQEtcRiBOwYozTle");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_kVgCjVvoljLKuviYSUAXPnguVqt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "kVgCjVvoljLKuviYSUAXPnguVqt");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_iTSiNRFmTaUgkQrUasqvpNIolnX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "iTSiNRFmTaUgkQrUasqvpNIolnX");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_FDbFcfdCbQbbigMDkHpTwFqcQsX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "FDbFcfdCbQbbigMDkHpTwFqcQsX");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_MZGvzgxOXUAQmPYRHMLMddnkxLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "MZGvzgxOXUAQmPYRHMLMddnkxLC");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_RJPRICHkfBEdWCoFGnIKYjGqqnOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "RJPRICHkfBEdWCoFGnIKYjGqqnOD");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_qIpMKZmZdmMjsIwmjwSKIRVtRPH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "qIpMKZmZdmMjsIwmjwSKIRVtRPH");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_HEyjWWaQaVjhQTfJvGcdeezyBzTF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "HEyjWWaQaVjhQTfJvGcdeezyBzTF");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "tamJGhaDrwcqghjueRIJXoQsGYe");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_cHXgUkbCYeKQEnSQvuoKhZJTsUc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "cHXgUkbCYeKQEnSQvuoKhZJTsUc");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_nCvzHIaZltNcqVajorbbijeKbBCk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "nCvzHIaZltNcqVajorbbijeKbBCk");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_WJhTtnoPKfUNgUdPQPNbRNbRFnQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, "WJhTtnoPKfUNgUdPQPNbRNbRFnQ");
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_get_xboxControllerId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, 100676941);
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr__ctor_Public_Void_IXboxOneInputSource_UInt64_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, 100676942);
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, 100676943);
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, 100676944);
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_QfGPTYLRgCyphPGiTguxvWucxER_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, 100676945);
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_IGHJtcUsJKSjkaMGCICEjkyTwnj_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, 100676946);
				XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_pmsoOLMDBALUTpsnmGgnHGuPRLs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr, 100676947);
			}

			// Token: 0x17001948 RID: 6472
			// (get) Token: 0x06005229 RID: 21033 RVA: 0x00175A74 File Offset: 0x00173C74
			public unsafe ulong egFuUvFGHkdNgCJyNKYFcCoKUAnN
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_get_xboxControllerId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600522A RID: 21034 RVA: 0x00175AB0 File Offset: 0x00173CB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 347599, RefRangeEnd = 347600, XrefRangeStart = 347579, XrefRangeEnd = 347599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe qfOBCcGWMycYuffyzFFTjAyUSdn(IXboxOneInputSource inputSource, ulong xboxControllerId, int unityJoystickId, bool isConnected)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputSource);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xboxControllerId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unityJoystickId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isConnected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr__ctor_Public_Void_IXboxOneInputSource_UInt64_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600522B RID: 21035 RVA: 0x00175B28 File Offset: 0x00173D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347600, XrefRangeEnd = 347662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void xozDTcGUrsCTUDmjINWIvPSceAOJ()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600522C RID: 21036 RVA: 0x00175B64 File Offset: 0x00173D64
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 347672, RefRangeEnd = 347673, XrefRangeStart = 347662, XrefRangeEnd = 347672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void dwHOFmApnpWkXreTmwZYsRXRrow(ulong A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600522D RID: 21037 RVA: 0x00175BA4 File Offset: 0x00173DA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 347688, RefRangeEnd = 347689, XrefRangeStart = 347673, XrefRangeEnd = 347688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void QfGPTYLRgCyphPGiTguxvWucxER()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_QfGPTYLRgCyphPGiTguxvWucxER_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600522E RID: 21038 RVA: 0x00175BD8 File Offset: 0x00173DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347689, XrefRangeEnd = 347693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IGHJtcUsJKSjkaMGCICEjkyTwnj(int A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref A_1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_IGHJtcUsJKSjkaMGCICEjkyTwnj_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600522F RID: 21039 RVA: 0x00175C24 File Offset: 0x00173E24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 347727, RefRangeEnd = 347728, XrefRangeStart = 347693, XrefRangeEnd = 347727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void pmsoOLMDBALUTpsnmGgnHGuPRLs()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeMethodInfoPtr_pmsoOLMDBALUTpsnmGgnHGuPRLs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005230 RID: 21040 RVA: 0x0001D993 File Offset: 0x0001BB93
			public qfOBCcGWMycYuffyzFFTjAyUSdn(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700192D RID: 6445
			// (get) Token: 0x06005231 RID: 21041 RVA: 0x00175C58 File Offset: 0x00173E58
			// (set) Token: 0x06005232 RID: 21042 RVA: 0x0001D99C File Offset: 0x0001BB9C
			public unsafe static int wuJGhDkBlVgWLDdNjgUhulfhZzxt
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_wuJGhDkBlVgWLDdNjgUhulfhZzxt, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_wuJGhDkBlVgWLDdNjgUhulfhZzxt, (void*)(&value));
				}
			}

			// Token: 0x1700192E RID: 6446
			// (get) Token: 0x06005233 RID: 21043 RVA: 0x00175C74 File Offset: 0x00173E74
			// (set) Token: 0x06005234 RID: 21044 RVA: 0x0001D9AA File Offset: 0x0001BBAA
			public unsafe static int AHoQaCqgIOGogOpDnwRoZuWfUKU
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU, (void*)(&value));
				}
			}

			// Token: 0x1700192F RID: 6447
			// (get) Token: 0x06005235 RID: 21045 RVA: 0x00175C90 File Offset: 0x00173E90
			// (set) Token: 0x06005236 RID: 21046 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
			public unsafe static string HSxEDSKBTmvIKgTlxldgopnkErK
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_HSxEDSKBTmvIKgTlxldgopnkErK, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_HSxEDSKBTmvIKgTlxldgopnkErK, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001930 RID: 6448
			// (get) Token: 0x06005237 RID: 21047 RVA: 0x00175CB0 File Offset: 0x00173EB0
			// (set) Token: 0x06005238 RID: 21048 RVA: 0x0001D9CA File Offset: 0x0001BBCA
			public unsafe static int syzaEenEjIyTeckEVIqCeWgKmZnn
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_syzaEenEjIyTeckEVIqCeWgKmZnn, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_syzaEenEjIyTeckEVIqCeWgKmZnn, (void*)(&value));
				}
			}

			// Token: 0x17001931 RID: 6449
			// (get) Token: 0x06005239 RID: 21049 RVA: 0x00175CCC File Offset: 0x00173ECC
			// (set) Token: 0x0600523A RID: 21050 RVA: 0x0001D9D8 File Offset: 0x0001BBD8
			public unsafe static int BqIXwAIuRaghwJnUbBOnbysLqYGh
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_BqIXwAIuRaghwJnUbBOnbysLqYGh, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_BqIXwAIuRaghwJnUbBOnbysLqYGh, (void*)(&value));
				}
			}

			// Token: 0x17001932 RID: 6450
			// (get) Token: 0x0600523B RID: 21051 RVA: 0x00175CE8 File Offset: 0x00173EE8
			// (set) Token: 0x0600523C RID: 21052 RVA: 0x0001D9E6 File Offset: 0x0001BBE6
			public unsafe static int sXIJXDyWIdGIAFsknTKXWJFpnbT
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_sXIJXDyWIdGIAFsknTKXWJFpnbT, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_sXIJXDyWIdGIAFsknTKXWJFpnbT, (void*)(&value));
				}
			}

			// Token: 0x17001933 RID: 6451
			// (get) Token: 0x0600523D RID: 21053 RVA: 0x00175D04 File Offset: 0x00173F04
			// (set) Token: 0x0600523E RID: 21054 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
			public unsafe static int ZqzjaQxGaTXQUDMcHBiVJTdcANf
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_ZqzjaQxGaTXQUDMcHBiVJTdcANf, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_ZqzjaQxGaTXQUDMcHBiVJTdcANf, (void*)(&value));
				}
			}

			// Token: 0x17001934 RID: 6452
			// (get) Token: 0x0600523F RID: 21055 RVA: 0x00175D20 File Offset: 0x00173F20
			// (set) Token: 0x06005240 RID: 21056 RVA: 0x0001DA02 File Offset: 0x0001BC02
			public unsafe static int OJcDjkbVbtDSDndemXQPqyUzgXj
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_OJcDjkbVbtDSDndemXQPqyUzgXj, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_OJcDjkbVbtDSDndemXQPqyUzgXj, (void*)(&value));
				}
			}

			// Token: 0x17001935 RID: 6453
			// (get) Token: 0x06005241 RID: 21057 RVA: 0x00175D3C File Offset: 0x00173F3C
			// (set) Token: 0x06005242 RID: 21058 RVA: 0x0001DA10 File Offset: 0x0001BC10
			public unsafe static int zvYFkOheBTfswITMRACCxVIeoOY
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_zvYFkOheBTfswITMRACCxVIeoOY, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_zvYFkOheBTfswITMRACCxVIeoOY, (void*)(&value));
				}
			}

			// Token: 0x17001936 RID: 6454
			// (get) Token: 0x06005243 RID: 21059 RVA: 0x00175D58 File Offset: 0x00173F58
			// (set) Token: 0x06005244 RID: 21060 RVA: 0x0001DA1E File Offset: 0x0001BC1E
			public unsafe static int JotiUbjvsDltxIyExabmeBEOIou
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_JotiUbjvsDltxIyExabmeBEOIou, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_JotiUbjvsDltxIyExabmeBEOIou, (void*)(&value));
				}
			}

			// Token: 0x17001937 RID: 6455
			// (get) Token: 0x06005245 RID: 21061 RVA: 0x00175D74 File Offset: 0x00173F74
			// (set) Token: 0x06005246 RID: 21062 RVA: 0x0001DA2C File Offset: 0x0001BC2C
			public unsafe static int qAqXwlHNMreMssPkDHEWkKeimpz
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_qAqXwlHNMreMssPkDHEWkKeimpz, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_qAqXwlHNMreMssPkDHEWkKeimpz, (void*)(&value));
				}
			}

			// Token: 0x17001938 RID: 6456
			// (get) Token: 0x06005247 RID: 21063 RVA: 0x00175D90 File Offset: 0x00173F90
			// (set) Token: 0x06005248 RID: 21064 RVA: 0x0001DA3A File Offset: 0x0001BC3A
			public unsafe static int ETGMzVIrFroPyqiMRskBgQhkhTbJ
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_ETGMzVIrFroPyqiMRskBgQhkhTbJ, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_ETGMzVIrFroPyqiMRskBgQhkhTbJ, (void*)(&value));
				}
			}

			// Token: 0x17001939 RID: 6457
			// (get) Token: 0x06005249 RID: 21065 RVA: 0x00175DAC File Offset: 0x00173FAC
			// (set) Token: 0x0600524A RID: 21066 RVA: 0x0001DA48 File Offset: 0x0001BC48
			public unsafe static int aRfarStljqLRqdMSlFbVHEXEtyH
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_aRfarStljqLRqdMSlFbVHEXEtyH, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_aRfarStljqLRqdMSlFbVHEXEtyH, (void*)(&value));
				}
			}

			// Token: 0x1700193A RID: 6458
			// (get) Token: 0x0600524B RID: 21067 RVA: 0x00175DC8 File Offset: 0x00173FC8
			// (set) Token: 0x0600524C RID: 21068 RVA: 0x0001DA56 File Offset: 0x0001BC56
			public unsafe static int LhQCGqaUnvOIjKMfbJRcckFUqnPR
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_LhQCGqaUnvOIjKMfbJRcckFUqnPR, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_LhQCGqaUnvOIjKMfbJRcckFUqnPR, (void*)(&value));
				}
			}

			// Token: 0x1700193B RID: 6459
			// (get) Token: 0x0600524D RID: 21069 RVA: 0x00175DE4 File Offset: 0x00173FE4
			// (set) Token: 0x0600524E RID: 21070 RVA: 0x0001DA64 File Offset: 0x0001BC64
			public unsafe static int UKCJjJMjTPKceQGRJDATJJOYGdqU
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_UKCJjJMjTPKceQGRJDATJJOYGdqU, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_UKCJjJMjTPKceQGRJDATJJOYGdqU, (void*)(&value));
				}
			}

			// Token: 0x1700193C RID: 6460
			// (get) Token: 0x0600524F RID: 21071 RVA: 0x00175E00 File Offset: 0x00174000
			// (set) Token: 0x06005250 RID: 21072 RVA: 0x0001DA72 File Offset: 0x0001BC72
			public unsafe static int kVDSSrShTwGQQEtcRiBOwYozTle
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_kVDSSrShTwGQQEtcRiBOwYozTle, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_kVDSSrShTwGQQEtcRiBOwYozTle, (void*)(&value));
				}
			}

			// Token: 0x1700193D RID: 6461
			// (get) Token: 0x06005251 RID: 21073 RVA: 0x00175E1C File Offset: 0x0017401C
			// (set) Token: 0x06005252 RID: 21074 RVA: 0x0001DA80 File Offset: 0x0001BC80
			public unsafe static int kVgCjVvoljLKuviYSUAXPnguVqt
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_kVgCjVvoljLKuviYSUAXPnguVqt, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_kVgCjVvoljLKuviYSUAXPnguVqt, (void*)(&value));
				}
			}

			// Token: 0x1700193E RID: 6462
			// (get) Token: 0x06005253 RID: 21075 RVA: 0x00175E38 File Offset: 0x00174038
			// (set) Token: 0x06005254 RID: 21076 RVA: 0x0001DA8E File Offset: 0x0001BC8E
			public unsafe static int iTSiNRFmTaUgkQrUasqvpNIolnX
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_iTSiNRFmTaUgkQrUasqvpNIolnX, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_iTSiNRFmTaUgkQrUasqvpNIolnX, (void*)(&value));
				}
			}

			// Token: 0x1700193F RID: 6463
			// (get) Token: 0x06005255 RID: 21077 RVA: 0x00175E54 File Offset: 0x00174054
			// (set) Token: 0x06005256 RID: 21078 RVA: 0x0001DA9C File Offset: 0x0001BC9C
			public unsafe static int FDbFcfdCbQbbigMDkHpTwFqcQsX
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_FDbFcfdCbQbbigMDkHpTwFqcQsX, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_FDbFcfdCbQbbigMDkHpTwFqcQsX, (void*)(&value));
				}
			}

			// Token: 0x17001940 RID: 6464
			// (get) Token: 0x06005257 RID: 21079 RVA: 0x00175E70 File Offset: 0x00174070
			// (set) Token: 0x06005258 RID: 21080 RVA: 0x0001DAAA File Offset: 0x0001BCAA
			public unsafe static int MZGvzgxOXUAQmPYRHMLMddnkxLC
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_MZGvzgxOXUAQmPYRHMLMddnkxLC, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_MZGvzgxOXUAQmPYRHMLMddnkxLC, (void*)(&value));
				}
			}

			// Token: 0x17001941 RID: 6465
			// (get) Token: 0x06005259 RID: 21081 RVA: 0x00175E8C File Offset: 0x0017408C
			// (set) Token: 0x0600525A RID: 21082 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
			public unsafe static int RJPRICHkfBEdWCoFGnIKYjGqqnOD
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_RJPRICHkfBEdWCoFGnIKYjGqqnOD, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_RJPRICHkfBEdWCoFGnIKYjGqqnOD, (void*)(&value));
				}
			}

			// Token: 0x17001942 RID: 6466
			// (get) Token: 0x0600525B RID: 21083 RVA: 0x00175EA8 File Offset: 0x001740A8
			// (set) Token: 0x0600525C RID: 21084 RVA: 0x0001DAC6 File Offset: 0x0001BCC6
			public unsafe static int qIpMKZmZdmMjsIwmjwSKIRVtRPH
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_qIpMKZmZdmMjsIwmjwSKIRVtRPH, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_qIpMKZmZdmMjsIwmjwSKIRVtRPH, (void*)(&value));
				}
			}

			// Token: 0x17001943 RID: 6467
			// (get) Token: 0x0600525D RID: 21085 RVA: 0x00175EC4 File Offset: 0x001740C4
			// (set) Token: 0x0600525E RID: 21086 RVA: 0x0001DAD4 File Offset: 0x0001BCD4
			public unsafe static int HEyjWWaQaVjhQTfJvGcdeezyBzTF
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_HEyjWWaQaVjhQTfJvGcdeezyBzTF, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_HEyjWWaQaVjhQTfJvGcdeezyBzTF, (void*)(&value));
				}
			}

			// Token: 0x17001944 RID: 6468
			// (get) Token: 0x0600525F RID: 21087 RVA: 0x00175EE0 File Offset: 0x001740E0
			// (set) Token: 0x06005260 RID: 21088 RVA: 0x0001DAE2 File Offset: 0x0001BCE2
			public unsafe IXboxOneInputSource tamJGhaDrwcqghjueRIJXoQsGYe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXboxOneInputSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001945 RID: 6469
			// (get) Token: 0x06005261 RID: 21089 RVA: 0x00175F10 File Offset: 0x00174110
			// (set) Token: 0x06005262 RID: 21090 RVA: 0x0001DB01 File Offset: 0x0001BD01
			public unsafe int cHXgUkbCYeKQEnSQvuoKhZJTsUc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_cHXgUkbCYeKQEnSQvuoKhZJTsUc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_cHXgUkbCYeKQEnSQvuoKhZJTsUc)) = value;
				}
			}

			// Token: 0x17001946 RID: 6470
			// (get) Token: 0x06005263 RID: 21091 RVA: 0x00175F38 File Offset: 0x00174138
			// (set) Token: 0x06005264 RID: 21092 RVA: 0x0001DB1C File Offset: 0x0001BD1C
			public unsafe ulong nCvzHIaZltNcqVajorbbijeKbBCk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_nCvzHIaZltNcqVajorbbijeKbBCk);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_nCvzHIaZltNcqVajorbbijeKbBCk)) = value;
				}
			}

			// Token: 0x17001947 RID: 6471
			// (get) Token: 0x06005265 RID: 21093 RVA: 0x00175F60 File Offset: 0x00174160
			// (set) Token: 0x06005266 RID: 21094 RVA: 0x0001DB37 File Offset: 0x0001BD37
			public unsafe Il2CppStringArray WJhTtnoPKfUNgUdPQPNbRNbRFnQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_WJhTtnoPKfUNgUdPQPNbRNbRFnQ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XboxOneInputSource.qfOBCcGWMycYuffyzFFTjAyUSdn.NativeFieldInfoPtr_WJhTtnoPKfUNgUdPQPNbRNbRFnQ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004505 RID: 17669
			private static readonly IntPtr NativeFieldInfoPtr_wuJGhDkBlVgWLDdNjgUhulfhZzxt;

			// Token: 0x04004506 RID: 17670
			private static readonly IntPtr NativeFieldInfoPtr_AHoQaCqgIOGogOpDnwRoZuWfUKU;

			// Token: 0x04004507 RID: 17671
			private static readonly IntPtr NativeFieldInfoPtr_HSxEDSKBTmvIKgTlxldgopnkErK;

			// Token: 0x04004508 RID: 17672
			private static readonly IntPtr NativeFieldInfoPtr_syzaEenEjIyTeckEVIqCeWgKmZnn;

			// Token: 0x04004509 RID: 17673
			private static readonly IntPtr NativeFieldInfoPtr_BqIXwAIuRaghwJnUbBOnbysLqYGh;

			// Token: 0x0400450A RID: 17674
			private static readonly IntPtr NativeFieldInfoPtr_sXIJXDyWIdGIAFsknTKXWJFpnbT;

			// Token: 0x0400450B RID: 17675
			private static readonly IntPtr NativeFieldInfoPtr_ZqzjaQxGaTXQUDMcHBiVJTdcANf;

			// Token: 0x0400450C RID: 17676
			private static readonly IntPtr NativeFieldInfoPtr_OJcDjkbVbtDSDndemXQPqyUzgXj;

			// Token: 0x0400450D RID: 17677
			private static readonly IntPtr NativeFieldInfoPtr_zvYFkOheBTfswITMRACCxVIeoOY;

			// Token: 0x0400450E RID: 17678
			private static readonly IntPtr NativeFieldInfoPtr_JotiUbjvsDltxIyExabmeBEOIou;

			// Token: 0x0400450F RID: 17679
			private static readonly IntPtr NativeFieldInfoPtr_qAqXwlHNMreMssPkDHEWkKeimpz;

			// Token: 0x04004510 RID: 17680
			private static readonly IntPtr NativeFieldInfoPtr_ETGMzVIrFroPyqiMRskBgQhkhTbJ;

			// Token: 0x04004511 RID: 17681
			private static readonly IntPtr NativeFieldInfoPtr_aRfarStljqLRqdMSlFbVHEXEtyH;

			// Token: 0x04004512 RID: 17682
			private static readonly IntPtr NativeFieldInfoPtr_LhQCGqaUnvOIjKMfbJRcckFUqnPR;

			// Token: 0x04004513 RID: 17683
			private static readonly IntPtr NativeFieldInfoPtr_UKCJjJMjTPKceQGRJDATJJOYGdqU;

			// Token: 0x04004514 RID: 17684
			private static readonly IntPtr NativeFieldInfoPtr_kVDSSrShTwGQQEtcRiBOwYozTle;

			// Token: 0x04004515 RID: 17685
			private static readonly IntPtr NativeFieldInfoPtr_kVgCjVvoljLKuviYSUAXPnguVqt;

			// Token: 0x04004516 RID: 17686
			private static readonly IntPtr NativeFieldInfoPtr_iTSiNRFmTaUgkQrUasqvpNIolnX;

			// Token: 0x04004517 RID: 17687
			private static readonly IntPtr NativeFieldInfoPtr_FDbFcfdCbQbbigMDkHpTwFqcQsX;

			// Token: 0x04004518 RID: 17688
			private static readonly IntPtr NativeFieldInfoPtr_MZGvzgxOXUAQmPYRHMLMddnkxLC;

			// Token: 0x04004519 RID: 17689
			private static readonly IntPtr NativeFieldInfoPtr_RJPRICHkfBEdWCoFGnIKYjGqqnOD;

			// Token: 0x0400451A RID: 17690
			private static readonly IntPtr NativeFieldInfoPtr_qIpMKZmZdmMjsIwmjwSKIRVtRPH;

			// Token: 0x0400451B RID: 17691
			private static readonly IntPtr NativeFieldInfoPtr_HEyjWWaQaVjhQTfJvGcdeezyBzTF;

			// Token: 0x0400451C RID: 17692
			private static readonly IntPtr NativeFieldInfoPtr_tamJGhaDrwcqghjueRIJXoQsGYe;

			// Token: 0x0400451D RID: 17693
			private static readonly IntPtr NativeFieldInfoPtr_cHXgUkbCYeKQEnSQvuoKhZJTsUc;

			// Token: 0x0400451E RID: 17694
			private static readonly IntPtr NativeFieldInfoPtr_nCvzHIaZltNcqVajorbbijeKbBCk;

			// Token: 0x0400451F RID: 17695
			private static readonly IntPtr NativeFieldInfoPtr_WJhTtnoPKfUNgUdPQPNbRNbRFnQ;

			// Token: 0x04004520 RID: 17696
			private static readonly IntPtr NativeMethodInfoPtr_get_xboxControllerId_Public_get_UInt64_0;

			// Token: 0x04004521 RID: 17697
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IXboxOneInputSource_UInt64_Int32_Boolean_0;

			// Token: 0x04004522 RID: 17698
			private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Virtual_Void_0;

			// Token: 0x04004523 RID: 17699
			private static readonly IntPtr NativeMethodInfoPtr_dwHOFmApnpWkXreTmwZYsRXRrow_Public_Void_UInt64_0;

			// Token: 0x04004524 RID: 17700
			private static readonly IntPtr NativeMethodInfoPtr_QfGPTYLRgCyphPGiTguxvWucxER_Private_Void_0;

			// Token: 0x04004525 RID: 17701
			private static readonly IntPtr NativeMethodInfoPtr_IGHJtcUsJKSjkaMGCICEjkyTwnj_Private_Boolean_Int32_0;

			// Token: 0x04004526 RID: 17702
			private static readonly IntPtr NativeMethodInfoPtr_pmsoOLMDBALUTpsnmGgnHGuPRLs_Private_Void_0;
		}
	}
}
