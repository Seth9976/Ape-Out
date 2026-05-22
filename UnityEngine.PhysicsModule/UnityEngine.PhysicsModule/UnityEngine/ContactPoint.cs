using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	[StructLayout(2)]
	public struct ContactPoint
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00006BC0 File Offset: 0x00004DC0
		// Note: this type is marked as 'beforefieldinit'.
		static ContactPoint()
		{
			Il2CppClassPointerStore<ContactPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ContactPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr);
			ContactPoint.NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Point");
			ContactPoint.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Normal");
			ContactPoint.NativeFieldInfoPtr_m_ThisColliderInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_ThisColliderInstanceID");
			ContactPoint.NativeFieldInfoPtr_m_OtherColliderInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_OtherColliderInstanceID");
			ContactPoint.NativeFieldInfoPtr_m_Separation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Separation");
			ContactPoint.NativeMethodInfoPtr_get_point_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, 100663362);
			ContactPoint.GetColliderByInstanceIDDelegateField = IL2CPP.ResolveICall<ContactPoint.GetColliderByInstanceIDDelegate>("UnityEngine.ContactPoint::GetColliderByInstanceID");
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00006C78 File Offset: 0x00004E78
		public unsafe Vector3 point
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactPoint.NativeMethodInfoPtr_get_point_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002CAA File Offset: 0x00000EAA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, ref this));
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00006CA8 File Offset: 0x00004EA8
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public Collider thisCollider
		{
			get
			{
				return ContactPoint.GetColliderByInstanceID(this.m_ThisColliderInstanceID);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00006CE0 File Offset: 0x00004EE0
		public Collider otherCollider
		{
			get
			{
				return ContactPoint.GetColliderByInstanceID(this.m_OtherColliderInstanceID);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00006D00 File Offset: 0x00004F00
		public float separation
		{
			get
			{
				return this.m_Separation;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00006D18 File Offset: 0x00004F18
		public static Collider GetColliderByInstanceID(int instanceID)
		{
			IntPtr intPtr = ContactPoint.GetColliderByInstanceIDDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
		}

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_m_Point;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_m_ThisColliderInstanceID;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherColliderInstanceID;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_m_Separation;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector3_0;

		// Token: 0x040000E1 RID: 225
		[FieldOffset(0)]
		public Vector3 m_Point;

		// Token: 0x040000E2 RID: 226
		[FieldOffset(12)]
		public Vector3 m_Normal;

		// Token: 0x040000E3 RID: 227
		[FieldOffset(24)]
		public int m_ThisColliderInstanceID;

		// Token: 0x040000E4 RID: 228
		[FieldOffset(28)]
		public int m_OtherColliderInstanceID;

		// Token: 0x040000E5 RID: 229
		[FieldOffset(32)]
		public float m_Separation;

		// Token: 0x040000E6 RID: 230
		private static readonly ContactPoint.GetColliderByInstanceIDDelegate GetColliderByInstanceIDDelegateField;

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000452 RID: 1106
		private delegate IntPtr GetColliderByInstanceIDDelegate(int instanceID);
	}
}
