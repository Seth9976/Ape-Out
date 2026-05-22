using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000166 RID: 358
	public class Pole : MonoBehaviour
	{
		// Token: 0x06002B77 RID: 11127 RVA: 0x000AC87C File Offset: 0x000AAA7C
		// Note: this type is marked as 'beforefieldinit'.
		static Pole()
		{
			Il2CppClassPointerStore<Pole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Pole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pole>.NativeClassPtr);
			Pole.NativeFieldInfoPtr_mesher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "mesher");
			Pole.NativeFieldInfoPtr_botPol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "botPol");
			Pole.NativeFieldInfoPtr_topPol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "topPol");
			Pole.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "verts");
			Pole.NativeFieldInfoPtr_pts1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "pts1");
			Pole.NativeFieldInfoPtr_pts2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "pts2");
			Pole.NativeFieldInfoPtr_defPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "defPos");
			Pole.NativeFieldInfoPtr_topPolTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "topPolTrans");
			Pole.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "on");
			Pole.NativeFieldInfoPtr_mesherIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "mesherIndex");
			Pole.NativeFieldInfoPtr_mesherMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pole>.NativeClassPtr, "mesherMesh");
			Pole.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pole>.NativeClassPtr, 100666718);
			Pole.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pole>.NativeClassPtr, 100666719);
			Pole.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pole>.NativeClassPtr, 100666720);
			Pole.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pole>.NativeClassPtr, 100666721);
			Pole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pole>.NativeClassPtr, 100666722);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000AC9EC File Offset: 0x000AABEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79379, XrefRangeEnd = 79406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pole.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000ACA20 File Offset: 0x000AAC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79406, XrefRangeEnd = 79410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pole.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000ACA54 File Offset: 0x000AAC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79410, XrefRangeEnd = 79416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pole.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000ACA88 File Offset: 0x000AAC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79416, XrefRangeEnd = 79501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pole.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000ACABC File Offset: 0x000AACBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pole()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x0001E246 File Offset: 0x0001C446
		public Pole(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000ACAF8 File Offset: 0x000AACF8
		// (set) Token: 0x06002B7F RID: 11135 RVA: 0x0001E24F File Offset: 0x0001C44F
		public unsafe MeshFilter mesher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_mesher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_mesher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x000ACB28 File Offset: 0x000AAD28
		// (set) Token: 0x06002B81 RID: 11137 RVA: 0x0001E26E File Offset: 0x0001C46E
		public unsafe PolygonCollider2D botPol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_botPol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_botPol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x000ACB58 File Offset: 0x000AAD58
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x0001E28D File Offset: 0x0001C48D
		public unsafe PolygonCollider2D topPol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_topPol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_topPol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x000ACB88 File Offset: 0x000AAD88
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x0001E2AC File Offset: 0x0001C4AC
		public unsafe Il2CppStructArray<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x000ACBB8 File Offset: 0x000AADB8
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x0001E2CB File Offset: 0x0001C4CB
		public unsafe Il2CppStructArray<Vector3> pts1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_pts1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_pts1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000ACBE8 File Offset: 0x000AADE8
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x0001E2EA File Offset: 0x0001C4EA
		public unsafe Il2CppStructArray<Vector3> pts2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_pts2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_pts2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x000ACC18 File Offset: 0x000AAE18
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x0001E309 File Offset: 0x0001C509
		public unsafe Vector3 defPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_defPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_defPos)) = value;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x000ACC40 File Offset: 0x000AAE40
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x0001E324 File Offset: 0x0001C524
		public unsafe Transform topPolTrans
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_topPolTrans);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_topPolTrans), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x000ACC70 File Offset: 0x000AAE70
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x0001E343 File Offset: 0x0001C543
		public unsafe bool on
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_on);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_on)) = value;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x000ACC98 File Offset: 0x000AAE98
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x0001E35E File Offset: 0x0001C55E
		public unsafe int mesherIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_mesherIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_mesherIndex)) = value;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x000ACCC0 File Offset: 0x000AAEC0
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x0001E379 File Offset: 0x0001C579
		public unsafe Mesh mesherMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_mesherMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pole.NativeFieldInfoPtr_mesherMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeFieldInfoPtr_mesher;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeFieldInfoPtr_botPol;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeFieldInfoPtr_topPol;

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeFieldInfoPtr_pts1;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeFieldInfoPtr_pts2;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeFieldInfoPtr_defPos;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeFieldInfoPtr_topPolTrans;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr_on;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr_mesherIndex;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeFieldInfoPtr_mesherMesh;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
