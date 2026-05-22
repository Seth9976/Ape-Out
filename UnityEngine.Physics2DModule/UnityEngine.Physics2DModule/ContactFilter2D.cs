using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	[StructLayout(2)]
	public struct ContactFilter2D
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00009E24 File Offset: 0x00008024
		// Note: this type is marked as 'beforefieldinit'.
		static ContactFilter2D()
		{
			Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "ContactFilter2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr);
			ContactFilter2D.NativeFieldInfoPtr_useTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useTriggers");
			ContactFilter2D.NativeFieldInfoPtr_useLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useLayerMask");
			ContactFilter2D.NativeFieldInfoPtr_useDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useDepth");
			ContactFilter2D.NativeFieldInfoPtr_useOutsideDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useOutsideDepth");
			ContactFilter2D.NativeFieldInfoPtr_useNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useNormalAngle");
			ContactFilter2D.NativeFieldInfoPtr_useOutsideNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useOutsideNormalAngle");
			ContactFilter2D.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "layerMask");
			ContactFilter2D.NativeFieldInfoPtr_minDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "minDepth");
			ContactFilter2D.NativeFieldInfoPtr_maxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "maxDepth");
			ContactFilter2D.NativeFieldInfoPtr_minNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "minNormalAngle");
			ContactFilter2D.NativeFieldInfoPtr_maxNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "maxNormalAngle");
			ContactFilter2D.NativeFieldInfoPtr_NormalAngleUpperLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "NormalAngleUpperLimit");
			ContactFilter2D.NativeMethodInfoPtr_CheckConsistency_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663378);
			ContactFilter2D.NativeMethodInfoPtr_SetLayerMask_Public_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663379);
			ContactFilter2D.NativeMethodInfoPtr_SetDepth_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663380);
			ContactFilter2D.NativeMethodInfoPtr_CreateLegacyFilter_Internal_Static_ContactFilter2D_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663381);
			ContactFilter2D.NativeMethodInfoPtr_CheckConsistency_Injected_Private_Static_Void_byref_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663382);
			ContactFilter2D.IsFilteringNormalAngle_InjectedDelegateField = IL2CPP.ResolveICall<ContactFilter2D.IsFilteringNormalAngle_InjectedDelegate>("UnityEngine.ContactFilter2D::IsFilteringNormalAngle_Injected");
			ContactFilter2D.IsFilteringNormalAngleUsingAngle_InjectedDelegateField = IL2CPP.ResolveICall<ContactFilter2D.IsFilteringNormalAngleUsingAngle_InjectedDelegate>("UnityEngine.ContactFilter2D::IsFilteringNormalAngleUsingAngle_Injected");
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00009FC8 File Offset: 0x000081C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512957, XrefRangeEnd = 512961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckConsistency()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_CheckConsistency_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00009FF0 File Offset: 0x000081F0
		[CallerCount(0)]
		public unsafe void SetLayerMask(LayerMask layerMask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerMask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_SetLayerMask_Public_Void_LayerMask_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A024 File Offset: 0x00008224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512961, XrefRangeEnd = 512965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDepth(float minDepth, float maxDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_SetDepth_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000A064 File Offset: 0x00008264
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 512972, RefRangeEnd = 512986, XrefRangeStart = 512965, XrefRangeEnd = 512972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerMask;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDepth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_CreateLegacyFilter_Internal_Static_ContactFilter2D_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000A0C0 File Offset: 0x000082C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckConsistency_Injected(ref ContactFilter2D _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_CheckConsistency_Injected_Private_Static_Void_byref_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000028DC File Offset: 0x00000ADC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, ref this));
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000A0F4 File Offset: 0x000082F4
		// (set) Token: 0x060001DD RID: 477 RVA: 0x000028EE File Offset: 0x00000AEE
		public unsafe static float NormalAngleUpperLimit
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ContactFilter2D.NativeFieldInfoPtr_NormalAngleUpperLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContactFilter2D.NativeFieldInfoPtr_NormalAngleUpperLimit, (void*)(&value));
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A110 File Offset: 0x00008310
		public ContactFilter2D NoFilter()
		{
			this.useTriggers = true;
			this.useLayerMask = false;
			this.layerMask = -1;
			this.useDepth = false;
			this.useOutsideDepth = false;
			this.minDepth = float.NegativeInfinity;
			this.maxDepth = float.PositiveInfinity;
			this.useNormalAngle = false;
			this.useOutsideNormalAngle = false;
			this.minNormalAngle = 0f;
			this.maxNormalAngle = 359.9999f;
			return this;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000028FC File Offset: 0x00000AFC
		public void ClearLayerMask()
		{
			this.useLayerMask = false;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002906 File Offset: 0x00000B06
		public void ClearDepth()
		{
			this.useDepth = false;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002910 File Offset: 0x00000B10
		public void ClearNormalAngle()
		{
			this.useNormalAngle = false;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000291A File Offset: 0x00000B1A
		public void SetNormalAngle(float minNormalAngle, float maxNormalAngle)
		{
			this.minNormalAngle = minNormalAngle;
			this.maxNormalAngle = maxNormalAngle;
			this.useNormalAngle = true;
			this.CheckConsistency();
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000A18C File Offset: 0x0000838C
		public bool isFiltering
		{
			get
			{
				return !this.useTriggers || this.useLayerMask || this.useDepth || this.useNormalAngle;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A1C0 File Offset: 0x000083C0
		public bool IsFilteringTrigger(Collider2D collider)
		{
			return !this.useTriggers && collider.isTrigger;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A1E4 File Offset: 0x000083E4
		public bool IsFilteringLayerMask(GameObject obj)
		{
			return this.useLayerMask && (this.layerMask & (1 << obj.layer)) == 0;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A21C File Offset: 0x0000841C
		public bool IsFilteringDepth(GameObject obj)
		{
			bool flag = !this.useDepth;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = this.minDepth > this.maxDepth;
				if (flag3)
				{
					float num = this.minDepth;
					this.minDepth = this.maxDepth;
					this.maxDepth = num;
				}
				float z = obj.transform.position.z;
				bool flag4 = z < this.minDepth || z > this.maxDepth;
				bool flag5 = this.useOutsideDepth;
				if (flag5)
				{
					flag2 = !flag4;
				}
				else
				{
					flag2 = flag4;
				}
			}
			return flag2;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002939 File Offset: 0x00000B39
		public bool IsFilteringNormalAngle(Vector2 normal)
		{
			return ContactFilter2D.IsFilteringNormalAngle_Injected(ref this, ref normal);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A2AC File Offset: 0x000084AC
		public bool IsFilteringNormalAngle(float angle)
		{
			return this.IsFilteringNormalAngleUsingAngle(angle);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002943 File Offset: 0x00000B43
		public bool IsFilteringNormalAngleUsingAngle(float angle)
		{
			return ContactFilter2D.IsFilteringNormalAngleUsingAngle_Injected(ref this, angle);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000294C File Offset: 0x00000B4C
		public static bool IsFilteringNormalAngle_Injected(ref ContactFilter2D _unity_self, ref Vector2 normal)
		{
			return ContactFilter2D.IsFilteringNormalAngle_InjectedDelegateField(ref _unity_self, ref normal);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000295A File Offset: 0x00000B5A
		public static bool IsFilteringNormalAngleUsingAngle_Injected(ref ContactFilter2D _unity_self, float angle)
		{
			return ContactFilter2D.IsFilteringNormalAngleUsingAngle_InjectedDelegateField(ref _unity_self, angle);
		}

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_useTriggers;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_useLayerMask;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_useDepth;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_useOutsideDepth;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_useNormalAngle;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_useOutsideNormalAngle;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_minDepth;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_maxDepth;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_minNormalAngle;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_maxNormalAngle;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_NormalAngleUpperLimit;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_CheckConsistency_Private_Void_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerMask_Public_Void_LayerMask_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_SetDepth_Public_Void_Single_Single_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_CreateLegacyFilter_Internal_Static_ContactFilter2D_Int32_Single_Single_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_CheckConsistency_Injected_Private_Static_Void_byref_ContactFilter2D_0;

		// Token: 0x040000EB RID: 235
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool useTriggers;

		// Token: 0x040000EC RID: 236
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool useLayerMask;

		// Token: 0x040000ED RID: 237
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool useDepth;

		// Token: 0x040000EE RID: 238
		[FieldOffset(3)]
		[MarshalAs(4)]
		public bool useOutsideDepth;

		// Token: 0x040000EF RID: 239
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool useNormalAngle;

		// Token: 0x040000F0 RID: 240
		[FieldOffset(5)]
		[MarshalAs(4)]
		public bool useOutsideNormalAngle;

		// Token: 0x040000F1 RID: 241
		[FieldOffset(8)]
		public LayerMask layerMask;

		// Token: 0x040000F2 RID: 242
		[FieldOffset(12)]
		public float minDepth;

		// Token: 0x040000F3 RID: 243
		[FieldOffset(16)]
		public float maxDepth;

		// Token: 0x040000F4 RID: 244
		[FieldOffset(20)]
		public float minNormalAngle;

		// Token: 0x040000F5 RID: 245
		[FieldOffset(24)]
		public float maxNormalAngle;

		// Token: 0x040000F6 RID: 246
		private static readonly ContactFilter2D.IsFilteringNormalAngle_InjectedDelegate IsFilteringNormalAngle_InjectedDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly ContactFilter2D.IsFilteringNormalAngleUsingAngle_InjectedDelegate IsFilteringNormalAngleUsingAngle_InjectedDelegateField;

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000514 RID: 1300
		private delegate bool IsFilteringNormalAngle_InjectedDelegate(IntPtr _unity_self, IntPtr normal);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000516 RID: 1302
		private delegate bool IsFilteringNormalAngleUsingAngle_InjectedDelegate(IntPtr _unity_self, float angle);
	}
}
