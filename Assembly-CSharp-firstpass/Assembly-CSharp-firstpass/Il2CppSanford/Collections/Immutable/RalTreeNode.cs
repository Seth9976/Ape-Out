using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001E1 RID: 481
	public class RalTreeNode : Object
	{
		// Token: 0x0600185C RID: 6236 RVA: 0x0006D518 File Offset: 0x0006B718
		// Note: this type is marked as 'beforefieldinit'.
		static RalTreeNode()
		{
			Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "RalTreeNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr);
			RalTreeNode.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, "value");
			RalTreeNode.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, "count");
			RalTreeNode.NativeFieldInfoPtr_leftChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, "leftChild");
			RalTreeNode.NativeFieldInfoPtr_rightChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, "rightChild");
			RalTreeNode.NativeMethodInfoPtr__ctor_Public_Void_Object_RalTreeNode_RalTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, 100666828);
			RalTreeNode.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, 100666829);
			RalTreeNode.NativeMethodInfoPtr_GetValue_Private_Object_Int32_RalTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, 100666830);
			RalTreeNode.NativeMethodInfoPtr_SetValue_Public_RalTreeNode_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, 100666831);
			RalTreeNode.NativeMethodInfoPtr_SetValue_Private_RalTreeNode_Object_Int32_RalTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, 100666832);
			RalTreeNode.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, 100666833);
			RalTreeNode.NativeMethodInfoPtr_get_LeftChild_Public_get_RalTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, 100666834);
			RalTreeNode.NativeMethodInfoPtr_get_RightChild_Public_get_RalTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, 100666835);
			RalTreeNode.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr, 100666836);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0006D64C File Offset: 0x0006B84C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 19880, RefRangeEnd = 19887, XrefRangeStart = 19880, XrefRangeEnd = 19880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RalTreeNode(Object value, RalTreeNode leftChild, RalTreeNode rightChild)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RalTreeNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(leftChild);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTreeNode.NativeMethodInfoPtr__ctor_Public_Void_Object_RalTreeNode_RalTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0006D6BC File Offset: 0x0006B8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19887, XrefRangeEnd = 19889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTreeNode.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0006D708 File Offset: 0x0006B908
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 19891, RefRangeEnd = 19897, XrefRangeStart = 19889, XrefRangeEnd = 19891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index, RalTreeNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTreeNode.NativeMethodInfoPtr_GetValue_Private_Object_Int32_RalTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0006D768 File Offset: 0x0006B968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19905, RefRangeEnd = 19908, XrefRangeStart = 19897, XrefRangeEnd = 19905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RalTreeNode SetValue(Object value, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTreeNode.NativeMethodInfoPtr_SetValue_Public_RalTreeNode_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RalTreeNode>(intPtr3) : null;
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0006D7C8 File Offset: 0x0006B9C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19916, RefRangeEnd = 19918, XrefRangeStart = 19908, XrefRangeEnd = 19916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RalTreeNode SetValue(Object value, int index, RalTreeNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTreeNode.NativeMethodInfoPtr_SetValue_Private_RalTreeNode_Object_Int32_RalTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RalTreeNode>(intPtr3) : null;
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x0006D838 File Offset: 0x0006BA38
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTreeNode.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x0006D874 File Offset: 0x0006BA74
		public unsafe RalTreeNode LeftChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTreeNode.NativeMethodInfoPtr_get_LeftChild_Public_get_RalTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RalTreeNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x0006D8B4 File Offset: 0x0006BAB4
		public unsafe RalTreeNode RightChild
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 13519, RefRangeEnd = 13522, XrefRangeStart = 13519, XrefRangeEnd = 13522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTreeNode.NativeMethodInfoPtr_get_RightChild_Public_get_RalTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RalTreeNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x0006D8F4 File Offset: 0x0006BAF4
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RalTreeNode.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00009B5C File Offset: 0x00007D5C
		public RalTreeNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x0006D934 File Offset: 0x0006BB34
		// (set) Token: 0x06001868 RID: 6248 RVA: 0x00009B65 File Offset: 0x00007D65
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTreeNode.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTreeNode.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x0006D964 File Offset: 0x0006BB64
		// (set) Token: 0x0600186A RID: 6250 RVA: 0x00009B84 File Offset: 0x00007D84
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTreeNode.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTreeNode.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x0006D98C File Offset: 0x0006BB8C
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x00009B9F File Offset: 0x00007D9F
		public unsafe RalTreeNode leftChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTreeNode.NativeFieldInfoPtr_leftChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RalTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTreeNode.NativeFieldInfoPtr_leftChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x0006D9BC File Offset: 0x0006BBBC
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x00009BBE File Offset: 0x00007DBE
		public unsafe RalTreeNode rightChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTreeNode.NativeFieldInfoPtr_rightChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RalTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RalTreeNode.NativeFieldInfoPtr_rightChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeFieldInfoPtr_leftChild;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeFieldInfoPtr_rightChild;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_RalTreeNode_RalTreeNode_0;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_0;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Private_Object_Int32_RalTreeNode_0;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_RalTreeNode_Object_Int32_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Private_RalTreeNode_Object_Int32_RalTreeNode_0;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftChild_Public_get_RalTreeNode_0;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeMethodInfoPtr_get_RightChild_Public_get_RalTreeNode_0;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;
	}
}
