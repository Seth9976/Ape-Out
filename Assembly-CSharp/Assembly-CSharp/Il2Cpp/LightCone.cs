using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000122 RID: 290
	public class LightCone : MonoBehaviour
	{
		// Token: 0x060022D2 RID: 8914 RVA: 0x00094EFC File Offset: 0x000930FC
		// Note: this type is marked as 'beforefieldinit'.
		static LightCone()
		{
			Il2CppClassPointerStore<LightCone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LightCone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCone>.NativeClassPtr);
			LightCone.NativeFieldInfoPtr_beamAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCone>.NativeClassPtr, "beamAng");
			LightCone.NativeFieldInfoPtr_beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCone>.NativeClassPtr, "beam");
			LightCone.NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCone>.NativeClassPtr, "res");
			LightCone.NativeFieldInfoPtr_gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCone>.NativeClassPtr, "gun");
			LightCone.NativeFieldInfoPtr_verts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCone>.NativeClassPtr, "verts");
			LightCone.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCone>.NativeClassPtr, "pts");
			LightCone.NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCone>.NativeClassPtr, "tris");
			LightCone.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCone>.NativeClassPtr, "uv");
			LightCone.NativeFieldInfoPtr_pointingVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCone>.NativeClassPtr, "pointingVect");
			LightCone.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCone>.NativeClassPtr, 100665997);
			LightCone.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCone>.NativeClassPtr, 100665998);
			LightCone.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCone>.NativeClassPtr, 100665999);
			LightCone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCone>.NativeClassPtr, 100666000);
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00095030 File Offset: 0x00093230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69510, XrefRangeEnd = 69519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCone.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00095064 File Offset: 0x00093264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69519, XrefRangeEnd = 69671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCone.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00095098 File Offset: 0x00093298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69671, XrefRangeEnd = 69688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCone.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x000950CC File Offset: 0x000932CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightCone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0001871A File Offset: 0x0001691A
		public LightCone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x00095108 File Offset: 0x00093308
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x00018723 File Offset: 0x00016923
		public unsafe float beamAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_beamAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_beamAng)) = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x00095130 File Offset: 0x00093330
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x0001873E File Offset: 0x0001693E
		public unsafe MeshFilter beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x00095160 File Offset: 0x00093360
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x0001875D File Offset: 0x0001695D
		public unsafe int res
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_res);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_res)) = value;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x00095188 File Offset: 0x00093388
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x00018778 File Offset: 0x00016978
		public unsafe GameObject gun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_gun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_gun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000951B8 File Offset: 0x000933B8
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x00018797 File Offset: 0x00016997
		public unsafe Il2CppStructArray<Vector3> verts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_verts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_verts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000951E8 File Offset: 0x000933E8
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x000187B6 File Offset: 0x000169B6
		public unsafe Il2CppStructArray<Vector2> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x00095218 File Offset: 0x00093418
		// (set) Token: 0x060022E5 RID: 8933 RVA: 0x000187D5 File Offset: 0x000169D5
		public unsafe Il2CppStructArray<int> tris
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_tris);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_tris), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x00095248 File Offset: 0x00093448
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x000187F4 File Offset: 0x000169F4
		public unsafe Il2CppStructArray<Vector2> uv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_uv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_uv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x00095278 File Offset: 0x00093478
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x00018813 File Offset: 0x00016A13
		public unsafe Vector2 pointingVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_pointingVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCone.NativeFieldInfoPtr_pointingVect)) = value;
			}
		}

		// Token: 0x04001488 RID: 5256
		private static readonly IntPtr NativeFieldInfoPtr_beamAng;

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeFieldInfoPtr_beam;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeFieldInfoPtr_res;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeFieldInfoPtr_gun;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeFieldInfoPtr_verts;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeFieldInfoPtr_tris;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeFieldInfoPtr_pointingVect;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
