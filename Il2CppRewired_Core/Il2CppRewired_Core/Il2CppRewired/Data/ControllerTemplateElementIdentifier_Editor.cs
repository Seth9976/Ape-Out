using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired.Data
{
	// Token: 0x0200013F RID: 319
	[Serializable]
	public sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier
	{
		// Token: 0x06002309 RID: 8969 RVA: 0x000B2C2C File Offset: 0x000B0E2C
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerTemplateElementIdentifier_Editor()
		{
			Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Data", "ControllerTemplateElementIdentifier_Editor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr);
			ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__scriptingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, "_scriptingName");
			ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__alternateScriptingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, "_alternateScriptingName");
			ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__excludeFromExport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, "_excludeFromExport");
			ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__useEditorElementTypeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, "_useEditorElementTypeOverride");
			ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__editorElementTypeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, "_editorElementTypeOverride");
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_scriptingName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670788);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_set_scriptingName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670789);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_alternateScriptingName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670790);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_set_alternateScriptingName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670791);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_excludeFromExport_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670792);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_useEditorElementTypeOverride_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670793);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_editorElementTypeOverride_Internal_Virtual_get_ControllerElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670794);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_effectiveElementType_Internal_get_ControllerTemplateElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670795);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670796);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerTemplateElementIdentifier_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670797);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_Rewired_Interfaces_IControllerTemplateElementIdentifier_Editor_get_scriptingName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670798);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_Rewired_Interfaces_IControllerTemplateElementIdentifier_Editor_get_alternateScriptingName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670799);
			ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_Clone_Public_Virtual_ControllerTemplateElementIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr, 100670800);
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x000B2DC4 File Offset: 0x000B0FC4
		// (set) Token: 0x0600230B RID: 8971 RVA: 0x000B2DFC File Offset: 0x000B0FFC
		public unsafe string scriptingName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_scriptingName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 99340, RefRangeEnd = 99363, XrefRangeStart = 99340, XrefRangeEnd = 99363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_set_scriptingName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x000B2E40 File Offset: 0x000B1040
		// (set) Token: 0x0600230D RID: 8973 RVA: 0x000B2E78 File Offset: 0x000B1078
		public unsafe string alternateScriptingName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_alternateScriptingName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 13782, RefRangeEnd = 13825, XrefRangeStart = 13782, XrefRangeEnd = 13825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_set_alternateScriptingName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x000B2EBC File Offset: 0x000B10BC
		public unsafe bool excludeFromExport
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_excludeFromExport_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x000B2EF8 File Offset: 0x000B10F8
		public unsafe override bool useEditorElementTypeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_useEditorElementTypeOverride_Internal_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x000B2F34 File Offset: 0x000B1134
		public unsafe override ControllerElementType editorElementTypeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_editorElementTypeOverride_Internal_Virtual_get_ControllerElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x000B2F70 File Offset: 0x000B1170
		public unsafe ControllerTemplateElementType effectiveElementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_get_effectiveElementType_Internal_get_ControllerTemplateElementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x000B2FAC File Offset: 0x000B11AC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateElementIdentifier_Editor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x000B2FE8 File Offset: 0x000B11E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288231, XrefRangeEnd = 288232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerTemplateElementIdentifier_Editor(ControllerTemplateElementIdentifier_Editor source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerTemplateElementIdentifier_Editor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr__ctor_Public_Void_ControllerTemplateElementIdentifier_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x000B3034 File Offset: 0x000B1234
		public unsafe string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.scriptingName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_Rewired_Interfaces_IControllerTemplateElementIdentifier_Editor_get_scriptingName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x000B306C File Offset: 0x000B126C
		public unsafe string Rewired.Interfaces.IControllerTemplateElementIdentifier_Editor.alternateScriptingName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_Rewired_Interfaces_IControllerTemplateElementIdentifier_Editor_get_alternateScriptingName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x000B30A4 File Offset: 0x000B12A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288232, XrefRangeEnd = 288236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ControllerTemplateElementIdentifier Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateElementIdentifier_Editor.NativeMethodInfoPtr_Clone_Public_Virtual_ControllerTemplateElementIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ControllerTemplateElementIdentifier>(intPtr3) : null;
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x0000E1CE File Offset: 0x0000C3CE
		public ControllerTemplateElementIdentifier_Editor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x000B30E4 File Offset: 0x000B12E4
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x0000E1D7 File Offset: 0x0000C3D7
		public unsafe string _scriptingName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__scriptingName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__scriptingName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x000B310C File Offset: 0x000B130C
		// (set) Token: 0x0600231B RID: 8987 RVA: 0x0000E1F6 File Offset: 0x0000C3F6
		public unsafe string _alternateScriptingName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__alternateScriptingName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__alternateScriptingName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000B3134 File Offset: 0x000B1334
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x0000E215 File Offset: 0x0000C415
		public unsafe bool _excludeFromExport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__excludeFromExport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__excludeFromExport)) = value;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x000B315C File Offset: 0x000B135C
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x0000E230 File Offset: 0x0000C430
		public unsafe bool _useEditorElementTypeOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__useEditorElementTypeOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__useEditorElementTypeOverride)) = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000B3184 File Offset: 0x000B1384
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x0000E24B File Offset: 0x0000C44B
		public unsafe ControllerElementType _editorElementTypeOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__editorElementTypeOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerTemplateElementIdentifier_Editor.NativeFieldInfoPtr__editorElementTypeOverride)) = value;
			}
		}

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeFieldInfoPtr__scriptingName;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeFieldInfoPtr__alternateScriptingName;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeFieldInfoPtr__excludeFromExport;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeFieldInfoPtr__useEditorElementTypeOverride;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeFieldInfoPtr__editorElementTypeOverride;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeMethodInfoPtr_get_scriptingName_Internal_get_String_0;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeMethodInfoPtr_set_scriptingName_Internal_set_Void_String_0;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeMethodInfoPtr_get_alternateScriptingName_Internal_get_String_0;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeMethodInfoPtr_set_alternateScriptingName_Internal_set_Void_String_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeMethodInfoPtr_get_excludeFromExport_Internal_get_Boolean_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeMethodInfoPtr_get_useEditorElementTypeOverride_Internal_Virtual_get_Boolean_0;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeMethodInfoPtr_get_editorElementTypeOverride_Internal_Virtual_get_ControllerElementType_0;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeMethodInfoPtr_get_effectiveElementType_Internal_get_ControllerTemplateElementType_0;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ControllerTemplateElementIdentifier_Editor_0;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerTemplateElementIdentifier_Editor_get_scriptingName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IControllerTemplateElementIdentifier_Editor_get_alternateScriptingName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_ControllerTemplateElementIdentifier_0;
	}
}
