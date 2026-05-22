using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppRewired
{
	// Token: 0x0200014B RID: 331
	public sealed class CustomControllerMapSaveData : ControllerMapSaveData
	{
		// Token: 0x06002409 RID: 9225 RVA: 0x000B68C8 File Offset: 0x000B4AC8
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerMapSaveData()
		{
			Il2CppClassPointerStore<CustomControllerMapSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "CustomControllerMapSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerMapSaveData>.NativeClassPtr);
			CustomControllerMapSaveData.NativeMethodInfoPtr_get_customController_Public_get_CustomController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMapSaveData>.NativeClassPtr, 100671043);
			CustomControllerMapSaveData.NativeMethodInfoPtr_get_customControllerMap_Public_get_CustomControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMapSaveData>.NativeClassPtr, 100671044);
			CustomControllerMapSaveData.NativeMethodInfoPtr_get_customControllerSourceId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMapSaveData>.NativeClassPtr, 100671045);
			CustomControllerMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_CustomController_CustomControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerMapSaveData>.NativeClassPtr, 100671046);
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x000B6948 File Offset: 0x000B4B48
		public unsafe CustomController customController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290103, XrefRangeEnd = 290109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMapSaveData.NativeMethodInfoPtr_get_customController_Public_get_CustomController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomController>(intPtr3) : null;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x000B6988 File Offset: 0x000B4B88
		public unsafe CustomControllerMap customControllerMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290109, XrefRangeEnd = 290115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMapSaveData.NativeMethodInfoPtr_get_customControllerMap_Public_get_CustomControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomControllerMap>(intPtr3) : null;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x000B69C8 File Offset: 0x000B4BC8
		public unsafe int customControllerSourceId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290115, XrefRangeEnd = 290125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMapSaveData.NativeMethodInfoPtr_get_customControllerSourceId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x000B6A04 File Offset: 0x000B4C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerMapSaveData(CustomController customController, CustomControllerMap map)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerMapSaveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customController);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(map);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerMapSaveData.NativeMethodInfoPtr__ctor_Internal_Void_CustomController_CustomControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0000E769 File Offset: 0x0000C969
		public CustomControllerMapSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr_get_customController_Public_get_CustomController_0;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeMethodInfoPtr_get_customControllerMap_Public_get_CustomControllerMap_0;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_get_customControllerSourceId_Public_get_Int32_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CustomController_CustomControllerMap_0;
	}
}
