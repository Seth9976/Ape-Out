using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class Collision : Object
	{
		// Token: 0x0600001C RID: 28 RVA: 0x0000442C File Offset: 0x0000262C
		// Note: this type is marked as 'beforefieldinit'.
		static Collision()
		{
			Il2CppClassPointerStore<Collision>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Collision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collision>.NativeClassPtr);
			Collision.NativeFieldInfoPtr_m_Impulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_Impulse");
			Collision.NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_RelativeVelocity");
			Collision.NativeFieldInfoPtr_m_Body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_Body");
			Collision.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_Collider");
			Collision.NativeFieldInfoPtr_m_ContactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_ContactCount");
			Collision.NativeFieldInfoPtr_m_ReusedContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_ReusedContacts");
			Collision.NativeFieldInfoPtr_m_LegacyContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_LegacyContacts");
			Collision.NativeMethodInfoPtr_get_relativeVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663301);
			Collision.NativeMethodInfoPtr_get_collider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663302);
			Collision.NativeMethodInfoPtr_get_contacts_Public_get_Il2CppStructArray_1_ContactPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663303);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00004524 File Offset: 0x00002724
		public unsafe Vector3 relativeVelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision.NativeMethodInfoPtr_get_relativeVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00004560 File Offset: 0x00002760
		public unsafe Collider collider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision.NativeMethodInfoPtr_get_collider_Public_get_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000045A0 File Offset: 0x000027A0
		public unsafe Il2CppStructArray<ContactPoint> contacts
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 513513, RefRangeEnd = 513516, XrefRangeStart = 513507, XrefRangeEnd = 513513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision.NativeMethodInfoPtr_get_contacts_Public_get_Il2CppStructArray_1_ContactPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint>>(intPtr3) : null;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000212E File Offset: 0x0000032E
		public Collision(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000045E0 File Offset: 0x000027E0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002137 File Offset: 0x00000337
		public unsafe Vector3 m_Impulse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Impulse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Impulse)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00004608 File Offset: 0x00002808
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe Vector3 m_RelativeVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_RelativeVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_RelativeVelocity)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00004630 File Offset: 0x00002830
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000216D File Offset: 0x0000036D
		public unsafe Component m_Body
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Body);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Body), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004660 File Offset: 0x00002860
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000218C File Offset: 0x0000038C
		public unsafe Collider m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004690 File Offset: 0x00002890
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000021AB File Offset: 0x000003AB
		public unsafe int m_ContactCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_ContactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_ContactCount)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000046B8 File Offset: 0x000028B8
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000021C6 File Offset: 0x000003C6
		public unsafe Il2CppStructArray<ContactPoint> m_ReusedContacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_ReusedContacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_ReusedContacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000046E8 File Offset: 0x000028E8
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000021E5 File Offset: 0x000003E5
		public unsafe Il2CppStructArray<ContactPoint> m_LegacyContacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_LegacyContacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision.NativeFieldInfoPtr_m_LegacyContacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004718 File Offset: 0x00002918
		public Il2CppStructArray<ContactPoint> GetContacts_Internal()
		{
			return (this.m_LegacyContacts == null) ? this.m_ReusedContacts : this.m_LegacyContacts;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004740 File Offset: 0x00002940
		public Rigidbody rigidbody
		{
			get
			{
				return this.m_Body.TryCast<Rigidbody>();
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004760 File Offset: 0x00002960
		public ArticulationBody articulationBody
		{
			get
			{
				return this.m_Body.TryCast<ArticulationBody>();
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00004780 File Offset: 0x00002980
		public Component body
		{
			get
			{
				return this.m_Body;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004798 File Offset: 0x00002998
		public Transform transform
		{
			get
			{
				return (this.rigidbody != null) ? this.rigidbody.transform : this.collider.transform;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000047D0 File Offset: 0x000029D0
		public GameObject gameObject
		{
			get
			{
				return (this.m_Body != null) ? this.m_Body.gameObject : this.m_Collider.gameObject;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00004808 File Offset: 0x00002A08
		public int contactCount
		{
			get
			{
				return this.m_ContactCount;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004820 File Offset: 0x00002A20
		public ContactPoint GetContact(int index)
		{
			bool flag = index < 0 || index >= this.m_ContactCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Cannot get contact at index {0}. There are {1} contact(s).", index, this.m_ContactCount));
			}
			return this.GetContacts_Internal()[index];
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004878 File Offset: 0x00002A78
		public int GetContacts(Il2CppStructArray<ContactPoint> contacts)
		{
			bool flag = contacts == null;
			if (flag)
			{
				throw new NullReferenceException("Cannot get contacts as the provided array is NULL.");
			}
			int num = Mathf.Min(this.m_ContactCount, contacts.Length);
			Array.Copy(this.GetContacts_Internal(), contacts, num);
			return num;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000048C0 File Offset: 0x00002AC0
		public int GetContacts(List<ContactPoint> contacts)
		{
			bool flag = contacts == null;
			if (flag)
			{
				throw new NullReferenceException("Cannot get contacts as the provided list is NULL.");
			}
			contacts.Clear();
			contacts.AddRange(this.GetContacts_Internal());
			return this.contactCount;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004900 File Offset: 0x00002B00
		public virtual IEnumerator GetEnumerator()
		{
			return this.contacts.GetEnumerator();
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004920 File Offset: 0x00002B20
		public Vector3 impulse
		{
			get
			{
				return this.m_Impulse;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00004938 File Offset: 0x00002B38
		public Vector3 impactForceSum
		{
			get
			{
				return this.relativeVelocity;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00004950 File Offset: 0x00002B50
		public Vector3 frictionForceSum
		{
			get
			{
				return Vector3.zero;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00004968 File Offset: 0x00002B68
		public Component other
		{
			get
			{
				return (this.m_Body != null) ? this.m_Body : this.m_Collider;
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_m_Impulse;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_m_Body;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_m_ContactCount;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_m_ReusedContacts;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyContacts;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_relativeVelocity_Public_get_Vector3_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_contacts_Public_get_Il2CppStructArray_1_ContactPoint_0;
	}
}
