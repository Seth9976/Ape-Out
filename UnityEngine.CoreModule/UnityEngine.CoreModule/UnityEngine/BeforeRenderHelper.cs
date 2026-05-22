using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine
{
	// Token: 0x0200005A RID: 90
	public static class BeforeRenderHelper : Object
	{
		// Token: 0x0600055C RID: 1372 RVA: 0x00023594 File Offset: 0x00021794
		// Note: this type is marked as 'beforefieldinit'.
		static BeforeRenderHelper()
		{
			Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BeforeRenderHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr);
			BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "s_OrderBlocks");
			BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, 100663753);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000235EC File Offset: 0x000217EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 487751, RefRangeEnd = 487752, XrefRangeStart = 487733, XrefRangeEnd = 487751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00004BC9 File Offset: 0x00002DC9
		public BeforeRenderHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00023614 File Offset: 0x00021814
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00004BD2 File Offset: 0x00002DD2
		public unsafe static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BeforeRenderHelper.OrderBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00004BE4 File Offset: 0x00002DE4
		public static int GetUpdateOrder(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00004BF1 File Offset: 0x00002DF1
		public static void RegisterCallback(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00004BFE File Offset: 0x00002DFE
		public static void UnregisterCallback(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_s_OrderBlocks;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_0;

		// Token: 0x02000430 RID: 1072
		public sealed class OrderBlock : ValueType
		{
			// Token: 0x06002689 RID: 9865 RVA: 0x0007B08C File Offset: 0x0007928C
			// Note: this type is marked as 'beforefieldinit'.
			static OrderBlock()
			{
				Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "OrderBlock");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr);
				BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, "order");
				BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, "callback");
			}

			// Token: 0x0600268A RID: 9866 RVA: 0x000136A0 File Offset: 0x000118A0
			public OrderBlock(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600268B RID: 9867 RVA: 0x000136A9 File Offset: 0x000118A9
			public OrderBlock()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr))
			{
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x0600268C RID: 9868 RVA: 0x0007B0E0 File Offset: 0x000792E0
			// (set) Token: 0x0600268D RID: 9869 RVA: 0x000136BB File Offset: 0x000118BB
			public unsafe int order
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order)) = value;
				}
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x0600268E RID: 9870 RVA: 0x0007B108 File Offset: 0x00079308
			// (set) Token: 0x0600268F RID: 9871 RVA: 0x000136D6 File Offset: 0x000118D6
			public unsafe UnityEngine.Events.UnityAction callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001ECB RID: 7883
			private static readonly IntPtr NativeFieldInfoPtr_order;

			// Token: 0x04001ECC RID: 7884
			private static readonly IntPtr NativeFieldInfoPtr_callback;
		}
	}
}
