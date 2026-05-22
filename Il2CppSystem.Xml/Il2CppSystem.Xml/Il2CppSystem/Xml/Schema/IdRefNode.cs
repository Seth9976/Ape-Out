using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D7 RID: 471
	public class IdRefNode : Object
	{
		// Token: 0x06002526 RID: 9510 RVA: 0x000AB1EC File Offset: 0x000A93EC
		// Note: this type is marked as 'beforefieldinit'.
		static IdRefNode()
		{
			Il2CppClassPointerStore<IdRefNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "IdRefNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr);
			IdRefNode.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, "Id");
			IdRefNode.NativeFieldInfoPtr_LineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, "LineNo");
			IdRefNode.NativeFieldInfoPtr_LinePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, "LinePos");
			IdRefNode.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, "Next");
			IdRefNode.NativeMethodInfoPtr__ctor_Internal_Void_IdRefNode_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr, 100668583);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x000AB280 File Offset: 0x000A9480
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 429412, RefRangeEnd = 429415, XrefRangeStart = 429412, XrefRangeEnd = 429412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdRefNode(IdRefNode next, string id, int lineNo, int linePos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdRefNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdRefNode.NativeMethodInfoPtr__ctor_Internal_Void_IdRefNode_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000101E0 File Offset: 0x0000E3E0
		public IdRefNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x000AB2FC File Offset: 0x000A94FC
		// (set) Token: 0x0600252A RID: 9514 RVA: 0x000101E9 File Offset: 0x0000E3E9
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x000AB324 File Offset: 0x000A9524
		// (set) Token: 0x0600252C RID: 9516 RVA: 0x00010208 File Offset: 0x0000E408
		public unsafe int LineNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_LineNo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_LineNo)) = value;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x000AB34C File Offset: 0x000A954C
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x00010223 File Offset: 0x0000E423
		public unsafe int LinePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_LinePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_LinePos)) = value;
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x000AB374 File Offset: 0x000A9574
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x0001023E File Offset: 0x0000E43E
		public unsafe IdRefNode Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdRefNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdRefNode.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeFieldInfoPtr_LineNo;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeFieldInfoPtr_LinePos;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IdRefNode_String_Int32_Int32_0;
	}
}
