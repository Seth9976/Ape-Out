using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.Internal
{
	// Token: 0x0200012A RID: 298
	[Serializable]
	public sealed class StandaloneAxis2D : global::Il2CppSystem.Object
	{
		// Token: 0x06001ECA RID: 7882 RVA: 0x000A1340 File Offset: 0x0009F540
		// Note: this type is marked as 'beforefieldinit'.
		static StandaloneAxis2D()
		{
			Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Internal", "StandaloneAxis2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr);
			StandaloneAxis2D.NativeFieldInfoPtr__calibration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, "_calibration");
			StandaloneAxis2D.NativeFieldInfoPtr__xAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, "_xAxis");
			StandaloneAxis2D.NativeFieldInfoPtr__yAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, "_yAxis");
			StandaloneAxis2D.NativeFieldInfoPtr__allowEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, "_allowEvents");
			StandaloneAxis2D.NativeFieldInfoPtr__ValueChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, "_ValueChangedEvent");
			StandaloneAxis2D.NativeFieldInfoPtr__RawValueChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, "_RawValueChangedEvent");
			StandaloneAxis2D.NativeMethodInfoPtr_get_calibration_Public_get_Axis2DCalibration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669977);
			StandaloneAxis2D.NativeMethodInfoPtr_get_xAxis_Public_get_StandaloneAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669978);
			StandaloneAxis2D.NativeMethodInfoPtr_get_yAxis_Public_get_StandaloneAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669979);
			StandaloneAxis2D.NativeMethodInfoPtr_get_value_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669980);
			StandaloneAxis2D.NativeMethodInfoPtr_get_valuePrev_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669981);
			StandaloneAxis2D.NativeMethodInfoPtr_get_valueDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669982);
			StandaloneAxis2D.NativeMethodInfoPtr_get_rawValue_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669983);
			StandaloneAxis2D.NativeMethodInfoPtr_get_rawValuePrev_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669984);
			StandaloneAxis2D.NativeMethodInfoPtr_get_rawValueDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669985);
			StandaloneAxis2D.NativeMethodInfoPtr_get_rawZero_Internal_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669986);
			StandaloneAxis2D.NativeMethodInfoPtr_add__ValueChangedEvent_Private_add_Void_ValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669987);
			StandaloneAxis2D.NativeMethodInfoPtr_remove__ValueChangedEvent_Private_rem_Void_ValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669988);
			StandaloneAxis2D.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_ValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669989);
			StandaloneAxis2D.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_ValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669990);
			StandaloneAxis2D.NativeMethodInfoPtr_add__RawValueChangedEvent_Private_add_Void_ValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669991);
			StandaloneAxis2D.NativeMethodInfoPtr_remove__RawValueChangedEvent_Private_rem_Void_ValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669992);
			StandaloneAxis2D.NativeMethodInfoPtr_add_RawValueChangedEvent_Public_add_Void_ValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669993);
			StandaloneAxis2D.NativeMethodInfoPtr_remove_RawValueChangedEvent_Public_rem_Void_ValueChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669994);
			StandaloneAxis2D.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669995);
			StandaloneAxis2D.NativeMethodInfoPtr__ctor_Internal_Void_StandaloneAxis_StandaloneAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669996);
			StandaloneAxis2D.NativeMethodInfoPtr_SetRawValue_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669997);
			StandaloneAxis2D.NativeMethodInfoPtr_SetRawValue_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669998);
			StandaloneAxis2D.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100669999);
			StandaloneAxis2D.NativeMethodInfoPtr_Initialize_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670000);
			StandaloneAxis2D.NativeMethodInfoPtr_Deinitialize_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670001);
			StandaloneAxis2D.NativeMethodInfoPtr_EvalAndSendValueChangeEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670002);
			StandaloneAxis2D.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670003);
			StandaloneAxis2D.NativeMethodInfoPtr_Unsubscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670004);
			StandaloneAxis2D.NativeMethodInfoPtr_GetCalibratedValue_Private_Vector2_StandaloneAxis_StandaloneAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670005);
			StandaloneAxis2D.NativeMethodInfoPtr_GetCalibratedValuePrev_Private_Vector2_StandaloneAxis_StandaloneAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670006);
			StandaloneAxis2D.NativeMethodInfoPtr_OnAxisValueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670007);
			StandaloneAxis2D.NativeMethodInfoPtr_OnAxisRawValueChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670008);
			StandaloneAxis2D.NativeMethodInfoPtr_CreateRelative_Internal_Static_StandaloneAxis2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, 100670009);
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x000A167C File Offset: 0x0009F87C
		public unsafe Axis2DCalibration calibration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_calibration_Public_get_Axis2DCalibration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Axis2DCalibration>(intPtr3) : null;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001ECC RID: 7884 RVA: 0x000A16BC File Offset: 0x0009F8BC
		public unsafe StandaloneAxis xAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_xAxis_Public_get_StandaloneAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandaloneAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x000A16FC File Offset: 0x0009F8FC
		public unsafe StandaloneAxis yAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_yAxis_Public_get_StandaloneAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandaloneAxis>(intPtr3) : null;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x000A173C File Offset: 0x0009F93C
		public unsafe Vector2 value
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 281710, RefRangeEnd = 281723, XrefRangeStart = 281707, XrefRangeEnd = 281710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_value_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x000A1778 File Offset: 0x0009F978
		public unsafe Vector2 valuePrev
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 281726, RefRangeEnd = 281730, XrefRangeStart = 281723, XrefRangeEnd = 281726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_valuePrev_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x000A17B4 File Offset: 0x0009F9B4
		public unsafe Vector2 valueDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281730, XrefRangeEnd = 281732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_valueDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x000A17F0 File Offset: 0x0009F9F0
		public unsafe Vector2 rawValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 281735, RefRangeEnd = 281742, XrefRangeStart = 281732, XrefRangeEnd = 281735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_rawValue_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x000A182C File Offset: 0x0009FA2C
		public unsafe Vector2 rawValuePrev
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281742, XrefRangeEnd = 281745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_rawValuePrev_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x000A1868 File Offset: 0x0009FA68
		public unsafe Vector2 rawValueDelta
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281745, XrefRangeEnd = 281749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_rawValueDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x000A18A4 File Offset: 0x0009FAA4
		public unsafe Vector2 rawZero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281749, XrefRangeEnd = 281750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_get_rawZero_Internal_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x000A18E0 File Offset: 0x0009FAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281750, XrefRangeEnd = 281753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__ValueChangedEvent(StandaloneAxis2D.ValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_add__ValueChangedEvent_Private_add_Void_ValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000A1924 File Offset: 0x0009FB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281753, XrefRangeEnd = 281756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__ValueChangedEvent(StandaloneAxis2D.ValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_remove__ValueChangedEvent_Private_rem_Void_ValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000A1968 File Offset: 0x0009FB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ValueChangedEvent(StandaloneAxis2D.ValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_ValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000A19AC File Offset: 0x0009FBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ValueChangedEvent(StandaloneAxis2D.ValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_ValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000A19F0 File Offset: 0x0009FBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281756, XrefRangeEnd = 281759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__RawValueChangedEvent(StandaloneAxis2D.ValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_add__RawValueChangedEvent_Private_add_Void_ValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000A1A34 File Offset: 0x0009FC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281759, XrefRangeEnd = 281762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__RawValueChangedEvent(StandaloneAxis2D.ValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_remove__RawValueChangedEvent_Private_rem_Void_ValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000A1A78 File Offset: 0x0009FC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_RawValueChangedEvent(StandaloneAxis2D.ValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_add_RawValueChangedEvent_Public_add_Void_ValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000A1ABC File Offset: 0x0009FCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_RawValueChangedEvent(StandaloneAxis2D.ValueChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_remove_RawValueChangedEvent_Public_rem_Void_ValueChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x000A1B00 File Offset: 0x0009FD00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281772, RefRangeEnd = 281774, XrefRangeStart = 281762, XrefRangeEnd = 281772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandaloneAxis2D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x000A1B3C File Offset: 0x0009FD3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281784, RefRangeEnd = 281786, XrefRangeStart = 281774, XrefRangeEnd = 281784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandaloneAxis2D(StandaloneAxis xAxis, StandaloneAxis yAxis)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xAxis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(yAxis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr__ctor_Internal_Void_StandaloneAxis_StandaloneAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000A1B9C File Offset: 0x0009FD9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281789, RefRangeEnd = 281791, XrefRangeStart = 281786, XrefRangeEnd = 281789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRawValue(float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_SetRawValue_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000A1BE8 File Offset: 0x0009FDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281791, XrefRangeEnd = 281794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRawValue(Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_SetRawValue_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x000A1C28 File Offset: 0x0009FE28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281798, RefRangeEnd = 281802, XrefRangeStart = 281794, XrefRangeEnd = 281798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000A1C5C File Offset: 0x0009FE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281802, XrefRangeEnd = 281803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_Initialize_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000A1C90 File Offset: 0x0009FE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281803, XrefRangeEnd = 281804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_Deinitialize_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x000A1CC4 File Offset: 0x0009FEC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 281815, RefRangeEnd = 281820, XrefRangeStart = 281804, XrefRangeEnd = 281815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvalAndSendValueChangeEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_EvalAndSendValueChangeEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x000A1CF8 File Offset: 0x0009FEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281840, RefRangeEnd = 281842, XrefRangeStart = 281820, XrefRangeEnd = 281840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x000A1D2C File Offset: 0x0009FF2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281861, RefRangeEnd = 281864, XrefRangeStart = 281842, XrefRangeEnd = 281861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unsubscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_Unsubscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x000A1D60 File Offset: 0x0009FF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281864, XrefRangeEnd = 281867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetCalibratedValue(StandaloneAxis xAxis, StandaloneAxis yAxis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xAxis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(yAxis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_GetCalibratedValue_Private_Vector2_StandaloneAxis_StandaloneAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000A1DC0 File Offset: 0x0009FFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281867, XrefRangeEnd = 281870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetCalibratedValuePrev(StandaloneAxis xAxis, StandaloneAxis yAxis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xAxis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(yAxis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_GetCalibratedValuePrev_Private_Vector2_StandaloneAxis_StandaloneAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000A1E20 File Offset: 0x000A0020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281870, XrefRangeEnd = 281872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAxisValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_OnAxisValueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x000A1E60 File Offset: 0x000A0060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281872, XrefRangeEnd = 281874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAxisRawValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_OnAxisRawValueChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000A1EA0 File Offset: 0x000A00A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281874, XrefRangeEnd = 281880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StandaloneAxis2D CreateRelative()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.NativeMethodInfoPtr_CreateRelative_Internal_Static_StandaloneAxis2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StandaloneAxis2D>(intPtr3) : null;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0000CAA7 File Offset: 0x0000ACA7
		public StandaloneAxis2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x000A1ED4 File Offset: 0x000A00D4
		// (set) Token: 0x06001EEE RID: 7918 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		public unsafe Axis2DCalibration _calibration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__calibration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Axis2DCalibration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__calibration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x000A1F04 File Offset: 0x000A0104
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x0000CACF File Offset: 0x0000ACCF
		public unsafe StandaloneAxis _xAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__xAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__xAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x000A1F34 File Offset: 0x000A0134
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x0000CAEE File Offset: 0x0000ACEE
		public unsafe StandaloneAxis _yAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__yAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__yAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x000A1F64 File Offset: 0x000A0164
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x0000CB0D File Offset: 0x0000AD0D
		public unsafe bool _allowEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__allowEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__allowEvents)) = value;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x000A1F8C File Offset: 0x000A018C
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x0000CB28 File Offset: 0x0000AD28
		public unsafe StandaloneAxis2D.ValueChangedEventHandler _ValueChangedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__ValueChangedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis2D.ValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__ValueChangedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x000A1FBC File Offset: 0x000A01BC
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x0000CB47 File Offset: 0x0000AD47
		public unsafe StandaloneAxis2D.ValueChangedEventHandler _RawValueChangedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__RawValueChangedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandaloneAxis2D.ValueChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneAxis2D.NativeFieldInfoPtr__RawValueChangedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeFieldInfoPtr__calibration;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeFieldInfoPtr__xAxis;

		// Token: 0x04001997 RID: 6551
		private static readonly IntPtr NativeFieldInfoPtr__yAxis;

		// Token: 0x04001998 RID: 6552
		private static readonly IntPtr NativeFieldInfoPtr__allowEvents;

		// Token: 0x04001999 RID: 6553
		private static readonly IntPtr NativeFieldInfoPtr__ValueChangedEvent;

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeFieldInfoPtr__RawValueChangedEvent;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_get_calibration_Public_get_Axis2DCalibration_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_get_xAxis_Public_get_StandaloneAxis_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_get_yAxis_Public_get_StandaloneAxis_0;

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Vector2_0;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr_get_valuePrev_Public_get_Vector2_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_get_valueDelta_Public_get_Vector2_0;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_get_rawValue_Public_get_Vector2_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr_get_rawValuePrev_Public_get_Vector2_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr_get_rawValueDelta_Public_get_Vector2_0;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeMethodInfoPtr_get_rawZero_Internal_get_Vector2_0;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_add__ValueChangedEvent_Private_add_Void_ValueChangedEventHandler_0;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr_remove__ValueChangedEvent_Private_rem_Void_ValueChangedEventHandler_0;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeMethodInfoPtr_add_ValueChangedEvent_Public_add_Void_ValueChangedEventHandler_0;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeMethodInfoPtr_remove_ValueChangedEvent_Public_rem_Void_ValueChangedEventHandler_0;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeMethodInfoPtr_add__RawValueChangedEvent_Private_add_Void_ValueChangedEventHandler_0;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeMethodInfoPtr_remove__RawValueChangedEvent_Private_rem_Void_ValueChangedEventHandler_0;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr_add_RawValueChangedEvent_Public_add_Void_ValueChangedEventHandler_0;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeMethodInfoPtr_remove_RawValueChangedEvent_Public_rem_Void_ValueChangedEventHandler_0;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StandaloneAxis_StandaloneAxis_0;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeMethodInfoPtr_SetRawValue_Public_Void_Single_Single_0;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeMethodInfoPtr_SetRawValue_Public_Void_Vector2_0;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_0;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Internal_Void_0;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeMethodInfoPtr_EvalAndSendValueChangeEvents_Private_Void_0;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeMethodInfoPtr_Unsubscribe_Private_Void_0;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibratedValue_Private_Vector2_StandaloneAxis_StandaloneAxis_0;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr_GetCalibratedValuePrev_Private_Vector2_StandaloneAxis_StandaloneAxis_0;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_OnAxisValueChanged_Private_Void_Single_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr_OnAxisRawValueChanged_Private_Void_Single_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_CreateRelative_Internal_Static_StandaloneAxis2D_0;

		// Token: 0x02000342 RID: 834
		public sealed class ValueChangedEventHandler : MulticastDelegate
		{
			// Token: 0x06004615 RID: 17941 RVA: 0x00145F84 File Offset: 0x00144184
			// Note: this type is marked as 'beforefieldinit'.
			static ValueChangedEventHandler()
			{
				Il2CppClassPointerStore<StandaloneAxis2D.ValueChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StandaloneAxis2D>.NativeClassPtr, "ValueChangedEventHandler");
				StandaloneAxis2D.ValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D.ValueChangedEventHandler>.NativeClassPtr, 100670010);
				StandaloneAxis2D.ValueChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D.ValueChangedEventHandler>.NativeClassPtr, 100670011);
				StandaloneAxis2D.ValueChangedEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D.ValueChangedEventHandler>.NativeClassPtr, 100670012);
				StandaloneAxis2D.ValueChangedEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneAxis2D.ValueChangedEventHandler>.NativeClassPtr, 100670013);
			}

			// Token: 0x06004616 RID: 17942 RVA: 0x00145FF8 File Offset: 0x001441F8
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueChangedEventHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneAxis2D.ValueChangedEventHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.ValueChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004617 RID: 17943 RVA: 0x00146054 File Offset: 0x00144254
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 281695, RefRangeEnd = 281703, XrefRangeStart = 281695, XrefRangeEnd = 281695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Vector2 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.ValueChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004618 RID: 17944 RVA: 0x00146094 File Offset: 0x00144294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281703, XrefRangeEnd = 281707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Vector2 value, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.ValueChangedEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004619 RID: 17945 RVA: 0x00146104 File Offset: 0x00144304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneAxis2D.ValueChangedEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600461A RID: 17946 RVA: 0x000194C6 File Offset: 0x000176C6
			public ValueChangedEventHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600461B RID: 17947 RVA: 0x000194CF File Offset: 0x000176CF
			public static implicit operator StandaloneAxis2D.ValueChangedEventHandler(Action<Vector2> A_0)
			{
				return DelegateSupport.ConvertDelegate<StandaloneAxis2D.ValueChangedEventHandler>(A_0);
			}

			// Token: 0x0600461C RID: 17948 RVA: 0x000194D7 File Offset: 0x000176D7
			public static StandaloneAxis2D.ValueChangedEventHandler operator +(StandaloneAxis2D.ValueChangedEventHandler A_0, StandaloneAxis2D.ValueChangedEventHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StandaloneAxis2D.ValueChangedEventHandler>();
			}

			// Token: 0x0600461D RID: 17949 RVA: 0x000194E5 File Offset: 0x000176E5
			public static StandaloneAxis2D.ValueChangedEventHandler operator -(StandaloneAxis2D.ValueChangedEventHandler A_0, StandaloneAxis2D.ValueChangedEventHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StandaloneAxis2D.ValueChangedEventHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400393F RID: 14655
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003940 RID: 14656
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Vector2_0;

			// Token: 0x04003941 RID: 14657
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_AsyncCallback_Object_0;

			// Token: 0x04003942 RID: 14658
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
