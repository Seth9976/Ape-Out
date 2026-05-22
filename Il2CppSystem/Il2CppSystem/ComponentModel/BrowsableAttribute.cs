using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000070 RID: 112
	public sealed class BrowsableAttribute : Attribute
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x0002E8AC File Offset: 0x0002CAAC
		// Note: this type is marked as 'beforefieldinit'.
		static BrowsableAttribute()
		{
			Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "BrowsableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr);
			BrowsableAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, "Yes");
			BrowsableAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, "No");
			BrowsableAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, "Default");
			BrowsableAttribute.NativeFieldInfoPtr_browsable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, "browsable");
			BrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, 100664451);
			BrowsableAttribute.NativeMethodInfoPtr_get_Browsable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, 100664452);
			BrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, 100664453);
			BrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr, 100664454);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0002E97C File Offset: 0x0002CB7C
		[CallerCount(0)]
		public unsafe BrowsableAttribute(bool browsable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrowsableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref browsable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0002E9C4 File Offset: 0x0002CBC4
		public unsafe bool Browsable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrowsableAttribute.NativeMethodInfoPtr_get_Browsable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0002EA00 File Offset: 0x0002CC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372694, XrefRangeEnd = 372696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0002EA50 File Offset: 0x0002CC50
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00005187 File Offset: 0x00003387
		public BrowsableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0002EA8C File Offset: 0x0002CC8C
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00005190 File Offset: 0x00003390
		public unsafe static BrowsableAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BrowsableAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrowsableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BrowsableAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0002EAB4 File Offset: 0x0002CCB4
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x000051A2 File Offset: 0x000033A2
		public unsafe static BrowsableAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BrowsableAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrowsableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BrowsableAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0002EADC File Offset: 0x0002CCDC
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x000051B4 File Offset: 0x000033B4
		public unsafe static BrowsableAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BrowsableAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrowsableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BrowsableAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0002EB04 File Offset: 0x0002CD04
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x000051C6 File Offset: 0x000033C6
		public unsafe bool browsable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrowsableAttribute.NativeFieldInfoPtr_browsable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrowsableAttribute.NativeFieldInfoPtr_browsable)) = value;
			}
		}

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_browsable;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_get_Browsable_Public_get_Boolean_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
