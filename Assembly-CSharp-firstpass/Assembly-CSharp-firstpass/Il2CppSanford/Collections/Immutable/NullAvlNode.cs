using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001DC RID: 476
	public class NullAvlNode : Object
	{
		// Token: 0x06001806 RID: 6150 RVA: 0x0006BF58 File Offset: 0x0006A158
		// Note: this type is marked as 'beforefieldinit'.
		static NullAvlNode()
		{
			Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "NullAvlNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr);
			NullAvlNode.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666781);
			NullAvlNode.NativeMethodInfoPtr_Balance_Public_Virtual_Final_New_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666782);
			NullAvlNode.NativeMethodInfoPtr_IsBalanced_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666783);
			NullAvlNode.NativeMethodInfoPtr_get_BalanceFactor_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666784);
			NullAvlNode.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666785);
			NullAvlNode.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666786);
			NullAvlNode.NativeMethodInfoPtr_get_Height_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666787);
			NullAvlNode.NativeMethodInfoPtr_get_LeftChild_Public_Virtual_Final_New_get_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666788);
			NullAvlNode.NativeMethodInfoPtr_get_RightChild_Public_Virtual_Final_New_get_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666789);
			NullAvlNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr, 100666790);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0006C050 File Offset: 0x0006A250
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAvlNode Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0006C090 File Offset: 0x0006A290
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAvlNode Balance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr_Balance_Public_Virtual_Final_New_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x0006C0D0 File Offset: 0x0006A2D0
		[CallerCount(0)]
		public unsafe virtual bool IsBalanced()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr_IsBalanced_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x0006C10C File Offset: 0x0006A30C
		public unsafe virtual int BalanceFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr_get_BalanceFactor_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x0006C148 File Offset: 0x0006A348
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0006C184 File Offset: 0x0006A384
		public unsafe virtual Object Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x0006C1C4 File Offset: 0x0006A3C4
		public unsafe virtual int Height
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr_get_Height_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0006C200 File Offset: 0x0006A400
		public unsafe virtual IAvlNode LeftChild
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr_get_LeftChild_Public_Virtual_Final_New_get_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x0006C240 File Offset: 0x0006A440
		public unsafe virtual IAvlNode RightChild
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr_get_RightChild_Public_Virtual_Final_New_get_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0006C280 File Offset: 0x0006A480
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullAvlNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullAvlNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullAvlNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0000999D File Offset: 0x00007B9D
		public NullAvlNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_IAvlNode_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr_Balance_Public_Virtual_Final_New_IAvlNode_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_IsBalanced_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_get_BalanceFactor_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftChild_Public_Virtual_Final_New_get_IAvlNode_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_get_RightChild_Public_Virtual_Final_New_get_IAvlNode_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
