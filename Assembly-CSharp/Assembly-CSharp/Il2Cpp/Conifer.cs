using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000AA RID: 170
	public class Conifer : MessageReceiver
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x0006E830 File Offset: 0x0006CA30
		// Note: this type is marked as 'beforefieldinit'.
		static Conifer()
		{
			Il2CppClassPointerStore<Conifer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Conifer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Conifer>.NativeClassPtr);
			Conifer.NativeFieldInfoPtr_treeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "treeType");
			Conifer.NativeFieldInfoPtr_botMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "botMesh");
			Conifer.NativeFieldInfoPtr_topMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "topMesh");
			Conifer.NativeFieldInfoPtr_shadowMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "shadowMesh");
			Conifer.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "verts");
			Conifer.NativeFieldInfoPtr_debugPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "debugPt");
			Conifer.NativeFieldInfoPtr_shadowVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "shadowVerts");
			Conifer.NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "tris");
			Conifer.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "uv");
			Conifer.NativeFieldInfoPtr_layList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "layList");
			Conifer.NativeFieldInfoPtr_layTransList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "layTransList");
			Conifer.NativeFieldInfoPtr_prevOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "prevOffset");
			Conifer.NativeFieldInfoPtr_radCurve1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "radCurve1");
			Conifer.NativeFieldInfoPtr_radCurve2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "radCurve2");
			Conifer.NativeFieldInfoPtr_off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "off");
			Conifer.NativeFieldInfoPtr_officePlant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "officePlant");
			Conifer.NativeFieldInfoPtr_rad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "rad");
			Conifer.NativeFieldInfoPtr_onFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "onFire");
			Conifer.NativeFieldInfoPtr_layNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "layNum");
			Conifer.NativeFieldInfoPtr_fireList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "fireList");
			Conifer.NativeFieldInfoPtr_paraAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "paraAmount");
			Conifer.NativeFieldInfoPtr_closeToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "closeToPlayer");
			Conifer.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "visible");
			Conifer.NativeFieldInfoPtr_sizeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "sizeIndex");
			Conifer.NativeFieldInfoPtr_maxBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "maxBounds");
			Conifer.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "pts");
			Conifer.NativeFieldInfoPtr_myPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "myPos");
			Conifer.NativeFieldInfoPtr_matIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "matIndex");
			Conifer.NativeFieldInfoPtr_foreSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "foreSort");
			Conifer.NativeFieldInfoPtr_defSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "defSort");
			Conifer.NativeFieldInfoPtr_prevCloseToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "prevCloseToPlayer");
			Conifer.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "scale");
			Conifer.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer>.NativeClassPtr, 100665041);
			Conifer.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer>.NativeClassPtr, 100665042);
			Conifer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer>.NativeClassPtr, 100665043);
			Conifer.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer>.NativeClassPtr, 100665044);
			Conifer.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer>.NativeClassPtr, 100665045);
			Conifer.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer>.NativeClassPtr, 100665046);
			Conifer.NativeMethodInfoPtr_BurnUp_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer>.NativeClassPtr, 100665047);
			Conifer.NativeMethodInfoPtr_OnScreen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer>.NativeClassPtr, 100665048);
			Conifer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer>.NativeClassPtr, 100665049);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0006EB94 File Offset: 0x0006CD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52693, XrefRangeEnd = 52794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0006EBC8 File Offset: 0x0006CDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52794, XrefRangeEnd = 52802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0006EBFC File Offset: 0x0006CDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52802, XrefRangeEnd = 52810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0006EC30 File Offset: 0x0006CE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52810, XrefRangeEnd = 52817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0006EC64 File Offset: 0x0006CE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52817, XrefRangeEnd = 52838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0006EC98 File Offset: 0x0006CE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52838, XrefRangeEnd = 52844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Conifer.NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0006ECD4 File Offset: 0x0006CED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52844, XrefRangeEnd = 52847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BurnUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer.NativeMethodInfoPtr_BurnUp_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0006ED14 File Offset: 0x0006CF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52847, XrefRangeEnd = 52849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer.NativeMethodInfoPtr_OnScreen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0006ED50 File Offset: 0x0006CF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52849, XrefRangeEnd = 52855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Conifer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Conifer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0000ED64 File Offset: 0x0000CF64
		public Conifer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0006ED8C File Offset: 0x0006CF8C
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0000ED6D File Offset: 0x0000CF6D
		public unsafe Conifer.TreeType treeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_treeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_treeType)) = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0006EDB4 File Offset: 0x0006CFB4
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0000ED88 File Offset: 0x0000CF88
		public unsafe MeshFilter botMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_botMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_botMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0006EDE4 File Offset: 0x0006CFE4
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0000EDA7 File Offset: 0x0000CFA7
		public unsafe MeshFilter topMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_topMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_topMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0006EE14 File Offset: 0x0006D014
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x0000EDC6 File Offset: 0x0000CFC6
		public unsafe MeshFilter shadowMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_shadowMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_shadowMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0006EE44 File Offset: 0x0006D044
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x0000EDE5 File Offset: 0x0000CFE5
		public unsafe Il2CppStructArray<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0006EE74 File Offset: 0x0006D074
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x0000EE04 File Offset: 0x0000D004
		public unsafe Vector2 debugPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_debugPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_debugPt)) = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0006EE9C File Offset: 0x0006D09C
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x0000EE1F File Offset: 0x0000D01F
		public unsafe Il2CppStructArray<Vector3> shadowVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_shadowVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_shadowVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0006EECC File Offset: 0x0006D0CC
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x0000EE3E File Offset: 0x0000D03E
		public unsafe Il2CppStructArray<int> tris
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_tris);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_tris), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0006EEFC File Offset: 0x0006D0FC
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x0000EE5D File Offset: 0x0000D05D
		public unsafe Il2CppStructArray<Vector2> uv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_uv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_uv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0006EF2C File Offset: 0x0006D12C
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x0000EE7C File Offset: 0x0000D07C
		public unsafe Il2CppReferenceArray<MeshRenderer> layList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_layList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_layList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0006EF5C File Offset: 0x0006D15C
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0000EE9B File Offset: 0x0000D09B
		public unsafe Il2CppReferenceArray<Transform> layTransList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_layTransList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_layTransList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0006EF8C File Offset: 0x0006D18C
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x0000EEBA File Offset: 0x0000D0BA
		public unsafe Vector2 prevOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_prevOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_prevOffset)) = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0006EFB4 File Offset: 0x0006D1B4
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0000EED5 File Offset: 0x0000D0D5
		public unsafe AnimationCurve radCurve1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_radCurve1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_radCurve1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0006EFE4 File Offset: 0x0006D1E4
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		public unsafe AnimationCurve radCurve2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_radCurve2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_radCurve2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0006F014 File Offset: 0x0006D214
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0000EF13 File Offset: 0x0000D113
		public unsafe bool off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_off);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_off)) = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0006F03C File Offset: 0x0006D23C
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0000EF2E File Offset: 0x0000D12E
		public unsafe bool officePlant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_officePlant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_officePlant)) = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0006F064 File Offset: 0x0006D264
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0000EF49 File Offset: 0x0000D149
		public unsafe float rad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_rad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_rad)) = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0006F08C File Offset: 0x0006D28C
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0000EF64 File Offset: 0x0000D164
		public unsafe bool onFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_onFire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_onFire)) = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0006F0B4 File Offset: 0x0006D2B4
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0000EF7F File Offset: 0x0000D17F
		public unsafe int layNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_layNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_layNum)) = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0006F0DC File Offset: 0x0006D2DC
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0000EF9A File Offset: 0x0000D19A
		public unsafe List<Transform> fireList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_fireList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_fireList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0006F10C File Offset: 0x0006D30C
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x0000EFB9 File Offset: 0x0000D1B9
		public unsafe float paraAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_paraAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_paraAmount)) = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0006F134 File Offset: 0x0006D334
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0000EFD4 File Offset: 0x0000D1D4
		public unsafe bool closeToPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_closeToPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_closeToPlayer)) = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0006F15C File Offset: 0x0006D35C
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x0000EFEF File Offset: 0x0000D1EF
		public unsafe bool visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_visible)) = value;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x0006F184 File Offset: 0x0006D384
		// (set) Token: 0x060014B0 RID: 5296 RVA: 0x0000F00A File Offset: 0x0000D20A
		public unsafe int sizeIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_sizeIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_sizeIndex)) = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0006F1AC File Offset: 0x0006D3AC
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0000F025 File Offset: 0x0000D225
		public unsafe Bounds maxBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_maxBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_maxBounds)) = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0006F1D4 File Offset: 0x0006D3D4
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x0000F040 File Offset: 0x0000D240
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x0006F204 File Offset: 0x0006D404
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x0000F05F File Offset: 0x0000D25F
		public unsafe Vector3 myPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_myPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_myPos)) = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0006F22C File Offset: 0x0006D42C
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0000F07A File Offset: 0x0000D27A
		public unsafe int matIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_matIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_matIndex)) = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x0006F254 File Offset: 0x0006D454
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x0000F095 File Offset: 0x0000D295
		public unsafe int foreSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_foreSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_foreSort)) = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0006F27C File Offset: 0x0006D47C
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		public unsafe int defSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_defSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_defSort)) = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x0006F2A4 File Offset: 0x0006D4A4
		// (set) Token: 0x060014BE RID: 5310 RVA: 0x0000F0CB File Offset: 0x0000D2CB
		public unsafe bool prevCloseToPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_prevCloseToPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_prevCloseToPlayer)) = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0006F2CC File Offset: 0x0006D4CC
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x0000F0E6 File Offset: 0x0000D2E6
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeFieldInfoPtr_treeType;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeFieldInfoPtr_botMesh;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeFieldInfoPtr_topMesh;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeFieldInfoPtr_shadowMesh;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeFieldInfoPtr_debugPt;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeFieldInfoPtr_shadowVerts;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr_tris;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeFieldInfoPtr_layList;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeFieldInfoPtr_layTransList;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeFieldInfoPtr_prevOffset;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeFieldInfoPtr_radCurve1;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeFieldInfoPtr_radCurve2;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeFieldInfoPtr_off;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeFieldInfoPtr_officePlant;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeFieldInfoPtr_rad;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeFieldInfoPtr_onFire;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeFieldInfoPtr_layNum;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeFieldInfoPtr_fireList;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeFieldInfoPtr_paraAmount;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeFieldInfoPtr_closeToPlayer;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeFieldInfoPtr_visible;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeFieldInfoPtr_sizeIndex;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeFieldInfoPtr_maxBounds;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeFieldInfoPtr_myPos;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeFieldInfoPtr_matIndex;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeFieldInfoPtr_foreSort;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeFieldInfoPtr_defSort;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeFieldInfoPtr_prevCloseToPlayer;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_OnFire_Public_Virtual_Void_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_BurnUp_Private_IEnumerator_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_OnScreen_Public_Boolean_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002EE RID: 750
		[OriginalName("Assembly-CSharp.dll", "", "TreeType")]
		public enum TreeType
		{
			// Token: 0x0400335A RID: 13146
			pine,
			// Token: 0x0400335B RID: 13147
			potPlant,
			// Token: 0x0400335C RID: 13148
			tropical1,
			// Token: 0x0400335D RID: 13149
			tropical2
		}

		// Token: 0x020002EF RID: 751
		[ObfuscatedName("Conifer+<BurnUp>d__39")]
		public sealed class _BurnUp_d__39 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E76 RID: 20086 RVA: 0x0011FA64 File Offset: 0x0011DC64
			// Note: this type is marked as 'beforefieldinit'.
			static _BurnUp_d__39()
			{
				Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Conifer>.NativeClassPtr, "<BurnUp>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr);
				Conifer._BurnUp_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, "<>1__state");
				Conifer._BurnUp_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, "<>2__current");
				Conifer._BurnUp_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, "<>4__this");
				Conifer._BurnUp_d__39.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, "<i>5__2");
				Conifer._BurnUp_d__39.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, "<>7__wrap2");
				Conifer._BurnUp_d__39.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, "<>7__wrap3");
				Conifer._BurnUp_d__39.NativeFieldInfoPtr__lay_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, "<lay>5__5");
				Conifer._BurnUp_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, 100665050);
				Conifer._BurnUp_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, 100665051);
				Conifer._BurnUp_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, 100665052);
				Conifer._BurnUp_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, 100665053);
				Conifer._BurnUp_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, 100665054);
				Conifer._BurnUp_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr, 100665055);
			}

			// Token: 0x06004E77 RID: 20087 RVA: 0x0011FB94 File Offset: 0x0011DD94
			[CallerCount(0)]
			public unsafe _BurnUp_d__39(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Conifer._BurnUp_d__39>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer._BurnUp_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E78 RID: 20088 RVA: 0x0011FBDC File Offset: 0x0011DDDC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer._BurnUp_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E79 RID: 20089 RVA: 0x0011FC10 File Offset: 0x0011DE10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52662, XrefRangeEnd = 52688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer._BurnUp_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C9C RID: 7324
			// (get) Token: 0x06004E7A RID: 20090 RVA: 0x0011FC4C File Offset: 0x0011DE4C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer._BurnUp_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E7B RID: 20091 RVA: 0x0011FC8C File Offset: 0x0011DE8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52688, XrefRangeEnd = 52693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer._BurnUp_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C9D RID: 7325
			// (get) Token: 0x06004E7C RID: 20092 RVA: 0x0011FCC0 File Offset: 0x0011DEC0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conifer._BurnUp_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E7D RID: 20093 RVA: 0x0002DFBB File Offset: 0x0002C1BB
			public _BurnUp_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C95 RID: 7317
			// (get) Token: 0x06004E7E RID: 20094 RVA: 0x0011FD00 File Offset: 0x0011DF00
			// (set) Token: 0x06004E7F RID: 20095 RVA: 0x0002DFC4 File Offset: 0x0002C1C4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C96 RID: 7318
			// (get) Token: 0x06004E80 RID: 20096 RVA: 0x0011FD28 File Offset: 0x0011DF28
			// (set) Token: 0x06004E81 RID: 20097 RVA: 0x0002DFDF File Offset: 0x0002C1DF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C97 RID: 7319
			// (get) Token: 0x06004E82 RID: 20098 RVA: 0x0011FD58 File Offset: 0x0011DF58
			// (set) Token: 0x06004E83 RID: 20099 RVA: 0x0002DFFE File Offset: 0x0002C1FE
			public unsafe Conifer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Conifer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C98 RID: 7320
			// (get) Token: 0x06004E84 RID: 20100 RVA: 0x0011FD88 File Offset: 0x0011DF88
			// (set) Token: 0x06004E85 RID: 20101 RVA: 0x0002E01D File Offset: 0x0002C21D
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x17001C99 RID: 7321
			// (get) Token: 0x06004E86 RID: 20102 RVA: 0x0011FDB0 File Offset: 0x0011DFB0
			// (set) Token: 0x06004E87 RID: 20103 RVA: 0x0002E038 File Offset: 0x0002C238
			public unsafe Il2CppReferenceArray<MeshRenderer> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C9A RID: 7322
			// (get) Token: 0x06004E88 RID: 20104 RVA: 0x0011FDE0 File Offset: 0x0011DFE0
			// (set) Token: 0x06004E89 RID: 20105 RVA: 0x0002E057 File Offset: 0x0002C257
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x17001C9B RID: 7323
			// (get) Token: 0x06004E8A RID: 20106 RVA: 0x0011FE08 File Offset: 0x0011E008
			// (set) Token: 0x06004E8B RID: 20107 RVA: 0x0002E072 File Offset: 0x0002C272
			public unsafe MeshRenderer _lay_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr__lay_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conifer._BurnUp_d__39.NativeFieldInfoPtr__lay_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400335E RID: 13150
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400335F RID: 13151
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003360 RID: 13152
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003361 RID: 13153
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04003362 RID: 13154
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04003363 RID: 13155
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04003364 RID: 13156
			private static readonly IntPtr NativeFieldInfoPtr__lay_5__5;

			// Token: 0x04003365 RID: 13157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003366 RID: 13158
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003367 RID: 13159
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003368 RID: 13160
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003369 RID: 13161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400336A RID: 13162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
