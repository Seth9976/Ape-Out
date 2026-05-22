using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public sealed class Navigation : ValueType
	{
		// Token: 0x0600053C RID: 1340 RVA: 0x0001AFC8 File Offset: 0x000191C8
		// Note: this type is marked as 'beforefieldinit'.
		static Navigation()
		{
			Il2CppClassPointerStore<Navigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Navigation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Navigation>.NativeClassPtr);
			Navigation.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_Mode");
			Navigation.NativeFieldInfoPtr_m_WrapAround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_WrapAround");
			Navigation.NativeFieldInfoPtr_m_SelectOnUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnUp");
			Navigation.NativeFieldInfoPtr_m_SelectOnDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnDown");
			Navigation.NativeFieldInfoPtr_m_SelectOnLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnLeft");
			Navigation.NativeFieldInfoPtr_m_SelectOnRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnRight");
			Navigation.NativeMethodInfoPtr_get_mode_Public_get_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664154);
			Navigation.NativeMethodInfoPtr_set_mode_Public_set_Void_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664155);
			Navigation.NativeMethodInfoPtr_get_wrapAround_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664156);
			Navigation.NativeMethodInfoPtr_set_wrapAround_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664157);
			Navigation.NativeMethodInfoPtr_get_selectOnUp_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664158);
			Navigation.NativeMethodInfoPtr_set_selectOnUp_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664159);
			Navigation.NativeMethodInfoPtr_get_selectOnDown_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664160);
			Navigation.NativeMethodInfoPtr_set_selectOnDown_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664161);
			Navigation.NativeMethodInfoPtr_get_selectOnLeft_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664162);
			Navigation.NativeMethodInfoPtr_set_selectOnLeft_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664163);
			Navigation.NativeMethodInfoPtr_get_selectOnRight_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664164);
			Navigation.NativeMethodInfoPtr_set_selectOnRight_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664165);
			Navigation.NativeMethodInfoPtr_get_defaultNavigation_Public_Static_get_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664166);
			Navigation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664167);
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0001B188 File Offset: 0x00019388
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x0001B1CC File Offset: 0x000193CC
		public unsafe Navigation.Mode mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_mode_Public_get_Mode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_mode_Public_set_Void_Mode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0001B210 File Offset: 0x00019410
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x0001B254 File Offset: 0x00019454
		public unsafe bool wrapAround
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_wrapAround_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_wrapAround_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0001B298 File Offset: 0x00019498
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0001B2DC File Offset: 0x000194DC
		public unsafe Selectable selectOnUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnUp_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 99331, RefRangeEnd = 99333, XrefRangeStart = 99331, XrefRangeEnd = 99333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnUp_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001B324 File Offset: 0x00019524
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x0001B368 File Offset: 0x00019568
		public unsafe Selectable selectOnDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnDown_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnDown_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001B3B0 File Offset: 0x000195B0
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0001B3F4 File Offset: 0x000195F4
		public unsafe Selectable selectOnLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnLeft_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnLeft_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001B43C File Offset: 0x0001963C
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0001B480 File Offset: 0x00019680
		public unsafe Selectable selectOnRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnRight_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnRight_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001B4C8 File Offset: 0x000196C8
		public unsafe static Navigation defaultNavigation
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_defaultNavigation_Public_Static_get_Navigation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Navigation(intPtr);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001B4F4 File Offset: 0x000196F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 525866, RefRangeEnd = 525867, XrefRangeStart = 525794, XrefRangeEnd = 525866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Navigation other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Navigation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00003C73 File Offset: 0x00001E73
		public Navigation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00003C7C File Offset: 0x00001E7C
		public Navigation()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Navigation>.NativeClassPtr))
		{
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001B54C File Offset: 0x0001974C
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00003C8E File Offset: 0x00001E8E
		public unsafe Navigation.Mode m_Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_Mode)) = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001B574 File Offset: 0x00019774
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00003CA9 File Offset: 0x00001EA9
		public unsafe bool m_WrapAround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_WrapAround);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_WrapAround)) = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001B59C File Offset: 0x0001979C
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00003CC4 File Offset: 0x00001EC4
		public unsafe Selectable m_SelectOnUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0001B5CC File Offset: 0x000197CC
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00003CE3 File Offset: 0x00001EE3
		public unsafe Selectable m_SelectOnDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0001B5FC File Offset: 0x000197FC
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00003D02 File Offset: 0x00001F02
		public unsafe Selectable m_SelectOnLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0001B62C File Offset: 0x0001982C
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00003D21 File Offset: 0x00001F21
		public unsafe Selectable m_SelectOnRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_m_WrapAround;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnUp;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnDown;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnLeft;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnRight;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_get_mode_Public_get_Mode_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_set_mode_Public_set_Void_Mode_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_get_wrapAround_Public_get_Boolean_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapAround_Public_set_Void_Boolean_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnUp_Public_get_Selectable_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnUp_Public_set_Void_Selectable_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnDown_Public_get_Selectable_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnDown_Public_set_Void_Selectable_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnLeft_Public_get_Selectable_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnLeft_Public_set_Void_Selectable_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnRight_Public_get_Selectable_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnRight_Public_set_Void_Selectable_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultNavigation_Public_Static_get_Navigation_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Navigation_0;

		// Token: 0x020000A0 RID: 160
		[OriginalName("UnityEngine.UI.dll", "", "Mode")]
		[Flags]
		public enum Mode
		{
			// Token: 0x0400095C RID: 2396
			None = 0,
			// Token: 0x0400095D RID: 2397
			Horizontal = 1,
			// Token: 0x0400095E RID: 2398
			Vertical = 2,
			// Token: 0x0400095F RID: 2399
			Automatic = 3,
			// Token: 0x04000960 RID: 2400
			Explicit = 4
		}
	}
}
