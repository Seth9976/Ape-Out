using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000051 RID: 81
	public class SECTR_Sector : SECTR_Member
	{
		// Token: 0x06000BE5 RID: 3045 RVA: 0x00057AC4 File Offset: 0x00055CC4
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_Sector()
		{
			Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_Sector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr);
			SECTR_Sector.NativeFieldInfoPtr_portals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, "portals");
			SECTR_Sector.NativeFieldInfoPtr_members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, "members");
			SECTR_Sector.NativeFieldInfoPtr_visited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, "visited");
			SECTR_Sector.NativeFieldInfoPtr_allSectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, "allSectors");
			SECTR_Sector.NativeFieldInfoPtr_TopTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, "TopTerrain");
			SECTR_Sector.NativeFieldInfoPtr_BottomTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, "BottomTerrain");
			SECTR_Sector.NativeFieldInfoPtr_LeftTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, "LeftTerrain");
			SECTR_Sector.NativeFieldInfoPtr_RightTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, "RightTerrain");
			SECTR_Sector.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664328);
			SECTR_Sector.NativeMethodInfoPtr_get_All_Public_Static_get_List_1_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664329);
			SECTR_Sector.NativeMethodInfoPtr_GetContaining_Public_Static_Void_byref_List_1_SECTR_Sector_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664330);
			SECTR_Sector.NativeMethodInfoPtr_GetContaining_Public_Static_Void_byref_List_1_SECTR_Sector_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664331);
			SECTR_Sector.NativeMethodInfoPtr_get_Visited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664332);
			SECTR_Sector.NativeMethodInfoPtr_set_Visited_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664333);
			SECTR_Sector.NativeMethodInfoPtr_get_Portals_Public_get_List_1_SECTR_Portal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664334);
			SECTR_Sector.NativeMethodInfoPtr_get_Members_Public_get_List_1_SECTR_Member_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664335);
			SECTR_Sector.NativeMethodInfoPtr_get_IsConnectedTerrain_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664336);
			SECTR_Sector.NativeMethodInfoPtr_ConnectTerrainNeighbors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664337);
			SECTR_Sector.NativeMethodInfoPtr_DisonnectTerrainNeighbors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664338);
			SECTR_Sector.NativeMethodInfoPtr_Register_Public_Void_SECTR_Portal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664339);
			SECTR_Sector.NativeMethodInfoPtr_Deregister_Public_Void_SECTR_Portal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664340);
			SECTR_Sector.NativeMethodInfoPtr_Register_Public_Void_SECTR_Member_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664341);
			SECTR_Sector.NativeMethodInfoPtr_Deregister_Public_Void_SECTR_Member_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664342);
			SECTR_Sector.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664343);
			SECTR_Sector.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664344);
			SECTR_Sector.NativeMethodInfoPtr_GetTerrain_Protected_Static_Terrain_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr, 100664345);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00057CFC File Offset: 0x00055EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42151, XrefRangeEnd = 42171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_Sector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Sector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00057D38 File Offset: 0x00055F38
		public new unsafe static List<SECTR_Sector> All
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42171, XrefRangeEnd = 42175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_get_All_Public_Static_get_List_1_SECTR_Sector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Sector>>(intPtr3) : null;
			}
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00057D6C File Offset: 0x00055F6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42192, RefRangeEnd = 42194, XrefRangeStart = 42175, XrefRangeEnd = 42192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetContaining(ref List<SECTR_Sector> sectors, Vector3 position)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sectors);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_GetContaining_Public_Static_Void_byref_List_1_SECTR_Sector_Vector3_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sectors = ((intPtr4 == 0) ? null : new List<SECTR_Sector>(intPtr4));
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00057DC8 File Offset: 0x00055FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42194, XrefRangeEnd = 42209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetContaining(ref List<SECTR_Sector> sectors, Bounds bounds)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(sectors);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_GetContaining_Public_Static_Void_byref_List_1_SECTR_Sector_Bounds_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sectors = ((intPtr4 == 0) ? null : new List<SECTR_Sector>(intPtr4));
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00057E24 File Offset: 0x00056024
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00057E60 File Offset: 0x00056060
		public unsafe bool Visited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_get_Visited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_set_Visited_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00057EA0 File Offset: 0x000560A0
		public unsafe List<SECTR_Portal> Portals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_get_Portals_Public_get_List_1_SECTR_Portal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Portal>>(intPtr3) : null;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00057EE0 File Offset: 0x000560E0
		public unsafe List<SECTR_Member> Members
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_get_Members_Public_get_List_1_SECTR_Member_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member>>(intPtr3) : null;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00057F20 File Offset: 0x00056120
		public unsafe bool IsConnectedTerrain
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42209, XrefRangeEnd = 42222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_get_IsConnectedTerrain_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00057F5C File Offset: 0x0005615C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42222, XrefRangeEnd = 42237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectTerrainNeighbors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_ConnectTerrainNeighbors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00057F90 File Offset: 0x00056190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42237, XrefRangeEnd = 42295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisonnectTerrainNeighbors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_DisonnectTerrainNeighbors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00057FC4 File Offset: 0x000561C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 42301, RefRangeEnd = 42305, XrefRangeStart = 42295, XrefRangeEnd = 42301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(SECTR_Portal portal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(portal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_Register_Public_Void_SECTR_Portal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00058008 File Offset: 0x00056208
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 42307, RefRangeEnd = 42311, XrefRangeStart = 42305, XrefRangeEnd = 42307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deregister(SECTR_Portal portal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(portal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_Deregister_Public_Void_SECTR_Portal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0005804C File Offset: 0x0005624C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42315, RefRangeEnd = 42316, XrefRangeStart = 42311, XrefRangeEnd = 42315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(SECTR_Member member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_Register_Public_Void_SECTR_Member_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00058090 File Offset: 0x00056290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42318, RefRangeEnd = 42319, XrefRangeStart = 42316, XrefRangeEnd = 42318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deregister(SECTR_Member member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_Deregister_Public_Void_SECTR_Member_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000580D4 File Offset: 0x000562D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42319, XrefRangeEnd = 42356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Sector.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00058110 File Offset: 0x00056310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42356, XrefRangeEnd = 42378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Sector.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0005814C File Offset: 0x0005634C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 42383, RefRangeEnd = 42410, XrefRangeStart = 42378, XrefRangeEnd = 42383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Terrain GetTerrain(SECTR_Sector sector)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Sector.NativeMethodInfoPtr_GetTerrain_Protected_Static_Terrain_SECTR_Sector_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr3) : null;
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00009495 File Offset: 0x00007695
		public SECTR_Sector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00058190 File Offset: 0x00056390
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x0000949E File Offset: 0x0000769E
		public unsafe List<SECTR_Portal> portals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_portals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Portal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_portals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x000581C0 File Offset: 0x000563C0
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x000094BD File Offset: 0x000076BD
		public unsafe List<SECTR_Member> members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x000581F0 File Offset: 0x000563F0
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x000094DC File Offset: 0x000076DC
		public unsafe bool visited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_visited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_visited)) = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00058218 File Offset: 0x00056418
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x000094F7 File Offset: 0x000076F7
		public unsafe static List<SECTR_Sector> allSectors
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Sector.NativeFieldInfoPtr_allSectors, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Sector>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Sector.NativeFieldInfoPtr_allSectors, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00058240 File Offset: 0x00056440
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00009509 File Offset: 0x00007709
		public unsafe SECTR_Sector TopTerrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_TopTerrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_TopTerrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00058270 File Offset: 0x00056470
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00009528 File Offset: 0x00007728
		public unsafe SECTR_Sector BottomTerrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_BottomTerrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_BottomTerrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x000582A0 File Offset: 0x000564A0
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00009547 File Offset: 0x00007747
		public unsafe SECTR_Sector LeftTerrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_LeftTerrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_LeftTerrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x000582D0 File Offset: 0x000564D0
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x00009566 File Offset: 0x00007766
		public unsafe SECTR_Sector RightTerrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_RightTerrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Sector.NativeFieldInfoPtr_RightTerrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr_portals;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr_members;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr_visited;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr_allSectors;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr_TopTerrain;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr_BottomTerrain;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr_LeftTerrain;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr_RightTerrain;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_List_1_SECTR_Sector_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_GetContaining_Public_Static_Void_byref_List_1_SECTR_Sector_Vector3_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_GetContaining_Public_Static_Void_byref_List_1_SECTR_Sector_Bounds_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_get_Visited_Public_get_Boolean_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_set_Visited_Public_set_Void_Boolean_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_get_Portals_Public_get_List_1_SECTR_Portal_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_get_Members_Public_get_List_1_SECTR_Member_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnectedTerrain_Public_get_Boolean_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_ConnectTerrainNeighbors_Public_Void_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_DisonnectTerrainNeighbors_Public_Void_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_SECTR_Portal_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_Deregister_Public_Void_SECTR_Portal_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_SECTR_Member_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_Deregister_Public_Void_SECTR_Member_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_GetTerrain_Protected_Static_Terrain_SECTR_Sector_0;
	}
}
