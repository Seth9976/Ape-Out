using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000107 RID: 263
	public class SymbolsDictionary : Object
	{
		// Token: 0x060015D5 RID: 5589 RVA: 0x0007016C File Offset: 0x0006E36C
		// Note: this type is marked as 'beforefieldinit'.
		static SymbolsDictionary()
		{
			Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SymbolsDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr);
			SymbolsDictionary.NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "last");
			SymbolsDictionary.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "names");
			SymbolsDictionary.NativeFieldInfoPtr_wildcards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "wildcards");
			SymbolsDictionary.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "particles");
			SymbolsDictionary.NativeFieldInfoPtr_particleLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "particleLast");
			SymbolsDictionary.NativeFieldInfoPtr_isUpaEnforced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, "isUpaEnforced");
			SymbolsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666596);
			SymbolsDictionary.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666597);
			SymbolsDictionary.NativeMethodInfoPtr_get_IsUpaEnforced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666598);
			SymbolsDictionary.NativeMethodInfoPtr_set_IsUpaEnforced_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666599);
			SymbolsDictionary.NativeMethodInfoPtr_AddName_Public_Int32_XmlQualifiedName_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666600);
			SymbolsDictionary.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666601);
			SymbolsDictionary.NativeMethodInfoPtr_AddWildcard_Private_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666602);
			SymbolsDictionary.NativeMethodInfoPtr_GetNamespaceListSymbols_Public_ICollection_NamespaceList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666603);
			SymbolsDictionary.NativeMethodInfoPtr_get_Item_Public_get_Int32_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666604);
			SymbolsDictionary.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666605);
			SymbolsDictionary.NativeMethodInfoPtr_GetParticle_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666606);
			SymbolsDictionary.NativeMethodInfoPtr_NameOf_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr, 100666607);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00070304 File Offset: 0x0006E504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409206, XrefRangeEnd = 409214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolsDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymbolsDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x00070340 File Offset: 0x0006E540
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x0007037C File Offset: 0x0006E57C
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x000703B8 File Offset: 0x0006E5B8
		public unsafe bool IsUpaEnforced
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_get_IsUpaEnforced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_set_IsUpaEnforced_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x000703F8 File Offset: 0x0006E5F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409217, RefRangeEnd = 409219, XrefRangeStart = 409214, XrefRangeEnd = 409217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddName(XmlQualifiedName name, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_AddName_Public_Int32_XmlQualifiedName_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00070458 File Offset: 0x0006E658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409243, RefRangeEnd = 409244, XrefRangeStart = 409219, XrefRangeEnd = 409243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespaceList(NamespaceList list, Object particle, bool allowLocal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLocal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000704BC File Offset: 0x0006E6BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 409250, RefRangeEnd = 409253, XrefRangeStart = 409244, XrefRangeEnd = 409250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWildcard(string wildcard, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(wildcard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_AddWildcard_Private_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00070510 File Offset: 0x0006E710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409295, RefRangeEnd = 409296, XrefRangeStart = 409253, XrefRangeEnd = 409295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ICollection GetNamespaceListSymbols(NamespaceList list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_GetNamespaceListSymbols_Public_ICollection_NamespaceList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700075E RID: 1886
		public unsafe int this[XmlQualifiedName name]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 409298, RefRangeEnd = 409301, XrefRangeStart = 409296, XrefRangeEnd = 409298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_get_Item_Public_get_Int32_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x000705B0 File Offset: 0x0006E7B0
		[CallerCount(0)]
		public unsafe bool Exists(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00070600 File Offset: 0x0006E800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409301, RefRangeEnd = 409303, XrefRangeStart = 409301, XrefRangeEnd = 409301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetParticle(int symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_GetParticle_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0007064C File Offset: 0x0006E84C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 409339, RefRangeEnd = 409342, XrefRangeStart = 409303, XrefRangeEnd = 409339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NameOf(int symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref symbol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolsDictionary.NativeMethodInfoPtr_NameOf_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00009C3F File Offset: 0x00007E3F
		public SymbolsDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00070690 File Offset: 0x0006E890
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00009C48 File Offset: 0x00007E48
		public unsafe int last
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_last);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_last)) = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x000706B8 File Offset: 0x0006E8B8
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x00009C63 File Offset: 0x00007E63
		public unsafe Hashtable names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x000706E8 File Offset: 0x0006E8E8
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x00009C82 File Offset: 0x00007E82
		public unsafe Hashtable wildcards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_wildcards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_wildcards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x00070718 File Offset: 0x0006E918
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x00009CA1 File Offset: 0x00007EA1
		public unsafe ArrayList particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00070748 File Offset: 0x0006E948
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00009CC0 File Offset: 0x00007EC0
		public unsafe Object particleLast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particleLast);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_particleLast), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x00070778 File Offset: 0x0006E978
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x00009CDF File Offset: 0x00007EDF
		public unsafe bool isUpaEnforced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_isUpaEnforced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolsDictionary.NativeFieldInfoPtr_isUpaEnforced)) = value;
			}
		}

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeFieldInfoPtr_last;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeFieldInfoPtr_wildcards;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeFieldInfoPtr_particleLast;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeFieldInfoPtr_isUpaEnforced;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUpaEnforced_Public_get_Boolean_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUpaEnforced_Public_set_Void_Boolean_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Public_Int32_XmlQualifiedName_Object_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_Boolean_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_AddWildcard_Private_Void_String_Object_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespaceListSymbols_Public_ICollection_NamespaceList_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_XmlQualifiedName_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_GetParticle_Public_Object_Int32_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_NameOf_Public_String_Int32_0;
	}
}
