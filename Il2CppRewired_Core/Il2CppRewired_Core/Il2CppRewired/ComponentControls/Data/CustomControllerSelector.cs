using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.ComponentControls.Data
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public sealed class CustomControllerSelector : Object
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x00041FB4 File Offset: 0x000401B4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerSelector()
		{
			Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.ComponentControls.Data", "CustomControllerSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr);
			CustomControllerSelector.NativeFieldInfoPtr__findUsingSourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, "_findUsingSourceId");
			CustomControllerSelector.NativeFieldInfoPtr__sourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, "_sourceId");
			CustomControllerSelector.NativeFieldInfoPtr__findUsingTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, "_findUsingTag");
			CustomControllerSelector.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, "_tag");
			CustomControllerSelector.NativeFieldInfoPtr__findInPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, "_findInPlayer");
			CustomControllerSelector.NativeFieldInfoPtr__playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, "_playerId");
			CustomControllerSelector.NativeMethodInfoPtr_get_findUsingSourceId_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664198);
			CustomControllerSelector.NativeMethodInfoPtr_set_findUsingSourceId_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664199);
			CustomControllerSelector.NativeMethodInfoPtr_get_sourceId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664200);
			CustomControllerSelector.NativeMethodInfoPtr_set_sourceId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664201);
			CustomControllerSelector.NativeMethodInfoPtr_get_findUsingTag_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664202);
			CustomControllerSelector.NativeMethodInfoPtr_set_findUsingTag_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664203);
			CustomControllerSelector.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664204);
			CustomControllerSelector.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664205);
			CustomControllerSelector.NativeMethodInfoPtr_get_findInPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664206);
			CustomControllerSelector.NativeMethodInfoPtr_set_findInPlayer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664207);
			CustomControllerSelector.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664208);
			CustomControllerSelector.NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664209);
			CustomControllerSelector.NativeMethodInfoPtr_GetCustomController_Internal_CustomController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664210);
			CustomControllerSelector.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664211);
			CustomControllerSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr, 100664212);
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00042188 File Offset: 0x00040388
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x000421C4 File Offset: 0x000403C4
		public unsafe bool findUsingSourceId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_get_findUsingSourceId_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_set_findUsingSourceId_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00042204 File Offset: 0x00040404
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00042240 File Offset: 0x00040440
		public unsafe int sourceId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_get_sourceId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_set_sourceId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00042280 File Offset: 0x00040480
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x000422BC File Offset: 0x000404BC
		public unsafe bool findUsingTag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_get_findUsingTag_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_set_findUsingTag_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x000422FC File Offset: 0x000404FC
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00042334 File Offset: 0x00040534
		public unsafe string tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00042378 File Offset: 0x00040578
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x000423B4 File Offset: 0x000405B4
		public unsafe bool findInPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_get_findInPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_set_findInPlayer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x000423F4 File Offset: 0x000405F4
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00042430 File Offset: 0x00040630
		public unsafe int playerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00042470 File Offset: 0x00040670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246051, RefRangeEnd = 246052, XrefRangeStart = 246033, XrefRangeEnd = 246051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomController GetCustomController()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_GetCustomController_Internal_CustomController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController>(intPtr3) : null;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000424B0 File Offset: 0x000406B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VcVpHMiieyhyUeIXveeGUlXtjUXf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000424E4 File Offset: 0x000406E4
		[CallerCount(0)]
		public unsafe CustomControllerSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00003A79 File Offset: 0x00001C79
		public CustomControllerSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00042520 File Offset: 0x00040720
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00003A82 File Offset: 0x00001C82
		public unsafe bool _findUsingSourceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__findUsingSourceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__findUsingSourceId)) = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00042548 File Offset: 0x00040748
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00003A9D File Offset: 0x00001C9D
		public unsafe int _sourceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__sourceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__sourceId)) = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00042570 File Offset: 0x00040770
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public unsafe bool _findUsingTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__findUsingTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__findUsingTag)) = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00042598 File Offset: 0x00040798
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00003AD3 File Offset: 0x00001CD3
		public unsafe string _tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x000425C0 File Offset: 0x000407C0
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00003AF2 File Offset: 0x00001CF2
		public unsafe bool _findInPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__findInPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__findInPlayer)) = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x000425E8 File Offset: 0x000407E8
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00003B0D File Offset: 0x00001D0D
		public unsafe int _playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerSelector.NativeFieldInfoPtr__playerId)) = value;
			}
		}

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr__findUsingSourceId;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr__sourceId;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr__findUsingTag;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr__tag;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr__findInPlayer;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr__playerId;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_get_findUsingSourceId_Public_get_Boolean_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_set_findUsingSourceId_Public_set_Void_Boolean_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceId_Public_get_Int32_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_set_sourceId_Public_set_Void_Int32_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_get_findUsingTag_Public_get_Boolean_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_set_findUsingTag_Public_set_Void_Boolean_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_get_findInPlayer_Public_get_Boolean_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_set_findInPlayer_Public_set_Void_Boolean_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomController_Internal_CustomController_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_VcVpHMiieyhyUeIXveeGUlXtjUXf_Private_Void_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
