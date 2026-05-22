using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001A RID: 26
	public class ResonanceAudioRoom : MonoBehaviour
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x0003E124 File Offset: 0x0003C324
		// Note: this type is marked as 'beforefieldinit'.
		static ResonanceAudioRoom()
		{
			Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResonanceAudioRoom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr);
			ResonanceAudioRoom.NativeFieldInfoPtr_leftWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "leftWall");
			ResonanceAudioRoom.NativeFieldInfoPtr_rightWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "rightWall");
			ResonanceAudioRoom.NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "floor");
			ResonanceAudioRoom.NativeFieldInfoPtr_ceiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "ceiling");
			ResonanceAudioRoom.NativeFieldInfoPtr_backWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "backWall");
			ResonanceAudioRoom.NativeFieldInfoPtr_frontWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "frontWall");
			ResonanceAudioRoom.NativeFieldInfoPtr_reflectivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "reflectivity");
			ResonanceAudioRoom.NativeFieldInfoPtr_reverbGainDb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "reverbGainDb");
			ResonanceAudioRoom.NativeFieldInfoPtr_reverbBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "reverbBrightness");
			ResonanceAudioRoom.NativeFieldInfoPtr_reverbTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "reverbTime");
			ResonanceAudioRoom.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, "size");
			ResonanceAudioRoom.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, 100663530);
			ResonanceAudioRoom.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, 100663531);
			ResonanceAudioRoom.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, 100663532);
			ResonanceAudioRoom.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, 100663533);
			ResonanceAudioRoom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr, 100663534);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0003E294 File Offset: 0x0003C494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33916, XrefRangeEnd = 33920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoom.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0003E2C8 File Offset: 0x0003C4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33920, XrefRangeEnd = 33929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoom.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0003E2FC File Offset: 0x0003C4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33929, XrefRangeEnd = 33933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoom.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0003E330 File Offset: 0x0003C530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33933, XrefRangeEnd = 33945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoom.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0003E364 File Offset: 0x0003C564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33945, XrefRangeEnd = 33950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResonanceAudioRoom()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResonanceAudioRoom>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResonanceAudioRoom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000474B File Offset: 0x0000294B
		public ResonanceAudioRoom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0003E3A0 File Offset: 0x0003C5A0
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00004754 File Offset: 0x00002954
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial leftWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_leftWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_leftWall)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
		// (set) Token: 0x060003AC RID: 940 RVA: 0x0000476F File Offset: 0x0000296F
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial rightWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_rightWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_rightWall)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0003E3F0 File Offset: 0x0003C5F0
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000478A File Offset: 0x0000298A
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial floor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_floor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_floor)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0003E418 File Offset: 0x0003C618
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x000047A5 File Offset: 0x000029A5
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial ceiling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_ceiling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_ceiling)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0003E440 File Offset: 0x0003C640
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x000047C0 File Offset: 0x000029C0
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial backWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_backWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_backWall)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0003E468 File Offset: 0x0003C668
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x000047DB File Offset: 0x000029DB
		public unsafe ResonanceAudioRoomManager.SurfaceMaterial frontWall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_frontWall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_frontWall)) = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0003E490 File Offset: 0x0003C690
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x000047F6 File Offset: 0x000029F6
		public unsafe float reflectivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_reflectivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_reflectivity)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0003E4B8 File Offset: 0x0003C6B8
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00004811 File Offset: 0x00002A11
		public unsafe float reverbGainDb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_reverbGainDb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_reverbGainDb)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0003E4E0 File Offset: 0x0003C6E0
		// (set) Token: 0x060003BA RID: 954 RVA: 0x0000482C File Offset: 0x00002A2C
		public unsafe float reverbBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_reverbBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_reverbBrightness)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0003E508 File Offset: 0x0003C708
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00004847 File Offset: 0x00002A47
		public unsafe float reverbTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_reverbTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_reverbTime)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0003E530 File Offset: 0x0003C730
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00004862 File Offset: 0x00002A62
		public unsafe Vector3 size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResonanceAudioRoom.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_leftWall;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_rightWall;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_floor;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_ceiling;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_backWall;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_frontWall;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_reflectivity;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_reverbGainDb;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_reverbBrightness;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr_reverbTime;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
