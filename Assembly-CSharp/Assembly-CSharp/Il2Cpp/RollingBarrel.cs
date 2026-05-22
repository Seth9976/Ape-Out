using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000061 RID: 97
	public class RollingBarrel : MonoBehaviour
	{
		// Token: 0x06000D2F RID: 3375 RVA: 0x0005BA10 File Offset: 0x00059C10
		// Note: this type is marked as 'beforefieldinit'.
		static RollingBarrel()
		{
			Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RollingBarrel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr);
			RollingBarrel.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, "col");
			RollingBarrel.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, "rb");
			RollingBarrel.NativeFieldInfoPtr_vel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, "vel");
			RollingBarrel.NativeFieldInfoPtr_remainder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, "remainder");
			RollingBarrel.NativeFieldInfoPtr_collisionLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, "collisionLayers");
			RollingBarrel.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, "frame");
			RollingBarrel.NativeFieldInfoPtr_frameScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, "frameScale");
			RollingBarrel.NativeFieldInfoPtr_impactSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, "impactSounds");
			RollingBarrel.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, "source");
			RollingBarrel.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, 100664465);
			RollingBarrel.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, 100664466);
			RollingBarrel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr, 100664467);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0005BB30 File Offset: 0x00059D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43766, XrefRangeEnd = 43784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollingBarrel.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0005BB64 File Offset: 0x00059D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43784, XrefRangeEnd = 43872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollingBarrel.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0005BB98 File Offset: 0x00059D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43872, XrefRangeEnd = 43875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RollingBarrel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RollingBarrel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollingBarrel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0000A006 File Offset: 0x00008206
		public RollingBarrel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x0005BBD4 File Offset: 0x00059DD4
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x0000A00F File Offset: 0x0000820F
		public unsafe CircleCollider2D col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0005BC04 File Offset: 0x00059E04
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x0000A02E File Offset: 0x0000822E
		public unsafe Rigidbody2D rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x0005BC34 File Offset: 0x00059E34
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x0000A04D File Offset: 0x0000824D
		public unsafe Vector2 vel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_vel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_vel)) = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0005BC5C File Offset: 0x00059E5C
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x0000A068 File Offset: 0x00008268
		public unsafe Vector2 remainder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_remainder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_remainder)) = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0005BC84 File Offset: 0x00059E84
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x0000A083 File Offset: 0x00008283
		public unsafe LayerMask collisionLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_collisionLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_collisionLayers)) = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x0005BCAC File Offset: 0x00059EAC
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x0000A09E File Offset: 0x0000829E
		public unsafe int frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_frame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_frame)) = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0005BCD4 File Offset: 0x00059ED4
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x0000A0B9 File Offset: 0x000082B9
		public unsafe int frameScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_frameScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_frameScale)) = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0005BCFC File Offset: 0x00059EFC
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x0000A0D4 File Offset: 0x000082D4
		public unsafe Il2CppReferenceArray<AudioClip> impactSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_impactSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_impactSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0005BD2C File Offset: 0x00059F2C
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x0000A0F3 File Offset: 0x000082F3
		public unsafe AudioSource source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingBarrel.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeFieldInfoPtr_vel;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeFieldInfoPtr_remainder;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr_collisionLayers;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeFieldInfoPtr_frame;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr_frameScale;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeFieldInfoPtr_impactSounds;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
