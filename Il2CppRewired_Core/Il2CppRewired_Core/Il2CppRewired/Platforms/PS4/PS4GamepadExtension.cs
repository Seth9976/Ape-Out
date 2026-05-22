using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Platforms.PS4
{
	// Token: 0x02000192 RID: 402
	public sealed class PS4GamepadExtension : PS4ControllerExtension
	{
		// Token: 0x0600293A RID: 10554 RVA: 0x000D01D0 File Offset: 0x000CE3D0
		// Note: this type is marked as 'beforefieldinit'.
		static PS4GamepadExtension()
		{
			Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Platforms.PS4", "PS4GamepadExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr);
			PS4GamepadExtension.NativeMethodInfoPtr_get_Source_Private_get_IPS4GamepadExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673285);
			PS4GamepadExtension.NativeMethodInfoPtr__ctor_Internal_Void_IPS4GamepadExtensionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673286);
			PS4GamepadExtension.NativeMethodInfoPtr__ctor_Private_Void_PS4GamepadExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673287);
			PS4GamepadExtension.NativeMethodInfoPtr_get_connectionType_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673288);
			PS4GamepadExtension.NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673289);
			PS4GamepadExtension.NativeMethodInfoPtr_get_touchpadPixelDensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673290);
			PS4GamepadExtension.NativeMethodInfoPtr_get_touchpadResolution_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673291);
			PS4GamepadExtension.NativeMethodInfoPtr_get_touchpadResolutionX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673292);
			PS4GamepadExtension.NativeMethodInfoPtr_get_touchpadResolutionY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673293);
			PS4GamepadExtension.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673294);
			PS4GamepadExtension.NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673295);
			PS4GamepadExtension.NativeMethodInfoPtr_GetTouchPosition_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673296);
			PS4GamepadExtension.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673297);
			PS4GamepadExtension.NativeMethodInfoPtr_GetTouchPositionAbsolute_Public_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673298);
			PS4GamepadExtension.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673299);
			PS4GamepadExtension.NativeMethodInfoPtr_IsTouching_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673300);
			PS4GamepadExtension.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673301);
			PS4GamepadExtension.NativeMethodInfoPtr_GetVibration_Public_Single_PS4GamepadMotorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673302);
			PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4GamepadMotorType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673303);
			PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4GamepadMotorType_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673304);
			PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4GamepadMotorType_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673305);
			PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673306);
			PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673307);
			PS4GamepadExtension.NativeMethodInfoPtr_TbnZibtYeYSFcPksjBqUcHFCgmw_Private_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673308);
			PS4GamepadExtension.NativeMethodInfoPtr_xDmkllxQHuTPcBJDzXtJLqbycZN_Private_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673309);
			PS4GamepadExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673310);
			PS4GamepadExtension.NativeMethodInfoPtr_xrnxHrueTVMIZLTLNjrQvmcjdSR_Private_Static_Int32_PS4GamepadMotorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr, 100673311);
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x000D041C File Offset: 0x000CE61C
		public new unsafe IPS4GamepadExtensionSource Source
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 309550, RefRangeEnd = 309565, XrefRangeStart = 309544, XrefRangeEnd = 309550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_get_Source_Private_get_IPS4GamepadExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPS4GamepadExtensionSource>(intPtr3) : null;
			}
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000D045C File Offset: 0x000CE65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PS4GamepadExtension(IPS4GamepadExtensionSource source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr__ctor_Internal_Void_IPS4GamepadExtensionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000D04A8 File Offset: 0x000CE6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PS4GamepadExtension(PS4GamepadExtension source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PS4GamepadExtension>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr__ctor_Private_Void_PS4GamepadExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x000D04F4 File Offset: 0x000CE6F4
		public unsafe int connectionType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309565, XrefRangeEnd = 309575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_get_connectionType_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x000D0530 File Offset: 0x000CE730
		public unsafe int maxTouches
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309575, XrefRangeEnd = 309585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000D056C File Offset: 0x000CE76C
		public unsafe float touchpadPixelDensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309585, XrefRangeEnd = 309595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_get_touchpadPixelDensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x000D05A8 File Offset: 0x000CE7A8
		public unsafe Vector2 touchpadResolution
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309595, XrefRangeEnd = 309606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_get_touchpadResolution_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x000D05E4 File Offset: 0x000CE7E4
		public unsafe int touchpadResolutionX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309606, XrefRangeEnd = 309616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_get_touchpadResolutionX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x000D0620 File Offset: 0x000CE820
		public unsafe int touchpadResolutionY
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309616, XrefRangeEnd = 309626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_get_touchpadResolutionY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x000D065C File Offset: 0x000CE85C
		public unsafe int touchCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309626, XrefRangeEnd = 309636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000D0698 File Offset: 0x000CE898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309636, XrefRangeEnd = 309646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTouchId(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x000D06E4 File Offset: 0x000CE8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309646, XrefRangeEnd = 309659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTouchPosition(int index, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_GetTouchPosition_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x000D073C File Offset: 0x000CE93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309659, XrefRangeEnd = 309672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x000D0794 File Offset: 0x000CE994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309672, XrefRangeEnd = 309685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTouchPositionAbsolute(int index, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_GetTouchPositionAbsolute_Public_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x000D07EC File Offset: 0x000CE9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309685, XrefRangeEnd = 309698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000D0844 File Offset: 0x000CEA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309698, XrefRangeEnd = 309708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTouching(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_IsTouching_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000D0890 File Offset: 0x000CEA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309708, XrefRangeEnd = 309718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTouchingByTouchId(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000D08DC File Offset: 0x000CEADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309718, XrefRangeEnd = 309725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVibration(PS4GamepadMotorType motor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_GetVibration_Public_Single_PS4GamepadMotorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x000D0928 File Offset: 0x000CEB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309725, XrefRangeEnd = 309726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(PS4GamepadMotorType motor, float motorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4GamepadMotorType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x000D0974 File Offset: 0x000CEB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309726, XrefRangeEnd = 309727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(PS4GamepadMotorType motor, float motorLevel, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4GamepadMotorType_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x000D09D0 File Offset: 0x000CEBD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309735, RefRangeEnd = 309737, XrefRangeStart = 309727, XrefRangeEnd = 309735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(PS4GamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref motor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref motorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopOtherMotors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Void_PS4GamepadMotorType_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x000D0A38 File Offset: 0x000CEC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309737, XrefRangeEnd = 309746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftMotorLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotorLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x000D0A84 File Offset: 0x000CEC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309746, XrefRangeEnd = 309755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref leftMotorLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotorLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftMotorDuration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotorDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000D0AEC File Offset: 0x000CECEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309755, XrefRangeEnd = 309768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TbnZibtYeYSFcPksjBqUcHFCgmw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_TbnZibtYeYSFcPksjBqUcHFCgmw_Private_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000D0B28 File Offset: 0x000CED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309768, XrefRangeEnd = 309781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 xDmkllxQHuTPcBJDzXtJLqbycZN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_xDmkllxQHuTPcBJDzXtJLqbycZN_Private_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000D0B64 File Offset: 0x000CED64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309781, XrefRangeEnd = 309785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension dLAxRoWNebGZzafOZSROBGeqqVrC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000D0BA4 File Offset: 0x000CEDA4
		[CallerCount(0)]
		public unsafe static int xrnxHrueTVMIZLTLNjrQvmcjdSR(PS4GamepadMotorType A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PS4GamepadExtension.NativeMethodInfoPtr_xrnxHrueTVMIZLTLNjrQvmcjdSR_Private_Static_Int32_PS4GamepadMotorType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x0000FBBD File Offset: 0x0000DDBD
		public PS4GamepadExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Private_get_IPS4GamepadExtensionSource_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IPS4GamepadExtensionSource_0;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_PS4GamepadExtension_0;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeMethodInfoPtr_get_connectionType_Public_get_Int32_0;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeMethodInfoPtr_get_maxTouches_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeMethodInfoPtr_get_touchpadPixelDensity_Public_get_Single_0;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeMethodInfoPtr_get_touchpadResolution_Public_get_Vector2_0;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeMethodInfoPtr_get_touchpadResolutionX_Public_get_Int32_0;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeMethodInfoPtr_get_touchpadResolutionY_Public_get_Int32_0;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeMethodInfoPtr_get_touchCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchId_Public_Virtual_Final_New_Int32_Int32_0;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPosition_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsolute_Public_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeMethodInfoPtr_IsTouching_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingByTouchId_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Single_PS4GamepadMotorType_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_PS4GamepadMotorType_Single_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_PS4GamepadMotorType_Single_Boolean_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Void_PS4GamepadMotorType_Single_Single_Boolean_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Single_Single_Single_Single_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_TbnZibtYeYSFcPksjBqUcHFCgmw_Private_Virtual_Final_New_Vector3_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_xDmkllxQHuTPcBJDzXtJLqbycZN_Private_Virtual_Final_New_Vector3_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Internal_Virtual_Extension_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr_xrnxHrueTVMIZLTLNjrQvmcjdSR_Private_Static_Int32_PS4GamepadMotorType_0;
	}
}
