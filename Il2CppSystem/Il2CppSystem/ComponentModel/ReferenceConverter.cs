using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000090 RID: 144
	public class ReferenceConverter : TypeConverter
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x00031908 File Offset: 0x0002FB08
		// Note: this type is marked as 'beforefieldinit'.
		static ReferenceConverter()
		{
			Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ReferenceConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr);
			ReferenceConverter.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, "none");
			ReferenceConverter.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, "type");
			ReferenceConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr, 100664556);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00031974 File Offset: 0x0002FB74
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferenceConverter(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0000589D File Offset: 0x00003A9D
		public ReferenceConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000319C0 File Offset: 0x0002FBC0
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x000058A6 File Offset: 0x00003AA6
		public unsafe static string none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReferenceConverter.NativeFieldInfoPtr_none, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReferenceConverter.NativeFieldInfoPtr_none, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x000319E0 File Offset: 0x0002FBE0
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x000058B8 File Offset: 0x00003AB8
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceConverter.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceConverter.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
