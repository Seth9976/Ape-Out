using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000FF RID: 255
	public class CompiledIdentityConstraint : Object
	{
		// Token: 0x0600155A RID: 5466 RVA: 0x0006E90C File Offset: 0x0006CB0C
		// Note: this type is marked as 'beforefieldinit'.
		static CompiledIdentityConstraint()
		{
			Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "CompiledIdentityConstraint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr);
			CompiledIdentityConstraint.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "name");
			CompiledIdentityConstraint.NativeFieldInfoPtr_role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "role");
			CompiledIdentityConstraint.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "selector");
			CompiledIdentityConstraint.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "fields");
			CompiledIdentityConstraint.NativeFieldInfoPtr_refer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "refer");
			CompiledIdentityConstraint.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, "Empty");
			CompiledIdentityConstraint.NativeMethodInfoPtr_get_Role_Public_get_ConstraintRole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100666551);
			CompiledIdentityConstraint.NativeMethodInfoPtr_get_Selector_Public_get_Asttree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100666552);
			CompiledIdentityConstraint.NativeMethodInfoPtr_get_Fields_Public_get_Il2CppReferenceArray_1_Asttree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100666553);
			CompiledIdentityConstraint.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100666554);
			CompiledIdentityConstraint.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaIdentityConstraint_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr, 100666555);
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600155B RID: 5467 RVA: 0x0006EA18 File Offset: 0x0006CC18
		public unsafe CompiledIdentityConstraint.ConstraintRole Role
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr_get_Role_Public_get_ConstraintRole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x0006EA54 File Offset: 0x0006CC54
		public unsafe Asttree Selector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr_get_Selector_Public_get_Asttree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Asttree>(intPtr3) : null;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x0006EA94 File Offset: 0x0006CC94
		public unsafe Il2CppReferenceArray<Asttree> Fields
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr_get_Fields_Public_get_Il2CppReferenceArray_1_Asttree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Asttree>>(intPtr3) : null;
			}
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0006EAD4 File Offset: 0x0006CCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409001, XrefRangeEnd = 409006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompiledIdentityConstraint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0006EB10 File Offset: 0x0006CD10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409031, RefRangeEnd = 409033, XrefRangeStart = 409006, XrefRangeEnd = 409031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompiledIdentityConstraint(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompiledIdentityConstraint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompiledIdentityConstraint.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaIdentityConstraint_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00009816 File Offset: 0x00007A16
		public CompiledIdentityConstraint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x0006EB70 File Offset: 0x0006CD70
		// (set) Token: 0x06001562 RID: 5474 RVA: 0x0000981F File Offset: 0x00007A1F
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x0006EBA0 File Offset: 0x0006CDA0
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x0000983E File Offset: 0x00007A3E
		public unsafe CompiledIdentityConstraint.ConstraintRole role
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_role);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_role)) = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x0006EBC8 File Offset: 0x0006CDC8
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x00009859 File Offset: 0x00007A59
		public unsafe Asttree selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Asttree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x0006EBF8 File Offset: 0x0006CDF8
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x00009878 File Offset: 0x00007A78
		public unsafe Il2CppReferenceArray<Asttree> fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Asttree>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x0006EC28 File Offset: 0x0006CE28
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x00009897 File Offset: 0x00007A97
		public unsafe XmlQualifiedName refer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_refer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompiledIdentityConstraint.NativeFieldInfoPtr_refer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x0006EC58 File Offset: 0x0006CE58
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x000098B6 File Offset: 0x00007AB6
		public unsafe static CompiledIdentityConstraint Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompiledIdentityConstraint.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompiledIdentityConstraint>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompiledIdentityConstraint.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeFieldInfoPtr_role;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeFieldInfoPtr_selector;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeFieldInfoPtr_fields;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeFieldInfoPtr_refer;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_get_Role_Public_get_ConstraintRole_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_get_Selector_Public_get_Asttree_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_Il2CppReferenceArray_1_Asttree_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaIdentityConstraint_XmlNamespaceManager_0;

		// Token: 0x0200022D RID: 557
		[OriginalName("System.Xml.dll", "", "ConstraintRole")]
		public enum ConstraintRole
		{
			// Token: 0x04002277 RID: 8823
			Unique,
			// Token: 0x04002278 RID: 8824
			Key,
			// Token: 0x04002279 RID: 8825
			Keyref
		}
	}
}
