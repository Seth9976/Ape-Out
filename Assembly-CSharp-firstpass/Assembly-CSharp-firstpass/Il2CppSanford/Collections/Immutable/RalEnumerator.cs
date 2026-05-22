using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001DF RID: 479
	public class RalEnumerator : Object
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x0006CF5C File Offset: 0x0006B15C
		// Note: this type is marked as 'beforefieldinit'.
		static RalEnumerator()
		{
			Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "RalEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr);
			RalEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, "current");
			RalEnumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, "index");
			RalEnumerator.NativeFieldInfoPtr_treeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, "treeStack");
			RalEnumerator.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, "head");
			RalEnumerator.NativeFieldInfoPtr_currentTopNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, "currentTopNode");
			RalEnumerator.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, "count");
			RalEnumerator.NativeMethodInfoPtr__ctor_Public_Void_RalTopNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, 100666819);
			RalEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, 100666820);
			RalEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, 100666821);
			RalEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr, 100666822);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0006D054 File Offset: 0x0006B254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19781, RefRangeEnd = 19783, XrefRangeStart = 19777, XrefRangeEnd = 19781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RalEnumerator(RalTopNode head, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RalEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(head);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalEnumerator.NativeMethodInfoPtr__ctor_Public_Void_RalTopNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0006D0B0 File Offset: 0x0006B2B0
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x0006D0E4 File Offset: 0x0006B2E4
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0006D124 File Offset: 0x0006B324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19783, XrefRangeEnd = 19789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00009A5A File Offset: 0x00007C5A
		public RalEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x0006D160 File Offset: 0x0006B360
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x00009A63 File Offset: 0x00007C63
		public unsafe Object current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0006D190 File Offset: 0x0006B390
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x00009A82 File Offset: 0x00007C82
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x0006D1B8 File Offset: 0x0006B3B8
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x00009A9D File Offset: 0x00007C9D
		public unsafe Stack treeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_treeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_treeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x0006D1E8 File Offset: 0x0006B3E8
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x00009ABC File Offset: 0x00007CBC
		public unsafe RalTopNode head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RalTopNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x0006D218 File Offset: 0x0006B418
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x00009ADB File Offset: 0x00007CDB
		public unsafe RalTopNode currentTopNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_currentTopNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RalTopNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_currentTopNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x0006D248 File Offset: 0x0006B448
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x00009AFA File Offset: 0x00007CFA
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalEnumerator.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeFieldInfoPtr_treeStack;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeFieldInfoPtr_currentTopNode;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RalTopNode_Int32_0;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
	}
}
