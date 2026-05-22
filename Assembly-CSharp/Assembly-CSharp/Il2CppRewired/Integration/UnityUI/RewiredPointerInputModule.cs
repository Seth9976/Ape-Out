using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.UI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppRewired.Integration.UnityUI
{
	// Token: 0x020001EA RID: 490
	public class RewiredPointerInputModule : BaseInputModule
	{
		// Token: 0x06003939 RID: 14649 RVA: 0x000D5754 File Offset: 0x000D3954
		// Note: this type is marked as 'beforefieldinit'.
		static RewiredPointerInputModule()
		{
			Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", "RewiredPointerInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr);
			RewiredPointerInputModule.NativeFieldInfoPtr_kMouseLeftId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "kMouseLeftId");
			RewiredPointerInputModule.NativeFieldInfoPtr_kMouseRightId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "kMouseRightId");
			RewiredPointerInputModule.NativeFieldInfoPtr_kMouseMiddleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "kMouseMiddleId");
			RewiredPointerInputModule.NativeFieldInfoPtr_kFakeTouchesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "kFakeTouchesId");
			RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsStartingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "customButtonsStartingId");
			RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsMaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "customButtonsMaxCount");
			RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsLastId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "customButtonsLastId");
			RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseInputSourcesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "m_MouseInputSourcesList");
			RewiredPointerInputModule.NativeFieldInfoPtr_m_PlayerPointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "m_PlayerPointerData");
			RewiredPointerInputModule.NativeFieldInfoPtr_m_UserDefaultTouchInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "m_UserDefaultTouchInputSource");
			RewiredPointerInputModule.NativeFieldInfoPtr___m_DefaultInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "__m_DefaultInputSource");
			RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "m_MouseState");
			RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668072);
			RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668073);
			RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668074);
			RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668075);
			RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668076);
			RewiredPointerInputModule.NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668077);
			RewiredPointerInputModule.NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668078);
			RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668079);
			RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668080);
			RewiredPointerInputModule.NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668081);
			RewiredPointerInputModule.NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668082);
			RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668083);
			RewiredPointerInputModule.NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668084);
			RewiredPointerInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668085);
			RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668086);
			RewiredPointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668087);
			RewiredPointerInputModule.NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668088);
			RewiredPointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668089);
			RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668090);
			RewiredPointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668091);
			RewiredPointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668092);
			RewiredPointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668093);
			RewiredPointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668094);
			RewiredPointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668095);
			RewiredPointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668096);
			RewiredPointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668097);
			RewiredPointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668098);
			RewiredPointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668099);
			RewiredPointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668100);
			RewiredPointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668101);
			RewiredPointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, 100668102);
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x0600393A RID: 14650 RVA: 0x000D5AE0 File Offset: 0x000D3CE0
		public unsafe RewiredPointerInputModule.UnityInputSource defaultInputSource
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 88995, RefRangeEnd = 89009, XrefRangeStart = 88992, XrefRangeEnd = 88995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RewiredPointerInputModule.UnityInputSource>(intPtr3) : null;
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x000D5B20 File Offset: 0x000D3D20
		public unsafe IMouseInputSource defaultMouseInputSource
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89009, XrefRangeEnd = 89010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMouseInputSource>(intPtr3) : null;
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x0600393C RID: 14652 RVA: 0x000D5B60 File Offset: 0x000D3D60
		public unsafe ITouchInputSource defaultTouchInputSource
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr3) : null;
			}
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x000D5BA0 File Offset: 0x000D3DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89010, XrefRangeEnd = 89011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDefaultMouse(IMouseInputSource mouse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mouse);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x000D5BF0 File Offset: 0x000D3DF0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 89017, RefRangeEnd = 89028, XrefRangeStart = 89011, XrefRangeEnd = 89017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mouseIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMouseInputSource>(intPtr3) : null;
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x000D5C4C File Offset: 0x000D3E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89028, XrefRangeEnd = 89030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveMouseInputSource(IMouseInputSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x000D5C90 File Offset: 0x000D3E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89046, RefRangeEnd = 89047, XrefRangeStart = 89030, XrefRangeEnd = 89046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMouseInputSource(IMouseInputSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x000D5CD4 File Offset: 0x000D3ED4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 89052, RefRangeEnd = 89056, XrefRangeStart = 89047, XrefRangeEnd = 89052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMouseInputSourceCount(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x000D5D20 File Offset: 0x000D3F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89063, RefRangeEnd = 89064, XrefRangeStart = 89056, XrefRangeEnd = 89063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr3) : null;
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x000D5D7C File Offset: 0x000D3F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89064, XrefRangeEnd = 89065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTouchInputSource(ITouchInputSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x000D5DC0 File Offset: 0x000D3FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89065, XrefRangeEnd = 89071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTouchInputSource(ITouchInputSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x000D5E04 File Offset: 0x000D4004
		[CallerCount(0)]
		public unsafe int GetTouchInputSourceCount(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x000D5E50 File Offset: 0x000D4050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89071, XrefRangeEnd = 89073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearMouseInputSources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x000D5E84 File Offset: 0x000D4084
		public unsafe virtual bool isMouseSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89073, XrefRangeEnd = 89078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RewiredPointerInputModule.NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x000D5ECC File Offset: 0x000D40CC
		[CallerCount(0)]
		public unsafe virtual bool IsDefaultPlayer(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RewiredPointerInputModule.NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x000D5F20 File Offset: 0x000D4120
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 89122, RefRangeEnd = 89129, XrefRangeStart = 89078, XrefRangeEnd = 89122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerTypeId;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerEventType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new PlayerPointerEventData(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x000D5FC8 File Offset: 0x000D41C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89129, XrefRangeEnd = 89140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerTypeId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerEventType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerPointerEventData>(intPtr3) : null;
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x000D6040 File Offset: 0x000D4240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89145, RefRangeEnd = 89146, XrefRangeStart = 89140, XrefRangeEnd = 89145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePointerData(PlayerPointerEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x000D6084 File Offset: 0x000D4284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89155, RefRangeEnd = 89156, XrefRangeStart = 89146, XrefRangeEnd = 89155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref touchDeviceIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref input;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pressed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerPointerEventData>(intPtr3) : null;
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x000D610C File Offset: 0x000D430C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89156, XrefRangeEnd = 89196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RewiredPointerInputModule.MouseState GetMousePointerEventData(int playerId, int mouseIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mouseIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RewiredPointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RewiredPointerInputModule.MouseState>(intPtr3) : null;
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x000D6174 File Offset: 0x000D4374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89196, XrefRangeEnd = 89210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerTypeId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignorePointerTypeId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerEventType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerPointerEventData>(intPtr3) : null;
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x000D61F8 File Offset: 0x000D43F8
		[CallerCount(0)]
		public unsafe static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDragThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x000D6260 File Offset: 0x000D4460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89210, XrefRangeEnd = 89225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessMove(PlayerPointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RewiredPointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x000D62B0 File Offset: 0x000D44B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89225, XrefRangeEnd = 89282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RewiredPointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x000D6300 File Offset: 0x000D4500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89282, XrefRangeEnd = 89306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerOverGameObject(int pointerTypeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerTypeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RewiredPointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x000D6354 File Offset: 0x000D4554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89329, RefRangeEnd = 89330, XrefRangeStart = 89306, XrefRangeEnd = 89329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x000D6388 File Offset: 0x000D4588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89330, XrefRangeEnd = 89389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RewiredPointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x000D63CC File Offset: 0x000D45CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89412, RefRangeEnd = 89413, XrefRangeStart = 89389, XrefRangeEnd = 89412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentOverGo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x000D6420 File Offset: 0x000D4620
		[CallerCount(0)]
		public unsafe void CopyFromTo(PointerEventData from, PointerEventData to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x000D6474 File Offset: 0x000D4674
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 89422, RefRangeEnd = 89426, XrefRangeStart = 89413, XrefRangeEnd = 89422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mouseIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x000D64DC File Offset: 0x000D46DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 89448, RefRangeEnd = 89449, XrefRangeStart = 89426, XrefRangeEnd = 89448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RewiredPointerInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x000246DA File Offset: 0x000228DA
		public RewiredPointerInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x000D6518 File Offset: 0x000D4718
		// (set) Token: 0x0600395B RID: 14683 RVA: 0x000246E3 File Offset: 0x000228E3
		public unsafe static int kMouseLeftId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*)(&value));
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x000D6534 File Offset: 0x000D4734
		// (set) Token: 0x0600395D RID: 14685 RVA: 0x000246F1 File Offset: 0x000228F1
		public unsafe static int kMouseRightId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*)(&value));
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x000D6550 File Offset: 0x000D4750
		// (set) Token: 0x0600395F RID: 14687 RVA: 0x000246FF File Offset: 0x000228FF
		public unsafe static int kMouseMiddleId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*)(&value));
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06003960 RID: 14688 RVA: 0x000D656C File Offset: 0x000D476C
		// (set) Token: 0x06003961 RID: 14689 RVA: 0x0002470D File Offset: 0x0002290D
		public unsafe static int kFakeTouchesId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*)(&value));
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06003962 RID: 14690 RVA: 0x000D6588 File Offset: 0x000D4788
		// (set) Token: 0x06003963 RID: 14691 RVA: 0x0002471B File Offset: 0x0002291B
		public unsafe static int customButtonsStartingId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsStartingId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsStartingId, (void*)(&value));
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06003964 RID: 14692 RVA: 0x000D65A4 File Offset: 0x000D47A4
		// (set) Token: 0x06003965 RID: 14693 RVA: 0x00024729 File Offset: 0x00022929
		public unsafe static int customButtonsMaxCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsMaxCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsMaxCount, (void*)(&value));
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06003966 RID: 14694 RVA: 0x000D65C0 File Offset: 0x000D47C0
		// (set) Token: 0x06003967 RID: 14695 RVA: 0x00024737 File Offset: 0x00022937
		public unsafe static int customButtonsLastId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsLastId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RewiredPointerInputModule.NativeFieldInfoPtr_customButtonsLastId, (void*)(&value));
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06003968 RID: 14696 RVA: 0x000D65DC File Offset: 0x000D47DC
		// (set) Token: 0x06003969 RID: 14697 RVA: 0x00024745 File Offset: 0x00022945
		public unsafe List<IMouseInputSource> m_MouseInputSourcesList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseInputSourcesList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IMouseInputSource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseInputSourcesList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x0600396A RID: 14698 RVA: 0x000D660C File Offset: 0x000D480C
		// (set) Token: 0x0600396B RID: 14699 RVA: 0x00024764 File Offset: 0x00022964
		public unsafe Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>> m_PlayerPointerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_PlayerPointerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<Dictionary<int, PlayerPointerEventData>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_PlayerPointerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x0600396C RID: 14700 RVA: 0x000D663C File Offset: 0x000D483C
		// (set) Token: 0x0600396D RID: 14701 RVA: 0x00024783 File Offset: 0x00022983
		public unsafe ITouchInputSource m_UserDefaultTouchInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_UserDefaultTouchInputSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITouchInputSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_UserDefaultTouchInputSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x0600396E RID: 14702 RVA: 0x000D666C File Offset: 0x000D486C
		// (set) Token: 0x0600396F RID: 14703 RVA: 0x000247A2 File Offset: 0x000229A2
		public unsafe RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr___m_DefaultInputSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RewiredPointerInputModule.UnityInputSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr___m_DefaultInputSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x000D669C File Offset: 0x000D489C
		// (set) Token: 0x06003971 RID: 14705 RVA: 0x000247C1 File Offset: 0x000229C1
		public unsafe RewiredPointerInputModule.MouseState m_MouseState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RewiredPointerInputModule.MouseState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.NativeFieldInfoPtr_m_MouseState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeFieldInfoPtr_kMouseLeftId;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeFieldInfoPtr_kMouseRightId;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeFieldInfoPtr_kMouseMiddleId;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeFieldInfoPtr_kFakeTouchesId;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeFieldInfoPtr_customButtonsStartingId;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeFieldInfoPtr_customButtonsMaxCount;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeFieldInfoPtr_customButtonsLastId;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseInputSourcesList;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerPointerData;

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeFieldInfoPtr_m_UserDefaultTouchInputSource;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeFieldInfoPtr___m_DefaultInputSource;

		// Token: 0x0400224C RID: 8780
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseState;

		// Token: 0x0400224D RID: 8781
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultInputSource_Private_get_UnityInputSource_0;

		// Token: 0x0400224E RID: 8782
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMouseInputSource_Private_get_IMouseInputSource_0;

		// Token: 0x0400224F RID: 8783
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTouchInputSource_Protected_get_ITouchInputSource_0;

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultMouse_Protected_Boolean_IMouseInputSource_0;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseInputSource_Public_IMouseInputSource_Int32_Int32_0;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMouseInputSource_Public_Void_IMouseInputSource_0;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeMethodInfoPtr_AddMouseInputSource_Public_Void_IMouseInputSource_0;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseInputSourceCount_Public_Int32_Int32_0;

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchInputSource_Public_ITouchInputSource_Int32_Int32_0;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTouchInputSource_Public_Void_ITouchInputSource_0;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeMethodInfoPtr_AddTouchInputSource_Public_Void_ITouchInputSource_0;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchInputSourceCount_Public_Int32_Int32_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_ClearMouseInputSources_Protected_Void_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr_get_isMouseSupported_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultPlayer_Protected_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_Int32_Int32_byref_PlayerPointerEventData_Boolean_PointerEventType_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_CreatePointerEventData_Private_PlayerPointerEventData_Int32_Int32_Int32_PointerEventType_0;

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeMethodInfoPtr_RemovePointerData_Protected_Void_PlayerPointerEventData_0;

		// Token: 0x0400225F RID: 8799
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Touch_byref_Boolean_byref_Boolean_0;

		// Token: 0x04002260 RID: 8800
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_Int32_0;

		// Token: 0x04002261 RID: 8801
		private static readonly IntPtr NativeMethodInfoPtr_GetLastPointerEventData_Protected_PlayerPointerEventData_Int32_Int32_Int32_Boolean_PointerEventType_0;

		// Token: 0x04002262 RID: 8802
		private static readonly IntPtr NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0;

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PlayerPointerEventData_0;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PlayerPointerEventData_0;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Protected_Void_0;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_Int32_Int32_0;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000360 RID: 864
		public class MouseState : global::Il2CppSystem.Object
		{
			// Token: 0x06005476 RID: 21622 RVA: 0x00132530 File Offset: 0x00130730
			// Note: this type is marked as 'beforefieldinit'.
			static MouseState()
			{
				Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "MouseState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr);
				RewiredPointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, "m_TrackedButtons");
				RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668103);
				RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668104);
				RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668105);
				RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668106);
				RewiredPointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr, 100668107);
			}

			// Token: 0x06005477 RID: 21623 RVA: 0x001325D4 File Offset: 0x001307D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88894, XrefRangeEnd = 88897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AnyPressesThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005478 RID: 21624 RVA: 0x00132610 File Offset: 0x00130810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88897, XrefRangeEnd = 88900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AnyReleasesThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005479 RID: 21625 RVA: 0x0013264C File Offset: 0x0013084C
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 88912, RefRangeEnd = 88924, XrefRangeStart = 88900, XrefRangeEnd = 88912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RewiredPointerInputModule.ButtonState GetButtonState(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RewiredPointerInputModule.ButtonState>(intPtr3) : null;
				}
			}

			// Token: 0x0600547A RID: 21626 RVA: 0x00132698 File Offset: 0x00130898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88924, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateForMouseButton;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600547B RID: 21627 RVA: 0x001326F8 File Offset: 0x001308F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88925, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.MouseState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600547C RID: 21628 RVA: 0x00030F7F File Offset: 0x0002F17F
			public MouseState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EC6 RID: 7878
			// (get) Token: 0x0600547D RID: 21629 RVA: 0x00132734 File Offset: 0x00130934
			// (set) Token: 0x0600547E RID: 21630 RVA: 0x00030F88 File Offset: 0x0002F188
			public unsafe List<RewiredPointerInputModule.ButtonState> m_TrackedButtons
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RewiredPointerInputModule.ButtonState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037D6 RID: 14294
			private static readonly IntPtr NativeFieldInfoPtr_m_TrackedButtons;

			// Token: 0x040037D7 RID: 14295
			private static readonly IntPtr NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0;

			// Token: 0x040037D8 RID: 14296
			private static readonly IntPtr NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0;

			// Token: 0x040037D9 RID: 14297
			private static readonly IntPtr NativeMethodInfoPtr_GetButtonState_Public_ButtonState_Int32_0;

			// Token: 0x040037DA RID: 14298
			private static readonly IntPtr NativeMethodInfoPtr_SetButtonState_Public_Void_Int32_FramePressState_PlayerPointerEventData_0;

			// Token: 0x040037DB RID: 14299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000361 RID: 865
		public class MouseButtonEventData : global::Il2CppSystem.Object
		{
			// Token: 0x0600547F RID: 21631 RVA: 0x00132764 File Offset: 0x00130964
			// Note: this type is marked as 'beforefieldinit'.
			static MouseButtonEventData()
			{
				Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "MouseButtonEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr);
				RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, "buttonState");
				RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, "buttonData");
				RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, 100668108);
				RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, 100668109);
				RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr, 100668110);
			}

			// Token: 0x06005480 RID: 21632 RVA: 0x001327F4 File Offset: 0x001309F4
			[CallerCount(0)]
			public unsafe bool PressedThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005481 RID: 21633 RVA: 0x00132830 File Offset: 0x00130A30
			[CallerCount(0)]
			public unsafe bool ReleasedThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005482 RID: 21634 RVA: 0x0013286C File Offset: 0x00130A6C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseButtonEventData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.MouseButtonEventData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005483 RID: 21635 RVA: 0x00030FA7 File Offset: 0x0002F1A7
			public MouseButtonEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EC7 RID: 7879
			// (get) Token: 0x06005484 RID: 21636 RVA: 0x001328A8 File Offset: 0x00130AA8
			// (set) Token: 0x06005485 RID: 21637 RVA: 0x00030FB0 File Offset: 0x0002F1B0
			public unsafe PointerEventData.FramePressState buttonState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState)) = value;
				}
			}

			// Token: 0x17001EC8 RID: 7880
			// (get) Token: 0x06005486 RID: 21638 RVA: 0x001328D0 File Offset: 0x00130AD0
			// (set) Token: 0x06005487 RID: 21639 RVA: 0x00030FCB File Offset: 0x0002F1CB
			public unsafe PlayerPointerEventData buttonData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerPointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037DC RID: 14300
			private static readonly IntPtr NativeFieldInfoPtr_buttonState;

			// Token: 0x040037DD RID: 14301
			private static readonly IntPtr NativeFieldInfoPtr_buttonData;

			// Token: 0x040037DE RID: 14302
			private static readonly IntPtr NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0;

			// Token: 0x040037DF RID: 14303
			private static readonly IntPtr NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0;

			// Token: 0x040037E0 RID: 14304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000362 RID: 866
		public class ButtonState : global::Il2CppSystem.Object
		{
			// Token: 0x06005488 RID: 21640 RVA: 0x00132900 File Offset: 0x00130B00
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonState()
			{
				Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "ButtonState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr);
				RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, "m_Button");
				RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, "m_EventData");
				RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668111);
				RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668112);
				RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668113);
				RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668114);
				RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr, 100668115);
			}

			// Token: 0x17001ECB RID: 7883
			// (get) Token: 0x06005489 RID: 21641 RVA: 0x001329B8 File Offset: 0x00130BB8
			// (set) Token: 0x0600548A RID: 21642 RVA: 0x001329F8 File Offset: 0x00130BF8
			public unsafe RewiredPointerInputModule.MouseButtonEventData eventData
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RewiredPointerInputModule.MouseButtonEventData>(intPtr3) : null;
				}
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001ECC RID: 7884
			// (get) Token: 0x0600548B RID: 21643 RVA: 0x00132A3C File Offset: 0x00130C3C
			// (set) Token: 0x0600548C RID: 21644 RVA: 0x00132A78 File Offset: 0x00130C78
			public unsafe int button
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600548D RID: 21645 RVA: 0x00132AB8 File Offset: 0x00130CB8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.ButtonState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600548E RID: 21646 RVA: 0x00030FEA File Offset: 0x0002F1EA
			public ButtonState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EC9 RID: 7881
			// (get) Token: 0x0600548F RID: 21647 RVA: 0x00132AF4 File Offset: 0x00130CF4
			// (set) Token: 0x06005490 RID: 21648 RVA: 0x00030FF3 File Offset: 0x0002F1F3
			public unsafe int m_Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button)) = value;
				}
			}

			// Token: 0x17001ECA RID: 7882
			// (get) Token: 0x06005491 RID: 21649 RVA: 0x00132B1C File Offset: 0x00130D1C
			// (set) Token: 0x06005492 RID: 21650 RVA: 0x0003100E File Offset: 0x0002F20E
			public unsafe RewiredPointerInputModule.MouseButtonEventData m_EventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RewiredPointerInputModule.MouseButtonEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040037E1 RID: 14305
			private static readonly IntPtr NativeFieldInfoPtr_m_Button;

			// Token: 0x040037E2 RID: 14306
			private static readonly IntPtr NativeFieldInfoPtr_m_EventData;

			// Token: 0x040037E3 RID: 14307
			private static readonly IntPtr NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0;

			// Token: 0x040037E4 RID: 14308
			private static readonly IntPtr NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0;

			// Token: 0x040037E5 RID: 14309
			private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_Int32_0;

			// Token: 0x040037E6 RID: 14310
			private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_Int32_0;

			// Token: 0x040037E7 RID: 14311
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000363 RID: 867
		public sealed class UnityInputSource : global::Il2CppSystem.Object
		{
			// Token: 0x06005493 RID: 21651 RVA: 0x00132B4C File Offset: 0x00130D4C
			// Note: this type is marked as 'beforefieldinit'.
			static UnityInputSource()
			{
				Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredPointerInputModule>.NativeClassPtr, "UnityInputSource");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr);
				RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, "m_MousePosition");
				RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePositionPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, "m_MousePositionPrev");
				RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_LastUpdatedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, "m_LastUpdatedFrame");
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668116);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668117);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668118);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668119);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668120);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668121);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668122);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668123);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668124);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668125);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668126);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668127);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668128);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668129);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_TryUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668130);
				RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr, 100668131);
			}

			// Token: 0x17001ED0 RID: 7888
			// (get) Token: 0x06005494 RID: 21652 RVA: 0x00132CF4 File Offset: 0x00130EF4
			public unsafe int Rewired.UI.IMouseInputSource.playerId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88931, XrefRangeEnd = 88932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001ED1 RID: 7889
			// (get) Token: 0x06005495 RID: 21653 RVA: 0x00132D30 File Offset: 0x00130F30
			public unsafe int Rewired.UI.ITouchInputSource.playerId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001ED2 RID: 7890
			// (get) Token: 0x06005496 RID: 21654 RVA: 0x00132D6C File Offset: 0x00130F6C
			public unsafe bool Rewired.UI.IMouseInputSource.enabled
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88932, XrefRangeEnd = 88933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001ED3 RID: 7891
			// (get) Token: 0x06005497 RID: 21655 RVA: 0x00132DA8 File Offset: 0x00130FA8
			public unsafe bool Rewired.UI.IMouseInputSource.locked
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88933, XrefRangeEnd = 88936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001ED4 RID: 7892
			// (get) Token: 0x06005498 RID: 21656 RVA: 0x00132DE4 File Offset: 0x00130FE4
			public unsafe int Rewired.UI.IMouseInputSource.buttonCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88936, XrefRangeEnd = 88937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005499 RID: 21657 RVA: 0x00132E20 File Offset: 0x00131020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88937, XrefRangeEnd = 88942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Rewired_UI_IMouseInputSource_GetButtonDown(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600549A RID: 21658 RVA: 0x00132E6C File Offset: 0x0013106C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88942, XrefRangeEnd = 88947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Rewired_UI_IMouseInputSource_GetButtonUp(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600549B RID: 21659 RVA: 0x00132EB8 File Offset: 0x001310B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88947, XrefRangeEnd = 88952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Rewired_UI_IMouseInputSource_GetButton(int button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001ED5 RID: 7893
			// (get) Token: 0x0600549C RID: 21660 RVA: 0x00132F04 File Offset: 0x00131104
			public unsafe Vector2 Rewired.UI.IMouseInputSource.screenPosition
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88952, XrefRangeEnd = 88955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001ED6 RID: 7894
			// (get) Token: 0x0600549D RID: 21661 RVA: 0x00132F40 File Offset: 0x00131140
			public unsafe Vector2 Rewired.UI.IMouseInputSource.screenPositionDelta
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88955, XrefRangeEnd = 88956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001ED7 RID: 7895
			// (get) Token: 0x0600549E RID: 21662 RVA: 0x00132F7C File Offset: 0x0013117C
			public unsafe Vector2 Rewired.UI.IMouseInputSource.wheelDelta
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88956, XrefRangeEnd = 88959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001ED8 RID: 7896
			// (get) Token: 0x0600549F RID: 21663 RVA: 0x00132FB8 File Offset: 0x001311B8
			public unsafe bool Rewired.UI.ITouchInputSource.touchSupported
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88959, XrefRangeEnd = 88964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001ED9 RID: 7897
			// (get) Token: 0x060054A0 RID: 21664 RVA: 0x00132FF4 File Offset: 0x001311F4
			public unsafe int Rewired.UI.ITouchInputSource.touchCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88964, XrefRangeEnd = 88969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060054A1 RID: 21665 RVA: 0x00133030 File Offset: 0x00131230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88969, XrefRangeEnd = 88972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Touch Rewired_UI_ITouchInputSource_GetTouch(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060054A2 RID: 21666 RVA: 0x0013307C File Offset: 0x0013127C
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 88978, RefRangeEnd = 88992, XrefRangeStart = 88972, XrefRangeEnd = 88978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TryUpdate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr_TryUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054A3 RID: 21667 RVA: 0x001330B0 File Offset: 0x001312B0
			[CallerCount(0)]
			public unsafe UnityInputSource()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredPointerInputModule.UnityInputSource>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredPointerInputModule.UnityInputSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054A4 RID: 21668 RVA: 0x0003102D File Offset: 0x0002F22D
			public UnityInputSource(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001ECD RID: 7885
			// (get) Token: 0x060054A5 RID: 21669 RVA: 0x001330EC File Offset: 0x001312EC
			// (set) Token: 0x060054A6 RID: 21670 RVA: 0x00031036 File Offset: 0x0002F236
			public unsafe Vector2 m_MousePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePosition)) = value;
				}
			}

			// Token: 0x17001ECE RID: 7886
			// (get) Token: 0x060054A7 RID: 21671 RVA: 0x00133114 File Offset: 0x00131314
			// (set) Token: 0x060054A8 RID: 21672 RVA: 0x00031051 File Offset: 0x0002F251
			public unsafe Vector2 m_MousePositionPrev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePositionPrev);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_MousePositionPrev)) = value;
				}
			}

			// Token: 0x17001ECF RID: 7887
			// (get) Token: 0x060054A9 RID: 21673 RVA: 0x0013313C File Offset: 0x0013133C
			// (set) Token: 0x060054AA RID: 21674 RVA: 0x0003106C File Offset: 0x0002F26C
			public unsafe int m_LastUpdatedFrame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_LastUpdatedFrame);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredPointerInputModule.UnityInputSource.NativeFieldInfoPtr_m_LastUpdatedFrame)) = value;
				}
			}

			// Token: 0x040037E8 RID: 14312
			private static readonly IntPtr NativeFieldInfoPtr_m_MousePosition;

			// Token: 0x040037E9 RID: 14313
			private static readonly IntPtr NativeFieldInfoPtr_m_MousePositionPrev;

			// Token: 0x040037EA RID: 14314
			private static readonly IntPtr NativeFieldInfoPtr_m_LastUpdatedFrame;

			// Token: 0x040037EB RID: 14315
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040037EC RID: 14316
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_playerId_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040037ED RID: 14317
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_enabled_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040037EE RID: 14318
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_locked_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040037EF RID: 14319
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_buttonCount_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040037F0 RID: 14320
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonDown_Private_Virtual_Final_New_Boolean_Int32_0;

			// Token: 0x040037F1 RID: 14321
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButtonUp_Private_Virtual_Final_New_Boolean_Int32_0;

			// Token: 0x040037F2 RID: 14322
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_GetButton_Private_Virtual_Final_New_Boolean_Int32_0;

			// Token: 0x040037F3 RID: 14323
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPosition_Private_Virtual_Final_New_get_Vector2_0;

			// Token: 0x040037F4 RID: 14324
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_screenPositionDelta_Private_Virtual_Final_New_get_Vector2_0;

			// Token: 0x040037F5 RID: 14325
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_IMouseInputSource_get_wheelDelta_Private_Virtual_Final_New_get_Vector2_0;

			// Token: 0x040037F6 RID: 14326
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchSupported_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x040037F7 RID: 14327
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_get_touchCount_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040037F8 RID: 14328
			private static readonly IntPtr NativeMethodInfoPtr_Rewired_UI_ITouchInputSource_GetTouch_Private_Virtual_Final_New_Touch_Int32_0;

			// Token: 0x040037F9 RID: 14329
			private static readonly IntPtr NativeMethodInfoPtr_TryUpdate_Private_Void_0;

			// Token: 0x040037FA RID: 14330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
