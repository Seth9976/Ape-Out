using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000194 RID: 404
	public class SmokePartTest : MonoBehaviour
	{
		// Token: 0x06002F6D RID: 12141 RVA: 0x000B70DC File Offset: 0x000B52DC
		// Note: this type is marked as 'beforefieldinit'.
		static SmokePartTest()
		{
			Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SmokePartTest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr);
			SmokePartTest.NativeFieldInfoPtr_botMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "botMesh");
			SmokePartTest.NativeFieldInfoPtr_topMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "topMesh");
			SmokePartTest.NativeFieldInfoPtr_shadowMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "shadowMesh");
			SmokePartTest.NativeFieldInfoPtr_botRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "botRend");
			SmokePartTest.NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "pts");
			SmokePartTest.NativeFieldInfoPtr_debugPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "debugPt");
			SmokePartTest.NativeFieldInfoPtr_shadowVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "shadowVerts");
			SmokePartTest.NativeFieldInfoPtr_tris = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "tris");
			SmokePartTest.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "uv");
			SmokePartTest.NativeFieldInfoPtr_big = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "big");
			SmokePartTest.NativeFieldInfoPtr_paralaxAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "paralaxAmount");
			SmokePartTest.NativeFieldInfoPtr_flickerTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "flickerTimer");
			SmokePartTest.NativeFieldInfoPtr_rad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, "rad");
			SmokePartTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr, 100667012);
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x000B7224 File Offset: 0x000B5424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmokePartTest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmokePartTest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmokePartTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00020B30 File Offset: 0x0001ED30
		public SmokePartTest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x000B7260 File Offset: 0x000B5460
		// (set) Token: 0x06002F71 RID: 12145 RVA: 0x00020B39 File Offset: 0x0001ED39
		public unsafe MeshFilter botMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_botMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_botMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x000B7290 File Offset: 0x000B5490
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x00020B58 File Offset: 0x0001ED58
		public unsafe MeshFilter topMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_topMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_topMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x000B72C0 File Offset: 0x000B54C0
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x00020B77 File Offset: 0x0001ED77
		public unsafe MeshFilter shadowMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_shadowMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_shadowMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x000B72F0 File Offset: 0x000B54F0
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x00020B96 File Offset: 0x0001ED96
		public unsafe MeshRenderer botRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_botRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_botRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x000B7320 File Offset: 0x000B5520
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x00020BB5 File Offset: 0x0001EDB5
		public unsafe Il2CppStructArray<Vector3> pts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_pts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_pts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06002F7A RID: 12154 RVA: 0x000B7350 File Offset: 0x000B5550
		// (set) Token: 0x06002F7B RID: 12155 RVA: 0x00020BD4 File Offset: 0x0001EDD4
		public unsafe Vector2 debugPt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_debugPt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_debugPt)) = value;
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06002F7C RID: 12156 RVA: 0x000B7378 File Offset: 0x000B5578
		// (set) Token: 0x06002F7D RID: 12157 RVA: 0x00020BEF File Offset: 0x0001EDEF
		public unsafe Il2CppStructArray<Vector3> shadowVerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_shadowVerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_shadowVerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x06002F7E RID: 12158 RVA: 0x000B73A8 File Offset: 0x000B55A8
		// (set) Token: 0x06002F7F RID: 12159 RVA: 0x00020C0E File Offset: 0x0001EE0E
		public unsafe Il2CppStructArray<int> tris
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_tris);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_tris), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x000B73D8 File Offset: 0x000B55D8
		// (set) Token: 0x06002F81 RID: 12161 RVA: 0x00020C2D File Offset: 0x0001EE2D
		public unsafe Il2CppStructArray<Vector2> uv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_uv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_uv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x000B7408 File Offset: 0x000B5608
		// (set) Token: 0x06002F83 RID: 12163 RVA: 0x00020C4C File Offset: 0x0001EE4C
		public unsafe bool big
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_big);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_big)) = value;
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x000B7430 File Offset: 0x000B5630
		// (set) Token: 0x06002F85 RID: 12165 RVA: 0x00020C67 File Offset: 0x0001EE67
		public unsafe float paralaxAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_paralaxAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_paralaxAmount)) = value;
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x000B7458 File Offset: 0x000B5658
		// (set) Token: 0x06002F87 RID: 12167 RVA: 0x00020C82 File Offset: 0x0001EE82
		public unsafe float flickerTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_flickerTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_flickerTimer)) = value;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x000B7480 File Offset: 0x000B5680
		// (set) Token: 0x06002F89 RID: 12169 RVA: 0x00020C9D File Offset: 0x0001EE9D
		public unsafe int rad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_rad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmokePartTest.NativeFieldInfoPtr_rad)) = value;
			}
		}

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeFieldInfoPtr_botMesh;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeFieldInfoPtr_topMesh;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeFieldInfoPtr_shadowMesh;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeFieldInfoPtr_botRend;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeFieldInfoPtr_pts;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeFieldInfoPtr_debugPt;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeFieldInfoPtr_shadowVerts;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeFieldInfoPtr_tris;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeFieldInfoPtr_big;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeFieldInfoPtr_paralaxAmount;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeFieldInfoPtr_flickerTimer;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr_rad;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
