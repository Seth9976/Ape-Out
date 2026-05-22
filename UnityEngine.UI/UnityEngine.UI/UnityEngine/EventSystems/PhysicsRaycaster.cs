using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000071 RID: 113
	public class PhysicsRaycaster : BaseRaycaster
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x000311B8 File Offset: 0x0002F3B8
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsRaycaster()
		{
			Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "PhysicsRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr);
			PhysicsRaycaster.NativeFieldInfoPtr_kNoEventMaskSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "kNoEventMaskSet");
			PhysicsRaycaster.NativeFieldInfoPtr_m_EventCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_EventCamera");
			PhysicsRaycaster.NativeFieldInfoPtr_m_EventMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_EventMask");
			PhysicsRaycaster.NativeFieldInfoPtr_m_MaxRayIntersections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_MaxRayIntersections");
			PhysicsRaycaster.NativeFieldInfoPtr_m_LastMaxRayIntersections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_LastMaxRayIntersections");
			PhysicsRaycaster.NativeFieldInfoPtr_m_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_Hits");
			PhysicsRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665035);
			PhysicsRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665036);
			PhysicsRaycaster.NativeMethodInfoPtr_get_depth_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665037);
			PhysicsRaycaster.NativeMethodInfoPtr_get_finalEventMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665038);
			PhysicsRaycaster.NativeMethodInfoPtr_get_eventMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665039);
			PhysicsRaycaster.NativeMethodInfoPtr_set_eventMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665040);
			PhysicsRaycaster.NativeMethodInfoPtr_get_maxRayIntersections_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665041);
			PhysicsRaycaster.NativeMethodInfoPtr_set_maxRayIntersections_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665042);
			PhysicsRaycaster.NativeMethodInfoPtr_ComputeRayAndDistance_Protected_Boolean_PointerEventData_byref_Ray_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665043);
			PhysicsRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100665044);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00031328 File Offset: 0x0002F528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicsRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00031364 File Offset: 0x0002F564
		public unsafe override Camera eventCamera
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533293, XrefRangeEnd = 533310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x000313B0 File Offset: 0x0002F5B0
		public unsafe virtual int depth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533310, XrefRangeEnd = 533324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsRaycaster.NativeMethodInfoPtr_get_depth_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x000313F8 File Offset: 0x0002F5F8
		public unsafe int finalEventMask
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 533338, RefRangeEnd = 533342, XrefRangeStart = 533324, XrefRangeEnd = 533338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_get_finalEventMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00031434 File Offset: 0x0002F634
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00031470 File Offset: 0x0002F670
		public unsafe LayerMask eventMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_get_eventMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_set_eventMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x000314B0 File Offset: 0x0002F6B0
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x000314EC File Offset: 0x0002F6EC
		public unsafe int maxRayIntersections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_get_maxRayIntersections_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_set_maxRayIntersections_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0003152C File Offset: 0x0002F72C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 533369, RefRangeEnd = 533371, XrefRangeStart = 533342, XrefRangeEnd = 533369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventDisplayIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distanceToClipPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_ComputeRayAndDistance_Protected_Boolean_PointerEventData_byref_Ray_byref_Int32_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000315A4 File Offset: 0x0002F7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533371, XrefRangeEnd = 533408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultAppendList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00005F52 File Offset: 0x00004152
		public PhysicsRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00031604 File Offset: 0x0002F804
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00005F5B File Offset: 0x0000415B
		public unsafe static int kNoEventMaskSet
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PhysicsRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhysicsRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00031620 File Offset: 0x0002F820
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00005F69 File Offset: 0x00004169
		public unsafe Camera m_EventCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00031650 File Offset: 0x0002F850
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00005F88 File Offset: 0x00004188
		public unsafe LayerMask m_EventMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventMask)) = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00031678 File Offset: 0x0002F878
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00005FA3 File Offset: 0x000041A3
		public unsafe int m_MaxRayIntersections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_MaxRayIntersections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_MaxRayIntersections)) = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x000316A0 File Offset: 0x0002F8A0
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00005FBE File Offset: 0x000041BE
		public unsafe int m_LastMaxRayIntersections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_LastMaxRayIntersections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_LastMaxRayIntersections)) = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x000316C8 File Offset: 0x0002F8C8
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00005FD9 File Offset: 0x000041D9
		public unsafe Il2CppStructArray<RaycastHit> m_Hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_Hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_Hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_kNoEventMaskSet;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_m_EventCamera;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr_m_EventMask;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxRayIntersections;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMaxRayIntersections;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr_m_Hits;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_get_finalEventMask_Public_get_Int32_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_get_eventMask_Public_get_LayerMask_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_set_eventMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_get_maxRayIntersections_Public_get_Int32_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_set_maxRayIntersections_Public_set_Void_Int32_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRayAndDistance_Protected_Boolean_PointerEventData_byref_Ray_byref_Int32_byref_Single_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x020000CE RID: 206
		public class RaycastHitComparer : Object
		{
			// Token: 0x06000CDE RID: 3294 RVA: 0x00037190 File Offset: 0x00035390
			// Note: this type is marked as 'beforefieldinit'.
			static RaycastHitComparer()
			{
				Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "RaycastHitComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr);
				PhysicsRaycaster.RaycastHitComparer.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr, "instance");
				PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr, 100665045);
				PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr, 100665046);
			}

			// Token: 0x06000CDF RID: 3295 RVA: 0x000371F8 File Offset: 0x000353F8
			[CallerCount(0)]
			public unsafe virtual int Compare(RaycastHit x, RaycastHit y)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CE0 RID: 3296 RVA: 0x00037250 File Offset: 0x00035450
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastHitComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CE1 RID: 3297 RVA: 0x00006E22 File Offset: 0x00005022
			public RaycastHitComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0003728C File Offset: 0x0003548C
			// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00006E2B File Offset: 0x0000502B
			public unsafe static PhysicsRaycaster.RaycastHitComparer instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PhysicsRaycaster.RaycastHitComparer.NativeFieldInfoPtr_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsRaycaster.RaycastHitComparer>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PhysicsRaycaster.RaycastHitComparer.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A01 RID: 2561
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04000A02 RID: 2562
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0;

			// Token: 0x04000A03 RID: 2563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
