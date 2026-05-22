using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000093 RID: 147
	public sealed class SettingsBindableAttribute : Attribute
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsBindableAttribute()
		{
			Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "SettingsBindableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr);
			SettingsBindableAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, "Yes");
			SettingsBindableAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, "No");
			SettingsBindableAttribute.NativeFieldInfoPtr__bindable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, "_bindable");
			SettingsBindableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, 100664563);
			SettingsBindableAttribute.NativeMethodInfoPtr_get_Bindable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, 100664564);
			SettingsBindableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, 100664565);
			SettingsBindableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr, 100664566);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00031DB4 File Offset: 0x0002FFB4
		[CallerCount(0)]
		public unsafe SettingsBindableAttribute(bool bindable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsBindableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsBindableAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00031DFC File Offset: 0x0002FFFC
		public unsafe bool Bindable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsBindableAttribute.NativeMethodInfoPtr_get_Bindable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00031E38 File Offset: 0x00030038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372853, XrefRangeEnd = 372855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsBindableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00031E88 File Offset: 0x00030088
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsBindableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0000592F File Offset: 0x00003B2F
		public SettingsBindableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00031EC4 File Offset: 0x000300C4
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00005938 File Offset: 0x00003B38
		public unsafe static SettingsBindableAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SettingsBindableAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsBindableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsBindableAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00031EEC File Offset: 0x000300EC
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0000594A File Offset: 0x00003B4A
		public unsafe static SettingsBindableAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SettingsBindableAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsBindableAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsBindableAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00031F14 File Offset: 0x00030114
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0000595C File Offset: 0x00003B5C
		public unsafe bool _bindable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsBindableAttribute.NativeFieldInfoPtr__bindable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsBindableAttribute.NativeFieldInfoPtr__bindable)) = value;
			}
		}

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr__bindable;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_get_Bindable_Public_get_Boolean_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
