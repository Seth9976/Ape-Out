using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200014F RID: 335
	public class Paralax : MonoBehaviour
	{
		// Token: 0x06002854 RID: 10324 RVA: 0x000A3CC4 File Offset: 0x000A1EC4
		// Note: this type is marked as 'beforefieldinit'.
		static Paralax()
		{
			Il2CppClassPointerStore<Paralax>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Paralax");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Paralax>.NativeClassPtr);
			Paralax.NativeFieldInfoPtr_mesher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "mesher");
			Paralax.NativeFieldInfoPtr_topObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "topObj");
			Paralax.NativeFieldInfoPtr_myBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "myBox");
			Paralax.NativeFieldInfoPtr_myLocalBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "myLocalBox");
			Paralax.NativeFieldInfoPtr_topLocalBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "topLocalBox");
			Paralax.NativeFieldInfoPtr_topBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "topBox");
			Paralax.NativeFieldInfoPtr_parralax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "parralax");
			Paralax.NativeFieldInfoPtr_norms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "norms");
			Paralax.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "verts");
			Paralax.NativeFieldInfoPtr_extents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "extents");
			Paralax.NativeFieldInfoPtr_midPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "midPos");
			Paralax.NativeFieldInfoPtr_myBnds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "myBnds");
			Paralax.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "player");
			Paralax.NativeFieldInfoPtr_defTopPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "defTopPos");
			Paralax.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "sprite");
			Paralax.NativeFieldInfoPtr_topSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "topSprite");
			Paralax.NativeFieldInfoPtr_shadowLayerer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "shadowLayerer");
			Paralax.NativeFieldInfoPtr_meshRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "meshRend");
			Paralax.NativeFieldInfoPtr_camControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "camControl");
			Paralax.NativeFieldInfoPtr_subTopObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "subTopObjs");
			Paralax.NativeFieldInfoPtr_toppers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "toppers");
			Paralax.NativeFieldInfoPtr_meshesZeroed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "meshesZeroed");
			Paralax.NativeFieldInfoPtr_topperNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "topperNum");
			Paralax.NativeFieldInfoPtr_meshInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Paralax>.NativeClassPtr, "meshInd");
			Paralax.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paralax>.NativeClassPtr, 100666499);
			Paralax.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paralax>.NativeClassPtr, 100666500);
			Paralax.NativeMethodInfoPtr_OnBecameInvisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paralax>.NativeClassPtr, 100666501);
			Paralax.NativeMethodInfoPtr_UpdateVerts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paralax>.NativeClassPtr, 100666502);
			Paralax.NativeMethodInfoPtr_UpdateBoxes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paralax>.NativeClassPtr, 100666503);
			Paralax.NativeMethodInfoPtr_GetVerts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paralax>.NativeClassPtr, 100666504);
			Paralax.NativeMethodInfoPtr_SideMost_Public_Vector3_Il2CppStructArray_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paralax>.NativeClassPtr, 100666505);
			Paralax.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Paralax>.NativeClassPtr, 100666506);
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x000A3F74 File Offset: 0x000A2174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76068, XrefRangeEnd = 76172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paralax.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x000A3FA8 File Offset: 0x000A21A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76172, XrefRangeEnd = 76214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paralax.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x000A3FDC File Offset: 0x000A21DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76253, RefRangeEnd = 76254, XrefRangeStart = 76214, XrefRangeEnd = 76253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBecameInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paralax.NativeMethodInfoPtr_OnBecameInvisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x000A4010 File Offset: 0x000A2210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76254, XrefRangeEnd = 76265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVerts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paralax.NativeMethodInfoPtr_UpdateVerts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x000A4044 File Offset: 0x000A2244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76273, RefRangeEnd = 76274, XrefRangeStart = 76265, XrefRangeEnd = 76273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBoxes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paralax.NativeMethodInfoPtr_UpdateBoxes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x000A4078 File Offset: 0x000A2278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76297, RefRangeEnd = 76298, XrefRangeStart = 76274, XrefRangeEnd = 76297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetVerts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paralax.NativeMethodInfoPtr_GetVerts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x000A40AC File Offset: 0x000A22AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76298, XrefRangeEnd = 76318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 SideMost(Il2CppStructArray<Vector3> vts, bool right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paralax.NativeMethodInfoPtr_SideMost_Public_Vector3_Il2CppStructArray_1_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x000A4108 File Offset: 0x000A2308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Paralax()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Paralax>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Paralax.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x0001C1E2 File Offset: 0x0001A3E2
		public Paralax(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000A4144 File Offset: 0x000A2344
		// (set) Token: 0x0600285F RID: 10335 RVA: 0x0001C1EB File Offset: 0x0001A3EB
		public unsafe MeshFilter mesher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_mesher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_mesher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x000A4174 File Offset: 0x000A2374
		// (set) Token: 0x06002861 RID: 10337 RVA: 0x0001C20A File Offset: 0x0001A40A
		public unsafe GameObject topObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x000A41A4 File Offset: 0x000A23A4
		// (set) Token: 0x06002863 RID: 10339 RVA: 0x0001C229 File Offset: 0x0001A429
		public unsafe Il2CppStructArray<Vector3> myBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_myBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_myBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x000A41D4 File Offset: 0x000A23D4
		// (set) Token: 0x06002865 RID: 10341 RVA: 0x0001C248 File Offset: 0x0001A448
		public unsafe Il2CppStructArray<Vector3> myLocalBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_myLocalBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_myLocalBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x000A4204 File Offset: 0x000A2404
		// (set) Token: 0x06002867 RID: 10343 RVA: 0x0001C267 File Offset: 0x0001A467
		public unsafe Il2CppStructArray<Vector3> topLocalBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topLocalBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topLocalBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x000A4234 File Offset: 0x000A2434
		// (set) Token: 0x06002869 RID: 10345 RVA: 0x0001C286 File Offset: 0x0001A486
		public unsafe Il2CppStructArray<Vector3> topBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x000A4264 File Offset: 0x000A2464
		// (set) Token: 0x0600286B RID: 10347 RVA: 0x0001C2A5 File Offset: 0x0001A4A5
		public unsafe float parralax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_parralax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_parralax)) = value;
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x000A428C File Offset: 0x000A248C
		// (set) Token: 0x0600286D RID: 10349 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
		public unsafe Il2CppStructArray<Vector3> norms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_norms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_norms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x000A42BC File Offset: 0x000A24BC
		// (set) Token: 0x0600286F RID: 10351 RVA: 0x0001C2DF File Offset: 0x0001A4DF
		public unsafe Il2CppStructArray<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002870 RID: 10352 RVA: 0x000A42EC File Offset: 0x000A24EC
		// (set) Token: 0x06002871 RID: 10353 RVA: 0x0001C2FE File Offset: 0x0001A4FE
		public unsafe Vector2 extents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_extents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_extents)) = value;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x000A4314 File Offset: 0x000A2514
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x0001C319 File Offset: 0x0001A519
		public unsafe Vector2 midPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_midPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_midPos)) = value;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x000A433C File Offset: 0x000A253C
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x0001C334 File Offset: 0x0001A534
		public unsafe Bounds myBnds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_myBnds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_myBnds)) = value;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x000A4364 File Offset: 0x000A2564
		// (set) Token: 0x06002877 RID: 10359 RVA: 0x0001C34F File Offset: 0x0001A54F
		public unsafe GameObject player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x000A4394 File Offset: 0x000A2594
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x0001C36E File Offset: 0x0001A56E
		public unsafe Vector2 defTopPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_defTopPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_defTopPos)) = value;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x000A43BC File Offset: 0x000A25BC
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x0001C389 File Offset: 0x0001A589
		public unsafe SpriteRenderer sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x000A43EC File Offset: 0x000A25EC
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		public unsafe SpriteRenderer topSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x000A441C File Offset: 0x000A261C
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x0001C3C7 File Offset: 0x0001A5C7
		public unsafe ShadowLayerer shadowLayerer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_shadowLayerer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShadowLayerer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_shadowLayerer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x000A444C File Offset: 0x000A264C
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x0001C3E6 File Offset: 0x0001A5E6
		public unsafe MeshRenderer meshRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_meshRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_meshRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x000A447C File Offset: 0x000A267C
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x0001C405 File Offset: 0x0001A605
		public unsafe CamControl camControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_camControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CamControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_camControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x000A44AC File Offset: 0x000A26AC
		// (set) Token: 0x06002885 RID: 10373 RVA: 0x0001C424 File Offset: 0x0001A624
		public unsafe Il2CppReferenceArray<SpriteRenderer> subTopObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_subTopObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_subTopObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002886 RID: 10374 RVA: 0x000A44DC File Offset: 0x000A26DC
		// (set) Token: 0x06002887 RID: 10375 RVA: 0x0001C443 File Offset: 0x0001A643
		public unsafe Il2CppReferenceArray<GameObject> toppers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_toppers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_toppers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x000A450C File Offset: 0x000A270C
		// (set) Token: 0x06002889 RID: 10377 RVA: 0x0001C462 File Offset: 0x0001A662
		public unsafe bool meshesZeroed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_meshesZeroed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_meshesZeroed)) = value;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x000A4534 File Offset: 0x000A2734
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x0001C47D File Offset: 0x0001A67D
		public unsafe int topperNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topperNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_topperNum)) = value;
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x000A455C File Offset: 0x000A275C
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x0001C498 File Offset: 0x0001A698
		public unsafe int meshInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_meshInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Paralax.NativeFieldInfoPtr_meshInd)) = value;
			}
		}

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeFieldInfoPtr_mesher;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeFieldInfoPtr_topObj;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeFieldInfoPtr_myBox;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeFieldInfoPtr_myLocalBox;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeFieldInfoPtr_topLocalBox;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeFieldInfoPtr_topBox;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeFieldInfoPtr_parralax;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeFieldInfoPtr_norms;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeFieldInfoPtr_extents;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeFieldInfoPtr_midPos;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeFieldInfoPtr_myBnds;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeFieldInfoPtr_defTopPos;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeFieldInfoPtr_topSprite;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeFieldInfoPtr_shadowLayerer;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeFieldInfoPtr_meshRend;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeFieldInfoPtr_camControl;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeFieldInfoPtr_subTopObjs;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeFieldInfoPtr_toppers;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeFieldInfoPtr_meshesZeroed;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeFieldInfoPtr_topperNum;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeFieldInfoPtr_meshInd;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_OnBecameInvisible_Public_Void_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVerts_Public_Void_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBoxes_Public_Void_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_GetVerts_Public_Void_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_SideMost_Public_Vector3_Il2CppStructArray_1_Vector3_Boolean_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
