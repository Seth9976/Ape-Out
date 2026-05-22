using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[StructLayout(2)]
	public struct ContactPoint2D
	{
		// Token: 0x0600020E RID: 526 RVA: 0x0000A87C File Offset: 0x00008A7C
		// Note: this type is marked as 'beforefieldinit'.
		static ContactPoint2D()
		{
			Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "ContactPoint2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr);
			ContactPoint2D.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Point");
			ContactPoint2D.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Normal");
			ContactPoint2D.NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_RelativeVelocity");
			ContactPoint2D.NativeFieldInfoPtr_m_Separation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Separation");
			ContactPoint2D.NativeFieldInfoPtr_m_NormalImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_NormalImpulse");
			ContactPoint2D.NativeFieldInfoPtr_m_TangentImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_TangentImpulse");
			ContactPoint2D.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Collider");
			ContactPoint2D.NativeFieldInfoPtr_m_OtherCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_OtherCollider");
			ContactPoint2D.NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Rigidbody");
			ContactPoint2D.NativeFieldInfoPtr_m_OtherRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_OtherRigidbody");
			ContactPoint2D.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Enabled");
			ContactPoint2D.NativeMethodInfoPtr_get_point_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, 100663390);
			ContactPoint2D.NativeMethodInfoPtr_get_normal_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, 100663391);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		public unsafe Vector2 point
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPoint2D.NativeMethodInfoPtr_get_point_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		public unsafe Vector2 normal
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPoint2D.NativeMethodInfoPtr_get_normal_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002A79 File Offset: 0x00000C79
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, ref this));
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000AA10 File Offset: 0x00008C10
		public float separation
		{
			get
			{
				return this.m_Separation;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000AA28 File Offset: 0x00008C28
		public float normalImpulse
		{
			get
			{
				return this.m_NormalImpulse;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000AA40 File Offset: 0x00008C40
		public float tangentImpulse
		{
			get
			{
				return this.m_TangentImpulse;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000AA58 File Offset: 0x00008C58
		public Vector2 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000AA70 File Offset: 0x00008C70
		public Collider2D collider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Collider).TryCast<Collider2D>();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000AA94 File Offset: 0x00008C94
		public Collider2D otherCollider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherCollider).TryCast<Collider2D>();
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		public Rigidbody2D rigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_Rigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000AADC File Offset: 0x00008CDC
		public Rigidbody2D otherRigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherRigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000AB00 File Offset: 0x00008D00
		public bool enabled
		{
			get
			{
				return this.m_Enabled == 1;
			}
		}

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_m_Separation;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalImpulse;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_m_TangentImpulse;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherCollider;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_m_Rigidbody;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherRigidbody;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector2_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector2_0;

		// Token: 0x04000115 RID: 277
		[FieldOffset(0)]
		public Vector2 m_Point;

		// Token: 0x04000116 RID: 278
		[FieldOffset(8)]
		public Vector2 m_Normal;

		// Token: 0x04000117 RID: 279
		[FieldOffset(16)]
		public Vector2 m_RelativeVelocity;

		// Token: 0x04000118 RID: 280
		[FieldOffset(24)]
		public float m_Separation;

		// Token: 0x04000119 RID: 281
		[FieldOffset(28)]
		public float m_NormalImpulse;

		// Token: 0x0400011A RID: 282
		[FieldOffset(32)]
		public float m_TangentImpulse;

		// Token: 0x0400011B RID: 283
		[FieldOffset(36)]
		public int m_Collider;

		// Token: 0x0400011C RID: 284
		[FieldOffset(40)]
		public int m_OtherCollider;

		// Token: 0x0400011D RID: 285
		[FieldOffset(44)]
		public int m_Rigidbody;

		// Token: 0x0400011E RID: 286
		[FieldOffset(48)]
		public int m_OtherRigidbody;

		// Token: 0x0400011F RID: 287
		[FieldOffset(52)]
		public int m_Enabled;
	}
}
