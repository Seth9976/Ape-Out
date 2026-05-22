using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000E7 RID: 231
	public class Glass : MessageReceiver
	{
		// Token: 0x06001A6C RID: 6764 RVA: 0x0007F4EC File Offset: 0x0007D6EC
		// Note: this type is marked as 'beforefieldinit'.
		static Glass()
		{
			Il2CppClassPointerStore<Glass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Glass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Glass>.NativeClassPtr);
			Glass.NativeFieldInfoPtr_broke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "broke");
			Glass.NativeFieldInfoPtr_dontBreakWhenRunInto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "dontBreakWhenRunInto");
			Glass.NativeFieldInfoPtr_dontActuallyDestroyOnBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "dontActuallyDestroyOnBreak");
			Glass.NativeFieldInfoPtr_partString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "partString");
			Glass.NativeFieldInfoPtr_ob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "ob");
			Glass.NativeFieldInfoPtr_ObstacleLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "ObstacleLayerMask");
			Glass.NativeFieldInfoPtr_ObstacleLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "ObstacleLayer");
			Glass.NativeFieldInfoPtr_IgnoreRaycastLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "IgnoreRaycastLayer");
			Glass.NativeFieldInfoPtr_defPartString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "defPartString");
			Glass.NativeFieldInfoPtr_noStun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glass>.NativeClassPtr, "noStun");
			Glass.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665491);
			Glass.NativeMethodInfoPtr_CastYourself_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665492);
			Glass.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665493);
			Glass.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665494);
			Glass.NativeMethodInfoPtr_Break_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665495);
			Glass.NativeMethodInfoPtr_PlayBreakSound_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665496);
			Glass.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665497);
			Glass.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665498);
			Glass.NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665499);
			Glass.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665500);
			Glass.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665501);
			Glass.NativeMethodInfoPtr_RanInto_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665502);
			Glass.NativeMethodInfoPtr_OnMidPush_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665503);
			Glass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glass>.NativeClassPtr, 100665504);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0007F6FC File Offset: 0x0007D8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60838, XrefRangeEnd = 60862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0007F738 File Offset: 0x0007D938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60862, XrefRangeEnd = 61086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CastYourself()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_CastYourself_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x0007F774 File Offset: 0x0007D974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61144, RefRangeEnd = 61145, XrefRangeStart = 61086, XrefRangeEnd = 61144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x0007F7B0 File Offset: 0x0007D9B0
		[CallerCount(0)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x0007F7EC File Offset: 0x0007D9EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 61228, RefRangeEnd = 61231, XrefRangeStart = 61145, XrefRangeEnd = 61228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Break(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_Break_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0007F838 File Offset: 0x0007DA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61231, XrefRangeEnd = 61248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayBreakSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_PlayBreakSound_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0007F874 File Offset: 0x0007DA74
		[CallerCount(0)]
		public unsafe override void OnBlown(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0007F8C0 File Offset: 0x0007DAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61248, XrefRangeEnd = 61271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShot(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0007F910 File Offset: 0x0007DB10
		[CallerCount(0)]
		public unsafe override void OnSmashed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0007F95C File Offset: 0x0007DB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61271, XrefRangeEnd = 61280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSlammed(Il2CppStructArray<Vector2> pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0007F9AC File Offset: 0x0007DBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61280, XrefRangeEnd = 61302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPushed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0007F9F8 File Offset: 0x0007DBF8
		[CallerCount(0)]
		public unsafe void RanInto(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glass.NativeMethodInfoPtr_RanInto_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0007FA38 File Offset: 0x0007DC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61302, XrefRangeEnd = 61326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnMidPush(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Glass.NativeMethodInfoPtr_OnMidPush_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x0007FA84 File Offset: 0x0007DC84
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 61334, RefRangeEnd = 61340, XrefRangeStart = 61326, XrefRangeEnd = 61334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Glass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000128E6 File Offset: 0x00010AE6
		public Glass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0007FAC0 File Offset: 0x0007DCC0
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x000128EF File Offset: 0x00010AEF
		public unsafe bool broke
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_broke);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_broke)) = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0007FAE8 File Offset: 0x0007DCE8
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0001290A File Offset: 0x00010B0A
		public unsafe bool dontBreakWhenRunInto
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_dontBreakWhenRunInto);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_dontBreakWhenRunInto)) = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0007FB10 File Offset: 0x0007DD10
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x00012925 File Offset: 0x00010B25
		public unsafe bool dontActuallyDestroyOnBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_dontActuallyDestroyOnBreak);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_dontActuallyDestroyOnBreak)) = value;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0007FB38 File Offset: 0x0007DD38
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x00012940 File Offset: 0x00010B40
		public unsafe string partString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_partString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_partString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0007FB60 File Offset: 0x0007DD60
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0001295F File Offset: 0x00010B5F
		public unsafe Obstacle ob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_ob);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Obstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_ob), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0007FB90 File Offset: 0x0007DD90
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0001297E File Offset: 0x00010B7E
		public unsafe int ObstacleLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_ObstacleLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_ObstacleLayerMask)) = value;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x0007FBB8 File Offset: 0x0007DDB8
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x00012999 File Offset: 0x00010B99
		public unsafe int ObstacleLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_ObstacleLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_ObstacleLayer)) = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0007FBE0 File Offset: 0x0007DDE0
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x000129B4 File Offset: 0x00010BB4
		public unsafe int IgnoreRaycastLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_IgnoreRaycastLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_IgnoreRaycastLayer)) = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0007FC08 File Offset: 0x0007DE08
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x000129CF File Offset: 0x00010BCF
		public unsafe string defPartString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_defPartString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_defPartString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x0007FC30 File Offset: 0x0007DE30
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x000129EE File Offset: 0x00010BEE
		public unsafe bool noStun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_noStun);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glass.NativeFieldInfoPtr_noStun)) = value;
			}
		}

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeFieldInfoPtr_broke;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeFieldInfoPtr_dontBreakWhenRunInto;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeFieldInfoPtr_dontActuallyDestroyOnBreak;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeFieldInfoPtr_partString;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeFieldInfoPtr_ob;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleLayerMask;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeFieldInfoPtr_ObstacleLayer;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreRaycastLayer;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeFieldInfoPtr_defPartString;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeFieldInfoPtr_noStun;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_CastYourself_Public_Virtual_New_Void_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_New_Void_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_PlayBreakSound_Public_Virtual_New_Void_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_OnBlown_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_OnShot_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_OnSmashed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_OnSlammed_Public_Virtual_Void_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_RanInto_Public_Void_Vector2_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_OnMidPush_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
