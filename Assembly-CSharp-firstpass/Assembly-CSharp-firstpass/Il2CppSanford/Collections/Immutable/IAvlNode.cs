using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001DB RID: 475
	public class IAvlNode : Il2CppObjectBase
	{
		// Token: 0x060017FB RID: 6139 RVA: 0x0006BBE0 File Offset: 0x00069DE0
		// Note: this type is marked as 'beforefieldinit'.
		static IAvlNode()
		{
			Il2CppClassPointerStore<IAvlNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "IAvlNode");
			IAvlNode.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAvlNode>.NativeClassPtr, 100666772);
			IAvlNode.NativeMethodInfoPtr_Balance_Public_Abstract_Virtual_New_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAvlNode>.NativeClassPtr, 100666773);
			IAvlNode.NativeMethodInfoPtr_IsBalanced_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAvlNode>.NativeClassPtr, 100666774);
			IAvlNode.NativeMethodInfoPtr_get_BalanceFactor_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAvlNode>.NativeClassPtr, 100666775);
			IAvlNode.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAvlNode>.NativeClassPtr, 100666776);
			IAvlNode.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAvlNode>.NativeClassPtr, 100666777);
			IAvlNode.NativeMethodInfoPtr_get_Height_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAvlNode>.NativeClassPtr, 100666778);
			IAvlNode.NativeMethodInfoPtr_get_LeftChild_Public_Abstract_Virtual_New_get_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAvlNode>.NativeClassPtr, 100666779);
			IAvlNode.NativeMethodInfoPtr_get_RightChild_Public_Abstract_Virtual_New_get_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAvlNode>.NativeClassPtr, 100666780);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0006BCBC File Offset: 0x00069EBC
		[CallerCount(0)]
		public unsafe virtual IAvlNode Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAvlNode.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_IAvlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0006BD08 File Offset: 0x00069F08
		[CallerCount(0)]
		public unsafe virtual IAvlNode Balance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAvlNode.NativeMethodInfoPtr_Balance_Public_Abstract_Virtual_New_IAvlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0006BD54 File Offset: 0x00069F54
		[CallerCount(0)]
		public unsafe virtual bool IsBalanced()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAvlNode.NativeMethodInfoPtr_IsBalanced_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x0006BD9C File Offset: 0x00069F9C
		public unsafe virtual int BalanceFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAvlNode.NativeMethodInfoPtr_get_BalanceFactor_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x0006BDE4 File Offset: 0x00069FE4
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAvlNode.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x0006BE2C File Offset: 0x0006A02C
		public unsafe virtual Object Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAvlNode.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0006BE78 File Offset: 0x0006A078
		public unsafe virtual int Height
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAvlNode.NativeMethodInfoPtr_get_Height_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x0006BEC0 File Offset: 0x0006A0C0
		public unsafe virtual IAvlNode LeftChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAvlNode.NativeMethodInfoPtr_get_LeftChild_Public_Abstract_Virtual_New_get_IAvlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x0006BF0C File Offset: 0x0006A10C
		public unsafe virtual IAvlNode RightChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAvlNode.NativeMethodInfoPtr_get_RightChild_Public_Abstract_Virtual_New_get_IAvlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00009994 File Offset: 0x00007B94
		public IAvlNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_IAvlNode_0;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeMethodInfoPtr_Balance_Public_Abstract_Virtual_New_IAvlNode_0;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeMethodInfoPtr_IsBalanced_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeMethodInfoPtr_get_BalanceFactor_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftChild_Public_Abstract_Virtual_New_get_IAvlNode_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr_get_RightChild_Public_Abstract_Virtual_New_get_IAvlNode_0;
	}
}
