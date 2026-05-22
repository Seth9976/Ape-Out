using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003B RID: 59
	public class ToggleGroup : UIBehaviour
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x00024E30 File Offset: 0x00023030
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleGroup()
		{
			Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ToggleGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr);
			ToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, "m_AllowSwitchOff");
			ToggleGroup.NativeFieldInfoPtr_m_Toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, "m_Toggles");
			ToggleGroup.NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664540);
			ToggleGroup.NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664541);
			ToggleGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664542);
			ToggleGroup.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664543);
			ToggleGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664544);
			ToggleGroup.NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664545);
			ToggleGroup.NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664546);
			ToggleGroup.NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664547);
			ToggleGroup.NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664548);
			ToggleGroup.NativeMethodInfoPtr_EnsureValidState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664549);
			ToggleGroup.NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664550);
			ToggleGroup.NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664551);
			ToggleGroup.NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664552);
			ToggleGroup.NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664553);
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00024FA0 File Offset: 0x000231A0
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00024FDC File Offset: 0x000231DC
		public unsafe bool allowSwitchOff
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0002501C File Offset: 0x0002321C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529056, XrefRangeEnd = 529065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00025058 File Offset: 0x00023258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529065, XrefRangeEnd = 529066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleGroup.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00025094 File Offset: 0x00023294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000250D0 File Offset: 0x000232D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 529081, RefRangeEnd = 529082, XrefRangeStart = 529066, XrefRangeEnd = 529081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateToggleIsInGroup(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00025114 File Offset: 0x00023314
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 529109, RefRangeEnd = 529112, XrefRangeStart = 529082, XrefRangeEnd = 529109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00025164 File Offset: 0x00023364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529112, XrefRangeEnd = 529117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterToggle(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000251A8 File Offset: 0x000233A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529117, XrefRangeEnd = 529123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterToggle(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000251EC File Offset: 0x000233EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 529172, RefRangeEnd = 529175, XrefRangeStart = 529123, XrefRangeEnd = 529172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureValidState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_EnsureValidState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00025220 File Offset: 0x00023420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 529203, RefRangeEnd = 529205, XrefRangeStart = 529175, XrefRangeEnd = 529203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyTogglesOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0002525C File Offset: 0x0002345C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 529223, RefRangeEnd = 529226, XrefRangeStart = 529205, XrefRangeEnd = 529223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Toggle> ActiveToggles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Toggle>>(intPtr3) : null;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0002529C File Offset: 0x0002349C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529226, XrefRangeEnd = 529233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toggle GetFirstActiveToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000252DC File Offset: 0x000234DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529233, XrefRangeEnd = 529239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllTogglesOff(bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sendCallback;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00004A37 File Offset: 0x00002C37
		public ToggleGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0002531C File Offset: 0x0002351C
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00004A40 File Offset: 0x00002C40
		public unsafe bool m_AllowSwitchOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff)) = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00025344 File Offset: 0x00023544
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00004A5B File Offset: 0x00002C5B
		public unsafe List<Toggle> m_Toggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_Toggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Toggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_Toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowSwitchOff;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_m_Toggles;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_EnsureValidState_Public_Void_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0;

		// Token: 0x020000B2 RID: 178
		[ObfuscatedName("UnityEngine.UI.ToggleGroup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000C4D RID: 3149 RVA: 0x000350B8 File Offset: 0x000332B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr);
				ToggleGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, "<>9");
				ToggleGroup.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, "<>9__13_0");
				ToggleGroup.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, "<>9__14_0");
				ToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, 100664555);
				ToggleGroup.__c.NativeMethodInfoPtr__AnyTogglesOn_b__13_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, 100664556);
				ToggleGroup.__c.NativeMethodInfoPtr__ActiveToggles_b__14_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, 100664557);
			}

			// Token: 0x06000C4E RID: 3150 RVA: 0x0003515C File Offset: 0x0003335C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C4F RID: 3151 RVA: 0x00035198 File Offset: 0x00033398
			[CallerCount(0)]
			public unsafe bool _AnyTogglesOn_b__13_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.__c.NativeMethodInfoPtr__AnyTogglesOn_b__13_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C50 RID: 3152 RVA: 0x000351E8 File Offset: 0x000333E8
			[CallerCount(0)]
			public unsafe bool _ActiveToggles_b__14_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.__c.NativeMethodInfoPtr__ActiveToggles_b__14_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x00006A99 File Offset: 0x00004C99
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00035238 File Offset: 0x00033438
			// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00006AA2 File Offset: 0x00004CA2
			public unsafe static ToggleGroup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00035260 File Offset: 0x00033460
			// (set) Token: 0x06000C55 RID: 3157 RVA: 0x00006AB4 File Offset: 0x00004CB4
			public unsafe static Predicate<Toggle> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroup.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Toggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroup.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00035288 File Offset: 0x00033488
			// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00006AC6 File Offset: 0x00004CC6
			public unsafe static Func<Toggle, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroup.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Toggle, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroup.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009A3 RID: 2467
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040009A4 RID: 2468
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040009A5 RID: 2469
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040009A6 RID: 2470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009A7 RID: 2471
			private static readonly IntPtr NativeMethodInfoPtr__AnyTogglesOn_b__13_0_Internal_Boolean_Toggle_0;

			// Token: 0x040009A8 RID: 2472
			private static readonly IntPtr NativeMethodInfoPtr__ActiveToggles_b__14_0_Internal_Boolean_Toggle_0;
		}
	}
}
