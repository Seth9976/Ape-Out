using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Data
{
	// Token: 0x02000142 RID: 322
	[Serializable]
	public sealed class ControllerMapEnabler_Rule_Editor : Object
	{
		// Token: 0x06002352 RID: 9042 RVA: 0x000B3CFC File Offset: 0x000B1EFC
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerMapEnabler_Rule_Editor()
		{
			Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "ControllerMapEnabler_Rule_Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr);
			ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, "_tag");
			ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, "_enable");
			ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__categoryIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, "_categoryIds");
			ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__layoutIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, "_layoutIds");
			ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__controllerSetSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, "_controllerSetSelector");
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670888);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670889);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_enable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670890);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_enable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670891);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_categoryIds_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670892);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_categoryIds_Public_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670893);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_layoutIds_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670894);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_layoutIds_Public_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670895);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670896);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670897);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670898);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapEnabler_Rule_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670899);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_ToRuntime_Internal_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670900);
			ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr, 100670901);
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x000B3EA8 File Offset: 0x000B20A8
		// (set) Token: 0x06002354 RID: 9044 RVA: 0x000B3EE0 File Offset: 0x000B20E0
		public unsafe string tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x000B3F24 File Offset: 0x000B2124
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x000B3F60 File Offset: 0x000B2160
		public unsafe bool enable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_enable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_enable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x000B3FA0 File Offset: 0x000B21A0
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x000B3FE0 File Offset: 0x000B21E0
		public unsafe List<int> categoryIds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_categoryIds_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_categoryIds_Public_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x000B4024 File Offset: 0x000B2224
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x000B4064 File Offset: 0x000B2264
		public unsafe List<int> layoutIds
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_layoutIds_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 17089, RefRangeEnd = 17127, XrefRangeStart = 17089, XrefRangeEnd = 17127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_layoutIds_Public_set_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x000B40A8 File Offset: 0x000B22A8
		// (set) Token: 0x0600235C RID: 9052 RVA: 0x000B40E8 File Offset: 0x000B22E8
		public unsafe ControllerSetSelector_Editor controllerSetSelector
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector_Editor>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x000B412C File Offset: 0x000B232C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289016, XrefRangeEnd = 289030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapEnabler_Rule_Editor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x000B4168 File Offset: 0x000B2368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289039, RefRangeEnd = 289040, XrefRangeStart = 289030, XrefRangeEnd = 289039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapEnabler_Rule_Editor(ControllerMapEnabler_Rule_Editor source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerMapEnabler_Rule_Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerMapEnabler_Rule_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x000B41B4 File Offset: 0x000B23B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289054, RefRangeEnd = 289055, XrefRangeStart = 289040, XrefRangeEnd = 289054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerMapEnabler.Rule ToRuntime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_ToRuntime_Internal_Rule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerMapEnabler.Rule>(intPtr3) : null;
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x000B41F4 File Offset: 0x000B23F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289055, XrefRangeEnd = 289059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Rewired_Utils_Interfaces_IDeepCloneable_DeepClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerMapEnabler_Rule_Editor.NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0000E383 File Offset: 0x0000C583
		public ControllerMapEnabler_Rule_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x000B4234 File Offset: 0x000B2434
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x0000E38C File Offset: 0x0000C58C
		public unsafe string _tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x000B425C File Offset: 0x000B245C
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x0000E3AB File Offset: 0x0000C5AB
		public unsafe bool _enable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__enable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__enable)) = value;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x000B4284 File Offset: 0x000B2484
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x0000E3C6 File Offset: 0x0000C5C6
		public unsafe List<int> _categoryIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__categoryIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__categoryIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x000B42B4 File Offset: 0x000B24B4
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x0000E3E5 File Offset: 0x0000C5E5
		public unsafe List<int> _layoutIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__layoutIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__layoutIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x000B42E4 File Offset: 0x000B24E4
		// (set) Token: 0x0600236B RID: 9067 RVA: 0x0000E404 File Offset: 0x0000C604
		public unsafe ControllerSetSelector_Editor _controllerSetSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__controllerSetSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ControllerSetSelector_Editor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerMapEnabler_Rule_Editor.NativeFieldInfoPtr__controllerSetSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeFieldInfoPtr__tag;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeFieldInfoPtr__enable;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeFieldInfoPtr__categoryIds;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeFieldInfoPtr__layoutIds;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeFieldInfoPtr__controllerSetSelector;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_get_enable_Public_get_Boolean_0;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeMethodInfoPtr_set_enable_Public_set_Void_Boolean_0;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeMethodInfoPtr_get_categoryIds_Public_get_List_1_Int32_0;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeMethodInfoPtr_set_categoryIds_Public_set_Void_List_1_Int32_0;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutIds_Public_get_List_1_Int32_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_set_layoutIds_Public_set_Void_List_1_Int32_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerSetSelector_Public_get_ControllerSetSelector_Editor_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerSetSelector_Public_set_Void_ControllerSetSelector_Editor_0;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerMapEnabler_Rule_Editor_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeMethodInfoPtr_ToRuntime_Internal_Rule_0;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Utils_Interfaces_IDeepCloneable_DeepClone_Private_Virtual_Final_New_Object_0;
	}
}
