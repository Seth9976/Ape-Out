using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000084 RID: 132
	public class EnumConverter : TypeConverter
	{
		// Token: 0x0600088C RID: 2188 RVA: 0x00030B7C File Offset: 0x0002ED7C
		// Note: this type is marked as 'beforefieldinit'.
		static EnumConverter()
		{
			Il2CppClassPointerStore<EnumConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EnumConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr);
			EnumConverter.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr, "values");
			EnumConverter.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr, "type");
			EnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr, 100664528);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00030BE8 File Offset: 0x0002EDE8
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumConverter(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0000563D File Offset: 0x0000383D
		public EnumConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00030C34 File Offset: 0x0002EE34
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00005646 File Offset: 0x00003846
		public unsafe TypeConverter.StandardValuesCollection values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumConverter.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumConverter.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00030C64 File Offset: 0x0002EE64
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00005665 File Offset: 0x00003865
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumConverter.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumConverter.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
