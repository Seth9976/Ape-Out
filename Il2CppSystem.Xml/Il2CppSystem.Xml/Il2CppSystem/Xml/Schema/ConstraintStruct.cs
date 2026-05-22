using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000100 RID: 256
	public sealed class ConstraintStruct : Object
	{
		// Token: 0x0600156D RID: 5485 RVA: 0x0006EC80 File Offset: 0x0006CE80
		// Note: this type is marked as 'beforefieldinit'.
		static ConstraintStruct()
		{
			Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ConstraintStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr);
			ConstraintStruct.NativeFieldInfoPtr_constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "constraint");
			ConstraintStruct.NativeFieldInfoPtr_axisSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "axisSelector");
			ConstraintStruct.NativeFieldInfoPtr_axisFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "axisFields");
			ConstraintStruct.NativeFieldInfoPtr_qualifiedTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "qualifiedTable");
			ConstraintStruct.NativeFieldInfoPtr_keyrefTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "keyrefTable");
			ConstraintStruct.NativeFieldInfoPtr_tableDim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "tableDim");
			ConstraintStruct.NativeMethodInfoPtr_get_TableDim_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, 100666557);
			ConstraintStruct.NativeMethodInfoPtr__ctor_Internal_Void_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, 100666558);
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x0006ED50 File Offset: 0x0006CF50
		public unsafe int TableDim
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintStruct.NativeMethodInfoPtr_get_TableDim_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0006ED8C File Offset: 0x0006CF8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409049, RefRangeEnd = 409051, XrefRangeStart = 409033, XrefRangeEnd = 409049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintStruct(CompiledIdentityConstraint constraint)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintStruct.NativeMethodInfoPtr__ctor_Internal_Void_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x000098C8 File Offset: 0x00007AC8
		public ConstraintStruct(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0006EDD8 File Offset: 0x0006CFD8
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x000098D1 File Offset: 0x00007AD1
		public unsafe CompiledIdentityConstraint constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompiledIdentityConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0006EE08 File Offset: 0x0006D008
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x000098F0 File Offset: 0x00007AF0
		public unsafe SelectorActiveAxis axisSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_axisSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectorActiveAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_axisSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0006EE38 File Offset: 0x0006D038
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x0000990F File Offset: 0x00007B0F
		public unsafe ArrayList axisFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_axisFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_axisFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0006EE68 File Offset: 0x0006D068
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x0000992E File Offset: 0x00007B2E
		public unsafe Hashtable qualifiedTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_qualifiedTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_qualifiedTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x0006EE98 File Offset: 0x0006D098
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x0000994D File Offset: 0x00007B4D
		public unsafe Hashtable keyrefTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_keyrefTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_keyrefTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0006EEC8 File Offset: 0x0006D0C8
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x0000996C File Offset: 0x00007B6C
		public unsafe int tableDim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_tableDim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_tableDim)) = value;
			}
		}

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeFieldInfoPtr_constraint;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeFieldInfoPtr_axisSelector;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeFieldInfoPtr_axisFields;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeFieldInfoPtr_qualifiedTable;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeFieldInfoPtr_keyrefTable;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeFieldInfoPtr_tableDim;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_get_TableDim_Internal_get_Int32_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CompiledIdentityConstraint_0;
	}
}
