using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200014F RID: 335
	public sealed class MouseMap : ControllerMapWithAxes
	{
		// Token: 0x06002558 RID: 9560 RVA: 0x000BEEC0 File Offset: 0x000BD0C0
		// Note: this type is marked as 'beforefieldinit'.
		static MouseMap()
		{
			Il2CppClassPointerStore<MouseMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "MouseMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseMap>.NativeClassPtr);
			MouseMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMap>.NativeClassPtr, 100671435);
			MouseMap.NativeMethodInfoPtr__ctor_Public_Void_MouseMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMap>.NativeClassPtr, 100671436);
			MouseMap.NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMap>.NativeClassPtr, 100671437);
			MouseMap.NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_MouseMap_Guid_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMap>.NativeClassPtr, 100671438);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000BEF40 File Offset: 0x000BD140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293974, XrefRangeEnd = 293975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000BEF7C File Offset: 0x000BD17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293975, XrefRangeEnd = 293976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseMap(MouseMap mouseMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mouseMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMap.NativeMethodInfoPtr__ctor_Public_Void_MouseMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000BEFC8 File Offset: 0x000BD1C8
		[CallerCount(0)]
		public unsafe void SUdOyevPRMOQVCnWgtObyPwvIsY(Guid A_1, int A_2, int A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMap.NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000BF024 File Offset: 0x000BD224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293976, XrefRangeEnd = 293980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MouseMap XURQGtObEHUkeLhWMKKYUVgbnZt(Guid A_0, int A_1, int A_2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMap.NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_MouseMap_Guid_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MouseMap>(intPtr3) : null;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x0000E982 File Offset: 0x0000CB82
		public MouseMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MouseMap_0;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_MouseMap_Guid_Int32_Int32_0;
	}
}
