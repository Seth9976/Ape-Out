using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000151 RID: 337
	public sealed class CustomControllerMap : ControllerMapWithAxes
	{
		// Token: 0x06002564 RID: 9572 RVA: 0x000BF240 File Offset: 0x000BD440
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerMap()
		{
			Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "CustomControllerMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr);
			CustomControllerMap.NativeFieldInfoPtr_yeyHutzWTBEJjolfblRPvdpJcst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr, "yeyHutzWTBEJjolfblRPvdpJcst");
			CustomControllerMap.NativeMethodInfoPtr_get_sourceControllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr, 100671443);
			CustomControllerMap.NativeMethodInfoPtr_set_sourceControllerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr, 100671444);
			CustomControllerMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr, 100671445);
			CustomControllerMap.NativeMethodInfoPtr__ctor_Public_Void_CustomControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr, 100671446);
			CustomControllerMap.NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr, 100671447);
			CustomControllerMap.NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_CustomControllerMap_Guid_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr, 100671448);
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x000BF2FC File Offset: 0x000BD4FC
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x000BF338 File Offset: 0x000BD538
		public unsafe int sourceControllerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMap.NativeMethodInfoPtr_get_sourceControllerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMap.NativeMethodInfoPtr_set_sourceControllerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x000BF378 File Offset: 0x000BD578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000BF3B4 File Offset: 0x000BD5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293984, XrefRangeEnd = 293985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerMap(CustomControllerMap customControllerMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customControllerMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMap.NativeMethodInfoPtr__ctor_Public_Void_CustomControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000BF400 File Offset: 0x000BD600
		[CallerCount(0)]
		public unsafe void SUdOyevPRMOQVCnWgtObyPwvIsY(Guid A_1, int A_2, int A_3, int A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMap.NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x000BF468 File Offset: 0x000BD668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293989, RefRangeEnd = 293991, XrefRangeStart = 293985, XrefRangeEnd = 293989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CustomControllerMap XURQGtObEHUkeLhWMKKYUVgbnZt(Guid A_0, int A_1, int A_2, int A_3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMap.NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_CustomControllerMap_Guid_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerMap>(intPtr3) : null;
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x0000E994 File Offset: 0x0000CB94
		public CustomControllerMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000BF4D4 File Offset: 0x000BD6D4
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x0000E99D File Offset: 0x0000CB9D
		public unsafe int yeyHutzWTBEJjolfblRPvdpJcst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerMap.NativeFieldInfoPtr_yeyHutzWTBEJjolfblRPvdpJcst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerMap.NativeFieldInfoPtr_yeyHutzWTBEJjolfblRPvdpJcst)) = value;
			}
		}

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeFieldInfoPtr_yeyHutzWTBEJjolfblRPvdpJcst;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceControllerId_Public_get_Int32_0;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_set_sourceControllerId_Public_set_Void_Int32_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CustomControllerMap_0;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeMethodInfoPtr_SUdOyevPRMOQVCnWgtObyPwvIsY_Internal_Void_Guid_Int32_Int32_Int32_0;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeMethodInfoPtr_XURQGtObEHUkeLhWMKKYUVgbnZt_Internal_Static_CustomControllerMap_Guid_Int32_Int32_Int32_0;
	}
}
