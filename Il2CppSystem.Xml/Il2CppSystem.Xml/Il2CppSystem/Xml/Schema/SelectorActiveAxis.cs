using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000102 RID: 258
	public class SelectorActiveAxis : ActiveAxis
	{
		// Token: 0x06001588 RID: 5512 RVA: 0x0006F104 File Offset: 0x0006D304
		// Note: this type is marked as 'beforefieldinit'.
		static SelectorActiveAxis()
		{
			Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SelectorActiveAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr);
			SelectorActiveAxis.NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, "cs");
			SelectorActiveAxis.NativeFieldInfoPtr_KSs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, "KSs");
			SelectorActiveAxis.NativeFieldInfoPtr_KSpointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, "KSpointer");
			SelectorActiveAxis.NativeMethodInfoPtr_get_lastDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100666562);
			SelectorActiveAxis.NativeMethodInfoPtr__ctor_Public_Void_Asttree_ConstraintStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100666563);
			SelectorActiveAxis.NativeMethodInfoPtr_EndElement_Public_Virtual_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100666564);
			SelectorActiveAxis.NativeMethodInfoPtr_PushKS_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100666565);
			SelectorActiveAxis.NativeMethodInfoPtr_PopKS_Public_KeySequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr, 100666566);
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x0006F1D4 File Offset: 0x0006D3D4
		public unsafe int lastDepth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409052, XrefRangeEnd = 409053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorActiveAxis.NativeMethodInfoPtr_get_lastDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0006F210 File Offset: 0x0006D410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409053, XrefRangeEnd = 409058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectorActiveAxis(Asttree axisTree, ConstraintStruct cs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectorActiveAxis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisTree);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorActiveAxis.NativeMethodInfoPtr__ctor_Public_Void_Asttree_ConstraintStruct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0006F270 File Offset: 0x0006D470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409058, XrefRangeEnd = 409066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool EndElement(string localname, string URN)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(URN);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectorActiveAxis.NativeMethodInfoPtr_EndElement_Public_Virtual_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0006F2DC File Offset: 0x0006D4DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409087, RefRangeEnd = 409089, XrefRangeStart = 409066, XrefRangeEnd = 409087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PushKS(int errline, int errcol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errline;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errcol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorActiveAxis.NativeMethodInfoPtr_PushKS_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0006F334 File Offset: 0x0006D534
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409091, RefRangeEnd = 409093, XrefRangeStart = 409089, XrefRangeEnd = 409091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeySequence PopKS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorActiveAxis.NativeMethodInfoPtr_PopKS_Public_KeySequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeySequence>(intPtr3) : null;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000099E5 File Offset: 0x00007BE5
		public SelectorActiveAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x0006F374 File Offset: 0x0006D574
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x000099EE File Offset: 0x00007BEE
		public unsafe ConstraintStruct cs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_cs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstraintStruct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_cs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x0006F3A4 File Offset: 0x0006D5A4
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x00009A0D File Offset: 0x00007C0D
		public unsafe ArrayList KSs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_KSs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_KSs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x0006F3D4 File Offset: 0x0006D5D4
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00009A2C File Offset: 0x00007C2C
		public unsafe int KSpointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_KSpointer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorActiveAxis.NativeFieldInfoPtr_KSpointer)) = value;
			}
		}

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeFieldInfoPtr_cs;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeFieldInfoPtr_KSs;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr_KSpointer;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeMethodInfoPtr_get_lastDepth_Public_get_Int32_0;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Asttree_ConstraintStruct_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr_EndElement_Public_Virtual_Boolean_String_String_0;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeMethodInfoPtr_PushKS_Public_Int32_Int32_Int32_0;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeMethodInfoPtr_PopKS_Public_KeySequence_0;
	}
}
