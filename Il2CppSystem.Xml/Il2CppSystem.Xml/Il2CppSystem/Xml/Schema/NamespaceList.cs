using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200016C RID: 364
	public class NamespaceList : Object
	{
		// Token: 0x06001AC8 RID: 6856 RVA: 0x000841E8 File Offset: 0x000823E8
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceList()
		{
			Il2CppClassPointerStore<NamespaceList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "NamespaceList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr);
			NamespaceList.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, "type");
			NamespaceList.NativeFieldInfoPtr_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, "set");
			NamespaceList.NativeFieldInfoPtr_targetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, "targetNamespace");
			NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667263);
			NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667264);
			NamespaceList.NativeMethodInfoPtr_Clone_Public_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667265);
			NamespaceList.NativeMethodInfoPtr_get_Type_Public_get_ListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667266);
			NamespaceList.NativeMethodInfoPtr_get_Excluded_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667267);
			NamespaceList.NativeMethodInfoPtr_get_Enumerate_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667268);
			NamespaceList.NativeMethodInfoPtr_Allows_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667269);
			NamespaceList.NativeMethodInfoPtr_Allows_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667270);
			NamespaceList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667271);
			NamespaceList.NativeMethodInfoPtr_IsSubset_Public_Static_Boolean_NamespaceList_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667272);
			NamespaceList.NativeMethodInfoPtr_Union_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667273);
			NamespaceList.NativeMethodInfoPtr_CompareSetToOther_Private_NamespaceList_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667274);
			NamespaceList.NativeMethodInfoPtr_Intersection_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667275);
			NamespaceList.NativeMethodInfoPtr_RemoveNamespace_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr, 100667276);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0008436C File Offset: 0x0008256C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x000843A8 File Offset: 0x000825A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 413426, RefRangeEnd = 413430, XrefRangeStart = 413398, XrefRangeEnd = 413426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList(string namespaces, string targetNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceList>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaces);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00084408 File Offset: 0x00082608
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 413436, RefRangeEnd = 413442, XrefRangeStart = 413430, XrefRangeEnd = 413436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_Clone_Public_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x00084448 File Offset: 0x00082648
		public unsafe NamespaceList.ListType Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_get_Type_Public_get_ListType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x00084484 File Offset: 0x00082684
		public unsafe string Excluded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_get_Excluded_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x000844BC File Offset: 0x000826BC
		public unsafe ICollection Enumerate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 413448, RefRangeEnd = 413449, XrefRangeStart = 413442, XrefRangeEnd = 413448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_get_Enumerate_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x000844FC File Offset: 0x000826FC
		[CallerCount(0)]
		public unsafe virtual bool Allows(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceList.NativeMethodInfoPtr_Allows_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00084554 File Offset: 0x00082754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413449, XrefRangeEnd = 413450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Allows(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_Allows_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000845A4 File Offset: 0x000827A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413450, XrefRangeEnd = 413461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceList.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x000845E8 File Offset: 0x000827E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 413465, RefRangeEnd = 413470, XrefRangeStart = 413461, XrefRangeEnd = 413465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSubset(NamespaceList sub, NamespaceList super)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sub);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(super);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_IsSubset_Public_Static_Boolean_NamespaceList_NamespaceList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0008463C File Offset: 0x0008283C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413510, RefRangeEnd = 413511, XrefRangeStart = 413470, XrefRangeEnd = 413510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1Compat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_Union_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x000846A0 File Offset: 0x000828A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 413516, RefRangeEnd = 413518, XrefRangeStart = 413511, XrefRangeEnd = 413516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceList CompareSetToOther(NamespaceList other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_CompareSetToOther_Private_NamespaceList_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000846F0 File Offset: 0x000828F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 413546, RefRangeEnd = 413547, XrefRangeStart = 413518, XrefRangeEnd = 413546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v1Compat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_Intersection_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr3) : null;
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00084754 File Offset: 0x00082954
		[CallerCount(0)]
		public unsafe void RemoveNamespace(string tns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceList.NativeMethodInfoPtr_RemoveNamespace_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0000B537 File Offset: 0x00009737
		public NamespaceList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x00084798 File Offset: 0x00082998
		// (set) Token: 0x06001AD9 RID: 6873 RVA: 0x0000B540 File Offset: 0x00009740
		public unsafe NamespaceList.ListType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x000847C0 File Offset: 0x000829C0
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0000B55B File Offset: 0x0000975B
		public unsafe Hashtable set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_set);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_set), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x000847F0 File Offset: 0x000829F0
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0000B57A File Offset: 0x0000977A
		public unsafe string targetNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_targetNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceList.NativeFieldInfoPtr_targetNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeFieldInfoPtr_set;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespace;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_NamespaceList_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_ListType_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_get_Excluded_Public_get_String_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_get_Enumerate_Public_get_ICollection_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Public_Virtual_New_Boolean_String_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_Allows_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_IsSubset_Public_Static_Boolean_NamespaceList_NamespaceList_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_Union_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_CompareSetToOther_Private_NamespaceList_NamespaceList_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_Intersection_Public_Static_NamespaceList_NamespaceList_NamespaceList_Boolean_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNamespace_Private_Void_String_0;

		// Token: 0x02000233 RID: 563
		[OriginalName("System.Xml.dll", "", "ListType")]
		public enum ListType
		{
			// Token: 0x040022B6 RID: 8886
			Any,
			// Token: 0x040022B7 RID: 8887
			Other,
			// Token: 0x040022B8 RID: 8888
			Set
		}
	}
}
