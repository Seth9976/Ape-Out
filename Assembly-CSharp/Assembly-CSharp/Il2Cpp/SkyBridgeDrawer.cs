using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000191 RID: 401
	public class SkyBridgeDrawer : MonoBehaviour
	{
		// Token: 0x06002F14 RID: 12052 RVA: 0x000B6354 File Offset: 0x000B4554
		// Note: this type is marked as 'beforefieldinit'.
		static SkyBridgeDrawer()
		{
			Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkyBridgeDrawer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr);
			SkyBridgeDrawer.NativeFieldInfoPtr_buildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "buildings");
			SkyBridgeDrawer.NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "floor");
			SkyBridgeDrawer.NativeFieldInfoPtr_drawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "drawer");
			SkyBridgeDrawer.NativeFieldInfoPtr_prevFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "prevFloor");
			SkyBridgeDrawer.NativeFieldInfoPtr_shadowMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "shadowMesh");
			SkyBridgeDrawer.NativeFieldInfoPtr_windowMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "windowMesh");
			SkyBridgeDrawer.NativeFieldInfoPtr_windowRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "windowRend");
			SkyBridgeDrawer.NativeFieldInfoPtr_topMeshVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "topMeshVerts");
			SkyBridgeDrawer.NativeFieldInfoPtr_botMeshVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "botMeshVerts");
			SkyBridgeDrawer.NativeFieldInfoPtr_shadowVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "shadowVerts");
			SkyBridgeDrawer.NativeFieldInfoPtr_zeroVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "zeroVerts");
			SkyBridgeDrawer.NativeFieldInfoPtr_windowVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "windowVerts");
			SkyBridgeDrawer.NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "tris");
			SkyBridgeDrawer.NativeFieldInfoPtr_startFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "startFlag");
			SkyBridgeDrawer.NativeFieldInfoPtr_zeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, "zeroed");
			SkyBridgeDrawer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, 100666999);
			SkyBridgeDrawer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, 100667000);
			SkyBridgeDrawer.NativeMethodInfoPtr_GetTopVert_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, 100667001);
			SkyBridgeDrawer.NativeMethodInfoPtr_GetBotVert_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, 100667002);
			SkyBridgeDrawer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr, 100667003);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x000B6514 File Offset: 0x000B4714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83118, XrefRangeEnd = 83122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyBridgeDrawer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x000B6548 File Offset: 0x000B4748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83122, XrefRangeEnd = 83266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyBridgeDrawer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x000B657C File Offset: 0x000B477C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83266, XrefRangeEnd = 83267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTopVert(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyBridgeDrawer.NativeMethodInfoPtr_GetTopVert_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x000B65C8 File Offset: 0x000B47C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83267, XrefRangeEnd = 83268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBotVert(int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyBridgeDrawer.NativeMethodInfoPtr_GetBotVert_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x000B6614 File Offset: 0x000B4814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyBridgeDrawer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyBridgeDrawer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyBridgeDrawer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00020700 File Offset: 0x0001E900
		public SkyBridgeDrawer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x000B6650 File Offset: 0x000B4850
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x00020709 File Offset: 0x0001E909
		public unsafe Il2CppReferenceArray<BuildingDrawer> buildings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_buildings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BuildingDrawer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_buildings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x000B6680 File Offset: 0x000B4880
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00020728 File Offset: 0x0001E928
		public unsafe int floor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_floor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_floor)) = value;
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000B66A8 File Offset: 0x000B48A8
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00020743 File Offset: 0x0001E943
		public unsafe RockTech drawer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_drawer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RockTech>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_drawer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000B66D8 File Offset: 0x000B48D8
		// (set) Token: 0x06002F22 RID: 12066 RVA: 0x00020762 File Offset: 0x0001E962
		public unsafe int prevFloor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_prevFloor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_prevFloor)) = value;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000B6700 File Offset: 0x000B4900
		// (set) Token: 0x06002F24 RID: 12068 RVA: 0x0002077D File Offset: 0x0001E97D
		public unsafe MeshFilter shadowMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_shadowMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_shadowMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x000B6730 File Offset: 0x000B4930
		// (set) Token: 0x06002F26 RID: 12070 RVA: 0x0002079C File Offset: 0x0001E99C
		public unsafe MeshFilter windowMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_windowMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_windowMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x000B6760 File Offset: 0x000B4960
		// (set) Token: 0x06002F28 RID: 12072 RVA: 0x000207BB File Offset: 0x0001E9BB
		public unsafe MeshRenderer windowRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_windowRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_windowRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x000B6790 File Offset: 0x000B4990
		// (set) Token: 0x06002F2A RID: 12074 RVA: 0x000207DA File Offset: 0x0001E9DA
		public unsafe Il2CppStructArray<Vector3> topMeshVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_topMeshVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_topMeshVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x000B67C0 File Offset: 0x000B49C0
		// (set) Token: 0x06002F2C RID: 12076 RVA: 0x000207F9 File Offset: 0x0001E9F9
		public unsafe Il2CppStructArray<Vector3> botMeshVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_botMeshVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_botMeshVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000B67F0 File Offset: 0x000B49F0
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x00020818 File Offset: 0x0001EA18
		public unsafe List<Vector3> shadowVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_shadowVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_shadowVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06002F2F RID: 12079 RVA: 0x000B6820 File Offset: 0x000B4A20
		// (set) Token: 0x06002F30 RID: 12080 RVA: 0x00020837 File Offset: 0x0001EA37
		public unsafe List<Vector3> zeroVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_zeroVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_zeroVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000B6850 File Offset: 0x000B4A50
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x00020856 File Offset: 0x0001EA56
		public unsafe List<Vector3> windowVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_windowVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_windowVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x000B6880 File Offset: 0x000B4A80
		// (set) Token: 0x06002F34 RID: 12084 RVA: 0x00020875 File Offset: 0x0001EA75
		public unsafe Il2CppStructArray<int> tris
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_tris);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_tris), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06002F35 RID: 12085 RVA: 0x000B68B0 File Offset: 0x000B4AB0
		// (set) Token: 0x06002F36 RID: 12086 RVA: 0x00020894 File Offset: 0x0001EA94
		public unsafe bool startFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_startFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_startFlag)) = value;
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x000B68D8 File Offset: 0x000B4AD8
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x000208AF File Offset: 0x0001EAAF
		public unsafe bool zeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_zeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyBridgeDrawer.NativeFieldInfoPtr_zeroed)) = value;
			}
		}

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeFieldInfoPtr_buildings;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeFieldInfoPtr_floor;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeFieldInfoPtr_drawer;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeFieldInfoPtr_prevFloor;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeFieldInfoPtr_shadowMesh;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeFieldInfoPtr_windowMesh;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeFieldInfoPtr_windowRend;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeFieldInfoPtr_topMeshVerts;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeFieldInfoPtr_botMeshVerts;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeFieldInfoPtr_shadowVerts;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeFieldInfoPtr_zeroVerts;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeFieldInfoPtr_windowVerts;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeFieldInfoPtr_tris;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeFieldInfoPtr_startFlag;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeFieldInfoPtr_zeroed;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr_GetTopVert_Public_Int32_Int32_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_GetBotVert_Public_Int32_Int32_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
