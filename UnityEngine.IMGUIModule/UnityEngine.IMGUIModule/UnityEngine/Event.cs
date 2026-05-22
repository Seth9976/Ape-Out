using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class Event : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00004978 File Offset: 0x00002B78
		// Note: this type is marked as 'beforefieldinit'.
		static Event()
		{
			Il2CppClassPointerStore<Event>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "Event");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Event>.NativeClassPtr);
			Event.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "m_Ptr");
			Event.NativeFieldInfoPtr_s_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "s_Current");
			Event.NativeFieldInfoPtr_s_MasterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "s_MasterEvent");
			Event.NativeMethodInfoPtr_get_rawType_Public_get_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663297);
			Event.NativeMethodInfoPtr_get_mousePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663298);
			Event.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663299);
			Event.NativeMethodInfoPtr_get_pointerType_Public_get_PointerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663300);
			Event.NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663301);
			Event.NativeMethodInfoPtr_set_modifiers_Public_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663302);
			Event.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663303);
			Event.NativeMethodInfoPtr_get_character_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663304);
			Event.NativeMethodInfoPtr_set_character_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663305);
			Event.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663306);
			Event.NativeMethodInfoPtr_set_keyCode_Public_set_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663307);
			Event.NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663308);
			Event.NativeMethodInfoPtr_get_type_Public_get_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663309);
			Event.NativeMethodInfoPtr_set_type_Public_set_Void_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663310);
			Event.NativeMethodInfoPtr_get_commandName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663311);
			Event.NativeMethodInfoPtr_Internal_Use_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663312);
			Event.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663313);
			Event.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663314);
			Event.NativeMethodInfoPtr_GetTypeForControl_Public_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663315);
			Event.NativeMethodInfoPtr_PopEvent_Public_Static_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663316);
			Event.NativeMethodInfoPtr_Internal_SetNativeEvent_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663317);
			Event.NativeMethodInfoPtr_Internal_MakeMasterEventCurrent_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663318);
			Event.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663319);
			Event.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663320);
			Event.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663321);
			Event.NativeMethodInfoPtr_get_shift_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663322);
			Event.NativeMethodInfoPtr_get_control_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663323);
			Event.NativeMethodInfoPtr_get_alt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663324);
			Event.NativeMethodInfoPtr_get_command_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663325);
			Event.NativeMethodInfoPtr_get_current_Public_Static_get_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663326);
			Event.NativeMethodInfoPtr_get_isKey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663327);
			Event.NativeMethodInfoPtr_get_isMouse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663328);
			Event.NativeMethodInfoPtr_get_isDirectManipulationDevice_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663329);
			Event.NativeMethodInfoPtr_KeyboardEvent_Public_Static_Event_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663330);
			Event.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663331);
			Event.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663332);
			Event.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663333);
			Event.NativeMethodInfoPtr_Use_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663334);
			Event.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663335);
			Event.NativeMethodInfoPtr_get_delta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663336);
			Event.set_pointerTypeDelegateField = IL2CPP.ResolveICall<Event.set_pointerTypeDelegate>("UnityEngine.Event::set_pointerType");
			Event.get_buttonDelegateField = IL2CPP.ResolveICall<Event.get_buttonDelegate>("UnityEngine.Event::get_button");
			Event.set_buttonDelegateField = IL2CPP.ResolveICall<Event.set_buttonDelegate>("UnityEngine.Event::set_button");
			Event.get_pressureDelegateField = IL2CPP.ResolveICall<Event.get_pressureDelegate>("UnityEngine.Event::get_pressure");
			Event.set_pressureDelegateField = IL2CPP.ResolveICall<Event.set_pressureDelegate>("UnityEngine.Event::set_pressure");
			Event.set_clickCountDelegateField = IL2CPP.ResolveICall<Event.set_clickCountDelegate>("UnityEngine.Event::set_clickCount");
			Event.get_displayIndexDelegateField = IL2CPP.ResolveICall<Event.get_displayIndexDelegate>("UnityEngine.Event::get_displayIndex");
			Event.set_commandNameDelegateField = IL2CPP.ResolveICall<Event.set_commandNameDelegate>("UnityEngine.Event::set_commandName");
			Event.Internal_CopyDelegateField = IL2CPP.ResolveICall<Event.Internal_CopyDelegate>("UnityEngine.Event::Internal_Copy");
			Event.CopyFromPtrDelegateField = IL2CPP.ResolveICall<Event.CopyFromPtrDelegate>("UnityEngine.Event::CopyFromPtr");
			Event.GetEventCountDelegateField = IL2CPP.ResolveICall<Event.GetEventCountDelegate>("UnityEngine.Event::GetEventCount");
			Event.GetDoubleClickTimeDelegateField = IL2CPP.ResolveICall<Event.GetDoubleClickTimeDelegate>("UnityEngine.Event::GetDoubleClickTime");
			Event.set_mousePosition_InjectedDelegateField = IL2CPP.ResolveICall<Event.set_mousePosition_InjectedDelegate>("UnityEngine.Event::set_mousePosition_Injected");
			Event.set_delta_InjectedDelegateField = IL2CPP.ResolveICall<Event.set_delta_InjectedDelegate>("UnityEngine.Event::set_delta_Injected");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00004DD8 File Offset: 0x00002FD8
		public unsafe EventType rawType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 504884, RefRangeEnd = 504885, XrefRangeStart = 504880, XrefRangeEnd = 504884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_rawType_Public_get_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00004E14 File Offset: 0x00003014
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002098 File Offset: 0x00000298
		public unsafe Vector2 mousePosition
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 504887, RefRangeEnd = 504906, XrefRangeStart = 504885, XrefRangeEnd = 504887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_mousePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_mousePosition_Injected(ref value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00004E50 File Offset: 0x00003050
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000020A2 File Offset: 0x000002A2
		public unsafe Vector2 delta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504906, XrefRangeEnd = 504908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_delta_Injected(ref value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00004E8C File Offset: 0x0000308C
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000020AC File Offset: 0x000002AC
		public unsafe PointerType pointerType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504908, XrefRangeEnd = 504912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_pointerType_Public_get_PointerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_pointerTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00004EC8 File Offset: 0x000030C8
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00004F04 File Offset: 0x00003104
		public unsafe EventModifiers modifiers
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 504916, RefRangeEnd = 504924, XrefRangeStart = 504912, XrefRangeEnd = 504916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 504928, RefRangeEnd = 504931, XrefRangeStart = 504924, XrefRangeEnd = 504928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_modifiers_Public_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00004F44 File Offset: 0x00003144
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002109 File Offset: 0x00000309
		public unsafe int clickCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 504935, RefRangeEnd = 504937, XrefRangeStart = 504931, XrefRangeEnd = 504935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_clickCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00004F80 File Offset: 0x00003180
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00004FBC File Offset: 0x000031BC
		public unsafe char character
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 504941, RefRangeEnd = 504946, XrefRangeStart = 504937, XrefRangeEnd = 504941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_character_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 504950, RefRangeEnd = 504970, XrefRangeStart = 504946, XrefRangeEnd = 504950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_character_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00004FFC File Offset: 0x000031FC
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00005038 File Offset: 0x00003238
		public unsafe KeyCode keyCode
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 504974, RefRangeEnd = 504979, XrefRangeStart = 504970, XrefRangeEnd = 504974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 504983, RefRangeEnd = 505006, XrefRangeStart = 504979, XrefRangeEnd = 504983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_keyCode_Public_set_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00005078 File Offset: 0x00003278
		public unsafe int displayIndex
		{
			get
			{
				return Event.get_displayIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505006, XrefRangeEnd = 505010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000050B8 File Offset: 0x000032B8
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000050F4 File Offset: 0x000032F4
		public unsafe EventType type
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 505014, RefRangeEnd = 505020, XrefRangeStart = 505010, XrefRangeEnd = 505014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_type_Public_get_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505020, XrefRangeEnd = 505024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_type_Public_set_Void_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00005134 File Offset: 0x00003334
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0000212E File Offset: 0x0000032E
		public unsafe string commandName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 505028, RefRangeEnd = 505030, XrefRangeStart = 505024, XrefRangeEnd = 505028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_commandName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Event.set_commandNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000516C File Offset: 0x0000336C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505030, XrefRangeEnd = 505034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_Use_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000051A0 File Offset: 0x000033A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505034, XrefRangeEnd = 505038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000051E0 File Offset: 0x000033E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505038, XrefRangeEnd = 505042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00005214 File Offset: 0x00003414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505042, XrefRangeEnd = 505046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventType GetTypeForControl(int controlID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref controlID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_GetTypeForControl_Public_EventType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005260 File Offset: 0x00003460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505046, XrefRangeEnd = 505050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PopEvent(Event outEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_PopEvent_Public_Static_Boolean_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000052A4 File Offset: 0x000034A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505050, XrefRangeEnd = 505054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetNativeEvent(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_SetNativeEvent_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000052D8 File Offset: 0x000034D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505054, XrefRangeEnd = 505074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_MakeMasterEventCurrent(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_MakeMasterEventCurrent_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000530C File Offset: 0x0000350C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505074, XrefRangeEnd = 505076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Event>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005348 File Offset: 0x00003548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505076, XrefRangeEnd = 505078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event(int displayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Event>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005390 File Offset: 0x00003590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505078, XrefRangeEnd = 505082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000053C4 File Offset: 0x000035C4
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00005828 File Offset: 0x00003A28
		public unsafe bool shift
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 505084, RefRangeEnd = 505086, XrefRangeStart = 505082, XrefRangeEnd = 505084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_shift_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Shift;
				}
				else
				{
					this.modifiers |= EventModifiers.Shift;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00005400 File Offset: 0x00003600
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00005860 File Offset: 0x00003A60
		public unsafe bool control
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505086, XrefRangeEnd = 505088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_control_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Control;
				}
				else
				{
					this.modifiers |= EventModifiers.Control;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000543C File Offset: 0x0000363C
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005898 File Offset: 0x00003A98
		public unsafe bool alt
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 505090, RefRangeEnd = 505092, XrefRangeStart = 505088, XrefRangeEnd = 505090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_alt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Alt;
				}
				else
				{
					this.modifiers |= EventModifiers.Alt;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00005478 File Offset: 0x00003678
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000058D0 File Offset: 0x00003AD0
		public unsafe bool command
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505092, XrefRangeEnd = 505094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_command_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Command;
				}
				else
				{
					this.modifiers |= EventModifiers.Command;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000054B4 File Offset: 0x000036B4
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000219E File Offset: 0x0000039E
		public unsafe static Event current
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 505096, RefRangeEnd = 505104, XrefRangeStart = 505094, XrefRangeEnd = 505096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_current_Public_Static_get_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
			set
			{
				Event.s_Current = value ?? Event.s_MasterEvent;
				Event.Internal_SetNativeEvent(Event.s_Current.m_Ptr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000054E8 File Offset: 0x000036E8
		public unsafe bool isKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 505106, RefRangeEnd = 505107, XrefRangeStart = 505104, XrefRangeEnd = 505106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_isKey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00005524 File Offset: 0x00003724
		public unsafe bool isMouse
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 505109, RefRangeEnd = 505112, XrefRangeStart = 505107, XrefRangeEnd = 505109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_isMouse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00005560 File Offset: 0x00003760
		public unsafe bool isDirectManipulationDevice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505112, XrefRangeEnd = 505114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_isDirectManipulationDevice_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000559C File Offset: 0x0000379C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 505410, RefRangeEnd = 505411, XrefRangeStart = 505114, XrefRangeEnd = 505410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Event KeyboardEvent(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_KeyboardEvent_Public_Static_Event_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000055E0 File Offset: 0x000037E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505411, XrefRangeEnd = 505419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000561C File Offset: 0x0000381C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505419, XrefRangeEnd = 505431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000566C File Offset: 0x0000386C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505431, XrefRangeEnd = 505455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000056A4 File Offset: 0x000038A4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 505489, RefRangeEnd = 505507, XrefRangeStart = 505455, XrefRangeEnd = 505489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Use_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000056D8 File Offset: 0x000038D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505507, XrefRangeEnd = 505511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_mousePosition_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005718 File Offset: 0x00003918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505511, XrefRangeEnd = 505515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_delta_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_delta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		public Event(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00005758 File Offset: 0x00003958
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00005780 File Offset: 0x00003980
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe static Event s_Current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Event.NativeFieldInfoPtr_s_Current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Event.NativeFieldInfoPtr_s_Current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000057A8 File Offset: 0x000039A8
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002086 File Offset: 0x00000286
		public unsafe static Event s_MasterEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Event.NativeFieldInfoPtr_s_MasterEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Event.NativeFieldInfoPtr_s_MasterEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000020BF File Offset: 0x000002BF
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000020D1 File Offset: 0x000002D1
		public int button
		{
			get
			{
				return Event.get_buttonDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Event.set_buttonDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000020E4 File Offset: 0x000002E4
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000020F6 File Offset: 0x000002F6
		public float pressure
		{
			get
			{
				return Event.get_pressureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Event.set_pressureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002146 File Offset: 0x00000346
		public static IntPtr Internal_Copy(IntPtr otherPtr)
		{
			return Event.Internal_CopyDelegateField(otherPtr);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002153 File Offset: 0x00000353
		public void CopyFromPtr(IntPtr ptr)
		{
			Event.CopyFromPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ptr);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002166 File Offset: 0x00000366
		public static int GetEventCount()
		{
			return Event.GetEventCountDelegateField();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002172 File Offset: 0x00000372
		public static int GetDoubleClickTime()
		{
			return Event.GetDoubleClickTimeDelegateField();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000217E File Offset: 0x0000037E
		public static void CleanupRoots()
		{
			Event.s_Current = null;
			Event.s_MasterEvent = null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000057D0 File Offset: 0x000039D0
		public void CopyFrom(Event e)
		{
			bool flag = e.m_Ptr != this.m_Ptr;
			if (flag)
			{
				this.CopyFromPtr(e.m_Ptr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00005804 File Offset: 0x00003A04
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000218D File Offset: 0x0000038D
		public Ray mouseRay
		{
			get
			{
				return new Ray(Vector3.up, Vector3.up);
			}
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00005908 File Offset: 0x00003B08
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00005928 File Offset: 0x00003B28
		public bool capsLock
		{
			get
			{
				return (this.modifiers & EventModifiers.CapsLock) > EventModifiers.None;
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.CapsLock;
				}
				else
				{
					this.modifiers |= EventModifiers.CapsLock;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00005960 File Offset: 0x00003B60
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00005980 File Offset: 0x00003B80
		public bool numeric
		{
			get
			{
				return (this.modifiers & EventModifiers.Numeric) > EventModifiers.None;
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Numeric;
				}
				else
				{
					this.modifiers |= EventModifiers.Numeric;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002190 File Offset: 0x00000390
		public bool functionKey
		{
			get
			{
				return (this.modifiers & EventModifiers.FunctionKey) > EventModifiers.None;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000059B8 File Offset: 0x00003BB8
		public bool isScrollWheel
		{
			get
			{
				EventType type = this.type;
				return type == EventType.ScrollWheel;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021C0 File Offset: 0x000003C0
		public void set_mousePosition_Injected(ref Vector2 value)
		{
			Event.set_mousePosition_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000021D3 File Offset: 0x000003D3
		public void set_delta_Injected(ref Vector2 value)
		{
			Event.set_delta_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_s_Current;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_s_MasterEvent;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_rawType_Public_get_EventType_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_get_Vector2_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Public_get_Vector2_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_get_PointerType_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Public_set_Void_EventModifiers_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_character_Public_get_Char_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_set_character_Public_set_Void_Char_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_set_keyCode_Public_set_Void_KeyCode_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_EventType_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_EventType_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_commandName_Public_get_String_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Use_Private_Void_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Int32_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeForControl_Public_EventType_Int32_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_PopEvent_Public_Static_Boolean_Event_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetNativeEvent_Private_Static_Void_IntPtr_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MakeMasterEventCurrent_Internal_Static_Void_Int32_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_shift_Public_get_Boolean_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_control_Public_get_Boolean_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_alt_Public_get_Boolean_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_command_Public_get_Boolean_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Event_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_isKey_Public_get_Boolean_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_isMouse_Public_get_Boolean_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_isDirectManipulationDevice_Internal_get_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_KeyboardEvent_Public_Static_Event_String_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Void_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400002C RID: 44
		private static readonly Event.set_pointerTypeDelegate set_pointerTypeDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly Event.get_buttonDelegate get_buttonDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly Event.set_buttonDelegate set_buttonDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly Event.get_pressureDelegate get_pressureDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly Event.set_pressureDelegate set_pressureDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly Event.set_clickCountDelegate set_clickCountDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly Event.get_displayIndexDelegate get_displayIndexDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly Event.set_commandNameDelegate set_commandNameDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly Event.Internal_CopyDelegate Internal_CopyDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly Event.CopyFromPtrDelegate CopyFromPtrDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly Event.GetEventCountDelegate GetEventCountDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly Event.GetDoubleClickTimeDelegate GetDoubleClickTimeDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly Event.set_mousePosition_InjectedDelegate set_mousePosition_InjectedDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly Event.set_delta_InjectedDelegate set_delta_InjectedDelegateField;

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600062C RID: 1580
		private delegate void set_pointerTypeDelegate(IntPtr @this, PointerType value);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600062E RID: 1582
		private delegate int get_buttonDelegate(IntPtr @this);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000630 RID: 1584
		private delegate void set_buttonDelegate(IntPtr @this, int value);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000632 RID: 1586
		private delegate float get_pressureDelegate(IntPtr @this);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000634 RID: 1588
		private delegate void set_pressureDelegate(IntPtr @this, float value);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000636 RID: 1590
		private delegate void set_clickCountDelegate(IntPtr @this, int value);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000638 RID: 1592
		private delegate int get_displayIndexDelegate(IntPtr @this);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600063A RID: 1594
		private delegate void set_commandNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x0600063C RID: 1596
		private delegate IntPtr Internal_CopyDelegate(IntPtr otherPtr);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x0600063E RID: 1598
		private delegate void CopyFromPtrDelegate(IntPtr @this, IntPtr ptr);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000640 RID: 1600
		private delegate int GetEventCountDelegate();

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x06000642 RID: 1602
		private delegate int GetDoubleClickTimeDelegate();

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000644 RID: 1604
		private delegate void set_mousePosition_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000646 RID: 1606
		private delegate void set_delta_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
