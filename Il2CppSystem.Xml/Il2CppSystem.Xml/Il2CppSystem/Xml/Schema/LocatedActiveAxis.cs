using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000101 RID: 257
	public class LocatedActiveAxis : ActiveAxis
	{
		// Token: 0x0600157D RID: 5501 RVA: 0x0006EEF0 File Offset: 0x0006D0F0
		// Note: this type is marked as 'beforefieldinit'.
		static LocatedActiveAxis()
		{
			Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "LocatedActiveAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr);
			LocatedActiveAxis.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, "column");
			LocatedActiveAxis.NativeFieldInfoPtr_isMatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, "isMatched");
			LocatedActiveAxis.NativeFieldInfoPtr_Ks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, "Ks");
			LocatedActiveAxis.NativeMethodInfoPtr_get_Column_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, 100666559);
			LocatedActiveAxis.NativeMethodInfoPtr__ctor_Internal_Void_Asttree_KeySequence_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, 100666560);
			LocatedActiveAxis.NativeMethodInfoPtr_Reactivate_Internal_Void_KeySequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, 100666561);
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0006EF98 File Offset: 0x0006D198
		public unsafe int Column
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocatedActiveAxis.NativeMethodInfoPtr_get_Column_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0006EFD4 File Offset: 0x0006D1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409051, XrefRangeEnd = 409052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocatedActiveAxis(Asttree astfield, KeySequence ks, int column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(astfield);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ks);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocatedActiveAxis.NativeMethodInfoPtr__ctor_Internal_Void_Asttree_KeySequence_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0006F040 File Offset: 0x0006D240
		[CallerCount(0)]
		public unsafe void Reactivate(KeySequence ks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocatedActiveAxis.NativeMethodInfoPtr_Reactivate_Internal_Void_KeySequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00009987 File Offset: 0x00007B87
		public LocatedActiveAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x0006F084 File Offset: 0x0006D284
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x00009990 File Offset: 0x00007B90
		public unsafe int column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_column);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_column)) = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x0006F0AC File Offset: 0x0006D2AC
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x000099AB File Offset: 0x00007BAB
		public unsafe bool isMatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_isMatched);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_isMatched)) = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x0006F0D4 File Offset: 0x0006D2D4
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x000099C6 File Offset: 0x00007BC6
		public unsafe KeySequence Ks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_Ks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeySequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_Ks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeFieldInfoPtr_column;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeFieldInfoPtr_isMatched;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeFieldInfoPtr_Ks;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_get_Column_Internal_get_Int32_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Asttree_KeySequence_Int32_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_Reactivate_Internal_Void_KeySequence_0;
	}
}
