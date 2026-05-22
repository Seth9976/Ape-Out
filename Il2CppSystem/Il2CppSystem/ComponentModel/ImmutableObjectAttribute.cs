using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200008A RID: 138
	public sealed class ImmutableObjectAttribute : Attribute
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x000312C0 File Offset: 0x0002F4C0
		// Note: this type is marked as 'beforefieldinit'.
		static ImmutableObjectAttribute()
		{
			Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ImmutableObjectAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr);
			ImmutableObjectAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr, "Yes");
			ImmutableObjectAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr, "No");
			ImmutableObjectAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr, "Default");
			ImmutableObjectAttribute.NativeFieldInfoPtr_immutable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr, "immutable");
			ImmutableObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr, 100664543);
			ImmutableObjectAttribute.NativeMethodInfoPtr_get_Immutable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr, 100664544);
			ImmutableObjectAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr, 100664545);
			ImmutableObjectAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr, 100664546);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00031390 File Offset: 0x0002F590
		[CallerCount(0)]
		public unsafe ImmutableObjectAttribute(bool immutable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImmutableObjectAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref immutable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableObjectAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x000313D8 File Offset: 0x0002F5D8
		public unsafe bool Immutable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableObjectAttribute.NativeMethodInfoPtr_get_Immutable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00031414 File Offset: 0x0002F614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372847, XrefRangeEnd = 372849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableObjectAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00031464 File Offset: 0x0002F664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableObjectAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0000570A File Offset: 0x0000390A
		public ImmutableObjectAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000314A0 File Offset: 0x0002F6A0
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00005713 File Offset: 0x00003913
		public unsafe static ImmutableObjectAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableObjectAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImmutableObjectAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableObjectAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000314C8 File Offset: 0x0002F6C8
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00005725 File Offset: 0x00003925
		public unsafe static ImmutableObjectAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableObjectAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImmutableObjectAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableObjectAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x000314F0 File Offset: 0x0002F6F0
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00005737 File Offset: 0x00003937
		public unsafe static ImmutableObjectAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableObjectAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImmutableObjectAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableObjectAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00031518 File Offset: 0x0002F718
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00005749 File Offset: 0x00003949
		public unsafe bool immutable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableObjectAttribute.NativeFieldInfoPtr_immutable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableObjectAttribute.NativeFieldInfoPtr_immutable)) = value;
			}
		}

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_immutable;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_get_Immutable_Public_get_Boolean_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
