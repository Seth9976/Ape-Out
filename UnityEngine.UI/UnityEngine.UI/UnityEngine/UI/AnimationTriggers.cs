using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000002 RID: 2
	[Serializable]
	public class AnimationTriggers : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00006E68 File Offset: 0x00005068
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationTriggers()
		{
			Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "AnimationTriggers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr);
			AnimationTriggers.NativeFieldInfoPtr_kDefaultNormalAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultNormalAnimName");
			AnimationTriggers.NativeFieldInfoPtr_kDefaultHighlightedAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultHighlightedAnimName");
			AnimationTriggers.NativeFieldInfoPtr_kDefaultPressedAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultPressedAnimName");
			AnimationTriggers.NativeFieldInfoPtr_kDefaultSelectedAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultSelectedAnimName");
			AnimationTriggers.NativeFieldInfoPtr_kDefaultDisabledAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultDisabledAnimName");
			AnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_NormalTrigger");
			AnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_HighlightedTrigger");
			AnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_PressedTrigger");
			AnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_SelectedTrigger");
			AnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_DisabledTrigger");
			AnimationTriggers.NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663297);
			AnimationTriggers.NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663298);
			AnimationTriggers.NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663299);
			AnimationTriggers.NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663300);
			AnimationTriggers.NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663301);
			AnimationTriggers.NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663302);
			AnimationTriggers.NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663303);
			AnimationTriggers.NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663304);
			AnimationTriggers.NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663305);
			AnimationTriggers.NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663306);
			AnimationTriggers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663307);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000703C File Offset: 0x0000523C
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00007074 File Offset: 0x00005274
		public unsafe string normalTrigger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000070B8 File Offset: 0x000052B8
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000070F0 File Offset: 0x000052F0
		public unsafe string highlightedTrigger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00007134 File Offset: 0x00005334
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000716C File Offset: 0x0000536C
		public unsafe string pressedTrigger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000071B0 File Offset: 0x000053B0
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000071E8 File Offset: 0x000053E8
		public unsafe string selectedTrigger
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000722C File Offset: 0x0000542C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00007264 File Offset: 0x00005464
		public unsafe string disabledTrigger
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000072A8 File Offset: 0x000054A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 515663, RefRangeEnd = 515667, XrefRangeStart = 515653, XrefRangeEnd = 515663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationTriggers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		public AnimationTriggers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000072E4 File Offset: 0x000054E4
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static string kDefaultNormalAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultNormalAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultNormalAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00007304 File Offset: 0x00005504
		// (set) Token: 0x06000011 RID: 17 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe static string kDefaultHighlightedAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultHighlightedAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultHighlightedAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00007324 File Offset: 0x00005524
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe static string kDefaultPressedAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultPressedAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultPressedAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00007344 File Offset: 0x00005544
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000208F File Offset: 0x0000028F
		public unsafe static string kDefaultSelectedAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultSelectedAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultSelectedAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00007364 File Offset: 0x00005564
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000020A1 File Offset: 0x000002A1
		public unsafe static string kDefaultDisabledAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultDisabledAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultDisabledAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00007384 File Offset: 0x00005584
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020B3 File Offset: 0x000002B3
		public unsafe string m_NormalTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000073AC File Offset: 0x000055AC
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020D2 File Offset: 0x000002D2
		public unsafe string m_HighlightedTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000073D4 File Offset: 0x000055D4
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020F1 File Offset: 0x000002F1
		public unsafe string m_PressedTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000073FC File Offset: 0x000055FC
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002110 File Offset: 0x00000310
		public unsafe string m_SelectedTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00007424 File Offset: 0x00005624
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000212F File Offset: 0x0000032F
		public unsafe string m_DisabledTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultNormalAnimName;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultHighlightedAnimName;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultPressedAnimName;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultSelectedAnimName;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultDisabledAnimName;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalTrigger;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightedTrigger;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_m_PressedTrigger;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedTrigger;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_m_DisabledTrigger;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
