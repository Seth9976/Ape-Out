using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200007F RID: 127
	[Serializable]
	public sealed class AttributeUsageAttribute : Attribute
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x0004592C File Offset: 0x00043B2C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeUsageAttribute()
		{
			Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AttributeUsageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr);
			AttributeUsageAttribute.NativeFieldInfoPtr_m_attributeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "m_attributeTarget");
			AttributeUsageAttribute.NativeFieldInfoPtr_m_allowMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "m_allowMultiple");
			AttributeUsageAttribute.NativeFieldInfoPtr_m_inherited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "m_inherited");
			AttributeUsageAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, "Default");
			AttributeUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664498);
			AttributeUsageAttribute.NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664499);
			AttributeUsageAttribute.NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664500);
			AttributeUsageAttribute.NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664501);
			AttributeUsageAttribute.NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr, 100664502);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00045A10 File Offset: 0x00043C10
		[CallerCount(0)]
		public unsafe AttributeUsageAttribute(AttributeTargets validOn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeUsageAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref validOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00045A58 File Offset: 0x00043C58
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00045A94 File Offset: 0x00043C94
		public unsafe bool AllowMultiple
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00045AD4 File Offset: 0x00043CD4
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00045B10 File Offset: 0x00043D10
		public unsafe bool Inherited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUsageAttribute.NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000045FB File Offset: 0x000027FB
		public AttributeUsageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00045B50 File Offset: 0x00043D50
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00004604 File Offset: 0x00002804
		public unsafe AttributeTargets m_attributeTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_attributeTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_attributeTarget)) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00045B78 File Offset: 0x00043D78
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x0000461F File Offset: 0x0000281F
		public unsafe bool m_allowMultiple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_allowMultiple);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_allowMultiple)) = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00045BA0 File Offset: 0x00043DA0
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x0000463A File Offset: 0x0000283A
		public unsafe bool m_inherited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_inherited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeUsageAttribute.NativeFieldInfoPtr_m_inherited)) = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00045BC8 File Offset: 0x00043DC8
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00004655 File Offset: 0x00002855
		public unsafe static AttributeUsageAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeUsageAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeUsageAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr_m_attributeTarget;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr_m_allowMultiple;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeFieldInfoPtr_m_inherited;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeTargets_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowMultiple_Public_get_Boolean_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowMultiple_Public_set_Void_Boolean_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_get_Inherited_Public_get_Boolean_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_set_Inherited_Public_set_Void_Boolean_0;
	}
}
