using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200004D RID: 77
	public class SECTR_Member : MonoBehaviour
	{
		// Token: 0x06000B35 RID: 2869 RVA: 0x000557FC File Offset: 0x000539FC
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_Member()
		{
			Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_Member");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr);
			SECTR_Member.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "children");
			SECTR_Member.NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "renderers");
			SECTR_Member.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "lights");
			SECTR_Member.NativeFieldInfoPtr_terrains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "terrains");
			SECTR_Member.NativeFieldInfoPtr_shadowLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "shadowLights");
			SECTR_Member.NativeFieldInfoPtr_shadowCasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "shadowCasters");
			SECTR_Member.NativeFieldInfoPtr_totalBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "totalBounds");
			SECTR_Member.NativeFieldInfoPtr_renderBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "renderBounds");
			SECTR_Member.NativeFieldInfoPtr_lightBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "lightBounds");
			SECTR_Member.NativeFieldInfoPtr_hasRenderBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "hasRenderBounds");
			SECTR_Member.NativeFieldInfoPtr_hasLightBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "hasLightBounds");
			SECTR_Member.NativeFieldInfoPtr_shadowCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "shadowCaster");
			SECTR_Member.NativeFieldInfoPtr_shadowLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "shadowLight");
			SECTR_Member.NativeFieldInfoPtr_frozen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "frozen");
			SECTR_Member.NativeFieldInfoPtr_neverJoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "neverJoin");
			SECTR_Member.NativeFieldInfoPtr_bakedOnlyLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "bakedOnlyLights");
			SECTR_Member.NativeFieldInfoPtr_isSector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "isSector");
			SECTR_Member.NativeFieldInfoPtr_childProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "childProxy");
			SECTR_Member.NativeFieldInfoPtr_hasChildProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "hasChildProxy");
			SECTR_Member.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "started");
			SECTR_Member.NativeFieldInfoPtr_usedStartSector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "usedStartSector");
			SECTR_Member.NativeFieldInfoPtr_sectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "sectors");
			SECTR_Member.NativeFieldInfoPtr_newSectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "newSectors");
			SECTR_Member.NativeFieldInfoPtr_leftSectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "leftSectors");
			SECTR_Member.NativeFieldInfoPtr_childTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "childTable");
			SECTR_Member.NativeFieldInfoPtr_bakedOnlyTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "bakedOnlyTable");
			SECTR_Member.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "lastPosition");
			SECTR_Member.NativeFieldInfoPtr_childPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "childPool");
			SECTR_Member.NativeFieldInfoPtr_allMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "allMembers");
			SECTR_Member.NativeFieldInfoPtr_allMemberTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "allMemberTable");
			SECTR_Member.NativeFieldInfoPtr_PortalDetermined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "PortalDetermined");
			SECTR_Member.NativeFieldInfoPtr_ForceStartSector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "ForceStartSector");
			SECTR_Member.NativeFieldInfoPtr_BoundsUpdateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "BoundsUpdateMode");
			SECTR_Member.NativeFieldInfoPtr_ExtraBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "ExtraBounds");
			SECTR_Member.NativeFieldInfoPtr_OverrideBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "OverrideBounds");
			SECTR_Member.NativeFieldInfoPtr_BoundsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "BoundsOverride");
			SECTR_Member.NativeFieldInfoPtr_DirShadowCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "DirShadowCaster");
			SECTR_Member.NativeFieldInfoPtr_DirShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "DirShadowDistance");
			SECTR_Member.NativeFieldInfoPtr_ChildCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "ChildCulling");
			SECTR_Member.NativeFieldInfoPtr_LastVisibleFrameNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "LastVisibleFrameNumber");
			SECTR_Member.NativeFieldInfoPtr_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "Changed");
			SECTR_Member.NativeMethodInfoPtr_get_All_Public_Static_get_List_1_SECTR_Member_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664243);
			SECTR_Member.NativeMethodInfoPtr_get_CullEachChild_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664244);
			SECTR_Member.NativeMethodInfoPtr_get_Sectors_Public_get_List_1_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664245);
			SECTR_Member.NativeMethodInfoPtr_get_Children_Public_get_List_1_Child_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664246);
			SECTR_Member.NativeMethodInfoPtr_get_Renderers_Public_get_List_1_Child_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664247);
			SECTR_Member.NativeMethodInfoPtr_get_ShadowCaster_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664248);
			SECTR_Member.NativeMethodInfoPtr_get_ShadowCasters_Public_get_List_1_Child_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664249);
			SECTR_Member.NativeMethodInfoPtr_get_Lights_Public_get_List_1_Child_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664250);
			SECTR_Member.NativeMethodInfoPtr_get_ShadowLight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664251);
			SECTR_Member.NativeMethodInfoPtr_get_ShadowLights_Public_get_List_1_Child_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664252);
			SECTR_Member.NativeMethodInfoPtr_get_Terrains_Public_get_List_1_Child_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664253);
			SECTR_Member.NativeMethodInfoPtr_get_TotalBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664254);
			SECTR_Member.NativeMethodInfoPtr_get_RenderBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664255);
			SECTR_Member.NativeMethodInfoPtr_get_HasRenderBounds_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664256);
			SECTR_Member.NativeMethodInfoPtr_get_LightBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664257);
			SECTR_Member.NativeMethodInfoPtr_get_HasLightBounds_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664258);
			SECTR_Member.NativeMethodInfoPtr_IsVisibleThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664259);
			SECTR_Member.NativeMethodInfoPtr_WasVisibleLastFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664260);
			SECTR_Member.NativeMethodInfoPtr_set_Frozen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664261);
			SECTR_Member.NativeMethodInfoPtr_get_Frozen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664262);
			SECTR_Member.NativeMethodInfoPtr_set_ChildProxy_Public_set_Void_SECTR_Member_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664263);
			SECTR_Member.NativeMethodInfoPtr_set_NeverJoin_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664264);
			SECTR_Member.NativeMethodInfoPtr_get_IsSector_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664265);
			SECTR_Member.NativeMethodInfoPtr_ForceUpdate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664266);
			SECTR_Member.NativeMethodInfoPtr_SectorDisabled_Public_Void_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664267);
			SECTR_Member.NativeMethodInfoPtr_add_Changed_Public_add_Void_MembershipChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664268);
			SECTR_Member.NativeMethodInfoPtr_remove_Changed_Public_rem_Void_MembershipChanged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664269);
			SECTR_Member.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664270);
			SECTR_Member.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664271);
			SECTR_Member.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664272);
			SECTR_Member.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664273);
			SECTR_Member.NativeMethodInfoPtr__UpdateChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664274);
			SECTR_Member.NativeMethodInfoPtr__AddChildren_Private_Void_Transform_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664275);
			SECTR_Member.NativeMethodInfoPtr__UpdateSectorMembership_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664276);
			SECTR_Member.NativeMethodInfoPtr__CrossedPortal_Private_SECTR_Portal_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664277);
			SECTR_Member.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, 100664278);
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00055E30 File Offset: 0x00054030
		public unsafe static List<SECTR_Member> All
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41473, XrefRangeEnd = 41477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_All_Public_Static_get_List_1_SECTR_Member_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member>>(intPtr3) : null;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00055E64 File Offset: 0x00054064
		public unsafe bool CullEachChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_CullEachChild_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00055EA0 File Offset: 0x000540A0
		public unsafe List<SECTR_Sector> Sectors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_Sectors_Public_get_List_1_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Sector>>(intPtr3) : null;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00055EE0 File Offset: 0x000540E0
		public unsafe List<SECTR_Member.Child> Children
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_Children_Public_get_List_1_Child_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr3) : null;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00055F20 File Offset: 0x00054120
		public unsafe List<SECTR_Member.Child> Renderers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_Renderers_Public_get_List_1_Child_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr3) : null;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00055F60 File Offset: 0x00054160
		public unsafe bool ShadowCaster
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_ShadowCaster_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00055F9C File Offset: 0x0005419C
		public unsafe List<SECTR_Member.Child> ShadowCasters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_ShadowCasters_Public_get_List_1_Child_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr3) : null;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00055FDC File Offset: 0x000541DC
		public unsafe List<SECTR_Member.Child> Lights
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_Lights_Public_get_List_1_Child_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr3) : null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0005601C File Offset: 0x0005421C
		public unsafe bool ShadowLight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_ShadowLight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00056058 File Offset: 0x00054258
		public unsafe List<SECTR_Member.Child> ShadowLights
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_ShadowLights_Public_get_List_1_Child_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr3) : null;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x00056098 File Offset: 0x00054298
		public unsafe List<SECTR_Member.Child> Terrains
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_Terrains_Public_get_List_1_Child_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr3) : null;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x000560D8 File Offset: 0x000542D8
		public unsafe Bounds TotalBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_TotalBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00056114 File Offset: 0x00054314
		public unsafe Bounds RenderBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_RenderBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00056150 File Offset: 0x00054350
		public unsafe bool HasRenderBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_HasRenderBounds_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0005618C File Offset: 0x0005438C
		public unsafe Bounds LightBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_LightBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x000561C8 File Offset: 0x000543C8
		public unsafe bool HasLightBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_HasLightBounds_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00056204 File Offset: 0x00054404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41477, XrefRangeEnd = 41479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsVisibleThisFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_IsVisibleThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00056240 File Offset: 0x00054440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41479, XrefRangeEnd = 41481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WasVisibleLastFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_WasVisibleLastFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000562BC File Offset: 0x000544BC
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x0005627C File Offset: 0x0005447C
		public unsafe bool Frozen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_Frozen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_set_Frozen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000449 RID: 1097
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x000562F8 File Offset: 0x000544F8
		public unsafe SECTR_Member ChildProxy
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41481, XrefRangeEnd = 41493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_set_ChildProxy_Public_set_Void_SECTR_Member_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700044A RID: 1098
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x0005633C File Offset: 0x0005453C
		public unsafe bool NeverJoin
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_set_NeverJoin_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0005637C File Offset: 0x0005457C
		public unsafe bool IsSector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_get_IsSector_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000563B8 File Offset: 0x000545B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41499, RefRangeEnd = 41501, XrefRangeStart = 41493, XrefRangeEnd = 41499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceUpdate(bool updateChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateChildren;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_ForceUpdate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000563F8 File Offset: 0x000545F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41513, RefRangeEnd = 41514, XrefRangeStart = 41501, XrefRangeEnd = 41513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SectorDisabled(SECTR_Sector sector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_SectorDisabled_Public_Void_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0005643C File Offset: 0x0005463C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41514, XrefRangeEnd = 41517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Changed(SECTR_Member.MembershipChanged value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_add_Changed_Public_add_Void_MembershipChanged_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00056480 File Offset: 0x00054680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41517, XrefRangeEnd = 41520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Changed(SECTR_Member.MembershipChanged value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_remove_Changed_Public_rem_Void_MembershipChanged_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000564C4 File Offset: 0x000546C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41520, XrefRangeEnd = 41523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000564F8 File Offset: 0x000546F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41549, RefRangeEnd = 41550, XrefRangeStart = 41523, XrefRangeEnd = 41549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Member.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00056534 File Offset: 0x00054734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41595, RefRangeEnd = 41596, XrefRangeStart = 41550, XrefRangeEnd = 41595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Member.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00056570 File Offset: 0x00054770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41596, XrefRangeEnd = 41610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000565A4 File Offset: 0x000547A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41702, RefRangeEnd = 41704, XrefRangeStart = 41610, XrefRangeEnd = 41702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr__UpdateChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000565D8 File Offset: 0x000547D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41813, RefRangeEnd = 41815, XrefRangeStart = 41704, XrefRangeEnd = 41813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddChildren(Transform childTransform, bool dirShadowCaster, Vector3 shadowVec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirShadowCaster;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowVec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr__AddChildren_Private_Void_Transform_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00056638 File Offset: 0x00054838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41835, RefRangeEnd = 41837, XrefRangeStart = 41815, XrefRangeEnd = 41835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateSectorMembership()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr__UpdateSectorMembership_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0005666C File Offset: 0x0005486C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41837, XrefRangeEnd = 41879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_Portal _CrossedPortal(SECTR_Sector sector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr__CrossedPortal_Private_SECTR_Portal_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SECTR_Portal>(intPtr3) : null;
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x000566BC File Offset: 0x000548BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41974, RefRangeEnd = 41975, XrefRangeStart = 41879, XrefRangeEnd = 41974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SECTR_Member()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00008EFD File Offset: 0x000070FD
		public SECTR_Member(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000566F8 File Offset: 0x000548F8
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00008F06 File Offset: 0x00007106
		public unsafe List<SECTR_Member.Child> children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00056728 File Offset: 0x00054928
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00008F25 File Offset: 0x00007125
		public unsafe List<SECTR_Member.Child> renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00056758 File Offset: 0x00054958
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00008F44 File Offset: 0x00007144
		public unsafe List<SECTR_Member.Child> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00056788 File Offset: 0x00054988
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00008F63 File Offset: 0x00007163
		public unsafe List<SECTR_Member.Child> terrains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_terrains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_terrains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000567B8 File Offset: 0x000549B8
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00008F82 File Offset: 0x00007182
		public unsafe List<SECTR_Member.Child> shadowLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_shadowLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_shadowLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000567E8 File Offset: 0x000549E8
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00008FA1 File Offset: 0x000071A1
		public unsafe List<SECTR_Member.Child> shadowCasters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_shadowCasters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member.Child>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_shadowCasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00056818 File Offset: 0x00054A18
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00008FC0 File Offset: 0x000071C0
		public unsafe Bounds totalBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_totalBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_totalBounds)) = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00056840 File Offset: 0x00054A40
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00008FDB File Offset: 0x000071DB
		public unsafe Bounds renderBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_renderBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_renderBounds)) = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00056868 File Offset: 0x00054A68
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00008FF6 File Offset: 0x000071F6
		public unsafe Bounds lightBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_lightBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_lightBounds)) = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00056890 File Offset: 0x00054A90
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x00009011 File Offset: 0x00007211
		public unsafe bool hasRenderBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_hasRenderBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_hasRenderBounds)) = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x000568B8 File Offset: 0x00054AB8
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0000902C File Offset: 0x0000722C
		public unsafe bool hasLightBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_hasLightBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_hasLightBounds)) = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x000568E0 File Offset: 0x00054AE0
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00009047 File Offset: 0x00007247
		public unsafe bool shadowCaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_shadowCaster);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_shadowCaster)) = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00056908 File Offset: 0x00054B08
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x00009062 File Offset: 0x00007262
		public unsafe bool shadowLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_shadowLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_shadowLight)) = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00056930 File Offset: 0x00054B30
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x0000907D File Offset: 0x0000727D
		public unsafe bool frozen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_frozen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_frozen)) = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00056958 File Offset: 0x00054B58
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x00009098 File Offset: 0x00007298
		public unsafe bool neverJoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_neverJoin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_neverJoin)) = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00056980 File Offset: 0x00054B80
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x000090B3 File Offset: 0x000072B3
		public unsafe List<Light> bakedOnlyLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_bakedOnlyLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_bakedOnlyLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x000569B0 File Offset: 0x00054BB0
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x000090D2 File Offset: 0x000072D2
		public unsafe bool isSector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_isSector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_isSector)) = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x000569D8 File Offset: 0x00054BD8
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x000090ED File Offset: 0x000072ED
		public unsafe SECTR_Member childProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_childProxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Member>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_childProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00056A08 File Offset: 0x00054C08
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x0000910C File Offset: 0x0000730C
		public unsafe bool hasChildProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_hasChildProxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_hasChildProxy)) = value;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00056A30 File Offset: 0x00054C30
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00009127 File Offset: 0x00007327
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00056A58 File Offset: 0x00054C58
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00009142 File Offset: 0x00007342
		public unsafe bool usedStartSector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_usedStartSector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_usedStartSector)) = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00056A80 File Offset: 0x00054C80
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x0000915D File Offset: 0x0000735D
		public unsafe List<SECTR_Sector> sectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_sectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Sector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_sectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00056AB0 File Offset: 0x00054CB0
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x0000917C File Offset: 0x0000737C
		public unsafe List<SECTR_Sector> newSectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_newSectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Sector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_newSectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00056AE0 File Offset: 0x00054CE0
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0000919B File Offset: 0x0000739B
		public unsafe List<SECTR_Sector> leftSectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_leftSectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Sector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_leftSectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00056B10 File Offset: 0x00054D10
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x000091BA File Offset: 0x000073BA
		public unsafe Dictionary<Transform, SECTR_Member.Child> childTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_childTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Transform, SECTR_Member.Child>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_childTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00056B40 File Offset: 0x00054D40
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x000091D9 File Offset: 0x000073D9
		public unsafe Dictionary<Light, Light> bakedOnlyTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_bakedOnlyTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Light, Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_bakedOnlyTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x00056B70 File Offset: 0x00054D70
		// (set) Token: 0x06000B90 RID: 2960 RVA: 0x000091F8 File Offset: 0x000073F8
		public unsafe Vector3 lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00056B98 File Offset: 0x00054D98
		// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00009213 File Offset: 0x00007413
		public unsafe Stack<SECTR_Member.Child> childPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_childPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<SECTR_Member.Child>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_childPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00056BC8 File Offset: 0x00054DC8
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x00009232 File Offset: 0x00007432
		public unsafe static List<SECTR_Member> allMembers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Member.NativeFieldInfoPtr_allMembers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SECTR_Member>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Member.NativeFieldInfoPtr_allMembers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00056BF0 File Offset: 0x00054DF0
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x00009244 File Offset: 0x00007444
		public unsafe static Dictionary<Transform, SECTR_Member> allMemberTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Member.NativeFieldInfoPtr_allMemberTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Transform, SECTR_Member>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Member.NativeFieldInfoPtr_allMemberTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00056C18 File Offset: 0x00054E18
		// (set) Token: 0x06000B98 RID: 2968 RVA: 0x00009256 File Offset: 0x00007456
		public unsafe bool PortalDetermined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_PortalDetermined);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_PortalDetermined)) = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00056C40 File Offset: 0x00054E40
		// (set) Token: 0x06000B9A RID: 2970 RVA: 0x00009271 File Offset: 0x00007471
		public unsafe SECTR_Sector ForceStartSector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_ForceStartSector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Sector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_ForceStartSector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00056C70 File Offset: 0x00054E70
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x00009290 File Offset: 0x00007490
		public unsafe SECTR_Member.BoundsUpdateModes BoundsUpdateMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_BoundsUpdateMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_BoundsUpdateMode)) = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x00056C98 File Offset: 0x00054E98
		// (set) Token: 0x06000B9E RID: 2974 RVA: 0x000092AB File Offset: 0x000074AB
		public unsafe float ExtraBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_ExtraBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_ExtraBounds)) = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00056CC0 File Offset: 0x00054EC0
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x000092C6 File Offset: 0x000074C6
		public unsafe bool OverrideBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_OverrideBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_OverrideBounds)) = value;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x00056CE8 File Offset: 0x00054EE8
		// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x000092E1 File Offset: 0x000074E1
		public unsafe Bounds BoundsOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_BoundsOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_BoundsOverride)) = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00056D10 File Offset: 0x00054F10
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x000092FC File Offset: 0x000074FC
		public unsafe Light DirShadowCaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_DirShadowCaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_DirShadowCaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00056D40 File Offset: 0x00054F40
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0000931B File Offset: 0x0000751B
		public unsafe float DirShadowDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_DirShadowDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_DirShadowDistance)) = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00056D68 File Offset: 0x00054F68
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00009336 File Offset: 0x00007536
		public unsafe SECTR_Member.ChildCullModes ChildCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_ChildCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_ChildCulling)) = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00056D90 File Offset: 0x00054F90
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00009351 File Offset: 0x00007551
		public unsafe int LastVisibleFrameNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_LastVisibleFrameNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_LastVisibleFrameNumber)) = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00056DB8 File Offset: 0x00054FB8
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x0000936C File Offset: 0x0000756C
		public unsafe SECTR_Member.MembershipChanged Changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_Changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Member.MembershipChanged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.NativeFieldInfoPtr_Changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_renderers;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_terrains;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_shadowLights;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_shadowCasters;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr_totalBounds;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr_renderBounds;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_lightBounds;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_hasRenderBounds;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_hasLightBounds;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_shadowCaster;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_shadowLight;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_frozen;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_neverJoin;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_bakedOnlyLights;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_isSector;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_childProxy;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr_hasChildProxy;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr_usedStartSector;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr_sectors;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr_newSectors;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr_leftSectors;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr_childTable;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr_bakedOnlyTable;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr_childPool;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr_allMembers;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr_allMemberTable;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr_PortalDetermined;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr_ForceStartSector;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr_BoundsUpdateMode;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr_ExtraBounds;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr_OverrideBounds;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr_BoundsOverride;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr_DirShadowCaster;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr_DirShadowDistance;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr_ChildCulling;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr_LastVisibleFrameNumber;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr_Changed;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_List_1_SECTR_Member_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_get_CullEachChild_Public_get_Boolean_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_get_Sectors_Public_get_List_1_SECTR_Sector_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_List_1_Child_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_get_Renderers_Public_get_List_1_Child_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_get_ShadowCaster_Public_get_Boolean_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_get_ShadowCasters_Public_get_List_1_Child_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_get_Lights_Public_get_List_1_Child_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_get_ShadowLight_Public_get_Boolean_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_get_ShadowLights_Public_get_List_1_Child_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_get_Terrains_Public_get_List_1_Child_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalBounds_Public_get_Bounds_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_get_RenderBounds_Public_get_Bounds_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRenderBounds_Public_get_Boolean_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_get_LightBounds_Public_get_Bounds_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_HasLightBounds_Public_get_Boolean_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_IsVisibleThisFrame_Public_Boolean_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_WasVisibleLastFrame_Public_Boolean_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_set_Frozen_Public_set_Void_Boolean_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_get_Frozen_Public_get_Boolean_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildProxy_Public_set_Void_SECTR_Member_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_set_NeverJoin_Public_set_Void_Boolean_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSector_Public_get_Boolean_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdate_Public_Void_Boolean_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_SectorDisabled_Public_Void_SECTR_Sector_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_add_Changed_Public_add_Void_MembershipChanged_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_remove_Changed_Public_rem_Void_MembershipChanged_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr__UpdateChildren_Private_Void_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr__AddChildren_Private_Void_Transform_Boolean_Vector3_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr__UpdateSectorMembership_Private_Void_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr__CrossedPortal_Private_SECTR_Portal_SECTR_Sector_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002BF RID: 703
		[Serializable]
		public class Child : global::Il2CppSystem.Object
		{
			// Token: 0x06004BCC RID: 19404 RVA: 0x00117E24 File Offset: 0x00116024
			// Note: this type is marked as 'beforefieldinit'.
			static Child()
			{
				Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "Child");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr);
				SECTR_Member.Child.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "gameObject");
				SECTR_Member.Child.NativeFieldInfoPtr_gameObjectHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "gameObjectHash");
				SECTR_Member.Child.NativeFieldInfoPtr_member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "member");
				SECTR_Member.Child.NativeFieldInfoPtr_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "renderer");
				SECTR_Member.Child.NativeFieldInfoPtr_renderHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "renderHash");
				SECTR_Member.Child.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "light");
				SECTR_Member.Child.NativeFieldInfoPtr_lightHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "lightHash");
				SECTR_Member.Child.NativeFieldInfoPtr_terrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "terrain");
				SECTR_Member.Child.NativeFieldInfoPtr_terrainHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "terrainHash");
				SECTR_Member.Child.NativeFieldInfoPtr_rendererBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "rendererBounds");
				SECTR_Member.Child.NativeFieldInfoPtr_lightBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "lightBounds");
				SECTR_Member.Child.NativeFieldInfoPtr_terrainBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "terrainBounds");
				SECTR_Member.Child.NativeFieldInfoPtr_shadowLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "shadowLight");
				SECTR_Member.Child.NativeFieldInfoPtr_rendererCastsShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "rendererCastsShadows");
				SECTR_Member.Child.NativeFieldInfoPtr_terrainCastsShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "terrainCastsShadows");
				SECTR_Member.Child.NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "layer");
				SECTR_Member.Child.NativeFieldInfoPtr_shadowLightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "shadowLightPosition");
				SECTR_Member.Child.NativeFieldInfoPtr_shadowLightRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "shadowLightRange");
				SECTR_Member.Child.NativeFieldInfoPtr_shadowLightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "shadowLightType");
				SECTR_Member.Child.NativeFieldInfoPtr_shadowCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "shadowCullingMask");
				SECTR_Member.Child.NativeFieldInfoPtr_processed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "processed");
				SECTR_Member.Child.NativeFieldInfoPtr_renderCulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "renderCulled");
				SECTR_Member.Child.NativeFieldInfoPtr_lightCulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "lightCulled");
				SECTR_Member.Child.NativeFieldInfoPtr_terrainCulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, "terrainCulled");
				SECTR_Member.Child.NativeMethodInfoPtr_Init_Public_Void_GameObject_Renderer_Light_Terrain_SECTR_Member_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, 100664280);
				SECTR_Member.Child.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, 100664281);
				SECTR_Member.Child.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, 100664282);
				SECTR_Member.Child.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Child_Child_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, 100664283);
				SECTR_Member.Child.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Child_Child_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, 100664284);
				SECTR_Member.Child.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr, 100664285);
			}

			// Token: 0x06004BCD RID: 19405 RVA: 0x001180A8 File Offset: 0x001162A8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 41387, RefRangeEnd = 41389, XrefRangeStart = 41288, XrefRangeEnd = 41387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(GameObject gameObject, Renderer renderer, Light light, Terrain terrain, SECTR_Member member, bool dirShadowCaster, Vector3 shadowVec)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(terrain);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirShadowCaster;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowVec;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.Child.NativeMethodInfoPtr_Init_Public_Void_GameObject_Renderer_Light_Terrain_SECTR_Member_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BCE RID: 19406 RVA: 0x00118150 File Offset: 0x00116350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41389, XrefRangeEnd = 41391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(global::Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Member.Child.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BCF RID: 19407 RVA: 0x001181A8 File Offset: 0x001163A8
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SECTR_Member.Child.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BD0 RID: 19408 RVA: 0x001181F0 File Offset: 0x001163F0
			[CallerCount(0)]
			public unsafe static bool operator ==(SECTR_Member.Child x, SECTR_Member.Child y)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.Child.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Child_Child_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BD1 RID: 19409 RVA: 0x00118244 File Offset: 0x00116444
			[CallerCount(0)]
			public unsafe static bool operator !=(SECTR_Member.Child x, SECTR_Member.Child y)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.Child.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Child_Child_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004BD2 RID: 19410 RVA: 0x00118298 File Offset: 0x00116498
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Child()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Member.Child>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.Child.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BD3 RID: 19411 RVA: 0x0002C92D File Offset: 0x0002AB2D
			public Child(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B99 RID: 7065
			// (get) Token: 0x06004BD4 RID: 19412 RVA: 0x001182D4 File Offset: 0x001164D4
			// (set) Token: 0x06004BD5 RID: 19413 RVA: 0x0002C936 File Offset: 0x0002AB36
			public unsafe GameObject gameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_gameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9A RID: 7066
			// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x00118304 File Offset: 0x00116504
			// (set) Token: 0x06004BD7 RID: 19415 RVA: 0x0002C955 File Offset: 0x0002AB55
			public unsafe int gameObjectHash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_gameObjectHash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_gameObjectHash)) = value;
				}
			}

			// Token: 0x17001B9B RID: 7067
			// (get) Token: 0x06004BD8 RID: 19416 RVA: 0x0011832C File Offset: 0x0011652C
			// (set) Token: 0x06004BD9 RID: 19417 RVA: 0x0002C970 File Offset: 0x0002AB70
			public unsafe SECTR_Member member
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_member);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_Member>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_member), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9C RID: 7068
			// (get) Token: 0x06004BDA RID: 19418 RVA: 0x0011835C File Offset: 0x0011655C
			// (set) Token: 0x06004BDB RID: 19419 RVA: 0x0002C98F File Offset: 0x0002AB8F
			public unsafe Renderer renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9D RID: 7069
			// (get) Token: 0x06004BDC RID: 19420 RVA: 0x0011838C File Offset: 0x0011658C
			// (set) Token: 0x06004BDD RID: 19421 RVA: 0x0002C9AE File Offset: 0x0002ABAE
			public unsafe int renderHash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_renderHash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_renderHash)) = value;
				}
			}

			// Token: 0x17001B9E RID: 7070
			// (get) Token: 0x06004BDE RID: 19422 RVA: 0x001183B4 File Offset: 0x001165B4
			// (set) Token: 0x06004BDF RID: 19423 RVA: 0x0002C9C9 File Offset: 0x0002ABC9
			public unsafe Light light
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_light);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9F RID: 7071
			// (get) Token: 0x06004BE0 RID: 19424 RVA: 0x001183E4 File Offset: 0x001165E4
			// (set) Token: 0x06004BE1 RID: 19425 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
			public unsafe int lightHash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_lightHash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_lightHash)) = value;
				}
			}

			// Token: 0x17001BA0 RID: 7072
			// (get) Token: 0x06004BE2 RID: 19426 RVA: 0x0011840C File Offset: 0x0011660C
			// (set) Token: 0x06004BE3 RID: 19427 RVA: 0x0002CA03 File Offset: 0x0002AC03
			public unsafe Terrain terrain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrain);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrain), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BA1 RID: 7073
			// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x0011843C File Offset: 0x0011663C
			// (set) Token: 0x06004BE5 RID: 19429 RVA: 0x0002CA22 File Offset: 0x0002AC22
			public unsafe int terrainHash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrainHash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrainHash)) = value;
				}
			}

			// Token: 0x17001BA2 RID: 7074
			// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x00118464 File Offset: 0x00116664
			// (set) Token: 0x06004BE7 RID: 19431 RVA: 0x0002CA3D File Offset: 0x0002AC3D
			public unsafe Bounds rendererBounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_rendererBounds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_rendererBounds)) = value;
				}
			}

			// Token: 0x17001BA3 RID: 7075
			// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x0011848C File Offset: 0x0011668C
			// (set) Token: 0x06004BE9 RID: 19433 RVA: 0x0002CA58 File Offset: 0x0002AC58
			public unsafe Bounds lightBounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_lightBounds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_lightBounds)) = value;
				}
			}

			// Token: 0x17001BA4 RID: 7076
			// (get) Token: 0x06004BEA RID: 19434 RVA: 0x001184B4 File Offset: 0x001166B4
			// (set) Token: 0x06004BEB RID: 19435 RVA: 0x0002CA73 File Offset: 0x0002AC73
			public unsafe Bounds terrainBounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrainBounds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrainBounds)) = value;
				}
			}

			// Token: 0x17001BA5 RID: 7077
			// (get) Token: 0x06004BEC RID: 19436 RVA: 0x001184DC File Offset: 0x001166DC
			// (set) Token: 0x06004BED RID: 19437 RVA: 0x0002CA8E File Offset: 0x0002AC8E
			public unsafe bool shadowLight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowLight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowLight)) = value;
				}
			}

			// Token: 0x17001BA6 RID: 7078
			// (get) Token: 0x06004BEE RID: 19438 RVA: 0x00118504 File Offset: 0x00116704
			// (set) Token: 0x06004BEF RID: 19439 RVA: 0x0002CAA9 File Offset: 0x0002ACA9
			public unsafe bool rendererCastsShadows
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_rendererCastsShadows);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_rendererCastsShadows)) = value;
				}
			}

			// Token: 0x17001BA7 RID: 7079
			// (get) Token: 0x06004BF0 RID: 19440 RVA: 0x0011852C File Offset: 0x0011672C
			// (set) Token: 0x06004BF1 RID: 19441 RVA: 0x0002CAC4 File Offset: 0x0002ACC4
			public unsafe bool terrainCastsShadows
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrainCastsShadows);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrainCastsShadows)) = value;
				}
			}

			// Token: 0x17001BA8 RID: 7080
			// (get) Token: 0x06004BF2 RID: 19442 RVA: 0x00118554 File Offset: 0x00116754
			// (set) Token: 0x06004BF3 RID: 19443 RVA: 0x0002CADF File Offset: 0x0002ACDF
			public unsafe LayerMask layer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_layer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_layer)) = value;
				}
			}

			// Token: 0x17001BA9 RID: 7081
			// (get) Token: 0x06004BF4 RID: 19444 RVA: 0x0011857C File Offset: 0x0011677C
			// (set) Token: 0x06004BF5 RID: 19445 RVA: 0x0002CAFA File Offset: 0x0002ACFA
			public unsafe Vector3 shadowLightPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowLightPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowLightPosition)) = value;
				}
			}

			// Token: 0x17001BAA RID: 7082
			// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x001185A4 File Offset: 0x001167A4
			// (set) Token: 0x06004BF7 RID: 19447 RVA: 0x0002CB15 File Offset: 0x0002AD15
			public unsafe float shadowLightRange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowLightRange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowLightRange)) = value;
				}
			}

			// Token: 0x17001BAB RID: 7083
			// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x001185CC File Offset: 0x001167CC
			// (set) Token: 0x06004BF9 RID: 19449 RVA: 0x0002CB30 File Offset: 0x0002AD30
			public unsafe LightType shadowLightType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowLightType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowLightType)) = value;
				}
			}

			// Token: 0x17001BAC RID: 7084
			// (get) Token: 0x06004BFA RID: 19450 RVA: 0x001185F4 File Offset: 0x001167F4
			// (set) Token: 0x06004BFB RID: 19451 RVA: 0x0002CB4B File Offset: 0x0002AD4B
			public unsafe int shadowCullingMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowCullingMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_shadowCullingMask)) = value;
				}
			}

			// Token: 0x17001BAD RID: 7085
			// (get) Token: 0x06004BFC RID: 19452 RVA: 0x0011861C File Offset: 0x0011681C
			// (set) Token: 0x06004BFD RID: 19453 RVA: 0x0002CB66 File Offset: 0x0002AD66
			public unsafe bool processed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_processed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_processed)) = value;
				}
			}

			// Token: 0x17001BAE RID: 7086
			// (get) Token: 0x06004BFE RID: 19454 RVA: 0x00118644 File Offset: 0x00116844
			// (set) Token: 0x06004BFF RID: 19455 RVA: 0x0002CB81 File Offset: 0x0002AD81
			public unsafe bool renderCulled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_renderCulled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_renderCulled)) = value;
				}
			}

			// Token: 0x17001BAF RID: 7087
			// (get) Token: 0x06004C00 RID: 19456 RVA: 0x0011866C File Offset: 0x0011686C
			// (set) Token: 0x06004C01 RID: 19457 RVA: 0x0002CB9C File Offset: 0x0002AD9C
			public unsafe bool lightCulled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_lightCulled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_lightCulled)) = value;
				}
			}

			// Token: 0x17001BB0 RID: 7088
			// (get) Token: 0x06004C02 RID: 19458 RVA: 0x00118694 File Offset: 0x00116894
			// (set) Token: 0x06004C03 RID: 19459 RVA: 0x0002CBB7 File Offset: 0x0002ADB7
			public unsafe bool terrainCulled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrainCulled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SECTR_Member.Child.NativeFieldInfoPtr_terrainCulled)) = value;
				}
			}

			// Token: 0x040031AC RID: 12716
			private static readonly IntPtr NativeFieldInfoPtr_gameObject;

			// Token: 0x040031AD RID: 12717
			private static readonly IntPtr NativeFieldInfoPtr_gameObjectHash;

			// Token: 0x040031AE RID: 12718
			private static readonly IntPtr NativeFieldInfoPtr_member;

			// Token: 0x040031AF RID: 12719
			private static readonly IntPtr NativeFieldInfoPtr_renderer;

			// Token: 0x040031B0 RID: 12720
			private static readonly IntPtr NativeFieldInfoPtr_renderHash;

			// Token: 0x040031B1 RID: 12721
			private static readonly IntPtr NativeFieldInfoPtr_light;

			// Token: 0x040031B2 RID: 12722
			private static readonly IntPtr NativeFieldInfoPtr_lightHash;

			// Token: 0x040031B3 RID: 12723
			private static readonly IntPtr NativeFieldInfoPtr_terrain;

			// Token: 0x040031B4 RID: 12724
			private static readonly IntPtr NativeFieldInfoPtr_terrainHash;

			// Token: 0x040031B5 RID: 12725
			private static readonly IntPtr NativeFieldInfoPtr_rendererBounds;

			// Token: 0x040031B6 RID: 12726
			private static readonly IntPtr NativeFieldInfoPtr_lightBounds;

			// Token: 0x040031B7 RID: 12727
			private static readonly IntPtr NativeFieldInfoPtr_terrainBounds;

			// Token: 0x040031B8 RID: 12728
			private static readonly IntPtr NativeFieldInfoPtr_shadowLight;

			// Token: 0x040031B9 RID: 12729
			private static readonly IntPtr NativeFieldInfoPtr_rendererCastsShadows;

			// Token: 0x040031BA RID: 12730
			private static readonly IntPtr NativeFieldInfoPtr_terrainCastsShadows;

			// Token: 0x040031BB RID: 12731
			private static readonly IntPtr NativeFieldInfoPtr_layer;

			// Token: 0x040031BC RID: 12732
			private static readonly IntPtr NativeFieldInfoPtr_shadowLightPosition;

			// Token: 0x040031BD RID: 12733
			private static readonly IntPtr NativeFieldInfoPtr_shadowLightRange;

			// Token: 0x040031BE RID: 12734
			private static readonly IntPtr NativeFieldInfoPtr_shadowLightType;

			// Token: 0x040031BF RID: 12735
			private static readonly IntPtr NativeFieldInfoPtr_shadowCullingMask;

			// Token: 0x040031C0 RID: 12736
			private static readonly IntPtr NativeFieldInfoPtr_processed;

			// Token: 0x040031C1 RID: 12737
			private static readonly IntPtr NativeFieldInfoPtr_renderCulled;

			// Token: 0x040031C2 RID: 12738
			private static readonly IntPtr NativeFieldInfoPtr_lightCulled;

			// Token: 0x040031C3 RID: 12739
			private static readonly IntPtr NativeFieldInfoPtr_terrainCulled;

			// Token: 0x040031C4 RID: 12740
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_GameObject_Renderer_Light_Terrain_SECTR_Member_Boolean_Vector3_0;

			// Token: 0x040031C5 RID: 12741
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040031C6 RID: 12742
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040031C7 RID: 12743
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Child_Child_0;

			// Token: 0x040031C8 RID: 12744
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Child_Child_0;

			// Token: 0x040031C9 RID: 12745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020002C0 RID: 704
		[OriginalName("Assembly-CSharp.dll", "", "BoundsUpdateModes")]
		public enum BoundsUpdateModes
		{
			// Token: 0x040031CB RID: 12747
			Start,
			// Token: 0x040031CC RID: 12748
			Movement,
			// Token: 0x040031CD RID: 12749
			Always,
			// Token: 0x040031CE RID: 12750
			Static,
			// Token: 0x040031CF RID: 12751
			SelfOnly
		}

		// Token: 0x020002C1 RID: 705
		[OriginalName("Assembly-CSharp.dll", "", "ChildCullModes")]
		public enum ChildCullModes
		{
			// Token: 0x040031D1 RID: 12753
			Default,
			// Token: 0x040031D2 RID: 12754
			Group,
			// Token: 0x040031D3 RID: 12755
			Individual
		}

		// Token: 0x020002C2 RID: 706
		public sealed class MembershipChanged : MulticastDelegate
		{
			// Token: 0x06004C04 RID: 19460 RVA: 0x001186BC File Offset: 0x001168BC
			// Note: this type is marked as 'beforefieldinit'.
			static MembershipChanged()
			{
				Il2CppClassPointerStore<SECTR_Member.MembershipChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SECTR_Member>.NativeClassPtr, "MembershipChanged");
				SECTR_Member.MembershipChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.MembershipChanged>.NativeClassPtr, 100664286);
				SECTR_Member.MembershipChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_List_1_SECTR_Sector_List_1_SECTR_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.MembershipChanged>.NativeClassPtr, 100664287);
				SECTR_Member.MembershipChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_List_1_SECTR_Sector_List_1_SECTR_Sector_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.MembershipChanged>.NativeClassPtr, 100664288);
				SECTR_Member.MembershipChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Member.MembershipChanged>.NativeClassPtr, 100664289);
			}

			// Token: 0x06004C05 RID: 19461 RVA: 0x00118730 File Offset: 0x00116930
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MembershipChanged(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SECTR_Member.MembershipChanged>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.MembershipChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C06 RID: 19462 RVA: 0x0011878C File Offset: 0x0011698C
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 41391, RefRangeEnd = 41473, XrefRangeStart = 41391, XrefRangeEnd = 41391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(List<SECTR_Sector> left, List<SECTR_Sector> joined)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(joined);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.MembershipChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_List_1_SECTR_Sector_List_1_SECTR_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004C07 RID: 19463 RVA: 0x001187E0 File Offset: 0x001169E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(List<SECTR_Sector> left, List<SECTR_Sector> joined, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(joined);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.MembershipChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_List_1_SECTR_Sector_List_1_SECTR_Sector_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06004C08 RID: 19464 RVA: 0x00118868 File Offset: 0x00116A68
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Member.MembershipChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004C09 RID: 19465 RVA: 0x0002CBD2 File Offset: 0x0002ADD2
			public MembershipChanged(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004C0A RID: 19466 RVA: 0x0002CBDB File Offset: 0x0002ADDB
			public static implicit operator SECTR_Member.MembershipChanged(Action<List<SECTR_Sector>, List<SECTR_Sector>> A_0)
			{
				return DelegateSupport.ConvertDelegate<SECTR_Member.MembershipChanged>(A_0);
			}

			// Token: 0x06004C0B RID: 19467 RVA: 0x0002CBE3 File Offset: 0x0002ADE3
			public static SECTR_Member.MembershipChanged operator +(SECTR_Member.MembershipChanged A_0, SECTR_Member.MembershipChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SECTR_Member.MembershipChanged>();
			}

			// Token: 0x06004C0C RID: 19468 RVA: 0x0002CBF1 File Offset: 0x0002ADF1
			public static SECTR_Member.MembershipChanged operator -(SECTR_Member.MembershipChanged A_0, SECTR_Member.MembershipChanged A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SECTR_Member.MembershipChanged>();
				}
				return delegate2;
			}

			// Token: 0x040031D4 RID: 12756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040031D5 RID: 12757
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_List_1_SECTR_Sector_List_1_SECTR_Sector_0;

			// Token: 0x040031D6 RID: 12758
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_List_1_SECTR_Sector_List_1_SECTR_Sector_AsyncCallback_Object_0;

			// Token: 0x040031D7 RID: 12759
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
