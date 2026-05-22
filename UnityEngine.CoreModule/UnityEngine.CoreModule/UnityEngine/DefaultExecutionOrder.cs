using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000CC RID: 204
	public class DefaultExecutionOrder : Attribute
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x0004AE5C File Offset: 0x0004905C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultExecutionOrder()
		{
			Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DefaultExecutionOrder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr);
			DefaultExecutionOrder.NativeFieldInfoPtr_m_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, "m_Order");
			DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, 100664832);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x0004AEB4 File Offset: 0x000490B4
		public unsafe int order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0000AA42 File Offset: 0x00008C42
		public DefaultExecutionOrder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0004AEF0 File Offset: 0x000490F0
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x0000AA4B File Offset: 0x00008C4B
		public unsafe int m_Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order)) = value;
			}
		}

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeFieldInfoPtr_m_Order;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_get_order_Public_get_Int32_0;
	}
}
