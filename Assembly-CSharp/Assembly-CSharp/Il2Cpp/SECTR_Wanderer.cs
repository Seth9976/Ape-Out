using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200005B RID: 91
	public class SECTR_Wanderer : MonoBehaviour
	{
		// Token: 0x06000CD6 RID: 3286 RVA: 0x0005AC2C File Offset: 0x00058E2C
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_Wanderer()
		{
			Il2CppClassPointerStore<SECTR_Wanderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_Wanderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Wanderer>.NativeClassPtr);
			SECTR_Wanderer.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Wanderer>.NativeClassPtr, "path");
			SECTR_Wanderer.NativeFieldInfoPtr_waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Wanderer>.NativeClassPtr, "waypoints");
			SECTR_Wanderer.NativeFieldInfoPtr_currentWaypointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Wanderer>.NativeClassPtr, "currentWaypointIndex");
			SECTR_Wanderer.NativeFieldInfoPtr_MovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Wanderer>.NativeClassPtr, "MovementSpeed");
			SECTR_Wanderer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Wanderer>.NativeClassPtr, 100664436);
			SECTR_Wanderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Wanderer>.NativeClassPtr, 100664437);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0005ACD4 File Offset: 0x00058ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43467, XrefRangeEnd = 43529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Wanderer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0005AD08 File Offset: 0x00058F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43529, XrefRangeEnd = 43548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_Wanderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Wanderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Wanderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00009C48 File Offset: 0x00007E48
		public SECTR_Wanderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0005AD44 File Offset: 0x00058F44
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00009C51 File Offset: 0x00007E51
		public unsafe List<SECTR_Graph.Node> path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Wanderer.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Graph.Node>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Wanderer.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0005AD74 File Offset: 0x00058F74
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00009C70 File Offset: 0x00007E70
		public unsafe List<Vector3> waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Wanderer.NativeFieldInfoPtr_waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Wanderer.NativeFieldInfoPtr_waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0005ADA4 File Offset: 0x00058FA4
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00009C8F File Offset: 0x00007E8F
		public unsafe int currentWaypointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Wanderer.NativeFieldInfoPtr_currentWaypointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Wanderer.NativeFieldInfoPtr_currentWaypointIndex)) = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0005ADCC File Offset: 0x00058FCC
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00009CAA File Offset: 0x00007EAA
		public unsafe float MovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Wanderer.NativeFieldInfoPtr_MovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Wanderer.NativeFieldInfoPtr_MovementSpeed)) = value;
			}
		}

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeFieldInfoPtr_waypoints;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr_currentWaypointIndex;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeFieldInfoPtr_MovementSpeed;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
