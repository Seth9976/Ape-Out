using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml
{
	// Token: 0x020000AC RID: 172
	public class XmlNamespaceManager : Object
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x0005B184 File Offset: 0x00059384
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNamespaceManager()
		{
			Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNamespaceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr);
			XmlNamespaceManager.NativeFieldInfoPtr_nsdecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "nsdecls");
			XmlNamespaceManager.NativeFieldInfoPtr_lastDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "lastDecl");
			XmlNamespaceManager.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "nameTable");
			XmlNamespaceManager.NativeFieldInfoPtr_scopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "scopeId");
			XmlNamespaceManager.NativeFieldInfoPtr_hashTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "hashTable");
			XmlNamespaceManager.NativeFieldInfoPtr_useHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "useHashtable");
			XmlNamespaceManager.NativeFieldInfoPtr_xml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "xml");
			XmlNamespaceManager.NativeFieldInfoPtr_xmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "xmlNs");
			XmlNamespaceManager.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665913);
			XmlNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665914);
			XmlNamespaceManager.NativeMethodInfoPtr_get_NameTable_Public_Virtual_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665915);
			XmlNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665916);
			XmlNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665917);
			XmlNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665918);
			XmlNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665919);
			XmlNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665920);
			XmlNamespaceManager.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665921);
			XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665922);
			XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespaceDecl_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665923);
			XmlNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, 100665924);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0005B344 File Offset: 0x00059544
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0005B380 File Offset: 0x00059580
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 402666, RefRangeEnd = 402680, XrefRangeStart = 402650, XrefRangeEnd = 402666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceManager(XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x0005B3CC File Offset: 0x000595CC
		public unsafe virtual XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_get_NameTable_Public_Virtual_New_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0005B418 File Offset: 0x00059618
		public unsafe virtual string DefaultNamespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402680, XrefRangeEnd = 402683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0005B45C File Offset: 0x0005965C
		[CallerCount(0)]
		public unsafe virtual void PushScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0005B498 File Offset: 0x00059698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402683, XrefRangeEnd = 402686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool PopScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0005B4E0 File Offset: 0x000596E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402686, XrefRangeEnd = 402700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddNamespace(string prefix, string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0005B540 File Offset: 0x00059740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402700, XrefRangeEnd = 402714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0005B58C File Offset: 0x0005978C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402714, XrefRangeEnd = 402728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0005B5E4 File Offset: 0x000597E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402728, XrefRangeEnd = 402729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0005B638 File Offset: 0x00059838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 402730, RefRangeEnd = 402732, XrefRangeStart = 402729, XrefRangeEnd = 402730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaceDecl(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NativeMethodInfoPtr_LookupNamespaceDecl_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0005B688 File Offset: 0x00059888
		[CallerCount(0)]
		public unsafe virtual string LookupPrefix(string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0000757F File Offset: 0x0000577F
		public XmlNamespaceManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0005B6DC File Offset: 0x000598DC
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x00007588 File Offset: 0x00005788
		public unsafe Il2CppReferenceArray<XmlNamespaceManager.NamespaceDeclaration> nsdecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nsdecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNamespaceManager.NamespaceDeclaration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nsdecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x0005B70C File Offset: 0x0005990C
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x000075A7 File Offset: 0x000057A7
		public unsafe int lastDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_lastDecl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_lastDecl)) = value;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x0005B734 File Offset: 0x00059934
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x000075C2 File Offset: 0x000057C2
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x0005B764 File Offset: 0x00059964
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x000075E1 File Offset: 0x000057E1
		public unsafe int scopeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_scopeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_scopeId)) = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0005B78C File Offset: 0x0005998C
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x000075FC File Offset: 0x000057FC
		public unsafe Dictionary<string, int> hashTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_hashTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_hashTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0005B7BC File Offset: 0x000599BC
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x0000761B File Offset: 0x0000581B
		public unsafe bool useHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_useHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_useHashtable)) = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x0005B7E4 File Offset: 0x000599E4
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x00007636 File Offset: 0x00005836
		public unsafe string xml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0005B80C File Offset: 0x00059A0C
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x00007655 File Offset: 0x00005855
		public unsafe string xmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NativeFieldInfoPtr_xmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeFieldInfoPtr_nsdecls;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeFieldInfoPtr_lastDecl;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeFieldInfoPtr_scopeId;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeFieldInfoPtr_hashTable;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeFieldInfoPtr_useHashtable;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeFieldInfoPtr_xml;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeFieldInfoPtr_xmlNs;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_New_get_XmlNameTable_0;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_New_get_String_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_PushScope_Public_Virtual_New_Void_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_PopScope_Public_Virtual_New_Boolean_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Public_Virtual_New_Void_String_String_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Public_Virtual_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaceDecl_Private_Int32_String_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0;

		// Token: 0x02000225 RID: 549
		public sealed class NamespaceDeclaration : ValueType
		{
			// Token: 0x06002BDC RID: 11228 RVA: 0x000C4ED8 File Offset: 0x000C30D8
			// Note: this type is marked as 'beforefieldinit'.
			static NamespaceDeclaration()
			{
				Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNamespaceManager>.NativeClassPtr, "NamespaceDeclaration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr);
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "prefix");
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "uri");
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_scopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "scopeId");
				XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_previousNsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, "previousNsIndex");
				XmlNamespaceManager.NamespaceDeclaration.NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr, 100665925);
			}

			// Token: 0x06002BDD RID: 11229 RVA: 0x000C4F68 File Offset: 0x000C3168
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 402647, RefRangeEnd = 402650, XrefRangeStart = 402647, XrefRangeEnd = 402647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Set(string prefix, string uri, int scopeId, int previousNsIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousNsIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamespaceManager.NamespaceDeclaration.NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BDE RID: 11230 RVA: 0x00012BF6 File Offset: 0x00010DF6
			public NamespaceDeclaration(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002BDF RID: 11231 RVA: 0x00012BFF File Offset: 0x00010DFF
			public NamespaceDeclaration()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamespaceManager.NamespaceDeclaration>.NativeClassPtr))
			{
			}

			// Token: 0x17000EF7 RID: 3831
			// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x000C4FE0 File Offset: 0x000C31E0
			// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x00012C11 File Offset: 0x00010E11
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EF8 RID: 3832
			// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x000C5008 File Offset: 0x000C3208
			// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x00012C30 File Offset: 0x00010E30
			public unsafe string uri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_uri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EF9 RID: 3833
			// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x000C5030 File Offset: 0x000C3230
			// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x00012C4F File Offset: 0x00010E4F
			public unsafe int scopeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_scopeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_scopeId)) = value;
				}
			}

			// Token: 0x17000EFA RID: 3834
			// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x000C5058 File Offset: 0x000C3258
			// (set) Token: 0x06002BE7 RID: 11239 RVA: 0x00012C6A File Offset: 0x00010E6A
			public unsafe int previousNsIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_previousNsIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamespaceManager.NamespaceDeclaration.NativeFieldInfoPtr_previousNsIndex)) = value;
				}
			}

			// Token: 0x0400224C RID: 8780
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x0400224D RID: 8781
			private static readonly IntPtr NativeFieldInfoPtr_uri;

			// Token: 0x0400224E RID: 8782
			private static readonly IntPtr NativeFieldInfoPtr_scopeId;

			// Token: 0x0400224F RID: 8783
			private static readonly IntPtr NativeFieldInfoPtr_previousNsIndex;

			// Token: 0x04002250 RID: 8784
			private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_String_Int32_Int32_0;
		}
	}
}
