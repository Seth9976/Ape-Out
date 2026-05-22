using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[StructLayout(2)]
	public struct RaycastHit2D
	{
		// Token: 0x0600021B RID: 539 RVA: 0x0000AB1C File Offset: 0x00008D1C
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastHit2D()
		{
			Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "RaycastHit2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr);
			RaycastHit2D.NativeFieldInfoPtr_m_Centroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Centroid");
			RaycastHit2D.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Point");
			RaycastHit2D.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Normal");
			RaycastHit2D.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Distance");
			RaycastHit2D.NativeFieldInfoPtr_m_Fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Fraction");
			RaycastHit2D.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, "m_Collider");
			RaycastHit2D.NativeMethodInfoPtr_get_centroid_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663392);
			RaycastHit2D.NativeMethodInfoPtr_get_point_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663393);
			RaycastHit2D.NativeMethodInfoPtr_set_point_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663394);
			RaycastHit2D.NativeMethodInfoPtr_get_normal_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663395);
			RaycastHit2D.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663396);
			RaycastHit2D.NativeMethodInfoPtr_get_fraction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663397);
			RaycastHit2D.NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663398);
			RaycastHit2D.NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663399);
			RaycastHit2D.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663400);
			RaycastHit2D.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, 100663401);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000AC8C File Offset: 0x00008E8C
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002A9D File Offset: 0x00000C9D
		public unsafe Vector2 centroid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_centroid_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Centroid = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000ACBC File Offset: 0x00008EBC
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe Vector2 point
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_point_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_set_point_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000AD20 File Offset: 0x00008F20
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002AA7 File Offset: 0x00000CA7
		public unsafe Vector2 normal
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_normal_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000AD50 File Offset: 0x00008F50
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002AB1 File Offset: 0x00000CB1
		public unsafe float distance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_distance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Distance = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000AD80 File Offset: 0x00008F80
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002ABB File Offset: 0x00000CBB
		public unsafe float fraction
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 513070, RefRangeEnd = 513090, XrefRangeStart = 513070, XrefRangeEnd = 513070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_fraction_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Fraction = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000ADB0 File Offset: 0x00008FB0
		public unsafe Collider2D collider
		{
			[CallerCount(89)]
			[CachedScanResults(RefRangeStart = 513096, RefRangeEnd = 513185, XrefRangeStart = 513090, XrefRangeEnd = 513096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		public unsafe Rigidbody2D rigidbody
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513201, RefRangeEnd = 513202, XrefRangeStart = 513185, XrefRangeEnd = 513201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody2D_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000AE18 File Offset: 0x00009018
		public unsafe Transform transform
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 513233, RefRangeEnd = 513239, XrefRangeStart = 513202, XrefRangeEnd = 513233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000AE4C File Offset: 0x0000904C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 513252, RefRangeEnd = 513284, XrefRangeStart = 513239, XrefRangeEnd = 513252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(RaycastHit2D hit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastHit2D.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_RaycastHit2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002A8B File Offset: 0x00000C8B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastHit2D>.NativeClassPtr, ref this));
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000AE8C File Offset: 0x0000908C
		public int CompareTo(RaycastHit2D other)
		{
			bool flag = this.collider == null;
			int num;
			if (flag)
			{
				num = 1;
			}
			else
			{
				bool flag2 = other.collider == null;
				if (flag2)
				{
					num = -1;
				}
				else
				{
					num = this.fraction.CompareTo(other.fraction);
				}
			}
			return num;
		}

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeFieldInfoPtr_m_Centroid;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr_m_Fraction;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_get_centroid_Public_get_Vector2_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector2_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_set_point_Public_set_Void_Vector2_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector2_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_fraction_Public_get_Single_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody2D_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_RaycastHit2D_0;

		// Token: 0x04000130 RID: 304
		[FieldOffset(0)]
		public Vector2 m_Centroid;

		// Token: 0x04000131 RID: 305
		[FieldOffset(8)]
		public Vector2 m_Point;

		// Token: 0x04000132 RID: 306
		[FieldOffset(16)]
		public Vector2 m_Normal;

		// Token: 0x04000133 RID: 307
		[FieldOffset(24)]
		public float m_Distance;

		// Token: 0x04000134 RID: 308
		[FieldOffset(28)]
		public float m_Fraction;

		// Token: 0x04000135 RID: 309
		[FieldOffset(32)]
		public int m_Collider;
	}
}
