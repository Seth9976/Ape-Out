using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Data
{
	// Token: 0x020000BE RID: 190
	[Serializable]
	public sealed class Player_Editor : Object
	{
		// Token: 0x060015BB RID: 5563 RVA: 0x0007E4A4 File Offset: 0x0007C6A4
		// Note: this type is marked as 'beforefieldinit'.
		static Player_Editor()
		{
			Il2CppClassPointerStore<Player_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "Player_Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr);
			Player_Editor.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_id");
			Player_Editor.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_name");
			Player_Editor.NativeFieldInfoPtr__descriptiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_descriptiveName");
			Player_Editor.NativeFieldInfoPtr__startPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_startPlaying");
			Player_Editor.NativeFieldInfoPtr__defaultJoystickMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_defaultJoystickMaps");
			Player_Editor.NativeFieldInfoPtr__defaultMouseMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_defaultMouseMaps");
			Player_Editor.NativeFieldInfoPtr__defaultKeyboardMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_defaultKeyboardMaps");
			Player_Editor.NativeFieldInfoPtr__defaultCustomControllerMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_defaultCustomControllerMaps");
			Player_Editor.NativeFieldInfoPtr__startingCustomControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_startingCustomControllers");
			Player_Editor.NativeFieldInfoPtr__assignMouseOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_assignMouseOnStart");
			Player_Editor.NativeFieldInfoPtr__assignKeyboardOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_assignKeyboardOnStart");
			Player_Editor.NativeFieldInfoPtr__excludeFromControllerAutoAssignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_excludeFromControllerAutoAssignment");
			Player_Editor.NativeFieldInfoPtr__controllerMapLayoutManagerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_controllerMapLayoutManagerSettings");
			Player_Editor.NativeFieldInfoPtr__controllerMapEnablerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "_controllerMapEnablerSettings");
			Player_Editor.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668404);
			Player_Editor.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668405);
			Player_Editor.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668406);
			Player_Editor.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668407);
			Player_Editor.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668408);
			Player_Editor.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668409);
			Player_Editor.NativeMethodInfoPtr_get_startPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668410);
			Player_Editor.NativeMethodInfoPtr_set_startPlaying_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668411);
			Player_Editor.NativeMethodInfoPtr_get_defaultJoystickMaps_Public_get_List_1_Mapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668412);
			Player_Editor.NativeMethodInfoPtr_set_defaultJoystickMaps_Internal_set_Void_List_1_Mapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668413);
			Player_Editor.NativeMethodInfoPtr_get_defaultMouseMaps_Public_get_List_1_Mapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668414);
			Player_Editor.NativeMethodInfoPtr_set_defaultMouseMaps_Internal_set_Void_List_1_Mapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668415);
			Player_Editor.NativeMethodInfoPtr_get_defaultKeyboardMaps_Public_get_List_1_Mapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668416);
			Player_Editor.NativeMethodInfoPtr_set_defaultKeyboardMaps_Internal_set_Void_List_1_Mapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668417);
			Player_Editor.NativeMethodInfoPtr_get_defaultCustomControllerMaps_Public_get_List_1_Mapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668418);
			Player_Editor.NativeMethodInfoPtr_set_defaultCustomControllerMaps_Internal_set_Void_List_1_Mapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668419);
			Player_Editor.NativeMethodInfoPtr_get_startingCustomControllers_Public_get_List_1_CreateControllerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668420);
			Player_Editor.NativeMethodInfoPtr_set_startingCustomControllers_Internal_set_Void_List_1_CreateControllerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668421);
			Player_Editor.NativeMethodInfoPtr_get_assignMouseOnStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668422);
			Player_Editor.NativeMethodInfoPtr_set_assignMouseOnStart_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668423);
			Player_Editor.NativeMethodInfoPtr_get_assignKeyboardOnStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668424);
			Player_Editor.NativeMethodInfoPtr_set_assignKeyboardOnStart_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668425);
			Player_Editor.NativeMethodInfoPtr_get_excludeFromControllerAutoAssignment_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668426);
			Player_Editor.NativeMethodInfoPtr_set_excludeFromControllerAutoAssignment_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668427);
			Player_Editor.NativeMethodInfoPtr_get_controllerMapLayoutManagerSettings_Public_get_ControllerMapLayoutManagerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668428);
			Player_Editor.NativeMethodInfoPtr_set_controllerMapLayoutManagerSettings_Public_set_Void_ControllerMapLayoutManagerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668429);
			Player_Editor.NativeMethodInfoPtr_get_controllerMapEnablerSettings_Public_get_ControllerMapEnablerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668430);
			Player_Editor.NativeMethodInfoPtr_set_controllerMapEnablerSettings_Public_set_Void_ControllerMapEnablerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668431);
			Player_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668432);
			Player_Editor.NativeMethodInfoPtr__ctor_Public_Void_Player_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668433);
			Player_Editor.NativeMethodInfoPtr_Clone_Public_Player_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668434);
			Player_Editor.NativeMethodInfoPtr_pmFApobNWGIAbXJfvLSNDQoVWNU_Internal_atbfHZhdkvsWMbmdayQwVztEARh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, 100668435);
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x0007E86C File Offset: 0x0007CA6C
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x0007E8A8 File Offset: 0x0007CAA8
		public unsafe int id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x0007E8E8 File Offset: 0x0007CAE8
		// (set) Token: 0x060015BF RID: 5567 RVA: 0x0007E920 File Offset: 0x0007CB20
		public unsafe string name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0007E964 File Offset: 0x0007CB64
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x0007E99C File Offset: 0x0007CB9C
		public unsafe string descriptiveName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x0007E9E0 File Offset: 0x0007CBE0
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x0007EA1C File Offset: 0x0007CC1C
		public unsafe bool startPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_startPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_startPlaying_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0007EA5C File Offset: 0x0007CC5C
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x0007EA9C File Offset: 0x0007CC9C
		public unsafe List<Player_Editor.Mapping> defaultJoystickMaps
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_defaultJoystickMaps_Public_get_List_1_Mapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.Mapping>>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 14017, RefRangeEnd = 14055, XrefRangeStart = 14017, XrefRangeEnd = 14055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_defaultJoystickMaps_Internal_set_Void_List_1_Mapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x0007EAE0 File Offset: 0x0007CCE0
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x0007EB20 File Offset: 0x0007CD20
		public unsafe List<Player_Editor.Mapping> defaultMouseMaps
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_defaultMouseMaps_Public_get_List_1_Mapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.Mapping>>(intPtr3) : null;
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_defaultMouseMaps_Internal_set_Void_List_1_Mapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x0007EB64 File Offset: 0x0007CD64
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x0007EBA4 File Offset: 0x0007CDA4
		public unsafe List<Player_Editor.Mapping> defaultKeyboardMaps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_defaultKeyboardMaps_Public_get_List_1_Mapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.Mapping>>(intPtr3) : null;
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_defaultKeyboardMaps_Internal_set_Void_List_1_Mapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x0007EBE8 File Offset: 0x0007CDE8
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x0007EC28 File Offset: 0x0007CE28
		public unsafe List<Player_Editor.Mapping> defaultCustomControllerMaps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_defaultCustomControllerMaps_Public_get_List_1_Mapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.Mapping>>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14763, XrefRangeStart = 14747, XrefRangeEnd = 14763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_defaultCustomControllerMaps_Internal_set_Void_List_1_Mapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x0007EC6C File Offset: 0x0007CE6C
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x0007ECAC File Offset: 0x0007CEAC
		public unsafe List<Player_Editor.CreateControllerInfo> startingCustomControllers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_startingCustomControllers_Public_get_List_1_CreateControllerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.CreateControllerInfo>>(intPtr3) : null;
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 13543, RefRangeEnd = 13569, XrefRangeStart = 13543, XrefRangeEnd = 13569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_startingCustomControllers_Internal_set_Void_List_1_CreateControllerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x0007ECF0 File Offset: 0x0007CEF0
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x0007ED2C File Offset: 0x0007CF2C
		public unsafe bool assignMouseOnStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_assignMouseOnStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_assignMouseOnStart_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x0007ED6C File Offset: 0x0007CF6C
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x0007EDA8 File Offset: 0x0007CFA8
		public unsafe bool assignKeyboardOnStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_assignKeyboardOnStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_assignKeyboardOnStart_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x0007EDE8 File Offset: 0x0007CFE8
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x0007EE24 File Offset: 0x0007D024
		public unsafe bool excludeFromControllerAutoAssignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_excludeFromControllerAutoAssignment_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_excludeFromControllerAutoAssignment_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x0007EE64 File Offset: 0x0007D064
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x0007EEA4 File Offset: 0x0007D0A4
		public unsafe Player_Editor.ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_controllerMapLayoutManagerSettings_Public_get_ControllerMapLayoutManagerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player_Editor.ControllerMapLayoutManagerSettings>(intPtr3) : null;
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 214194, RefRangeEnd = 214233, XrefRangeStart = 214194, XrefRangeEnd = 214233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_controllerMapLayoutManagerSettings_Public_set_Void_ControllerMapLayoutManagerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x0007EEE8 File Offset: 0x0007D0E8
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0007EF28 File Offset: 0x0007D128
		public unsafe Player_Editor.ControllerMapEnablerSettings controllerMapEnablerSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_get_controllerMapEnablerSettings_Public_get_ControllerMapEnablerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player_Editor.ControllerMapEnablerSettings>(intPtr3) : null;
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14893, RefRangeEnd = 14909, XrefRangeStart = 14893, XrefRangeEnd = 14909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_set_controllerMapEnablerSettings_Public_set_Void_ControllerMapEnablerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x0007EF6C File Offset: 0x0007D16C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271684, RefRangeEnd = 271685, XrefRangeStart = 271652, XrefRangeEnd = 271684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player_Editor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x0007EFA8 File Offset: 0x0007D1A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271764, RefRangeEnd = 271766, XrefRangeStart = 271685, XrefRangeEnd = 271764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player_Editor(Player_Editor source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr__ctor_Public_Void_Player_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x0007EFF4 File Offset: 0x0007D1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271766, XrefRangeEnd = 271770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player_Editor Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_Clone_Public_Player_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player_Editor>(intPtr3) : null;
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0007F034 File Offset: 0x0007D234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271816, RefRangeEnd = 271817, XrefRangeStart = 271770, XrefRangeEnd = 271816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe atbfHZhdkvsWMbmdayQwVztEARh pmFApobNWGIAbXJfvLSNDQoVWNU()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.NativeMethodInfoPtr_pmFApobNWGIAbXJfvLSNDQoVWNU_Internal_atbfHZhdkvsWMbmdayQwVztEARh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<atbfHZhdkvsWMbmdayQwVztEARh>(intPtr3) : null;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0000988E File Offset: 0x00007A8E
		public Player_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x0007F074 File Offset: 0x0007D274
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x00009897 File Offset: 0x00007A97
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x0007F09C File Offset: 0x0007D29C
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x000098B2 File Offset: 0x00007AB2
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0007F0C4 File Offset: 0x0007D2C4
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x000098D1 File Offset: 0x00007AD1
		public unsafe string _descriptiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__descriptiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__descriptiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0007F0EC File Offset: 0x0007D2EC
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x000098F0 File Offset: 0x00007AF0
		public unsafe bool _startPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__startPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__startPlaying)) = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0007F114 File Offset: 0x0007D314
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0000990B File Offset: 0x00007B0B
		public unsafe List<Player_Editor.Mapping> _defaultJoystickMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__defaultJoystickMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.Mapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__defaultJoystickMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x0007F144 File Offset: 0x0007D344
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0000992A File Offset: 0x00007B2A
		public unsafe List<Player_Editor.Mapping> _defaultMouseMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__defaultMouseMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.Mapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__defaultMouseMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x0007F174 File Offset: 0x0007D374
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x00009949 File Offset: 0x00007B49
		public unsafe List<Player_Editor.Mapping> _defaultKeyboardMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__defaultKeyboardMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.Mapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__defaultKeyboardMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x0007F1A4 File Offset: 0x0007D3A4
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00009968 File Offset: 0x00007B68
		public unsafe List<Player_Editor.Mapping> _defaultCustomControllerMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__defaultCustomControllerMaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.Mapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__defaultCustomControllerMaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x0007F1D4 File Offset: 0x0007D3D4
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x00009987 File Offset: 0x00007B87
		public unsafe List<Player_Editor.CreateControllerInfo> _startingCustomControllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__startingCustomControllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.CreateControllerInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__startingCustomControllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x0007F204 File Offset: 0x0007D404
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x000099A6 File Offset: 0x00007BA6
		public unsafe bool _assignMouseOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__assignMouseOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__assignMouseOnStart)) = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0007F22C File Offset: 0x0007D42C
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x000099C1 File Offset: 0x00007BC1
		public unsafe bool _assignKeyboardOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__assignKeyboardOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__assignKeyboardOnStart)) = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0007F254 File Offset: 0x0007D454
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x000099DC File Offset: 0x00007BDC
		public unsafe bool _excludeFromControllerAutoAssignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__excludeFromControllerAutoAssignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__excludeFromControllerAutoAssignment)) = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x0007F27C File Offset: 0x0007D47C
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x000099F7 File Offset: 0x00007BF7
		public unsafe Player_Editor.ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__controllerMapLayoutManagerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player_Editor.ControllerMapLayoutManagerSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__controllerMapLayoutManagerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x0007F2AC File Offset: 0x0007D4AC
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x00009A16 File Offset: 0x00007C16
		public unsafe Player_Editor.ControllerMapEnablerSettings _controllerMapEnablerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__controllerMapEnablerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player_Editor.ControllerMapEnablerSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.NativeFieldInfoPtr__controllerMapEnablerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr__descriptiveName;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr__startPlaying;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr__defaultJoystickMaps;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeFieldInfoPtr__defaultMouseMaps;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeFieldInfoPtr__defaultKeyboardMaps;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeFieldInfoPtr__defaultCustomControllerMaps;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeFieldInfoPtr__startingCustomControllers;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr__assignMouseOnStart;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeFieldInfoPtr__assignKeyboardOnStart;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeFieldInfoPtr__excludeFromControllerAutoAssignment;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeFieldInfoPtr__controllerMapLayoutManagerSettings;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeFieldInfoPtr__controllerMapEnablerSettings;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_get_descriptiveName_Public_get_String_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_set_descriptiveName_Internal_set_Void_String_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_get_startPlaying_Public_get_Boolean_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_set_startPlaying_Internal_set_Void_Boolean_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultJoystickMaps_Public_get_List_1_Mapping_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultJoystickMaps_Internal_set_Void_List_1_Mapping_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMouseMaps_Public_get_List_1_Mapping_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultMouseMaps_Internal_set_Void_List_1_Mapping_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultKeyboardMaps_Public_get_List_1_Mapping_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultKeyboardMaps_Internal_set_Void_List_1_Mapping_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultCustomControllerMaps_Public_get_List_1_Mapping_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultCustomControllerMaps_Internal_set_Void_List_1_Mapping_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_get_startingCustomControllers_Public_get_List_1_CreateControllerInfo_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_set_startingCustomControllers_Internal_set_Void_List_1_CreateControllerInfo_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_get_assignMouseOnStart_Public_get_Boolean_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_set_assignMouseOnStart_Internal_set_Void_Boolean_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_get_assignKeyboardOnStart_Public_get_Boolean_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_set_assignKeyboardOnStart_Internal_set_Void_Boolean_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_get_excludeFromControllerAutoAssignment_Public_get_Boolean_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_set_excludeFromControllerAutoAssignment_Internal_set_Void_Boolean_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerMapLayoutManagerSettings_Public_get_ControllerMapLayoutManagerSettings_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerMapLayoutManagerSettings_Public_set_Void_ControllerMapLayoutManagerSettings_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerMapEnablerSettings_Public_get_ControllerMapEnablerSettings_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerMapEnablerSettings_Public_set_Void_ControllerMapEnablerSettings_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Player_Editor_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Player_Editor_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_pmFApobNWGIAbXJfvLSNDQoVWNU_Internal_atbfHZhdkvsWMbmdayQwVztEARh_0;

		// Token: 0x0200030E RID: 782
		[Serializable]
		public sealed class Mapping : Object
		{
			// Token: 0x06004287 RID: 17031 RVA: 0x0013B064 File Offset: 0x00139264
			// Note: this type is marked as 'beforefieldinit'.
			static Mapping()
			{
				Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "Mapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr);
				Player_Editor.Mapping.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, "_enabled");
				Player_Editor.Mapping.NativeFieldInfoPtr__categoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, "_categoryId");
				Player_Editor.Mapping.NativeFieldInfoPtr__layoutId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, "_layoutId");
				Player_Editor.Mapping.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668436);
				Player_Editor.Mapping.NativeMethodInfoPtr_set_categoryId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668437);
				Player_Editor.Mapping.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668438);
				Player_Editor.Mapping.NativeMethodInfoPtr_set_layoutId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668439);
				Player_Editor.Mapping.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668440);
				Player_Editor.Mapping.NativeMethodInfoPtr_set_enabled_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668441);
				Player_Editor.Mapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668442);
				Player_Editor.Mapping.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668443);
				Player_Editor.Mapping.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668444);
				Player_Editor.Mapping.NativeMethodInfoPtr_Clone_Public_Mapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668445);
				Player_Editor.Mapping.NativeMethodInfoPtr_nFTEHKoOWJQdqRQCojvjIYWXkdX_Internal_uLBffQmjZVJkNwKRVfvGHggdqhKj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr, 100668446);
			}

			// Token: 0x170014AA RID: 5290
			// (get) Token: 0x06004288 RID: 17032 RVA: 0x0013B1A8 File Offset: 0x001393A8
			// (set) Token: 0x06004289 RID: 17033 RVA: 0x0013B1E4 File Offset: 0x001393E4
			public unsafe int categoryId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr_set_categoryId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170014AB RID: 5291
			// (get) Token: 0x0600428A RID: 17034 RVA: 0x0013B224 File Offset: 0x00139424
			// (set) Token: 0x0600428B RID: 17035 RVA: 0x0013B260 File Offset: 0x00139460
			public unsafe int layoutId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr_set_layoutId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170014AC RID: 5292
			// (get) Token: 0x0600428C RID: 17036 RVA: 0x0013B2A0 File Offset: 0x001394A0
			// (set) Token: 0x0600428D RID: 17037 RVA: 0x0013B2DC File Offset: 0x001394DC
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr_set_enabled_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600428E RID: 17038 RVA: 0x0013B31C File Offset: 0x0013951C
			[CallerCount(0)]
			public unsafe Mapping()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600428F RID: 17039 RVA: 0x0013B358 File Offset: 0x00139558
			[CallerCount(0)]
			public unsafe Mapping(bool enabled, int categoryId, int layoutId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.Mapping>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref enabled;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004290 RID: 17040 RVA: 0x0013B3BC File Offset: 0x001395BC
			[CallerCount(0)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004291 RID: 17041 RVA: 0x0013B3F0 File Offset: 0x001395F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271503, XrefRangeEnd = 271506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Player_Editor.Mapping Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr_Clone_Public_Mapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player_Editor.Mapping>(intPtr3) : null;
			}

			// Token: 0x06004292 RID: 17042 RVA: 0x0013B430 File Offset: 0x00139630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271506, XrefRangeEnd = 271509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uLBffQmjZVJkNwKRVfvGHggdqhKj nFTEHKoOWJQdqRQCojvjIYWXkdX()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.Mapping.NativeMethodInfoPtr_nFTEHKoOWJQdqRQCojvjIYWXkdX_Internal_uLBffQmjZVJkNwKRVfvGHggdqhKj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<uLBffQmjZVJkNwKRVfvGHggdqhKj>(intPtr3) : null;
			}

			// Token: 0x06004293 RID: 17043 RVA: 0x0001780E File Offset: 0x00015A0E
			public Mapping(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014A7 RID: 5287
			// (get) Token: 0x06004294 RID: 17044 RVA: 0x0013B470 File Offset: 0x00139670
			// (set) Token: 0x06004295 RID: 17045 RVA: 0x00017817 File Offset: 0x00015A17
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.Mapping.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.Mapping.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x170014A8 RID: 5288
			// (get) Token: 0x06004296 RID: 17046 RVA: 0x0013B498 File Offset: 0x00139698
			// (set) Token: 0x06004297 RID: 17047 RVA: 0x00017832 File Offset: 0x00015A32
			public unsafe int _categoryId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.Mapping.NativeFieldInfoPtr__categoryId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.Mapping.NativeFieldInfoPtr__categoryId)) = value;
				}
			}

			// Token: 0x170014A9 RID: 5289
			// (get) Token: 0x06004298 RID: 17048 RVA: 0x0013B4C0 File Offset: 0x001396C0
			// (set) Token: 0x06004299 RID: 17049 RVA: 0x0001784D File Offset: 0x00015A4D
			public unsafe int _layoutId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.Mapping.NativeFieldInfoPtr__layoutId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.Mapping.NativeFieldInfoPtr__layoutId)) = value;
				}
			}

			// Token: 0x040036DC RID: 14044
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x040036DD RID: 14045
			private static readonly IntPtr NativeFieldInfoPtr__categoryId;

			// Token: 0x040036DE RID: 14046
			private static readonly IntPtr NativeFieldInfoPtr__layoutId;

			// Token: 0x040036DF RID: 14047
			private static readonly IntPtr NativeMethodInfoPtr_get_categoryId_Public_get_Int32_0;

			// Token: 0x040036E0 RID: 14048
			private static readonly IntPtr NativeMethodInfoPtr_set_categoryId_Internal_set_Void_Int32_0;

			// Token: 0x040036E1 RID: 14049
			private static readonly IntPtr NativeMethodInfoPtr_get_layoutId_Public_get_Int32_0;

			// Token: 0x040036E2 RID: 14050
			private static readonly IntPtr NativeMethodInfoPtr_set_layoutId_Internal_set_Void_Int32_0;

			// Token: 0x040036E3 RID: 14051
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x040036E4 RID: 14052
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Internal_set_Void_Boolean_0;

			// Token: 0x040036E5 RID: 14053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036E6 RID: 14054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_0;

			// Token: 0x040036E7 RID: 14055
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x040036E8 RID: 14056
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Mapping_0;

			// Token: 0x040036E9 RID: 14057
			private static readonly IntPtr NativeMethodInfoPtr_nFTEHKoOWJQdqRQCojvjIYWXkdX_Internal_uLBffQmjZVJkNwKRVfvGHggdqhKj_0;
		}

		// Token: 0x0200030F RID: 783
		[Serializable]
		public sealed class ControllerMapLayoutManagerSettings : Object
		{
			// Token: 0x0600429A RID: 17050 RVA: 0x0013B4E8 File Offset: 0x001396E8
			// Note: this type is marked as 'beforefieldinit'.
			static ControllerMapLayoutManagerSettings()
			{
				Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "ControllerMapLayoutManagerSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, "_enabled");
				Player_Editor.ControllerMapLayoutManagerSettings.NativeFieldInfoPtr__loadFromUserDataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, "_loadFromUserDataStore");
				Player_Editor.ControllerMapLayoutManagerSettings.NativeFieldInfoPtr__ruleSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, "_ruleSets");
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668447);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668448);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_get_loadFromUserDataStore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668449);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_set_loadFromUserDataStore_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668450);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668451);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668452);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668453);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapLayoutManagerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668454);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_opVjtajFAeEujhjoiIDCbuMBUwXD_Internal_sxAMvsNcBoaqKdJiNlPgecwsqKZd_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668455);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_bdCiCttADJbNKBPSbVGNcwUIdyrz_Private_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668456);
				Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr, 100668457);
			}

			// Token: 0x170014B0 RID: 5296
			// (get) Token: 0x0600429B RID: 17051 RVA: 0x0013B62C File Offset: 0x0013982C
			// (set) Token: 0x0600429C RID: 17052 RVA: 0x0013B668 File Offset: 0x00139868
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170014B1 RID: 5297
			// (get) Token: 0x0600429D RID: 17053 RVA: 0x0013B6A8 File Offset: 0x001398A8
			// (set) Token: 0x0600429E RID: 17054 RVA: 0x0013B6E4 File Offset: 0x001398E4
			public unsafe bool loadFromUserDataStore
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_get_loadFromUserDataStore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_set_loadFromUserDataStore_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170014B2 RID: 5298
			// (get) Token: 0x0600429F RID: 17055 RVA: 0x0013B724 File Offset: 0x00139924
			// (set) Token: 0x060042A0 RID: 17056 RVA: 0x0013B764 File Offset: 0x00139964
			public unsafe List<Player_Editor.RuleSetMapping> ruleSets
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.RuleSetMapping>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271509, XrefRangeEnd = 271515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060042A1 RID: 17057 RVA: 0x0013B7A8 File Offset: 0x001399A8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 271521, RefRangeEnd = 271524, XrefRangeStart = 271515, XrefRangeEnd = 271521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapLayoutManagerSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042A2 RID: 17058 RVA: 0x0013B7E4 File Offset: 0x001399E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271524, XrefRangeEnd = 271536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapLayoutManagerSettings(Player_Editor.ControllerMapLayoutManagerSettings source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.ControllerMapLayoutManagerSettings>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapLayoutManagerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060042A3 RID: 17059 RVA: 0x0013B830 File Offset: 0x00139A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271536, XrefRangeEnd = 271540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd opVjtajFAeEujhjoiIDCbuMBUwXD()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_opVjtajFAeEujhjoiIDCbuMBUwXD_Internal_sxAMvsNcBoaqKdJiNlPgecwsqKZd_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapLayoutManager.sxAMvsNcBoaqKdJiNlPgecwsqKZd>(intPtr3) : null;
			}

			// Token: 0x060042A4 RID: 17060 RVA: 0x0013B870 File Offset: 0x00139A70
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 271557, RefRangeEnd = 271559, XrefRangeStart = 271540, XrefRangeEnd = 271557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG> bdCiCttADJbNKBPSbVGNcwUIdyrz()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_bdCiCttADJbNKBPSbVGNcwUIdyrz_Private_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG>>(intPtr3) : null;
			}

			// Token: 0x060042A5 RID: 17061 RVA: 0x0013B8B0 File Offset: 0x00139AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271559, XrefRangeEnd = 271574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ArcItWcEwGFnEyxJxvmxUBgQabYI()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapLayoutManagerSettings.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060042A6 RID: 17062 RVA: 0x00017868 File Offset: 0x00015A68
			public ControllerMapLayoutManagerSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014AD RID: 5293
			// (get) Token: 0x060042A7 RID: 17063 RVA: 0x0013B8F0 File Offset: 0x00139AF0
			// (set) Token: 0x060042A8 RID: 17064 RVA: 0x00017871 File Offset: 0x00015A71
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapLayoutManagerSettings.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapLayoutManagerSettings.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x170014AE RID: 5294
			// (get) Token: 0x060042A9 RID: 17065 RVA: 0x0013B918 File Offset: 0x00139B18
			// (set) Token: 0x060042AA RID: 17066 RVA: 0x0001788C File Offset: 0x00015A8C
			public unsafe bool _loadFromUserDataStore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapLayoutManagerSettings.NativeFieldInfoPtr__loadFromUserDataStore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapLayoutManagerSettings.NativeFieldInfoPtr__loadFromUserDataStore)) = value;
				}
			}

			// Token: 0x170014AF RID: 5295
			// (get) Token: 0x060042AB RID: 17067 RVA: 0x0013B940 File Offset: 0x00139B40
			// (set) Token: 0x060042AC RID: 17068 RVA: 0x000178A7 File Offset: 0x00015AA7
			public unsafe List<Player_Editor.RuleSetMapping> _ruleSets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapLayoutManagerSettings.NativeFieldInfoPtr__ruleSets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.RuleSetMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapLayoutManagerSettings.NativeFieldInfoPtr__ruleSets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036EA RID: 14058
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x040036EB RID: 14059
			private static readonly IntPtr NativeFieldInfoPtr__loadFromUserDataStore;

			// Token: 0x040036EC RID: 14060
			private static readonly IntPtr NativeFieldInfoPtr__ruleSets;

			// Token: 0x040036ED RID: 14061
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x040036EE RID: 14062
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x040036EF RID: 14063
			private static readonly IntPtr NativeMethodInfoPtr_get_loadFromUserDataStore_Public_get_Boolean_0;

			// Token: 0x040036F0 RID: 14064
			private static readonly IntPtr NativeMethodInfoPtr_set_loadFromUserDataStore_Public_set_Void_Boolean_0;

			// Token: 0x040036F1 RID: 14065
			private static readonly IntPtr NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSetMapping_0;

			// Token: 0x040036F2 RID: 14066
			private static readonly IntPtr NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSetMapping_0;

			// Token: 0x040036F3 RID: 14067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036F4 RID: 14068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerMapLayoutManagerSettings_0;

			// Token: 0x040036F5 RID: 14069
			private static readonly IntPtr NativeMethodInfoPtr_opVjtajFAeEujhjoiIDCbuMBUwXD_Internal_sxAMvsNcBoaqKdJiNlPgecwsqKZd_0;

			// Token: 0x040036F6 RID: 14070
			private static readonly IntPtr NativeMethodInfoPtr_bdCiCttADJbNKBPSbVGNcwUIdyrz_Private_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0;

			// Token: 0x040036F7 RID: 14071
			private static readonly IntPtr NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0;
		}

		// Token: 0x02000310 RID: 784
		[Serializable]
		public sealed class ControllerMapEnablerSettings : Object
		{
			// Token: 0x060042AD RID: 17069 RVA: 0x0013B970 File Offset: 0x00139B70
			// Note: this type is marked as 'beforefieldinit'.
			static ControllerMapEnablerSettings()
			{
				Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "ControllerMapEnablerSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr);
				Player_Editor.ControllerMapEnablerSettings.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, "_enabled");
				Player_Editor.ControllerMapEnablerSettings.NativeFieldInfoPtr__ruleSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, "_ruleSets");
				Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, 100668458);
				Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, 100668459);
				Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, 100668460);
				Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, 100668461);
				Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, 100668462);
				Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapEnablerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, 100668463);
				Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_opVjtajFAeEujhjoiIDCbuMBUwXD_Internal_aFwGZiuGrUEoBNtlswFPEqaRBwB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, 100668464);
				Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_bdCiCttADJbNKBPSbVGNcwUIdyrz_Private_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, 100668465);
				Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr, 100668466);
			}

			// Token: 0x170014B5 RID: 5301
			// (get) Token: 0x060042AE RID: 17070 RVA: 0x0013BA78 File Offset: 0x00139C78
			// (set) Token: 0x060042AF RID: 17071 RVA: 0x0013BAB4 File Offset: 0x00139CB4
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170014B6 RID: 5302
			// (get) Token: 0x060042B0 RID: 17072 RVA: 0x0013BAF4 File Offset: 0x00139CF4
			// (set) Token: 0x060042B1 RID: 17073 RVA: 0x0013BB34 File Offset: 0x00139D34
			public unsafe List<Player_Editor.RuleSetMapping> ruleSets
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.RuleSetMapping>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271574, XrefRangeEnd = 271580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060042B2 RID: 17074 RVA: 0x0013BB78 File Offset: 0x00139D78
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 271586, RefRangeEnd = 271589, XrefRangeStart = 271580, XrefRangeEnd = 271586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapEnablerSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042B3 RID: 17075 RVA: 0x0013BBB4 File Offset: 0x00139DB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271589, XrefRangeEnd = 271601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapEnablerSettings(Player_Editor.ControllerMapEnablerSettings source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.ControllerMapEnablerSettings>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapEnablerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060042B4 RID: 17076 RVA: 0x0013BC00 File Offset: 0x00139E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271601, XrefRangeEnd = 271605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB opVjtajFAeEujhjoiIDCbuMBUwXD()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_opVjtajFAeEujhjoiIDCbuMBUwXD_Internal_aFwGZiuGrUEoBNtlswFPEqaRBwB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapEnabler.aFwGZiuGrUEoBNtlswFPEqaRBwB>(intPtr3) : null;
			}

			// Token: 0x060042B5 RID: 17077 RVA: 0x0013BC40 File Offset: 0x00139E40
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 271622, RefRangeEnd = 271624, XrefRangeStart = 271605, XrefRangeEnd = 271622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG> bdCiCttADJbNKBPSbVGNcwUIdyrz()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_bdCiCttADJbNKBPSbVGNcwUIdyrz_Private_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<lquWCEEbyIEgNbyPvPhzZBmqVqG>>(intPtr3) : null;
			}

			// Token: 0x060042B6 RID: 17078 RVA: 0x0013BC80 File Offset: 0x00139E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271624, XrefRangeEnd = 271639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ArcItWcEwGFnEyxJxvmxUBgQabYI()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.ControllerMapEnablerSettings.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060042B7 RID: 17079 RVA: 0x000178C6 File Offset: 0x00015AC6
			public ControllerMapEnablerSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014B3 RID: 5299
			// (get) Token: 0x060042B8 RID: 17080 RVA: 0x0013BCC0 File Offset: 0x00139EC0
			// (set) Token: 0x060042B9 RID: 17081 RVA: 0x000178CF File Offset: 0x00015ACF
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapEnablerSettings.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapEnablerSettings.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x170014B4 RID: 5300
			// (get) Token: 0x060042BA RID: 17082 RVA: 0x0013BCE8 File Offset: 0x00139EE8
			// (set) Token: 0x060042BB RID: 17083 RVA: 0x000178EA File Offset: 0x00015AEA
			public unsafe List<Player_Editor.RuleSetMapping> _ruleSets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapEnablerSettings.NativeFieldInfoPtr__ruleSets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player_Editor.RuleSetMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.ControllerMapEnablerSettings.NativeFieldInfoPtr__ruleSets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040036F8 RID: 14072
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x040036F9 RID: 14073
			private static readonly IntPtr NativeFieldInfoPtr__ruleSets;

			// Token: 0x040036FA RID: 14074
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x040036FB RID: 14075
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x040036FC RID: 14076
			private static readonly IntPtr NativeMethodInfoPtr_get_ruleSets_Public_get_List_1_RuleSetMapping_0;

			// Token: 0x040036FD RID: 14077
			private static readonly IntPtr NativeMethodInfoPtr_set_ruleSets_Public_set_Void_List_1_RuleSetMapping_0;

			// Token: 0x040036FE RID: 14078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040036FF RID: 14079
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerMapEnablerSettings_0;

			// Token: 0x04003700 RID: 14080
			private static readonly IntPtr NativeMethodInfoPtr_opVjtajFAeEujhjoiIDCbuMBUwXD_Internal_aFwGZiuGrUEoBNtlswFPEqaRBwB_0;

			// Token: 0x04003701 RID: 14081
			private static readonly IntPtr NativeMethodInfoPtr_bdCiCttADJbNKBPSbVGNcwUIdyrz_Private_Il2CppReferenceArray_1_lquWCEEbyIEgNbyPvPhzZBmqVqG_0;

			// Token: 0x04003702 RID: 14082
			private static readonly IntPtr NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0;
		}

		// Token: 0x02000311 RID: 785
		[Serializable]
		public sealed class RuleSetMapping : Object
		{
			// Token: 0x060042BC RID: 17084 RVA: 0x0013BD18 File Offset: 0x00139F18
			// Note: this type is marked as 'beforefieldinit'.
			static RuleSetMapping()
			{
				Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "RuleSetMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr);
				Player_Editor.RuleSetMapping.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, "_enabled");
				Player_Editor.RuleSetMapping.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, "_id");
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668467);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668468);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668469);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr_set_enabled_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668470);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668471);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr__ctor_Public_Void_RuleSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668472);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668473);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668474);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr_Clone_Public_RuleSetMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668475);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr_WNrHYPWSZjnvoSQFEbkibLWuqmP_Internal_lquWCEEbyIEgNbyPvPhzZBmqVqG_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668476);
				Player_Editor.RuleSetMapping.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr, 100668477);
			}

			// Token: 0x170014B9 RID: 5305
			// (get) Token: 0x060042BD RID: 17085 RVA: 0x0013BE48 File Offset: 0x0013A048
			// (set) Token: 0x060042BE RID: 17086 RVA: 0x0013BE84 File Offset: 0x0013A084
			public unsafe int id
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170014BA RID: 5306
			// (get) Token: 0x060042BF RID: 17087 RVA: 0x0013BEC4 File Offset: 0x0013A0C4
			// (set) Token: 0x060042C0 RID: 17088 RVA: 0x0013BF00 File Offset: 0x0013A100
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr_set_enabled_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060042C1 RID: 17089 RVA: 0x0013BF40 File Offset: 0x0013A140
			[CallerCount(0)]
			public unsafe RuleSetMapping()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042C2 RID: 17090 RVA: 0x0013BF7C File Offset: 0x0013A17C
			[CallerCount(0)]
			public unsafe RuleSetMapping(Player_Editor.RuleSetMapping source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr__ctor_Public_Void_RuleSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060042C3 RID: 17091 RVA: 0x0013BFC8 File Offset: 0x0013A1C8
			[CallerCount(0)]
			public unsafe RuleSetMapping(bool enabled, int id)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.RuleSetMapping>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref enabled;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042C4 RID: 17092 RVA: 0x0013C020 File Offset: 0x0013A220
			[CallerCount(0)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042C5 RID: 17093 RVA: 0x0013C054 File Offset: 0x0013A254
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 271642, RefRangeEnd = 271644, XrefRangeStart = 271639, XrefRangeEnd = 271642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Player_Editor.RuleSetMapping Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr_Clone_Public_RuleSetMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player_Editor.RuleSetMapping>(intPtr3) : null;
			}

			// Token: 0x060042C6 RID: 17094 RVA: 0x0013C094 File Offset: 0x0013A294
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 271647, RefRangeEnd = 271649, XrefRangeStart = 271644, XrefRangeEnd = 271647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe lquWCEEbyIEgNbyPvPhzZBmqVqG WNrHYPWSZjnvoSQFEbkibLWuqmP()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr_WNrHYPWSZjnvoSQFEbkibLWuqmP_Internal_lquWCEEbyIEgNbyPvPhzZBmqVqG_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<lquWCEEbyIEgNbyPvPhzZBmqVqG>(intPtr3) : null;
			}

			// Token: 0x060042C7 RID: 17095 RVA: 0x0013C0D4 File Offset: 0x0013A2D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271649, XrefRangeEnd = 271652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ArcItWcEwGFnEyxJxvmxUBgQabYI()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.RuleSetMapping.NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060042C8 RID: 17096 RVA: 0x00017909 File Offset: 0x00015B09
			public RuleSetMapping(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014B7 RID: 5303
			// (get) Token: 0x060042C9 RID: 17097 RVA: 0x0013C114 File Offset: 0x0013A314
			// (set) Token: 0x060042CA RID: 17098 RVA: 0x00017912 File Offset: 0x00015B12
			public unsafe bool _enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.RuleSetMapping.NativeFieldInfoPtr__enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.RuleSetMapping.NativeFieldInfoPtr__enabled)) = value;
				}
			}

			// Token: 0x170014B8 RID: 5304
			// (get) Token: 0x060042CB RID: 17099 RVA: 0x0013C13C File Offset: 0x0013A33C
			// (set) Token: 0x060042CC RID: 17100 RVA: 0x0001792D File Offset: 0x00015B2D
			public unsafe int _id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.RuleSetMapping.NativeFieldInfoPtr__id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.RuleSetMapping.NativeFieldInfoPtr__id)) = value;
				}
			}

			// Token: 0x04003703 RID: 14083
			private static readonly IntPtr NativeFieldInfoPtr__enabled;

			// Token: 0x04003704 RID: 14084
			private static readonly IntPtr NativeFieldInfoPtr__id;

			// Token: 0x04003705 RID: 14085
			private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

			// Token: 0x04003706 RID: 14086
			private static readonly IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;

			// Token: 0x04003707 RID: 14087
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x04003708 RID: 14088
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Internal_set_Void_Boolean_0;

			// Token: 0x04003709 RID: 14089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400370A RID: 14090
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuleSetMapping_0;

			// Token: 0x0400370B RID: 14091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0;

			// Token: 0x0400370C RID: 14092
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x0400370D RID: 14093
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_RuleSetMapping_0;

			// Token: 0x0400370E RID: 14094
			private static readonly IntPtr NativeMethodInfoPtr_WNrHYPWSZjnvoSQFEbkibLWuqmP_Internal_lquWCEEbyIEgNbyPvPhzZBmqVqG_0;

			// Token: 0x0400370F RID: 14095
			private static readonly IntPtr NativeMethodInfoPtr_ArcItWcEwGFnEyxJxvmxUBgQabYI_Private_Virtual_Final_New_Object_0;
		}

		// Token: 0x02000312 RID: 786
		[Serializable]
		public sealed class CreateControllerInfo : Object
		{
			// Token: 0x060042CD RID: 17101 RVA: 0x0013C164 File Offset: 0x0013A364
			// Note: this type is marked as 'beforefieldinit'.
			static CreateControllerInfo()
			{
				Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player_Editor>.NativeClassPtr, "CreateControllerInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr);
				Player_Editor.CreateControllerInfo.NativeFieldInfoPtr__sourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr, "_sourceId");
				Player_Editor.CreateControllerInfo.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr, "_tag");
				Player_Editor.CreateControllerInfo.NativeMethodInfoPtr_get_sourceId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr, 100668478);
				Player_Editor.CreateControllerInfo.NativeMethodInfoPtr_set_sourceId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr, 100668479);
				Player_Editor.CreateControllerInfo.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr, 100668480);
				Player_Editor.CreateControllerInfo.NativeMethodInfoPtr_set_tag_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr, 100668481);
				Player_Editor.CreateControllerInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr, 100668482);
				Player_Editor.CreateControllerInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr, 100668483);
				Player_Editor.CreateControllerInfo.NativeMethodInfoPtr__ctor_Public_Void_CreateControllerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr, 100668484);
			}

			// Token: 0x170014BD RID: 5309
			// (get) Token: 0x060042CE RID: 17102 RVA: 0x0013C244 File Offset: 0x0013A444
			// (set) Token: 0x060042CF RID: 17103 RVA: 0x0013C280 File Offset: 0x0013A480
			public unsafe int sourceId
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.CreateControllerInfo.NativeMethodInfoPtr_get_sourceId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.CreateControllerInfo.NativeMethodInfoPtr_set_sourceId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170014BE RID: 5310
			// (get) Token: 0x060042D0 RID: 17104 RVA: 0x0013C2C0 File Offset: 0x0013A4C0
			// (set) Token: 0x060042D1 RID: 17105 RVA: 0x0013C2F8 File Offset: 0x0013A4F8
			public unsafe string tag
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.CreateControllerInfo.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.CreateControllerInfo.NativeMethodInfoPtr_set_tag_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060042D2 RID: 17106 RVA: 0x0013C33C File Offset: 0x0013A53C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateControllerInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.CreateControllerInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042D3 RID: 17107 RVA: 0x0013C378 File Offset: 0x0013A578
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 106068, RefRangeEnd = 106070, XrefRangeStart = 106068, XrefRangeEnd = 106070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateControllerInfo(int sourceId, string tag)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sourceId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.CreateControllerInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060042D4 RID: 17108 RVA: 0x0013C3D4 File Offset: 0x0013A5D4
			[CallerCount(0)]
			public unsafe CreateControllerInfo(Player_Editor.CreateControllerInfo source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player_Editor.CreateControllerInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player_Editor.CreateControllerInfo.NativeMethodInfoPtr__ctor_Public_Void_CreateControllerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060042D5 RID: 17109 RVA: 0x00017948 File Offset: 0x00015B48
			public CreateControllerInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014BB RID: 5307
			// (get) Token: 0x060042D6 RID: 17110 RVA: 0x0013C420 File Offset: 0x0013A620
			// (set) Token: 0x060042D7 RID: 17111 RVA: 0x00017951 File Offset: 0x00015B51
			public unsafe int _sourceId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.CreateControllerInfo.NativeFieldInfoPtr__sourceId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.CreateControllerInfo.NativeFieldInfoPtr__sourceId)) = value;
				}
			}

			// Token: 0x170014BC RID: 5308
			// (get) Token: 0x060042D8 RID: 17112 RVA: 0x0013C448 File Offset: 0x0013A648
			// (set) Token: 0x060042D9 RID: 17113 RVA: 0x0001796C File Offset: 0x00015B6C
			public unsafe string _tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.CreateControllerInfo.NativeFieldInfoPtr__tag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player_Editor.CreateControllerInfo.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003710 RID: 14096
			private static readonly IntPtr NativeFieldInfoPtr__sourceId;

			// Token: 0x04003711 RID: 14097
			private static readonly IntPtr NativeFieldInfoPtr__tag;

			// Token: 0x04003712 RID: 14098
			private static readonly IntPtr NativeMethodInfoPtr_get_sourceId_Public_get_Int32_0;

			// Token: 0x04003713 RID: 14099
			private static readonly IntPtr NativeMethodInfoPtr_set_sourceId_Internal_set_Void_Int32_0;

			// Token: 0x04003714 RID: 14100
			private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

			// Token: 0x04003715 RID: 14101
			private static readonly IntPtr NativeMethodInfoPtr_set_tag_Internal_set_Void_String_0;

			// Token: 0x04003716 RID: 14102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003717 RID: 14103
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

			// Token: 0x04003718 RID: 14104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CreateControllerInfo_0;
		}
	}
}
