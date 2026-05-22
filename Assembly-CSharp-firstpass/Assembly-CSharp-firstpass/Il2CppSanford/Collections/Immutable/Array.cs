using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001DD RID: 477
	public class Array : Object
	{
		// Token: 0x06001812 RID: 6162 RVA: 0x0006C2BC File Offset: 0x0006A4BC
		// Note: this type is marked as 'beforefieldinit'.
		static Array()
		{
			Il2CppClassPointerStore<Array>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "Array");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array>.NativeClassPtr);
			Array.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array>.NativeClassPtr, "length");
			Array.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array>.NativeClassPtr, "head");
			Array.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666791);
			Array.NativeMethodInfoPtr__ctor_Private_Void_RalTopNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666792);
			Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666793);
			Array.NativeMethodInfoPtr_SetValue_Public_Array_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666794);
			Array.NativeMethodInfoPtr_CreateSubTree_Private_RalTreeNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666795);
			Array.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666796);
			Array.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Array>.NativeClassPtr, 100666797);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0006C3A0 File Offset: 0x0006A5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19445, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array(int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0006C3E8 File Offset: 0x0006A5E8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 19461, RefRangeEnd = 19470, XrefRangeStart = 19461, XrefRangeEnd = 19461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array(RalTopNode head, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Array>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(head);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr__ctor_Private_Void_RalTopNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0006C444 File Offset: 0x0006A644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19470, XrefRangeEnd = 19478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x0006C490 File Offset: 0x0006A690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19478, XrefRangeEnd = 19482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array SetValue(Object value, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_SetValue_Public_Array_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x0006C4F0 File Offset: 0x0006A6F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19488, RefRangeEnd = 19492, XrefRangeStart = 19482, XrefRangeEnd = 19488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RalTreeNode CreateSubTree(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_CreateSubTree_Private_RalTreeNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RalTreeNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x0006C53C File Offset: 0x0006A73C
		public unsafe int Length
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0006C578 File Offset: 0x0006A778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19492, XrefRangeEnd = 19496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Array.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x000099A6 File Offset: 0x00007BA6
		public Array(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x0006C5B8 File Offset: 0x0006A7B8
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x000099AF File Offset: 0x00007BAF
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x0006C5E0 File Offset: 0x0006A7E0
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x000099CA File Offset: 0x00007BCA
		public unsafe RalTopNode head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RalTopNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Array.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_RalTopNode_Int32_0;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_0;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Array_Object_Int32_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubTree_Private_RalTreeNode_Int32_0;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;
	}
}
