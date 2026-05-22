using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.Interfaces;
using Il2CppRewired.Utils.Classes.Utility;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000070 RID: 112
	public sealed class Mouse : ControllerWithAxes
	{
		// Token: 0x06000FB5 RID: 4021 RVA: 0x00067808 File Offset: 0x00065A08
		// Note: this type is marked as 'beforefieldinit'.
		static Mouse()
		{
			Il2CppClassPointerStore<Mouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "Mouse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mouse>.NativeClassPtr);
			Mouse.NativeFieldInfoPtr_rGPMpAlSrSlkbUAHoIAvsGKgZpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "rGPMpAlSrSlkbUAHoIAvsGKgZpr");
			Mouse.NativeFieldInfoPtr_FuuLtAuDRjBSpeXyQiDwKgviabaf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "FuuLtAuDRjBSpeXyQiDwKgviabaf");
			Mouse.NativeFieldInfoPtr_TfsoZYHQMdqdtFlHDBsyoghCqsZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "TfsoZYHQMdqdtFlHDBsyoghCqsZ");
			Mouse.NativeFieldInfoPtr_ZIlfCsNrPtiQHtguiwXkAMscvmr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "ZIlfCsNrPtiQHtguiwXkAMscvmr");
			Mouse.NativeFieldInfoPtr_ntUzVjqSVjMyKHgYEHvUaJUocQy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "ntUzVjqSVjMyKHgYEHvUaJUocQy");
			Mouse.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "qtbpemUQyoPTMaHrxCYIFOqVxvz");
			Mouse.NativeFieldInfoPtr_zOKGWxVZlauLMyWkKaSvRmejxUJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "zOKGWxVZlauLMyWkKaSvRmejxUJ");
			Mouse.NativeMethodInfoPtr_get_screenPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665800);
			Mouse.NativeMethodInfoPtr_get_screenPositionPrev_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665801);
			Mouse.NativeMethodInfoPtr_get_screenPositionDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665802);
			Mouse.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665803);
			Mouse.NativeMethodInfoPtr__ctor_Internal_Void_String_IUnifiedMouseSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665804);
			Mouse.NativeMethodInfoPtr__ctor_Private_Void_Int32_InputSource_String_String_Int32_Int32_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665805);
			Mouse.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665806);
			Mouse.NativeMethodInfoPtr_IsPolledAxisActive_Protected_Virtual_Boolean_Int32_byref_Pole_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665807);
			Mouse.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665808);
			Mouse.NativeMethodInfoPtr_DmSiOupNgsMWUccocIUOZmnzejoJ_Internal_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665809);
			Mouse.NativeMethodInfoPtr_ghEUJRiNGigeRWRJrVfISgOGsXd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665810);
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x000679A0 File Offset: 0x00065BA0
		public unsafe Vector2 screenPosition
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 257880, RefRangeEnd = 257886, XrefRangeStart = 257876, XrefRangeEnd = 257880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr_get_screenPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x000679DC File Offset: 0x00065BDC
		public unsafe Vector2 screenPositionPrev
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257886, XrefRangeEnd = 257890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr_get_screenPositionPrev_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00067A18 File Offset: 0x00065C18
		public unsafe Vector2 screenPositionDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257890, XrefRangeEnd = 257894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr_get_screenPositionDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00067A54 File Offset: 0x00065C54
		public unsafe override Guid deviceInstanceGuid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257894, XrefRangeEnd = 257901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00067A90 File Offset: 0x00065C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257944, RefRangeEnd = 257945, XrefRangeStart = 257901, XrefRangeEnd = 257944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mouse(string name, IUnifiedMouseSource source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mouse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr__ctor_Internal_Void_String_IUnifiedMouseSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00067AF0 File Offset: 0x00065CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257945, XrefRangeEnd = 257950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mouse(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Controller.Extension extension, ControllerDataUpdater dataUpdater)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mouse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controllerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hardwareIdentifier);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hardwareMap);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extension);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataUpdater);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr__ctor_Private_Void_Int32_InputSource_String_String_Int32_Int32_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00067BC0 File Offset: 0x00065DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257950, XrefRangeEnd = 257956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ZTVaYQHtFassaSGDSzEcxNiGpigu(UpdateLoopType A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00067C00 File Offset: 0x00065E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257956, XrefRangeEnd = 257978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pole;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &elementIdentifierId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr_IsPolledAxisActive_Protected_Virtual_Boolean_Int32_byref_Pole_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00067C68 File Offset: 0x00065E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257978, XrefRangeEnd = 257983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00067C9C File Offset: 0x00065E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257983, XrefRangeEnd = 257988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DmSiOupNgsMWUccocIUOZmnzejoJ(bool A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr_DmSiOupNgsMWUccocIUOZmnzejoJ_Internal_Virtual_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00067CE8 File Offset: 0x00065EE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258002, RefRangeEnd = 258004, XrefRangeStart = 257988, XrefRangeEnd = 258002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ghEUJRiNGigeRWRJrVfISgOGsXd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mouse.NativeMethodInfoPtr_ghEUJRiNGigeRWRJrVfISgOGsXd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00007284 File Offset: 0x00005484
		public Mouse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00067D1C File Offset: 0x00065F1C
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x0000728D File Offset: 0x0000548D
		public unsafe TimerAbs rGPMpAlSrSlkbUAHoIAvsGKgZpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_rGPMpAlSrSlkbUAHoIAvsGKgZpr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerAbs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_rGPMpAlSrSlkbUAHoIAvsGKgZpr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00067D4C File Offset: 0x00065F4C
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x000072AC File Offset: 0x000054AC
		public unsafe Il2CppStructArray<float> FuuLtAuDRjBSpeXyQiDwKgviabaf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_FuuLtAuDRjBSpeXyQiDwKgviabaf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_FuuLtAuDRjBSpeXyQiDwKgviabaf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00067D7C File Offset: 0x00065F7C
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x000072CB File Offset: 0x000054CB
		public unsafe Vector2 TfsoZYHQMdqdtFlHDBsyoghCqsZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_TfsoZYHQMdqdtFlHDBsyoghCqsZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_TfsoZYHQMdqdtFlHDBsyoghCqsZ)) = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00067DA4 File Offset: 0x00065FA4
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x000072E6 File Offset: 0x000054E6
		public unsafe Vector2 ZIlfCsNrPtiQHtguiwXkAMscvmr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_ZIlfCsNrPtiQHtguiwXkAMscvmr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_ZIlfCsNrPtiQHtguiwXkAMscvmr)) = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00067DCC File Offset: 0x00065FCC
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x00007301 File Offset: 0x00005501
		public unsafe int ntUzVjqSVjMyKHgYEHvUaJUocQy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_ntUzVjqSVjMyKHgYEHvUaJUocQy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_ntUzVjqSVjMyKHgYEHvUaJUocQy)) = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00067DF4 File Offset: 0x00065FF4
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x0000731C File Offset: 0x0000551C
		public unsafe IUnifiedMouseSource qtbpemUQyoPTMaHrxCYIFOqVxvz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUnifiedMouseSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mouse.NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00067E24 File Offset: 0x00066024
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0000733B File Offset: 0x0000553B
		public unsafe static Guid zOKGWxVZlauLMyWkKaSvRmejxUJ
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Mouse.NativeFieldInfoPtr_zOKGWxVZlauLMyWkKaSvRmejxUJ, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Mouse.NativeFieldInfoPtr_zOKGWxVZlauLMyWkKaSvRmejxUJ, (void*)(&value));
			}
		}

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeFieldInfoPtr_rGPMpAlSrSlkbUAHoIAvsGKgZpr;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeFieldInfoPtr_FuuLtAuDRjBSpeXyQiDwKgviabaf;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeFieldInfoPtr_TfsoZYHQMdqdtFlHDBsyoghCqsZ;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeFieldInfoPtr_ZIlfCsNrPtiQHtguiwXkAMscvmr;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeFieldInfoPtr_ntUzVjqSVjMyKHgYEHvUaJUocQy;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeFieldInfoPtr_qtbpemUQyoPTMaHrxCYIFOqVxvz;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeFieldInfoPtr_zOKGWxVZlauLMyWkKaSvRmejxUJ;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPosition_Public_get_Vector2_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPositionPrev_Public_get_Vector2_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_get_screenPositionDelta_Public_get_Vector2_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceInstanceGuid_Public_Virtual_get_Guid_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IUnifiedMouseSource_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_InputSource_String_String_Int32_Int32_HardwareControllerMap_Game_Extension_ControllerDataUpdater_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_ZTVaYQHtFassaSGDSzEcxNiGpigu_Internal_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_IsPolledAxisActive_Protected_Virtual_Boolean_Int32_byref_Pole_byref_Int32_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Internal_Virtual_Void_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_DmSiOupNgsMWUccocIUOZmnzejoJ_Internal_Virtual_Boolean_Boolean_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_ghEUJRiNGigeRWRJrVfISgOGsXd_Private_Void_0;
	}
}
