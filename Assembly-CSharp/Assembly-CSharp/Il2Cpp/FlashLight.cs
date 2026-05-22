using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000DE RID: 222
	public class FlashLight : MonoBehaviour
	{
		// Token: 0x0600195A RID: 6490 RVA: 0x0007B8D4 File Offset: 0x00079AD4
		// Note: this type is marked as 'beforefieldinit'.
		static FlashLight()
		{
			Il2CppClassPointerStore<FlashLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlashLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlashLight>.NativeClassPtr);
			FlashLight.NativeFieldInfoPtr_beamAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "beamAng");
			FlashLight.NativeFieldInfoPtr_beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "beam");
			FlashLight.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "res");
			FlashLight.NativeFieldInfoPtr_gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "gun");
			FlashLight.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "verts");
			FlashLight.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "pts");
			FlashLight.NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "tris");
			FlashLight.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "uv");
			FlashLight.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "colors");
			FlashLight.NativeFieldInfoPtr_gunVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "gunVect");
			FlashLight.NativeFieldInfoPtr_muzzDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "muzzDist");
			FlashLight.NativeFieldInfoPtr_lightRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "lightRange");
			FlashLight.NativeFieldInfoPtr_normalVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "normalVerts");
			FlashLight.NativeFieldInfoPtr_isStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "isStatic");
			FlashLight.NativeFieldInfoPtr_halfMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "halfMask");
			FlashLight.NativeFieldInfoPtr_fullMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "fullMask");
			FlashLight.NativeFieldInfoPtr_noPlayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "noPlayerMask");
			FlashLight.NativeFieldInfoPtr_spikey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "spikey");
			FlashLight.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "on");
			FlashLight.NativeFieldInfoPtr_NumberMeshesToCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "NumberMeshesToCache");
			FlashLight.NativeFieldInfoPtr_cachedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "cachedMeshes");
			FlashLight.NativeFieldInfoPtr_isStaticMesheseCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, "isStaticMesheseCached");
			FlashLight.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, 100665379);
			FlashLight.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, 100665380);
			FlashLight.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, 100665381);
			FlashLight.NativeMethodInfoPtr_CalculateMesh_Public_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, 100665382);
			FlashLight.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, 100665383);
			FlashLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashLight>.NativeClassPtr, 100665384);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0007BB34 File Offset: 0x00079D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58856, XrefRangeEnd = 58857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashLight.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x0007BB68 File Offset: 0x00079D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58857, XrefRangeEnd = 59008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashLight.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0007BB9C File Offset: 0x00079D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59008, XrefRangeEnd = 59026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashLight.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0007BBD0 File Offset: 0x00079DD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59142, XrefRangeStart = 59026, XrefRangeEnd = 59139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateMesh(Mesh mesh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashLight.NativeMethodInfoPtr_CalculateMesh_Public_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0007BC14 File Offset: 0x00079E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59142, XrefRangeEnd = 59166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashLight.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0007BC48 File Offset: 0x00079E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59166, XrefRangeEnd = 59172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlashLight()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlashLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlashLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00012112 File Offset: 0x00010312
		public FlashLight(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x0007BC84 File Offset: 0x00079E84
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0001211B File Offset: 0x0001031B
		public unsafe float beamAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_beamAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_beamAng)) = value;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x0007BCAC File Offset: 0x00079EAC
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x00012136 File Offset: 0x00010336
		public unsafe MeshFilter beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0007BCDC File Offset: 0x00079EDC
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00012155 File Offset: 0x00010355
		public unsafe int res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_res);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_res)) = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x0007BD04 File Offset: 0x00079F04
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00012170 File Offset: 0x00010370
		public unsafe GameObject gun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_gun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_gun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x0007BD34 File Offset: 0x00079F34
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x0001218F File Offset: 0x0001038F
		public unsafe Il2CppStructArray<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0007BD64 File Offset: 0x00079F64
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x000121AE File Offset: 0x000103AE
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x0007BD94 File Offset: 0x00079F94
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x000121CD File Offset: 0x000103CD
		public unsafe Il2CppStructArray<int> tris
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_tris);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_tris), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x0007BDC4 File Offset: 0x00079FC4
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x000121EC File Offset: 0x000103EC
		public unsafe Il2CppStructArray<Vector2> uv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_uv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_uv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x0007BDF4 File Offset: 0x00079FF4
		// (set) Token: 0x06001973 RID: 6515 RVA: 0x0001220B File Offset: 0x0001040B
		public unsafe Il2CppStructArray<Color> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x0007BE24 File Offset: 0x0007A024
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x0001222A File Offset: 0x0001042A
		public unsafe Vector2 gunVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_gunVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_gunVect)) = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x0007BE4C File Offset: 0x0007A04C
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x00012245 File Offset: 0x00010445
		public unsafe float muzzDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_muzzDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_muzzDist)) = value;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x0007BE74 File Offset: 0x0007A074
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x00012260 File Offset: 0x00010460
		public unsafe float lightRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_lightRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_lightRange)) = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0007BE9C File Offset: 0x0007A09C
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x0001227B File Offset: 0x0001047B
		public unsafe Il2CppStructArray<Vector2> normalVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_normalVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_normalVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x0007BECC File Offset: 0x0007A0CC
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x0001229A File Offset: 0x0001049A
		public unsafe bool isStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_isStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_isStatic)) = value;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x0007BEF4 File Offset: 0x0007A0F4
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x000122B5 File Offset: 0x000104B5
		public unsafe int halfMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_halfMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_halfMask)) = value;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x0007BF1C File Offset: 0x0007A11C
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x000122D0 File Offset: 0x000104D0
		public unsafe int fullMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_fullMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_fullMask)) = value;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x0007BF44 File Offset: 0x0007A144
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x000122EB File Offset: 0x000104EB
		public unsafe int noPlayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_noPlayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_noPlayerMask)) = value;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x0007BF6C File Offset: 0x0007A16C
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x00012306 File Offset: 0x00010506
		public unsafe bool spikey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_spikey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_spikey)) = value;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x0007BF94 File Offset: 0x0007A194
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x00012321 File Offset: 0x00010521
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x0007BFBC File Offset: 0x0007A1BC
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x0001233C File Offset: 0x0001053C
		public unsafe static int NumberMeshesToCache
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FlashLight.NativeFieldInfoPtr_NumberMeshesToCache, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlashLight.NativeFieldInfoPtr_NumberMeshesToCache, (void*)(&value));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x0007BFD8 File Offset: 0x0007A1D8
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x0001234A File Offset: 0x0001054A
		public unsafe Il2CppReferenceArray<Mesh> cachedMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_cachedMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_cachedMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x0007C008 File Offset: 0x0007A208
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x00012369 File Offset: 0x00010569
		public unsafe bool isStaticMesheseCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_isStaticMesheseCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlashLight.NativeFieldInfoPtr_isStaticMesheseCached)) = value;
			}
		}

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr_beamAng;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_beam;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr_gun;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeFieldInfoPtr_tris;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeFieldInfoPtr_gunVect;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeFieldInfoPtr_muzzDist;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeFieldInfoPtr_lightRange;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeFieldInfoPtr_normalVerts;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeFieldInfoPtr_isStatic;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeFieldInfoPtr_halfMask;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_fullMask;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_noPlayerMask;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_spikey;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeFieldInfoPtr_NumberMeshesToCache;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr_cachedMeshes;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr_isStaticMesheseCached;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMesh_Public_Void_Mesh_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
