using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security
{
	// Token: 0x020002C3 RID: 707
	[Serializable]
	public sealed class SecurityElement : Object
	{
		// Token: 0x06002FFE RID: 12286 RVA: 0x000F3804 File Offset: 0x000F1A04
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityElement()
		{
			Il2CppClassPointerStore<SecurityElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr);
			SecurityElement.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "text");
			SecurityElement.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "tag");
			SecurityElement.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "attributes");
			SecurityElement.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "children");
			SecurityElement.NativeFieldInfoPtr_invalid_tag_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_tag_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_text_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_text_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_attr_name_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_attr_name_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_attr_value_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_attr_value_chars");
			SecurityElement.NativeFieldInfoPtr_invalid_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "invalid_chars");
			SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670946);
			SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670947);
			SecurityElement.NativeMethodInfoPtr_get_Attributes_Public_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670948);
			SecurityElement.NativeMethodInfoPtr_get_Children_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670949);
			SecurityElement.NativeMethodInfoPtr_get_Tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670950);
			SecurityElement.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670951);
			SecurityElement.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670952);
			SecurityElement.NativeMethodInfoPtr_AddAttribute_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670953);
			SecurityElement.NativeMethodInfoPtr_AddChild_Public_Void_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670954);
			SecurityElement.NativeMethodInfoPtr_Escape_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670955);
			SecurityElement.NativeMethodInfoPtr_Unescape_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670956);
			SecurityElement.NativeMethodInfoPtr_FromString_Public_Static_SecurityElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670957);
			SecurityElement.NativeMethodInfoPtr_IsValidAttributeName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670958);
			SecurityElement.NativeMethodInfoPtr_IsValidAttributeValue_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670959);
			SecurityElement.NativeMethodInfoPtr_IsValidTag_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670960);
			SecurityElement.NativeMethodInfoPtr_IsValidText_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670961);
			SecurityElement.NativeMethodInfoPtr_SearchForChildByTag_Public_SecurityElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670962);
			SecurityElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670963);
			SecurityElement.NativeMethodInfoPtr_ToXml_Private_Void_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670964);
			SecurityElement.NativeMethodInfoPtr_GetAttribute_Internal_SecurityAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670965);
			SecurityElement.NativeMethodInfoPtr_set_m_strText_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670966);
			SecurityElement.NativeMethodInfoPtr_SearchForTextOfLocalName_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, 100670967);
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x000F3AA0 File Offset: 0x000F1CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207751, XrefRangeEnd = 207752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement(string tag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x000F3AEC File Offset: 0x000F1CEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 207777, RefRangeEnd = 207783, XrefRangeStart = 207752, XrefRangeEnd = 207777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement(string tag, string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06003001 RID: 12289 RVA: 0x000F3B4C File Offset: 0x000F1D4C
		public unsafe Hashtable Attributes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 207803, RefRangeEnd = 207804, XrefRangeStart = 207783, XrefRangeEnd = 207803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Attributes_Public_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x000F3B8C File Offset: 0x000F1D8C
		public unsafe ArrayList Children
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Children_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x000F3BCC File Offset: 0x000F1DCC
		public unsafe string Tag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x000F3C04 File Offset: 0x000F1E04
		// (set) Token: 0x06003005 RID: 12293 RVA: 0x000F3C3C File Offset: 0x000F1E3C
		public unsafe string Text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 207816, RefRangeEnd = 207820, XrefRangeStart = 207804, XrefRangeEnd = 207816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x000F3C80 File Offset: 0x000F1E80
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 207850, RefRangeEnd = 207858, XrefRangeStart = 207820, XrefRangeEnd = 207850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttribute(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_AddAttribute_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x000F3CD4 File Offset: 0x000F1ED4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 207869, RefRangeEnd = 207873, XrefRangeStart = 207858, XrefRangeEnd = 207869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(SecurityElement child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_AddChild_Public_Void_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x000F3D18 File Offset: 0x000F1F18
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 207906, RefRangeEnd = 207914, XrefRangeStart = 207873, XrefRangeEnd = 207906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Escape(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_Escape_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000F3D54 File Offset: 0x000F1F54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207943, RefRangeEnd = 207945, XrefRangeStart = 207914, XrefRangeEnd = 207943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Unescape(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_Unescape_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x000F3D90 File Offset: 0x000F1F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207950, RefRangeEnd = 207951, XrefRangeStart = 207945, XrefRangeEnd = 207950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SecurityElement FromString(string xml)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_FromString_Public_Static_SecurityElement_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x000F3DD4 File Offset: 0x000F1FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207951, XrefRangeEnd = 207952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidAttributeName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidAttributeName_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x000F3E18 File Offset: 0x000F2018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207952, XrefRangeEnd = 207953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidAttributeValue(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidAttributeValue_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000F3E5C File Offset: 0x000F205C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207953, XrefRangeEnd = 207954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidTag(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidTag_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x000F3EA0 File Offset: 0x000F20A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207954, XrefRangeEnd = 207955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidText(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_IsValidText_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x000F3EE4 File Offset: 0x000F20E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207958, RefRangeEnd = 207959, XrefRangeStart = 207955, XrefRangeEnd = 207958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement SearchForChildByTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_SearchForChildByTag_Public_SecurityElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
			}
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x000F3F34 File Offset: 0x000F2134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207959, XrefRangeEnd = 207967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x000F3F6C File Offset: 0x000F216C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208033, RefRangeEnd = 208035, XrefRangeStart = 207967, XrefRangeEnd = 208033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToXml(ref StringBuilder s, int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(s);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_ToXml_Private_Void_byref_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			s = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x000F3FD4 File Offset: 0x000F21D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208049, RefRangeEnd = 208050, XrefRangeStart = 208035, XrefRangeEnd = 208049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement.SecurityAttribute GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_GetAttribute_Internal_SecurityAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement.SecurityAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x000F4024 File Offset: 0x000F2224
		public unsafe string m_strText
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_set_m_strText_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x000F4068 File Offset: 0x000F2268
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 208063, RefRangeEnd = 208080, XrefRangeStart = 208050, XrefRangeEnd = 208063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string SearchForTextOfLocalName(string strLocalName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strLocalName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.NativeMethodInfoPtr_SearchForTextOfLocalName_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x0001097D File Offset: 0x0000EB7D
		public SecurityElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x000F40B0 File Offset: 0x000F22B0
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x00010986 File Offset: 0x0000EB86
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x000F40D8 File Offset: 0x000F22D8
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x000109A5 File Offset: 0x0000EBA5
		public unsafe string tag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_tag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_tag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x000F4100 File Offset: 0x000F2300
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x000109C4 File Offset: 0x0000EBC4
		public unsafe ArrayList attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x000F4130 File Offset: 0x000F2330
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x000109E3 File Offset: 0x0000EBE3
		public unsafe ArrayList children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x000F4160 File Offset: 0x000F2360
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x00010A02 File Offset: 0x0000EC02
		public unsafe static Il2CppStructArray<char> invalid_tag_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_tag_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_tag_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x000F4188 File Offset: 0x000F2388
		// (set) Token: 0x06003021 RID: 12321 RVA: 0x00010A14 File Offset: 0x0000EC14
		public unsafe static Il2CppStructArray<char> invalid_text_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_text_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_text_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x000F41B0 File Offset: 0x000F23B0
		// (set) Token: 0x06003023 RID: 12323 RVA: 0x00010A26 File Offset: 0x0000EC26
		public unsafe static Il2CppStructArray<char> invalid_attr_name_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_name_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_name_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x000F41D8 File Offset: 0x000F23D8
		// (set) Token: 0x06003025 RID: 12325 RVA: 0x00010A38 File Offset: 0x0000EC38
		public unsafe static Il2CppStructArray<char> invalid_attr_value_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_value_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_attr_value_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x000F4200 File Offset: 0x000F2400
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x00010A4A File Offset: 0x0000EC4A
		public unsafe static Il2CppStructArray<char> invalid_chars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SecurityElement.NativeFieldInfoPtr_invalid_chars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SecurityElement.NativeFieldInfoPtr_invalid_chars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002977 RID: 10615
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002978 RID: 10616
		private static readonly IntPtr NativeFieldInfoPtr_tag;

		// Token: 0x04002979 RID: 10617
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x0400297A RID: 10618
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x0400297B RID: 10619
		private static readonly IntPtr NativeFieldInfoPtr_invalid_tag_chars;

		// Token: 0x0400297C RID: 10620
		private static readonly IntPtr NativeFieldInfoPtr_invalid_text_chars;

		// Token: 0x0400297D RID: 10621
		private static readonly IntPtr NativeFieldInfoPtr_invalid_attr_name_chars;

		// Token: 0x0400297E RID: 10622
		private static readonly IntPtr NativeFieldInfoPtr_invalid_attr_value_chars;

		// Token: 0x0400297F RID: 10623
		private static readonly IntPtr NativeFieldInfoPtr_invalid_chars;

		// Token: 0x04002980 RID: 10624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002981 RID: 10625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04002982 RID: 10626
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_Hashtable_0;

		// Token: 0x04002983 RID: 10627
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_ArrayList_0;

		// Token: 0x04002984 RID: 10628
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_get_String_0;

		// Token: 0x04002985 RID: 10629
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x04002986 RID: 10630
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;

		// Token: 0x04002987 RID: 10631
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Void_String_String_0;

		// Token: 0x04002988 RID: 10632
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_SecurityElement_0;

		// Token: 0x04002989 RID: 10633
		private static readonly IntPtr NativeMethodInfoPtr_Escape_Public_Static_String_String_0;

		// Token: 0x0400298A RID: 10634
		private static readonly IntPtr NativeMethodInfoPtr_Unescape_Private_Static_String_String_0;

		// Token: 0x0400298B RID: 10635
		private static readonly IntPtr NativeMethodInfoPtr_FromString_Public_Static_SecurityElement_String_0;

		// Token: 0x0400298C RID: 10636
		private static readonly IntPtr NativeMethodInfoPtr_IsValidAttributeName_Public_Static_Boolean_String_0;

		// Token: 0x0400298D RID: 10637
		private static readonly IntPtr NativeMethodInfoPtr_IsValidAttributeValue_Public_Static_Boolean_String_0;

		// Token: 0x0400298E RID: 10638
		private static readonly IntPtr NativeMethodInfoPtr_IsValidTag_Public_Static_Boolean_String_0;

		// Token: 0x0400298F RID: 10639
		private static readonly IntPtr NativeMethodInfoPtr_IsValidText_Public_Static_Boolean_String_0;

		// Token: 0x04002990 RID: 10640
		private static readonly IntPtr NativeMethodInfoPtr_SearchForChildByTag_Public_SecurityElement_String_0;

		// Token: 0x04002991 RID: 10641
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002992 RID: 10642
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Private_Void_byref_StringBuilder_Int32_0;

		// Token: 0x04002993 RID: 10643
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Internal_SecurityAttribute_String_0;

		// Token: 0x04002994 RID: 10644
		private static readonly IntPtr NativeMethodInfoPtr_set_m_strText_Internal_set_Void_String_0;

		// Token: 0x04002995 RID: 10645
		private static readonly IntPtr NativeMethodInfoPtr_SearchForTextOfLocalName_Internal_String_String_0;

		// Token: 0x02000620 RID: 1568
		public class SecurityAttribute : Object
		{
			// Token: 0x06005542 RID: 21826 RVA: 0x0017E330 File Offset: 0x0017C530
			// Note: this type is marked as 'beforefieldinit'.
			static SecurityAttribute()
			{
				Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SecurityElement>.NativeClassPtr, "SecurityAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr);
				SecurityElement.SecurityAttribute.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, "_name");
				SecurityElement.SecurityAttribute.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, "_value");
				SecurityElement.SecurityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, 100670969);
				SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, 100670970);
				SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr, 100670971);
			}

			// Token: 0x06005543 RID: 21827 RVA: 0x0017E3C0 File Offset: 0x0017C5C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 207750, RefRangeEnd = 207751, XrefRangeStart = 207730, XrefRangeEnd = 207750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SecurityAttribute(string name, string value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityElement.SecurityAttribute>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.SecurityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015E1 RID: 5601
			// (get) Token: 0x06005544 RID: 21828 RVA: 0x0017E420 File Offset: 0x0017C620
			public unsafe string Name
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170015E2 RID: 5602
			// (get) Token: 0x06005545 RID: 21829 RVA: 0x0017E458 File Offset: 0x0017C658
			public unsafe string Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityElement.SecurityAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005546 RID: 21830 RVA: 0x00020445 File Offset: 0x0001E645
			public SecurityAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015DF RID: 5599
			// (get) Token: 0x06005547 RID: 21831 RVA: 0x0017E490 File Offset: 0x0017C690
			// (set) Token: 0x06005548 RID: 21832 RVA: 0x0002044E File Offset: 0x0001E64E
			public unsafe string _name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170015E0 RID: 5600
			// (get) Token: 0x06005549 RID: 21833 RVA: 0x0017E4B8 File Offset: 0x0017C6B8
			// (set) Token: 0x0600554A RID: 21834 RVA: 0x0002046D File Offset: 0x0001E66D
			public unsafe string _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityElement.SecurityAttribute.NativeFieldInfoPtr__value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040044DC RID: 17628
			private static readonly IntPtr NativeFieldInfoPtr__name;

			// Token: 0x040044DD RID: 17629
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x040044DE RID: 17630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

			// Token: 0x040044DF RID: 17631
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x040044E0 RID: 17632
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
		}
	}
}
