using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	public class Collision2D : Object
	{
		// Token: 0x060001EC RID: 492 RVA: 0x0000A2C8 File Offset: 0x000084C8
		// Note: this type is marked as 'beforefieldinit'.
		static Collision2D()
		{
			Il2CppClassPointerStore<Collision2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Collision2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collision2D>.NativeClassPtr);
			Collision2D.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Collider");
			Collision2D.NativeFieldInfoPtr_m_OtherCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_OtherCollider");
			Collision2D.NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Rigidbody");
			Collision2D.NativeFieldInfoPtr_m_OtherRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_OtherRigidbody");
			Collision2D.NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_RelativeVelocity");
			Collision2D.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Enabled");
			Collision2D.NativeFieldInfoPtr_m_ContactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_ContactCount");
			Collision2D.NativeFieldInfoPtr_m_ReusedContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_ReusedContacts");
			Collision2D.NativeFieldInfoPtr_m_LegacyContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_LegacyContacts");
			Collision2D.NativeMethodInfoPtr_GetContacts_Internal_Private_Il2CppStructArray_1_ContactPoint2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, 100663383);
			Collision2D.NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, 100663384);
			Collision2D.NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, 100663385);
			Collision2D.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, 100663386);
			Collision2D.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, 100663387);
			Collision2D.NativeMethodInfoPtr_get_contactCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, 100663388);
			Collision2D.NativeMethodInfoPtr_GetContact_Public_ContactPoint2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, 100663389);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A438 File Offset: 0x00008638
		[CallerCount(0)]
		public unsafe Il2CppStructArray<ContactPoint2D> GetContacts_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision2D.NativeMethodInfoPtr_GetContacts_Internal_Private_Il2CppStructArray_1_ContactPoint2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint2D>>(intPtr3) : null;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000A478 File Offset: 0x00008678
		public unsafe Collider2D collider
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 512992, RefRangeEnd = 512994, XrefRangeStart = 512986, XrefRangeEnd = 512992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision2D.NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000A4B8 File Offset: 0x000086B8
		public unsafe Rigidbody2D rigidbody
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 513000, RefRangeEnd = 513004, XrefRangeStart = 512994, XrefRangeEnd = 513000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision2D.NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000A4F8 File Offset: 0x000086F8
		public unsafe Transform transform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 513024, RefRangeEnd = 513025, XrefRangeStart = 513004, XrefRangeEnd = 513024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision2D.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000A538 File Offset: 0x00008738
		public unsafe GameObject gameObject
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 513045, RefRangeEnd = 513065, XrefRangeStart = 513025, XrefRangeEnd = 513045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision2D.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000A578 File Offset: 0x00008778
		public unsafe int contactCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision2D.NativeMethodInfoPtr_get_contactCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000A5B4 File Offset: 0x000087B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 513065, RefRangeEnd = 513070, XrefRangeStart = 513065, XrefRangeEnd = 513065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactPoint2D GetContact(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Collision2D.NativeMethodInfoPtr_GetContact_Public_ContactPoint2D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002968 File Offset: 0x00000B68
		public Collision2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000A600 File Offset: 0x00008800
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002971 File Offset: 0x00000B71
		public unsafe int m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Collider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Collider)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000A628 File Offset: 0x00008828
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0000298C File Offset: 0x00000B8C
		public unsafe int m_OtherCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherCollider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherCollider)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000A650 File Offset: 0x00008850
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000029A7 File Offset: 0x00000BA7
		public unsafe int m_Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Rigidbody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Rigidbody)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000A678 File Offset: 0x00008878
		// (set) Token: 0x060001FC RID: 508 RVA: 0x000029C2 File Offset: 0x00000BC2
		public unsafe int m_OtherRigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherRigidbody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_OtherRigidbody)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000A6A0 File Offset: 0x000088A0
		// (set) Token: 0x060001FE RID: 510 RVA: 0x000029DD File Offset: 0x00000BDD
		public unsafe Vector2 m_RelativeVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_RelativeVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_RelativeVelocity)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000A6C8 File Offset: 0x000088C8
		// (set) Token: 0x06000200 RID: 512 RVA: 0x000029F8 File Offset: 0x00000BF8
		public unsafe int m_Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_Enabled)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000A6F0 File Offset: 0x000088F0
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002A13 File Offset: 0x00000C13
		public unsafe int m_ContactCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ContactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ContactCount)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000A718 File Offset: 0x00008918
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002A2E File Offset: 0x00000C2E
		public unsafe Il2CppStructArray<ContactPoint2D> m_ReusedContacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ReusedContacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_ReusedContacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000A748 File Offset: 0x00008948
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002A4D File Offset: 0x00000C4D
		public unsafe Il2CppStructArray<ContactPoint2D> m_LegacyContacts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_LegacyContacts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Collision2D.NativeFieldInfoPtr_m_LegacyContacts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000A778 File Offset: 0x00008978
		public Collider2D otherCollider
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherCollider).TryCast<Collider2D>();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000A79C File Offset: 0x0000899C
		public Rigidbody2D otherRigidbody
		{
			get
			{
				return Object.FindObjectFromInstanceID(this.m_OtherRigidbody).TryCast<Rigidbody2D>();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000A7C0 File Offset: 0x000089C0
		public Vector2 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000A7D8 File Offset: 0x000089D8
		public bool enabled
		{
			get
			{
				return this.m_Enabled == 1;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00002A6C File Offset: 0x00000C6C
		public Il2CppStructArray<ContactPoint2D> contacts
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000A7F4 File Offset: 0x000089F4
		public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
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

		// Token: 0x0600020D RID: 525 RVA: 0x0000A83C File Offset: 0x00008A3C
		public int GetContacts(List<ContactPoint2D> contacts)
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

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherCollider;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_m_Rigidbody;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherRigidbody;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_m_ContactCount;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_m_ReusedContacts;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyContacts;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_GetContacts_Internal_Private_Il2CppStructArray_1_ContactPoint2D_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider2D_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_get_rigidbody_Public_get_Rigidbody2D_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_get_contactCount_Public_get_Int32_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_GetContact_Public_ContactPoint2D_Int32_0;
	}
}
