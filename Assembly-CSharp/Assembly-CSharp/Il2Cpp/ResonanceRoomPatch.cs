using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002E RID: 46
	public class ResonanceRoomPatch : ScriptableObject
	{
		// Token: 0x060005AF RID: 1455 RVA: 0x00045684 File Offset: 0x00043884
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceRoomPatch()
		{
			Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceRoomPatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr);
			ResonanceRoomPatch.NativeFieldInfoPtr_AmIEvenARoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "AmIEvenARoom");
			ResonanceRoomPatch.NativeFieldInfoPtr_leftWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "leftWall");
			ResonanceRoomPatch.NativeFieldInfoPtr_rightWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "rightWall");
			ResonanceRoomPatch.NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "floor");
			ResonanceRoomPatch.NativeFieldInfoPtr_ceiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "ceiling");
			ResonanceRoomPatch.NativeFieldInfoPtr_backWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "backWall");
			ResonanceRoomPatch.NativeFieldInfoPtr_frontWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "frontWall");
			ResonanceRoomPatch.NativeFieldInfoPtr_reflectivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "reflectivity");
			ResonanceRoomPatch.NativeFieldInfoPtr_reverbGainDb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "reverbGainDb");
			ResonanceRoomPatch.NativeFieldInfoPtr_reverbBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "reverbBrightness");
			ResonanceRoomPatch.NativeFieldInfoPtr_reverbTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "reverbTime");
			ResonanceRoomPatch.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, "size");
			ResonanceRoomPatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr, 100663792);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000457B8 File Offset: 0x000439B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35630, XrefRangeEnd = 35631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceRoomPatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceRoomPatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceRoomPatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000056A5 File Offset: 0x000038A5
		public ResonanceRoomPatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000457F4 File Offset: 0x000439F4
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x000056AE File Offset: 0x000038AE
		public unsafe bool AmIEvenARoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_AmIEvenARoom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_AmIEvenARoom)) = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0004581C File Offset: 0x00043A1C
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x000056C9 File Offset: 0x000038C9
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial leftWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_leftWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_leftWall)) = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00045844 File Offset: 0x00043A44
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x000056E4 File Offset: 0x000038E4
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial rightWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_rightWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_rightWall)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0004586C File Offset: 0x00043A6C
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x000056FF File Offset: 0x000038FF
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial floor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_floor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_floor)) = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00045894 File Offset: 0x00043A94
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x0000571A File Offset: 0x0000391A
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial ceiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_ceiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_ceiling)) = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x000458BC File Offset: 0x00043ABC
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00005735 File Offset: 0x00003935
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial backWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_backWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_backWall)) = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x000458E4 File Offset: 0x00043AE4
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00005750 File Offset: 0x00003950
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial frontWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_frontWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_frontWall)) = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0004590C File Offset: 0x00043B0C
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x0000576B File Offset: 0x0000396B
		public unsafe float reflectivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_reflectivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_reflectivity)) = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00045934 File Offset: 0x00043B34
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00005786 File Offset: 0x00003986
		public unsafe float reverbGainDb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_reverbGainDb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_reverbGainDb)) = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0004595C File Offset: 0x00043B5C
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x000057A1 File Offset: 0x000039A1
		public unsafe float reverbBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_reverbBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_reverbBrightness)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00045984 File Offset: 0x00043B84
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x000057BC File Offset: 0x000039BC
		public unsafe float reverbTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_reverbTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_reverbTime)) = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x000459AC File Offset: 0x00043BAC
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x000057D7 File Offset: 0x000039D7
		public unsafe Vector3 size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceRoomPatch.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_AmIEvenARoom;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr_leftWall;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr_rightWall;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeFieldInfoPtr_floor;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeFieldInfoPtr_ceiling;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr_backWall;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_frontWall;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_reflectivity;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_reverbGainDb;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_reverbBrightness;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr_reverbTime;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
